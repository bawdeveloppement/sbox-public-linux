namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Classe utilitaire pour émettre des événements de rendu
/// </summary>
public static class RenderableEventEmitter
{
	/// <summary>
	/// Émettre un événement de changement d'objet de scène
	/// </summary>
	public static void EmitSceneObjectChanged( object source )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.SceneObjectChanged, source );
	}

	/// <summary>
	/// Émettre un événement de mouvement de caméra
	/// </summary>
	public static void EmitCameraMoved( object camera )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.CameraMoved, camera );
	}

	/// <summary>
	/// Émettre un événement de changement de matériau
	/// </summary>
	public static void EmitMaterialChanged( object material )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.MaterialChanged, material );
	}

	/// <summary>
	/// Émettre un événement de changement de sélection
	/// </summary>
	public static void EmitSelectionChanged( object selection )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.SelectionChanged, selection );
	}

	/// <summary>
	/// Émettre un événement d'interaction avec gizmo
	/// </summary>
	public static void EmitGizmoInteraction( object gizmo )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.GizmoInteraction, gizmo );
	}

	/// <summary>
	/// Émettre un événement de frame d'animation
	/// </summary>
	public static void EmitAnimationFrame( object animator )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.AnimationFrame, animator );
	}

	/// <summary>
	/// Émettre un événement de changement de lumière
	/// </summary>
	public static void EmitLightingChanged( object light )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.LightingChanged, light );
	}

	/// <summary>
	/// Émettre un événement de changement de post-processing
	/// </summary>
	public static void EmitPostProcessChanged( object postProcess )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.PostProcessChanged, postProcess );
	}

	/// <summary>
	/// Émettre un événement de chargement de widget
	/// </summary>
	public static void EmitLoaded( object source )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.Loaded, source );
	}

	/// <summary>
	/// Émettre un événement de mise à jour de performance
	/// </summary>
	public static void EmitPerformanceUpdated( object source = null )
	{
		RenderableEventQueue.Enqueue( RenderableEvent.EventType.PerformanceUpdated, source );
	}

	/// <summary>
	/// Émettre un événement personnalisé
	/// </summary>
	public static void EmitCustom( object source, object customData = null )
	{
		var evt = new RenderableEvent( RenderableEvent.EventType.Custom, source )
		{
			CustomData = customData
		};
		RenderableEventQueue.Enqueue( evt );
	}
}

