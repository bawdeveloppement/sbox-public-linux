using System;
using System.Runtime.InteropServices;
using Sandbox.Engine.Emulation.Common;
using NativeEngine;

namespace Sandbox.Engine.Emulation.CUtl;

/// <summary>
/// Module d'émulation pour CUtlVectorUInt32 (CtlVctrnt32_*).
/// Gère les vecteurs de uint32.
/// </summary>
public static unsafe class CUtlVectorUInt32
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][CUtlVecU32] {name} {message}");
    }

    /// <summary>
    /// Initialise le module CUtlVectorUInt32 en patchant les fonctions natives.
    /// Indices depuis Interop.Engine.cs lignes 16101-16105 (1236-1240)
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // Indices 1236-1240
        native[1236] = (void*)(delegate* unmanaged<IntPtr, void>)&CtlVctrnt32_DeleteThis;
        native[1237] = (void*)(delegate* unmanaged<int, int, IntPtr>)&CtlVctrnt32_Create;
        native[1238] = (void*)(delegate* unmanaged<IntPtr, int>)&CtlVctrnt32_Count;
        native[1239] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CtlVctrnt32_SetCount;
        native[1240] = (void*)(delegate* unmanaged<IntPtr, int, uint>)&CtlVctrnt32_Element;
        
        LogCall(nameof(Init), minimal: true, message: "module initialized");
    }
    
    [UnmanagedCallersOnly]
    public static void CtlVctrnt32_DeleteThis(IntPtr self)
    {
        LogCall(nameof(CtlVctrnt32_DeleteThis), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return;
        
        var vectorData = HandleManager.Get<VectorUInt32Data>((int)self);
        if (vectorData != null)
        {
            if (vectorData.DataPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(vectorData.DataPtr);
            }
            HandleManager.Unregister((int)self);
        }
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr CtlVctrnt32_Create(int growsize, int initialcapacity)
    {
        LogCall(nameof(CtlVctrnt32_Create), minimal: true, message: $"growsize={growsize} initcap={initialcapacity}");
        var vectorData = new VectorUInt32Data
        {
            GrowSize = growsize,
            Capacity = Math.Max(initialcapacity, 16),
            Count = 0
        };
        
        int dataSize = vectorData.Capacity * sizeof(uint);
        vectorData.DataPtr = Marshal.AllocHGlobal(dataSize);
        
        int handle = HandleManager.Register(vectorData);
        if (handle == 0)
        {
            Marshal.FreeHGlobal(vectorData.DataPtr);
            return IntPtr.Zero;
        }
        
        return (IntPtr)handle;
    }
    
    [UnmanagedCallersOnly]
    public static int CtlVctrnt32_Count(IntPtr self)
    {
        LogCall(nameof(CtlVctrnt32_Count), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return 0;
        
        var vectorData = HandleManager.Get<VectorUInt32Data>((int)self);
        return vectorData?.Count ?? 0;
    }
    
    [UnmanagedCallersOnly]
    public static void CtlVctrnt32_SetCount(IntPtr self, int count)
    {
        LogCall(nameof(CtlVctrnt32_SetCount), minimal: true, message: $"self=0x{self.ToInt64():X} count={count}");
        if (self == IntPtr.Zero || count < 0)
            return;
        
        var vectorData = HandleManager.Get<VectorUInt32Data>((int)self);
        if (vectorData == null)
            return;
        
        if (count > vectorData.Capacity)
        {
            int newCapacity = Math.Max(count, vectorData.Capacity + vectorData.GrowSize);
            int newDataSize = newCapacity * sizeof(uint);
            IntPtr newDataPtr = Marshal.AllocHGlobal(newDataSize);
            
            if (vectorData.DataPtr != IntPtr.Zero)
            {
                int copySize = Math.Min(vectorData.Count, count) * sizeof(uint);
                Buffer.MemoryCopy(
                    (void*)vectorData.DataPtr,
                    (void*)newDataPtr,
                    newDataSize,
                    copySize
                );
                Marshal.FreeHGlobal(vectorData.DataPtr);
            }
            
            vectorData.DataPtr = newDataPtr;
            vectorData.Capacity = newCapacity;
        }
        
        vectorData.Count = count;
    }
    
    [UnmanagedCallersOnly]
    public static uint CtlVctrnt32_Element(IntPtr self, int i)
    {
        LogCall(nameof(CtlVctrnt32_Element), minimal: true, message: $"self=0x{self.ToInt64():X} i={i}");
        if (self == IntPtr.Zero || i < 0)
            return 0;
        
        var vectorData = HandleManager.Get<VectorUInt32Data>((int)self);
        if (vectorData == null || i >= vectorData.Count || vectorData.DataPtr == IntPtr.Zero)
            return 0;
        
        return (uint)Marshal.ReadInt32(vectorData.DataPtr, i * sizeof(uint));
    }
    
    public class VectorUInt32Data
    {
        public int GrowSize { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public IntPtr DataPtr { get; set; } = IntPtr.Zero;
    }
}

