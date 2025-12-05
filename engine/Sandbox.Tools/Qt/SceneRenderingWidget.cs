using System;
using Editor.Rendering.RenderableEventQueue;

namespace Editor;

/// <summary>
/// Render a scene to a native widget. This replaces NativeRenderingWidget. 
/// </summary>
public class SceneRenderingWidget : Frame
{
	private static readonly HashSet<SceneRenderingWidget> All = new();

	internal SwapChainHandle_t SwapChain;

	/// <summary>
	/// The active scene that we're rendering
	/// </summary>
	public Scene Scene { get; set; }

	/// <summary>
	/// The camera to render from. We will fallback to Scene.Camera if this is null
	/// </summary>
	public CameraComponent Camera { get; set; }

	/// <summary>
	/// This widget manages it's own gizmo instance.
	/// </summary>
	public Gizmo.Instance GizmoInstance { get; private set; } = new();

	public bool EnableEngineOverlays { get; set; } = false;

	/// <summary>
	/// Gestionnaire de cache GPU pour les frames rendues
	/// </summary>
	private RenderCacheManager _cacheManager;

	/// <summary>
	/// Activer/désactiver le système de cache d'événements
	/// </summary>
	public bool EnableEventCache { get; set; } = true;

	public SceneRenderingWidget( Widget parent = null ) : base( parent )
	{
		SetFlag( Flag.WA_NativeWindow, true );
		SetFlag( Flag.WA_PaintOnScreen, true );
		SetFlag( Flag.WA_NoSystemBackground, true );
		SetFlag( Flag.WA_OpaquePaintEvent, true );

		SwapChain = WidgetUtil.CreateSwapChain( _widget );

		FocusMode = FocusMode.Click; // If we're focused we're probably accepting input, don't let tab blur us

		// Initialiser le gestionnaire de cache
		_cacheManager = new RenderCacheManager( $"SceneRenderingWidget_{GetHashCode()}" );

		All.Add( this );

		// Émettre un événement Loaded pour indiquer que le widget est prêt
		if ( EnableEventCache )
		{
			RenderableEventEmitter.EmitLoaded( this );
		}
	}

	internal override void NativeShutdown()
	{
		base.NativeShutdown();

		All.Remove( this );

		// The swapchain might still be in use by native, so defer its destruction until the end of the frame.
		// Otherwise, a race condition could occur where render targets are accessed after destruction, causing a delayed crash.
		EngineLoop.DisposeAtFrameEnd( new Sandbox.Utility.DisposeAction( () => g_pRenderDevice.DestroySwapChain( SwapChain ) ) );
		SwapChain = default;

		GizmoInstance?.Dispose();
		GizmoInstance = default;

		// Nettoyer le cache
		_cacheManager?.Dispose();
		_cacheManager = null;
	}

	/// <summary>
	/// Create a hidden scene editor camera, post processing will be copied from a main camera in the scene.
	/// </summary>
	public CameraComponent CreateSceneEditorCamera()
	{
		if ( Scene is null ) return null;

		using ( Scene.Push() )
		{
			var go = new GameObject( true, "editor_camera" );
			go.Flags = GameObjectFlags.Hidden | GameObjectFlags.NotSaved | GameObjectFlags.EditorOnly | GameObjectFlags.Absolute;
			var camera = go.AddComponent<CameraComponent>();
			camera.IsMainCamera = false;
			camera.IsSceneEditorCamera = true;
			return camera;
		}
	}

	void RenderScene()
	{
		if ( !this.IsValid() )
			return;

		if ( SwapChain == default ) return;

		var sceneCamera = GetSceneCamera();
		if ( sceneCamera is not null )
		{
			sceneCamera.EnableEngineOverlays = EnableEngineOverlays;
		}

		if ( Camera.IsValid() )
		{
			Camera.Scene?.PreCameraRender();
			Camera.AddToRenderList( SwapChain, Size * DpiScale );
			
			// Émettre un événement de mouvement de caméra si le cache est activé
			if ( EnableEventCache )
			{
				RenderableEventEmitter.EmitCameraMoved( Camera );
			}
		}
		else if ( Scene.IsValid() )
		{
			Scene.Render( SwapChain, Size * DpiScale );
		}
	}

	/// <summary>
	/// Rendre la scène dans une texture de cache
	/// </summary>
	void RenderSceneToCache( Texture cacheTexture )
	{
		if ( !this.IsValid() || cacheTexture == null || !cacheTexture.IsValid() )
			return;

		var sceneCamera = GetSceneCamera();
		if ( sceneCamera is not null )
		{
			sceneCamera.EnableEngineOverlays = EnableEngineOverlays;
		}

		if ( Camera.IsValid() )
		{
			Camera.Scene?.PreCameraRender();
			Camera.RenderToTexture( cacheTexture, default );
		}
		else if ( Scene.IsValid() && Scene.Camera.IsValid() )
		{
			Scene.PreCameraRender();
			Scene.Camera.RenderToTexture( cacheTexture, default );
		}
	}

