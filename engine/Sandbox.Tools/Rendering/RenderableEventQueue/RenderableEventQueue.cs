using System.Collections.Generic;
using System.Linq;

namespace Editor.Rendering.RenderableEventQueue;

/// <summary>
/// Queue globale thread-safe qui track les événements nécessitant un rendu
/// </summary>
public static class RenderableEventQueue
{
	private static readonly Queue<RenderableEvent> _queue = new();
	private static readonly object _lock = new();
	private static int _maxQueueSize = 1000;
	private static float _duplicateThreshold = 0.016f; // ~1 frame à 60 FPS
	private static bool _enableDeduplication = true;

	/// <summary>
	/// Nombre maximum d'événements dans la queue (pour éviter les fuites mémoire)
	/// </summary>
	public static int MaxQueueSize
	{
		get => _maxQueueSize;
		set => _maxQueueSize = value.Clamp( 1, 10000 );
	}

	/// <summary>
	/// Délai en secondes pour considérer un événement comme doublon
	/// </summary>
	public static float DuplicateThreshold
	{
		get => _duplicateThreshold;
		set => _duplicateThreshold = value.Clamp( 0.001f, 1.0f );
	}

	/// <summary>
	/// Activer la déduplication des événements
	/// </summary>
	public static bool EnableDeduplication
	{
		get => _enableDeduplication;
		set => _enableDeduplication = value;
	}

	/// <summary>
	/// Ajouter un événement à la queue
	/// </summary>
	public static void Enqueue( RenderableEvent evt )
	{
		if ( evt == null ) return;

		lock ( _lock )
		{
			// Éviter les doublons récents du même type et source
			if ( _enableDeduplication && _queue.Count > 0 )
			{
				var recent = _queue.LastOrDefault( x =>
					x.Type == evt.Type &&
					x.Source == evt.Source &&
					(RealTime.Now - x.Timestamp) < _duplicateThreshold );

				if ( recent != null )
					return; // Ignorer les doublons
			}

			// Limiter la taille de la queue
			while ( _queue.Count >= MaxQueueSize )
			{
				_queue.Dequeue();
			}

			_queue.Enqueue( evt );
		}
	}

	/// <summary>
	/// Ajouter un événement avec type et source
	/// </summary>
	public static void Enqueue( RenderableEvent.EventType type, object source = null )
	{
		Enqueue( new RenderableEvent( type, source ) );
	}

	/// <summary>
	/// Obtenir le nombre d'événements dans la queue
	/// </summary>
	public static int Count
	{
		get
		{
			lock ( _lock )
			{
				return _queue.Count;
			}
		}
	}

	/// <summary>
	/// Vérifier si la queue est vide
	/// </summary>
	public static bool IsEmpty
	{
		get
		{
			lock ( _lock )
			{
				return _queue.Count == 0;
			}
		}
	}

	/// <summary>
	/// Vider la queue (appelé après le rendu)
	/// </summary>
	public static void Clear()
	{
		lock ( _lock )
		{
			_queue.Clear();
		}
	}

	/// <summary>
	/// Consulter le prochain événement sans le retirer
	/// </summary>
	public static RenderableEvent Peek()
	{
		lock ( _lock )
		{
			return _queue.Count > 0 ? _queue.Peek() : null;
		}
	}

	/// <summary>
	/// Retirer et retourner le prochain événement
	/// </summary>
	public static RenderableEvent Dequeue()
	{
		lock ( _lock )
		{
			return _queue.Count > 0 ? _queue.Dequeue() : null;
		}
	}

	/// <summary>
	/// Obtenir tous les événements et vider la queue
	/// </summary>
	public static List<RenderableEvent> DequeueAll()
	{
		lock ( _lock )
		{
			var events = _queue.ToList();
			_queue.Clear();
			return events;
		}
	}

	/// <summary>
	/// Obtenir une copie de tous les événements sans vider la queue
	/// </summary>
	public static List<RenderableEvent> PeekAll()
	{
		lock ( _lock )
		{
			return _queue.ToList();
		}
	}
}

