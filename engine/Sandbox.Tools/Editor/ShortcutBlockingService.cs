using System;

namespace Editor;

/// <summary>
/// Service responsible for determining if a shortcut should be blocked.
/// Uses an extensible and composable rule system.
/// </summary>
internal class ShortcutBlockingService
{
	private readonly IFocusProvider _focusProvider;
	private readonly Func<string, IEnumerable<IShortcutEntry>> _getEntriesForKeys;
	private readonly List<IShortcutBlockingRule> _rules = new();

	public ShortcutBlockingService(
		IFocusProvider focusProvider,
		Func<string, IEnumerable<IShortcutEntry>> getEntriesForKeys )
	{
		_focusProvider = focusProvider;
		_getEntriesForKeys = getEntriesForKeys;

		// Register default rules
		RegisterDefaultRules();
	}

	/// <summary>
	/// Registers a new blocking rule.
	/// Rules are evaluated in priority order (higher priority first).
	/// </summary>
	public void RegisterRule( IShortcutBlockingRule rule )
	{
		_rules.Add( rule );
		_rules.Sort( ( a, b ) => b.Priority.CompareTo( a.Priority ) ); // Descending sort
	}

	/// <summary>
	/// Unregisters a rule
	/// </summary>
	public void UnregisterRule( IShortcutBlockingRule rule )
	{
		_rules.Remove( rule );
	}

	/// <summary>
	/// Determines if a shortcut should be blocked by evaluating all rules.
	/// </summary>
	public bool ShouldBlockShortcut( string keys, bool force = false )
	{
		ShortcutBlockingContext context = CreateContext( keys, force );

		// Evaluate rules in priority order
		foreach ( var rule in _rules )
		{
			if ( !rule.ShouldEvaluate( context ) )
				continue;

			var result = rule.ShouldBlock( context );

			// If a rule returns a definitive decision, use it
			if ( result.HasValue )
			{
				// Rules with negative priority are exceptions (never block)
				if ( rule.Priority < 0 && result.Value )
					continue; // Ignore exceptions that try to block

				return result.Value;
			}
		}

		// By default, don't block
		return false;
	}

	private ShortcutBlockingContext CreateContext( string keys, bool force )
	{
		return new ShortcutBlockingContext
		{
			Keys = keys,
			FocusWidget = _focusProvider.FocusWidget,
			MatchingEntries = _getEntriesForKeys( keys ),
			Force = force
		};
	}

	private void RegisterDefaultRules()
	{
		// Exception: Window/Application shortcuts (negative priority = exception)
		RegisterRule( new WindowApplicationShortcutRule() );

		// Main rule: Text input focus
		RegisterRule( new TextInputFocusRule() );
	}
}

