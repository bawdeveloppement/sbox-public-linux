using System;
using NativeEngine;

namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Gestionnaire de cache GPU pour les frames rendues
/// </summary>
public class RenderCacheManager : IDisposable
{
	private Texture _cachedFrameTexture;
	private Vector2 _cachedSize;
	private bool _hasCachedFrame = false;
	private string _cacheName;

	/// <summary>
	/// Taille actuelle de la texture de cache
	/// </summary>
	public Vector2 CachedSize => _cachedSize;

	/// <summary>
	/// Indique si une frame est actuellement en cache
	/// </summary>
	public bool HasCachedFrame => _hasCachedFrame && _cachedFrameTexture != null && _cachedFrameTexture.IsValid();

	public RenderCacheManager( string cacheName = "RenderCache" )
	{
		_cacheName = cacheName;
	}

	/// <summary>
	/// Créer ou mettre à jour la texture de cache
	/// </summary>
	public Texture GetOrCreateCacheTexture( Vector2 size )
	{
		if ( _cachedFrameTexture == null || !_cachedFrameTexture.IsValid() || _cachedSize != size )
		{
			// Disposer de l'ancienne texture
			_cachedFrameTexture?.Dispose();

			// Créer une nouvelle texture de rendu
			_cachedFrameTexture = Texture.CreateRenderTarget(
				_cacheName,
				ImageFormat.RGBA8888,
				size,
				null // Ne pas réutiliser l'ancienne
			);

			_cachedSize = size;
			_hasCachedFrame = false;
		}

		return _cachedFrameTexture;
	}

	/// <summary>
	/// Marquer qu'une frame valide est en cache
	/// </summary>
	public void MarkFrameCached()
	{
		_hasCachedFrame = _cachedFrameTexture != null && _cachedFrameTexture.IsValid();
	}

	/// <summary>
	/// Invalider le cache
	/// </summary>
	public void InvalidateCache()
	{
		_hasCachedFrame = false;
	}

	/// <summary>
	/// Obtenir la texture de cache (peut être null)
	/// </summary>
	public Texture GetCachedTexture()
	{
		return HasCachedFrame ? _cachedFrameTexture : null;
	}

	/// <summary>
	/// Copier la texture de cache vers un SwapChain
	/// Note: Nécessite une API de blit GPU (à implémenter selon le moteur)
	/// </summary>
	internal bool BlitToSwapChain( SwapChainHandle_t swapChain, Vector2 targetSize )
	{
		if ( !HasCachedFrame )
			return false;

		// TODO: Implémenter le blit GPU vers SwapChain
		// Exemple: g_pRenderDevice.CopyTexture(_cachedFrameTexture.native, swapChain, ...);

		// Pour l'instant, retourner false si non implémenté
		return false;
	}

	public void Dispose()
	{
		_cachedFrameTexture?.Dispose();
		_cachedFrameTexture = null;
		_hasCachedFrame = false;
	}
}

