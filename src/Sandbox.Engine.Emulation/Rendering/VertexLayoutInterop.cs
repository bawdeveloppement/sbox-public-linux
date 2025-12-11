using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Sandbox.Engine.Emulation.Common;

namespace Sandbox.Engine.Emulation.Rendering;

/// <summary>
/// Emulation des fonctions VertexLayout_* (indices 2654-2658) pour exposer stride/attributs aux RenderTools.
/// </summary>
internal static unsafe class VertexLayoutInterop
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][VL] {name} {message}");
    }

    internal class LayoutData
    {
        public int Size;
        public readonly List<(string Semantic, int SemanticIndex, uint Format, int Offset)> Attributes = new();
    }

    private static readonly Dictionary<IntPtr, LayoutData> _layouts = new();

    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        native[2654] = (void*)(delegate* unmanaged<IntPtr, int, IntPtr>)&VertexLayout_Create;
        native[2655] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&VertexLayout_Destroy;
        native[2656] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&VertexLayout_Free;
        native[2657] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, uint, int, IntPtr>)&VertexLayout_Add;
        native[2658] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&VertexLayout_Build;
    }

    public static bool TryGetLayout(IntPtr handle, out LayoutData? data)
    {
        lock (_layouts)
        {
            return _layouts.TryGetValue(handle, out data);
        }
    }

    [UnmanagedCallersOnly]
    private static IntPtr VertexLayout_Create(IntPtr name, int size)
    {
        string semanticName = Marshal.PtrToStringUTF8(name) ?? "";
        LogCall(nameof(VertexLayout_Create), minimal: true, message: $"name={semanticName} size={size}");
        var data = new LayoutData { Size = size };
        int handle = HandleManager.Register(data);
        lock (_layouts)
        {
            _layouts[(IntPtr)handle] = data;
        }
        return (IntPtr)handle;
    }

    private static void DestroyLayout(IntPtr self)
    {
        LogCall(nameof(DestroyLayout), minimal: true, message: $"self=0x{self.ToInt64():X}");
        lock (_layouts)
        {
            _layouts.Remove(self);
        }
        HandleManager.Unregister((int)self);
    }

    [UnmanagedCallersOnly]
    private static IntPtr VertexLayout_Destroy(IntPtr self)
    {
        LogCall(nameof(VertexLayout_Destroy), minimal: true, message: $"self=0x{self.ToInt64():X}");
        DestroyLayout(self);
        return IntPtr.Zero;
    }

    [UnmanagedCallersOnly]
    private static IntPtr VertexLayout_Free(IntPtr self)
    {
        LogCall(nameof(VertexLayout_Free), minimal: true, message: $"self=0x{self.ToInt64():X}");
        DestroyLayout(self);
        return IntPtr.Zero;
    }

    [UnmanagedCallersOnly]
    private static IntPtr VertexLayout_Add(IntPtr self, IntPtr semanticName, int semanticIndex, uint format, int offset)
    {
        lock (_layouts)
        {
            if (_layouts.TryGetValue(self, out var data))
            {
                string semantic = Marshal.PtrToStringUTF8(semanticName) ?? "";
                LogCall(nameof(VertexLayout_Add), minimal: true, message: $"self=0x{self.ToInt64():X} semantic={semantic} idx={semanticIndex} fmt=0x{format:X} offset={offset}");
                data.Attributes.Add((semantic, semanticIndex, format, offset));
            }
        }
        return self;
    }

    [UnmanagedCallersOnly]
    private static IntPtr VertexLayout_Build(IntPtr self)
    {
        LogCall(nameof(VertexLayout_Build), minimal: true, message: $"self=0x{self.ToInt64():X}");
        // Rien de particulier à faire côté émulation pour le build.
        return self;
    }
}

