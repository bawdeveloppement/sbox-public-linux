namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Événement qui indique qu'un rendu est nécessaire
/// </summary>
public class RenderableEvent
{
	/// <summary>
	/// Type d'événement qui nécessite un rendu
	/// </summary>
	public enum EventType
	{
		/// <summary>
		/// Un GameObject a changé (transform, propriétés, etc.)
		/// </summary>
		SceneObjectChanged,

		/// <summary>
		/// La caméra a bougé ou changé
		/// </summary>
		CameraMoved,

		/// <summary>
		/// Un matériau ou une propriété de rendu a changé
		/// </summary>
		MaterialChanged,

		/// <summary>
		/// La sélection dans l'éditeur a changé
		/// </summary>
		SelectionChanged,

		/// <summary>
		/// Interaction utilisateur avec un gizmo
		/// </summary>
		GizmoInteraction,

		/// <summary>
		/// Frame d'animation
		/// </summary>
		AnimationFrame,

		/// <summary>
		/// Changement de lumière/éclairage
		/// </summary>
		LightingChanged,

		/// <summary>
		/// Changement de post-processing
		/// </summary>
		PostProcessChanged,

		/// <summary>
		/// Widget chargé et prêt pour le rendu
		/// </summary>
		Loaded,

		/// <summary>
		/// Mise à jour des statistiques de performance
		/// </summary>
		PerformanceUpdated,

		/// <summary>
		/// Événement personnalisé
		/// </summary>
		Custom
	}

	/// <summary>
	/// Type de l'événement
	/// </summary>
	public EventType Type { get; set; }

	/// <summary>
	/// Source de l'événement (GameObject, CameraComponent, etc.)
	/// </summary>
	public object Source { get; set; }

	/// <summary>
	/// Timestamp de l'événement (en secondes depuis le démarrage)
	/// </summary>
	public float Timestamp { get; set; }

	/// <summary>
	/// Priorité de l'événement (plus élevé = plus important)
	/// </summary>
	public int Priority { get; set; } = 0;

	/// <summary>
	/// Données personnalisées pour les événements Custom
	/// </summary>
	public object CustomData { get; set; }

	public RenderableEvent()
	{
		Timestamp = RealTime.Now;
	}

	public RenderableEvent( EventType type, object source = null ) : this()
	{
		Type = type;
		Source = source;
	}
}

