using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Bawstudios.OS27.PerformanceTrace;

/// <summary>
/// Emulation module for PerformanceTrace (PerformanceTrace_*).
/// Handles profiling and performance tracing events.
/// </summary>
public static unsafe class PerformanceTrace
{
    private static bool LogMinimal = false; // If you enable this, its 100% sure you gonna lag
    private static bool LogAll = false;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][Perf] {name} {message}");
    }

    /// <summary>
    /// Initializes the PerformanceTrace module by patching native functions.
    /// Indices depuis Interop.Engine.cs lignes 17252-17253 (2387-2388)
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // PerformanceTrace functions (indices 2387-2388 from Interop.Engine.cs)
        native[2390] = (void*)(delegate* unmanaged<IntPtr, IntPtr, uint, void>)&PerformanceTrace_BeginEvent;
        native[2391] = (void*)(delegate* unmanaged<void>)&PerformanceTrace_EndEvent;
        
        LogCall(nameof(Init), minimal: true, message: "module initialized");
    }
    
    /// <summary>
    /// Begin a performance trace event (profiling).
    /// Signature exacte depuis Interop.Engine.cs ligne 17252: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr, uint, void &gt;
    /// 
    /// **Source 2 behavior**: Records a profiling event with name, data, and color.
    /// **Emulation behavior**: No-op for now (profiling not critical). Can be implemented with a profiling library if needed.
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void PerformanceTrace_BeginEvent(IntPtr name, IntPtr data, uint color)
    {
        string nameStr = name != IntPtr.Zero ? Marshal.PtrToStringUTF8(name) ?? "" : "";
        LogCall(nameof(PerformanceTrace_BeginEvent), minimal: true, message: $"name={nameStr} data=0x{data.ToInt64():X} color=0x{color:X}");
        // No-op for now - profiling is not critical for engine functionality
        // In the future, this could be implemented with a profiling library if needed
    }
    
    /// <summary>
    /// End a performance trace event (profiling).
    /// Signature exacte depuis Interop.Engine.cs ligne 17253: delegate* unmanaged[SuppressGCTransition]&lt; void &gt;
    /// 
    /// **Source 2 behavior**: Ends the current profiling event.
    /// **Emulation behavior**: No-op for now (profiling not critical). Can be implemented with a profiling library if needed.
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void PerformanceTrace_EndEvent()
    {
        LogCall(nameof(PerformanceTrace_EndEvent), minimal: true);
        // No-op for now - profiling is not critical for engine functionality
        // In the future, this could be implemented with a profiling library if needed
    }
}

