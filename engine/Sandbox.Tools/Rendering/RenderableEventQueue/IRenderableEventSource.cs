namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Interface pour les objets qui peuvent émettre des événements de rendu
/// </summary>
public interface IRenderableEventSource
{
	/// <summary>
	/// Émettre un événement de rendu
	/// </summary>
	void EmitRenderableEvent( RenderableEvent evt );

	/// <summary>
	/// Émettre un événement de rendu avec type et source
	/// </summary>
	void EmitRenderableEvent( RenderableEvent.EventType type, object source = null );
}

