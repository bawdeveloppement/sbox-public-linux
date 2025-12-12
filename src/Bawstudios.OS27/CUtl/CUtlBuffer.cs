using System;
using System.Runtime.InteropServices;
using Bawstudios.OS27.Common;

namespace Bawstudios.OS27.CUtl;

/// <summary>
/// Emulation module for CUtlBuffer (CUtlBuffer_*).
/// Handles data buffers.
/// </summary>
public static unsafe class CUtlBuffer
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][CUtlBuffer] {name} {message}");
    }

    /// <summary>
    /// Initializes the CUtlBuffer module by patching native functions.
    /// Indices depuis Interop.Engine.cs lignes 16078-16081 (1213-1216)
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // Indices 1213-1216
        native[1213] = (void*)(delegate* unmanaged<IntPtr>)&CUtlBuffer_Create;
        native[1214] = (void*)(delegate* unmanaged<IntPtr, void>)&CUtlBuffer_Dispose;
        native[1215] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CUtlBuffer_Base;
        native[1216] = (void*)(delegate* unmanaged<IntPtr, int>)&CUtlBuffer_TellMaxPut;
        
        LogCall(nameof(Init), minimal: true, message: "module initialized");
    }
    
    /// <summary>
    /// Create a new CUtlBuffer instance.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CUtlBuffer_Create()
    {
        LogCall(nameof(CUtlBuffer_Create), minimal: true);
        var bufferData = new BufferData
        {
            DataPtr = IntPtr.Zero,
            Size = 0,
            MaxPut = 0
        };
        
        int handle = HandleManager.Register(bufferData);
        return handle == 0 ? IntPtr.Zero : (IntPtr)handle;
    }
    
    /// <summary>
    /// Dispose a CUtlBuffer instance.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CUtlBuffer_Dispose(IntPtr self)
    {
        LogCall(nameof(CUtlBuffer_Dispose), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return;
        
        var bufferData = HandleManager.Get<BufferData>((int)self);
        if (bufferData != null)
        {
            if (bufferData.DataPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(bufferData.DataPtr);
            }
            HandleManager.Unregister((int)self);
        }
    }
    
    /// <summary>
    /// Get the base pointer of the buffer.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CUtlBuffer_Base(IntPtr self)
    {
        LogCall(nameof(CUtlBuffer_Base), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return IntPtr.Zero;
        
        var bufferData = HandleManager.Get<BufferData>((int)self);
        return bufferData?.DataPtr ?? IntPtr.Zero;
    }
    
    /// <summary>
    /// Get the maximum put position.
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CUtlBuffer_TellMaxPut(IntPtr self)
    {
        LogCall(nameof(CUtlBuffer_TellMaxPut), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return 0;
        
        var bufferData = HandleManager.Get<BufferData>((int)self);
        return bufferData?.MaxPut ?? 0;
    }
    
    public class BufferData
    {
        public IntPtr DataPtr { get; set; } = IntPtr.Zero;
        public int Size { get; set; }
        public int MaxPut { get; set; }
    }
}

