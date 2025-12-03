using System;

namespace Editor;

/// <summary>
/// Rule: Window/Application shortcuts are never blocked
/// This rule has negative priority because it's an exception (never blocks)
/// </summary>
internal class WindowApplicationShortcutRule : IShortcutBlockingRule
{
	public int Priority => -100; // Exception (negative priority)
	public string Name => "Window/Application Shortcut Exception";

	public bool ShouldEvaluate( ShortcutBlockingContext context ) => true;

	public bool? ShouldBlock( ShortcutBlockingContext context )
	{
		bool isWindowOrApp = context.MatchingEntries.Any( entry =>
			entry.Type == ShortcutType.Window || entry.Type == ShortcutType.Application );

		if ( isWindowOrApp )
			return false; // Never block

		return null; // This rule doesn't apply
	}
}

/// <summary>
/// Rule: Block Widget shortcuts when a LineEdit/TextEdit has focus
/// </summary>
internal class TextInputFocusRule : IShortcutBlockingRule
{
	public int Priority => 10;
	public string Name => "Text Input Focus Block";

	public bool ShouldEvaluate( ShortcutBlockingContext context ) => true;

	public bool? ShouldBlock( ShortcutBlockingContext context )
	{
		var focusWidget = context.FocusWidget;

		// Check if a text input widget has focus
		if ( focusWidget is not LineEdit && focusWidget is not TextEdit )
			return null; // Doesn't apply

		// Check if it's a Widget shortcut
		bool isWidgetShortcut = context.MatchingEntries.Any( entry =>
			entry.Type == ShortcutType.Widget );

		if ( !isWidgetShortcut )
			return null; // Only applies to Widget shortcuts

		// Check exceptions (allowed modifiers)
		if ( HasAllowedModifiers( context.Keys ) )
			return false; // Allow due to modifiers

		return true; // Block
	}

	private static bool HasAllowedModifiers( string keys )
	{
		var parts = keys.Split( "+" );
		bool hasCtrlOrAlt = parts.Any( x => x == "CTRL" || x == "ALT" );

		if ( !hasCtrlOrAlt )
			return false;

		// Check allowed combinations
		return keys == "CTRL+A" || keys == "CTRL+C" || keys == "CTRL+V" || keys == "CTRL+X";
	}
}

/// <summary>
/// Customizable rule: Allows plugins to add their own rules
/// </summary>
internal class CustomShortcutBlockingRule(
	string name,
	int priority,
	Func<ShortcutBlockingContext, bool> shouldEvaluate,
	Func<ShortcutBlockingContext, bool?> evaluator )
	: IShortcutBlockingRule
{
	public int Priority => priority;
	public string Name => name;
	public bool ShouldEvaluate( ShortcutBlockingContext context ) => shouldEvaluate( context );
	public bool? ShouldBlock( ShortcutBlockingContext context ) => evaluator( context );
}

