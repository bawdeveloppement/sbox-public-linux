namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Paramètres de configuration pour le système de queue d'événements
/// </summary>
public class RenderableEventQueueSettings
{
	/// <summary>
	/// Taille maximale de la queue
	/// </summary>
	public int MaxQueueSize { get; set; } = 1000;

	/// <summary>
	/// Délai en secondes pour considérer un événement comme doublon
	/// </summary>
	public float DuplicateThreshold { get; set; } = 0.016f; // ~1 frame à 60 FPS

	/// <summary>
	/// Activer la déduplication des événements
	/// </summary>
	public bool EnableDeduplication { get; set; } = true;

	/// <summary>
	/// Activer le cache GPU
	/// </summary>
	public bool EnableGPUCache { get; set; } = true;

	/// <summary>
	/// Appliquer les paramètres à la queue globale
	/// </summary>
	public void Apply()
	{
		RenderableEventQueue.MaxQueueSize = MaxQueueSize;
		RenderableEventQueue.DuplicateThreshold = DuplicateThreshold;
		RenderableEventQueue.EnableDeduplication = EnableDeduplication;
	}

	/// <summary>
	/// Paramètres par défaut
	/// </summary>
	public static RenderableEventQueueSettings Default => new();
}

