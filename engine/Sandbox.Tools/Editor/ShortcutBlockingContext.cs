namespace Editor;

/// <summary>
/// Context for evaluating a shortcut blocking rule
/// </summary>
public record ShortcutBlockingContext
{
	public string Keys { get; init; }
	public Widget FocusWidget { get; init; }
	public IEnumerable<IShortcutEntry> MatchingEntries { get; init; }
	public bool Force { get; init; }
}

