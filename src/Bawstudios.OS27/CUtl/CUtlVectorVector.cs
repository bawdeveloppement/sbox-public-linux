using System;
using System.Runtime.InteropServices;
using Bawstudios.OS27.Common;
using NativeEngine;
using Sandbox;

namespace Bawstudios.OS27.CUtl;

/// <summary>
/// Emulation module for CUtlVectorVector (CtlVctrVctr_*).
/// Handles Vector3 vectors.
/// </summary>
public static unsafe class CUtlVectorVector
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][CUtlVecVec] {name} {message}");
    }

    /// <summary>
    /// Initializes the CUtlVectorVector module by patching native functions.
    /// Indices depuis Interop.Engine.cs lignes 16106-16110 (1241-1245)
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // Indices 1241-1245
        native[1241] = (void*)(delegate* unmanaged<IntPtr, void>)&CtlVctrVctr_DeleteThis;
        native[1242] = (void*)(delegate* unmanaged<int, int, IntPtr>)&CtlVctrVctr_Create;
        native[1243] = (void*)(delegate* unmanaged<IntPtr, int>)&CtlVctrVctr_Count;
        native[1244] = (void*)(delegate* unmanaged<IntPtr, int, void>)&CtlVctrVctr_SetCount;
        native[1245] = (void*)(delegate* unmanaged<IntPtr, int, Vector3>)&CtlVctrVctr_Element;
        
        LogCall(nameof(Init), minimal: true, message: "module initialized");
    }
    
    [UnmanagedCallersOnly]
    public static void CtlVctrVctr_DeleteThis(IntPtr self)
    {
        LogCall(nameof(CtlVctrVctr_DeleteThis), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return;
        
        var vectorData = HandleManager.Get<VectorVectorData>((int)self);
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
    public static IntPtr CtlVctrVctr_Create(int growsize, int initialcapacity)
    {
        LogCall(nameof(CtlVctrVctr_Create), minimal: true, message: $"growsize={growsize} initcap={initialcapacity}");
        var vectorData = new VectorVectorData
        {
            GrowSize = growsize,
            Capacity = Math.Max(initialcapacity, 16),
            Count = 0
        };
        
        int dataSize = vectorData.Capacity * sizeof(Vector3);
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
    public static int CtlVctrVctr_Count(IntPtr self)
    {
        LogCall(nameof(CtlVctrVctr_Count), minimal: true, message: $"self=0x{self.ToInt64():X}");
        if (self == IntPtr.Zero)
            return 0;
        
        var vectorData = HandleManager.Get<VectorVectorData>((int)self);
        return vectorData?.Count ?? 0;
    }
    
    [UnmanagedCallersOnly]
    public static void CtlVctrVctr_SetCount(IntPtr self, int count)
    {
        LogCall(nameof(CtlVctrVctr_SetCount), minimal: true, message: $"self=0x{self.ToInt64():X} count={count}");
        if (self == IntPtr.Zero || count < 0)
            return;
        
        var vectorData = HandleManager.Get<VectorVectorData>((int)self);
        if (vectorData == null)
            return;
        
        if (count > vectorData.Capacity)
        {
            int newCapacity = Math.Max(count, vectorData.Capacity + vectorData.GrowSize);
            int newDataSize = newCapacity * sizeof(Vector3);
            IntPtr newDataPtr = Marshal.AllocHGlobal(newDataSize);
            
            if (vectorData.DataPtr != IntPtr.Zero)
            {
                int copySize = Math.Min(vectorData.Count, count) * sizeof(Vector3);
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
    public static Vector3 CtlVctrVctr_Element(IntPtr self, int i)
    {
        LogCall(nameof(CtlVctrVctr_Element), minimal: true, message: $"self=0x{self.ToInt64():X} i={i}");
        if (self == IntPtr.Zero || i < 0)
            return Vector3.Zero;
        
        var vectorData = HandleManager.Get<VectorVectorData>((int)self);
        if (vectorData == null || i >= vectorData.Count || vectorData.DataPtr == IntPtr.Zero)
            return Vector3.Zero;
        
        return Marshal.PtrToStructure<Vector3>(vectorData.DataPtr + (i * sizeof(Vector3)));
    }
    
    public class VectorVectorData
    {
        public int GrowSize { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public IntPtr DataPtr { get; set; } = IntPtr.Zero;
    }
}

