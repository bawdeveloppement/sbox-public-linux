namespace Editor;

/// <summary>
/// Interface for obtaining the focused widget, enabling testability
/// </summary>
internal interface IFocusProvider
{
	Widget FocusWidget { get; }
}

/// <summary>
/// Default implementation using Application.FocusWidget
/// </summary>
internal class DefaultFocusProvider : IFocusProvider
{
	public Widget FocusWidget => Application.FocusWidget;
}

