# Fix F5 hotkey being ignored when inspector textbox is focused

## Commit Message

```
Fix F5 hotkey ignored when inspector textbox has focus

F5 (Play) shortcut was being blocked when a LineEdit/TextEdit widget
had focus, forcing users to click elsewhere or press ESC before F5
would work.

This fix implements an extensible rule-based system for shortcut blocking
that allows Window/Application level shortcuts (like F5) to work even
when text input widgets have focus, while still blocking Widget-level
shortcuts to prevent conflicts with text editing.

Changes:
- Refactored shortcut blocking logic into extensible rule system
- Created IShortcutBlockingRule interface for custom rules
- Added WindowApplicationShortcutRule exception for global shortcuts
- Maintained TextInputFocusRule for Widget shortcut blocking
- Made system testable and extensible for future enhancements
```

## Pull Request Description

### Problem

Pressing F5 to Play doesn't work if you've given focus to an inspector textbox. Users were forced to click somewhere else afterwards (or hit ESC) to unfocus before F5 works. Hitting Enter to "confirm" a change doesn't unfocus the textbox.

### Root Cause

The shortcut blocking logic in `EditorShortcuts.Invoke()` was blocking all shortcuts when a `LineEdit` or `TextEdit` widget had focus, without distinguishing between shortcut types. This prevented Window-level shortcuts like F5 (Play) from working even though they should be globally available.

### Solution

Implemented an extensible rule-based system for shortcut blocking that:

1. **Preserves existing behavior**: Widget-level shortcuts are still blocked when text input widgets have focus
2. **Fixes the bug**: Window/Application level shortcuts (like F5) now work regardless of focus state
3. **Improves architecture**: Makes the system extensible, testable, and maintainable

### Architecture Changes

#### New Files Created

- `engine/Sandbox.Tools/Editor/IShortcutEntry.cs` - Interface for shortcut entries (enables testability)
- `engine/Sandbox.Tools/Editor/IFocusProvider.cs` - Interface for focus widget access (enables testability)
- `engine/Sandbox.Tools/Editor/IShortcutBlockingRule.cs` - Interface for blocking rules (enables extensibility)
- `engine/Sandbox.Tools/Editor/ShortcutBlockingContext.cs` - Context record for rule evaluation
- `engine/Sandbox.Tools/Editor/ShortcutBlockingRules.cs` - Default rule implementations
- `engine/Sandbox.Tools/Editor/ShortcutBlockingService.cs` - Rule evaluation service

#### Key Components

**Rule System**
- Rules are evaluated by priority (higher priority first)
- Rules with negative priority are exceptions (never block)
- Each rule can return: `true` (block), `false` (allow), or `null` (doesn't apply)

**Default Rules**
- `WindowApplicationShortcutRule` (priority -100): Exception rule that never blocks Window/Application shortcuts
- `TextInputFocusRule` (priority 10): Blocks Widget shortcuts when LineEdit/TextEdit has focus

**Extensibility**
- Plugins/addons can register custom rules via `EditorShortcuts.RegisterBlockingRule()`
- Rules can be composed and prioritized
- System is fully testable with dependency injection

#### Modified Files

- `engine/Sandbox.Tools/EditorShortcuts.cs`
  - Refactored `Invoke()` to use `ShortcutBlockingService`
  - Added `Entry` class to implement `IShortcutEntry`
  - Added public methods for rule registration
  - Renamed `IsDown(string)` to `IsShortcutDown(string)` to avoid naming conflict

### Benefits

1. **Bug Fixed**: F5 now works even when inspector textboxes have focus
2. **Backward Compatible**: Existing behavior preserved for Widget shortcuts
3. **Extensible**: Easy to add new blocking rules without modifying core code
4. **Testable**: Rules can be unit tested independently
5. **Maintainable**: Clear separation of concerns and single responsibility per rule

### Testing

The fix can be verified by:
1. Opening the inspector
2. Clicking on any textbox to give it focus
3. Pressing F5 - it should work immediately without needing to unfocus first

### Future Enhancements

The new architecture enables future enhancements such as:
- Configurable rules via user preferences
- Rule composition with logical operators
- Rule logging/debugging
- Context-aware blocking (e.g., block during long operations)
- Plugin-specific blocking rules

### Breaking Changes

- Renamed `IsDown(string)` to `IsShortcutDown(string)` -> Editor Extentions should be aware.



