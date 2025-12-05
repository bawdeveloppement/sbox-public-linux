using Editor.Rendering.RenderableEventQueue;

namespace Editor.Rendering.RenderableEventQueue.Extensions;

/// <summary>
/// Extensions utilitaires pour RenderableEvent
/// </summary>
public static class RenderableEventExtensions
{
	/// <summary>
	/// Vérifier si l'événement est récent (dans les X secondes)
	/// </summary>
	public static bool IsRecent( this RenderableEvent evt, float thresholdSeconds = 0.1f )
	{
		if ( evt == null ) return false;
		return (RealTime.Now - evt.Timestamp) < thresholdSeconds;
	}

	/// <summary>
	/// Vérifier si deux événements sont similaires
	/// </summary>
	public static bool IsSimilarTo( this RenderableEvent evt, RenderableEvent other )
	{
		if ( evt == null || other == null ) return false;
		return evt.Type == other.Type && evt.Source == other.Source;
	}

	/// <summary>
	/// Obtenir l'âge de l'événement en secondes
	/// </summary>
	public static float GetAge( this RenderableEvent evt )
	{
		if ( evt == null ) return float.MaxValue;
		return RealTime.Now - evt.Timestamp;
	}
}
