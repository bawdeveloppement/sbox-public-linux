namespace Editor;

/// <summary>
/// Interface for shortcut entries, enabling testability and extensibility
/// </summary>
public interface IShortcutEntry
{
	string Identifier { get; }
	string Keys { get; }
	ShortcutType Type { get; }
	bool IsDown { get; set; }
	bool Invoke( bool force = false );
}

