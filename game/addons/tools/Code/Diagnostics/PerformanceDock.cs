using Sandbox.Diagnostics;
using Editor.Rendering.RenderableEventQueue;
namespace Editor;

[Dock( "Editor", "Performance", "timer" )]
public class PerformanceDock : Widget
{
	RealtimeChart Chart;
	Button MenuButton;

	public float RefreshSpeed = 0.25f;

	/// <summary>
	/// Activer/désactiver l'utilisation de RenderableEventQueue pour optimiser les mises à jour
	/// </summary>
	public bool EnableEventQueue { get; set; } = true;

	public PerformanceDock( Widget parent ) : base( parent )
	{
		MinimumSize = 200;

		MenuButton = new Button.Clear( "", this );
		MenuButton.Icon = "settings";
		MenuButton.Clicked = OpenMenu;

		Chart = new RealtimeChart( this );
		Chart.BackgroundColor = Theme.SurfaceBackground.Darken( 0.7f );
		Chart.Visible = true;
		Chart.Lower();
	}

	private void OpenMenu()
	{
		var menu = new ContextMenu( this );

		menu.AddOption( new Option { Text = "Every Frame", Checkable = true, Checked = RefreshSpeed == 0, Triggered = () => RefreshSpeed = 0 } );
		menu.AddOption( new Option { Text = "Fast", Checkable = true, Checked = RefreshSpeed == 0.1f, Triggered = () => RefreshSpeed = 0.1f } );
		menu.AddOption( new Option { Text = "Medium", Checkable = true, Checked = RefreshSpeed == 0.25f, Triggered = () => RefreshSpeed = 0.25f } );
		menu.AddOption( new Option { Text = "Slow", Checkable = true, Checked = RefreshSpeed == 0.5f, Triggered = () => RefreshSpeed = 0.5f } );

		menu.Position = MenuButton.ScreenRect.BottomLeft;
		menu.Visible = true;
	}

	protected override void DoLayout()
	{
		base.DoLayout();

		if ( Chart.IsValid() )
		{
			Chart.Position = 0;
			Chart.Size = Size;
		}

		MenuButton.Size = 32;
		MenuButton.Position = 8;
	}

	RealTimeSince timeSinceUpdate;
	int framesSinceUpdate;
	bool hasInitialRender = false;
	RealTimeSince lastPerformanceEventEmit;

	[EditorEvent.Frame]
	public void Frame()
	{
		framesSinceUpdate++;

		// Émettre un événement PerformanceUpdated périodiquement si EnableEventQueue est activé
		// Cela permet au système de cache de savoir quand mettre à jour
		if ( EnableEventQueue && timeSinceUpdate >= RefreshSpeed )
		{
			// Émettre un événement de performance pour déclencher la mise à jour
			// On limite l'émission à la même fréquence que RefreshSpeed pour éviter le spam
			if ( lastPerformanceEventEmit >= RefreshSpeed )
			{
				RenderableEventEmitter.EmitPerformanceUpdated( this );
				lastPerformanceEventEmit = 0;
			}
		}

		// Vérifier si on doit mettre à jour en utilisant la queue d'événements
		bool shouldUpdate = false;

		if ( EnableEventQueue )
		{
			// Vérifier s'il y a des événements de performance dans la queue
			var eventCount = RenderableEventQueue.Count;
			var hasPerformanceEvent = false;

			if ( eventCount > 0 )
			{
				// Vérifier s'il y a un événement PerformanceUpdated
				var events = RenderableEventQueue.PeekAll();
				hasPerformanceEvent = events.Any( e => e.Type == RenderableEvent.EventType.PerformanceUpdated );
			}

			// Mettre à jour si :
			// 1. Il y a un événement de performance dans la queue
			// 2. C'est le premier rendu (hasInitialRender = false)
			// 3. Le throttling temporel est respecté (fallback)
			shouldUpdate = hasPerformanceEvent || !hasInitialRender || timeSinceUpdate >= RefreshSpeed;
		}
		else
		{
			// Mode classique : seulement le throttling temporel
			shouldUpdate = timeSinceUpdate >= RefreshSpeed;
		}

		if ( !shouldUpdate )
			return;

		if ( !Chart.IsValid() )
			return;

		// TODO - add a toolbar with settings for all this shit
		// especially ScrollSize and the update speed above

		timeSinceUpdate = 0;

		Chart.ScrollSize = (int)(RefreshSpeed * 20) + 1;
		Chart.MinMax = new Vector2( 16, 0 );
		Chart.Stacked = true;
		Chart.ChartType = "bar";
		Chart.GridLineMajor = 4;
		Chart.GridLineMinor = 0;

		foreach ( var entry in PerformanceStats.Timings.GetMain() )
		{
			var renderColor = entry.Color;
			Chart.SetData( entry.Name, "image", renderColor, entry.GetMetric( framesSinceUpdate ) );
		}

		Chart.Draw();

		framesSinceUpdate = 0;
		hasInitialRender = true;

		// Vider les événements de performance après le rendu
		if ( EnableEventQueue )
		{
			// Retirer uniquement les événements PerformanceUpdated de la queue
			var events = RenderableEventQueue.DequeueAll();
			var otherEvents = events.Where( e => e.Type != RenderableEvent.EventType.PerformanceUpdated ).ToList();
			
			// Remettre les autres événements dans la queue
			foreach ( var evt in otherEvents )
			{
				RenderableEventQueue.Enqueue( evt );
			}
		}
	}
}
