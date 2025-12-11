using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Sandbox.Engine.Emulation.Common;

namespace Sandbox.Engine.Emulation.CUtl;

/// <summary>
/// Module d'émulation pour CUtlSymbolTable (CUtlSymbolTable_*).
/// Gère les tables de symboles.
/// </summary>
public static unsafe class CUtlSymbolTable
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][CUtlSym] {name} {message}");
    }

    /// <summary>
    /// Initialise le module CUtlSymbolTable en patchant les fonctions natives.
    /// Indice depuis Interop.Engine.cs ligne 16082 (1217)
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // Indice 1217
        native[1217] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CUtlSymbolTable_AddString;
        
        LogCall(nameof(Init), minimal: true, message: "module initialized");
    }
    
    [UnmanagedCallersOnly]
    public static void CUtlSymbolTable_AddString(IntPtr self, IntPtr pString)
    {
        string str = pString != IntPtr.Zero ? Marshal.PtrToStringUTF8(pString) ?? "" : "";
        LogCall(nameof(CUtlSymbolTable_AddString), minimal: true, message: $"self=0x{self.ToInt64():X} str={str}");
        if (self == IntPtr.Zero || pString == IntPtr.Zero)
            return;
        
        // Stub implementation - symbol tables are typically managed by the engine
        // This is a no-op for now
    }
}