	/// <inheritdoc cref="PreFrame"/>
	public event Action OnPreFrame;

	/// <summary>
	/// Called just before rendering.
	/// </summary>
	protected virtual void PreFrame()
	{
		OnPreFrame?.Invoke();
	}

	/// <summary>
	/// Update common inputs for gizmo.
	/// </summary>
	public void UpdateGizmoInputs( bool hasMouseFocus = true )
	{
		var camera = GetSceneCamera();
		if ( camera is null ) return;

		UpdateGizmoInputs( ref GizmoInstance.Input, camera, hasMouseFocus );
	}

	void Render()
	{
		if ( !Scene.IsValid() ) return;
		if ( !Visible ) return;

		// Vérifier la queue d'événements si le cache est activé
		int eventCount = EnableEventCache ? RenderableEventQueue.Count : 1;
		var realSize = Size * DpiScale;
		bool shouldRender = true;

		using ( Scene.Push() )
		{
			using ( GizmoInstance.Push() )
			{
				PreFrame();

				if ( EnableEventCache && eventCount == 0 )
				{
					// Queue = 0 : Utiliser le cache si disponible - NE PAS RENDRE
					if ( _cacheManager.HasCachedFrame )
					{
						// Cache disponible, on saute le rendu
						// Le SwapChain gardera la dernière frame présentée
						shouldRender = false;
					}
					else
					{
						// Pas de cache disponible, forcer le rendu une fois
						shouldRender = true;
					}
				}
				else if ( EnableEventCache && eventCount == 1 )
				{
					// Queue = 1 : Rendre UNE SEULE FOIS dans le cache, puis copier vers SwapChain
					var cacheTexture = _cacheManager.GetOrCreateCacheTexture( realSize );
					
					if ( cacheTexture != null && cacheTexture.IsValid() )
					{
						// Rendre dans la texture de cache
						RenderSceneToCache( cacheTexture );
						_cacheManager.MarkFrameCached();
						
						// Maintenant copier le cache vers le SwapChain en rendant depuis le cache
						// Pour l'instant, on rend directement vers le SwapChain aussi
						// TODO: Implémenter un blit GPU direct cache -> SwapChain pour éviter le double rendu
						RenderScene();
					}
					else
					{
						// Échec de création du cache, rendre normalement
						RenderScene();
					}
				}
				else
				{
					// Queue > 1 ou cache désactivé : Rendre normalement sans sauvegarder
					RenderScene();
					
					// Invalider le cache car trop de changements
					if ( EnableEventCache && eventCount > 1 )
					{
						_cacheManager.InvalidateCache();
					}
				}
			}
		}

		// Présenter seulement si on a rendu
		if ( shouldRender )
		{
			g_pRenderDevice.Present( SwapChain );
		}

		// Vider la queue après le rendu
		if ( EnableEventCache )
		{
			RenderableEventQueue.Clear();
		}
	}

	private void UpdateGizmoInputs( ref Gizmo.Inputs input, SceneCamera camera, bool hasMouseFocus )
	{
		ArgumentNullException.ThrowIfNull( camera );

		input.Camera = camera;
		input.Modifiers = Application.KeyboardModifiers;

		if ( !hasMouseFocus )
		{
			input.CursorRay = new Ray();
			return;
		}

		input.CursorPosition = Application.CursorPosition;
		input.LeftMouse = Application.MouseButtons.HasFlag( MouseButtons.Left );
		input.RightMouse = Application.MouseButtons.HasFlag( MouseButtons.Right );

		input.CursorPosition -= ScreenPosition;
		input.CursorRay = camera.GetRay( input.CursorPosition, Size );

		if ( !input.IsHovered )
		{
			input.LeftMouse = false;
			input.RightMouse = false;
		}
	}

	private SceneCamera GetSceneCamera()
	{
		if ( Camera.IsValid() )
			return Camera.SceneCamera;

		if ( !Scene.IsValid() )
			return null;

		if ( !Scene.Camera.IsValid() )
			return null;

		return Scene.Camera.SceneCamera;
	}

	/// <summary>
	/// Return a ray for the current cursor position
	/// </summary>
	public Ray CursorRay
	{
		get => GetRay( Application.CursorPosition - ScreenPosition );
	}

	/// <summary>
	/// Given a local widget position, return a Ray
	/// </summary>
	public Ray GetRay( Vector2 localPosition )
	{
		var camera = GetSceneCamera();
		if ( camera is null )
			return default;

		return camera.GetRay( localPosition, Size );
	}

	internal static void RenderAll()
	{
		foreach ( var widget in All )
		{
			if ( !widget.Visible ) continue;

			widget.Render();
		}
	}
}
