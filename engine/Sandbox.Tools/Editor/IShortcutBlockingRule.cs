namespace Editor;

/// <summary>
/// Represents a rule that determines if a shortcut should be blocked.
/// Enables extension and composition of rules.
/// </summary>
public interface IShortcutBlockingRule
{
	/// <summary>
	/// Priority of the rule (higher = evaluated first).
	/// Rules with negative priority are exceptions (never block).
	/// </summary>
	int Priority { get; }

	/// <summary>
	/// Name of the rule for debugging and configuration
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Determines if this rule should be evaluated for this shortcut
	/// </summary>
	bool ShouldEvaluate( ShortcutBlockingContext context );

	/// <summary>
	/// Evaluates if the shortcut should be blocked.
	/// Returns null if the rule doesn't apply, true to block, false to allow.
	/// </summary>
	bool? ShouldBlock( ShortcutBlockingContext context );
}

