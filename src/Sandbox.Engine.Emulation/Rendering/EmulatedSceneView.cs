using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NativeEngine;
using Sandbox;
using Sandbox.Engine.Emulation.Common;
using Sandbox.Engine.Emulation.RenderAttributes;
using Sandbox.Engine.Emulation.Rendering;
using Sandbox.Engine.Emulation.Platform;
using Sandbox.Rendering;
using Sandbox.Engine.Emulation.Scene;

namespace Sandbox.Engine.Emulation.Rendering;

/// <summary>
/// Emulated implementation of ISceneView exports (indices 2163-2185).
/// </summary>
internal static unsafe class EmulatedSceneView
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][SV] {name} {message}");
    }

    private class SceneViewData
    {
        public RenderViewport MainViewport = new RenderViewport(0, 0, 1280, 720);
        public IntPtr SwapChain = IntPtr.Zero;
        public IntPtr RenderAttributesPtr = IntPtr.Zero;
        public long DefaultRequiredFlags;
        public long DefaultExcludedFlags;
        public readonly List<IntPtr> RenderLayers = new();
        public readonly Dictionary<string, IntPtr> LayersByName = new();
        public readonly List<IntPtr> Worlds = new();
        public readonly List<IntPtr> DependentViews = new();
        public IntPtr Parent = IntPtr.Zero;
        public int Priority;
        public int ViewUniqueId = 1;
        public int ManagedCameraId;
        public bool PostProcessEnabled = true;
        public int ToolsVisMode;
        public IntPtr FrustumPtr = IntPtr.Zero;
        public readonly Dictionary<(string Name, IntPtr Texture, int Flags), IntPtr> RenderTargets = new();
    }

    private class RenderTargetData
    {
        public IntPtr Texture;
        public int Flags;
    }

    private static readonly Dictionary<IntPtr, SceneViewData> _views = new();

    public static IntPtr CreateView(RenderViewport viewport, int managedCameraId = 1, int priority = 0, IntPtr swapChain = default)
    {
        var rect = viewport.Rect;
        LogCall(nameof(CreateView), minimal: true, message: $"vp=({rect.Width}x{rect.Height}) cam={managedCameraId} prio={priority} swap=0x{swapChain.ToInt64():X}");
        var data = new SceneViewData
        {
            MainViewport = viewport,
            ManagedCameraId = managedCameraId,
            Priority = priority,
            RenderAttributesPtr = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal(),
            SwapChain = swapChain
        };

        int handle = HandleManager.Register(data);
        lock (_views)
        {
            _views[(IntPtr)handle] = data;
        }
        return (IntPtr)handle;
    }

    public static void SetSwapChainManaged(IntPtr self, IntPtr swapChain)
    {
        LogCall(nameof(SetSwapChainManaged), minimal: true, message: $"self=0x{self.ToInt64():X} swap=0x{swapChain.ToInt64():X}");
        var data = GetView(self);
        data.SwapChain = swapChain;
    }

    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        native[2163] = (void*)(delegate* unmanaged<IntPtr, RenderViewport>)&ISceneView_GetMainViewport;
        native[2164] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&ISceneView_GetSwapChain;
        native[2165] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, void>)&ISceneView_AddDependentView;
        native[2166] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&ISceneView_GetRenderAttributesPtr;
        native[2167] = (void*)(delegate* unmanaged<IntPtr, IntPtr, RenderViewport*, StringToken, IntPtr, IntPtr>)&ISceneView_AddRenderLayer;
        native[2168] = (void*)(delegate* unmanaged<IntPtr, IntPtr, RenderViewport*, IntPtr, IntPtr, int, IntPtr>)&ISceneView_AddManagedProceduralLayer;
        native[2169] = (void*)(delegate* unmanaged<IntPtr, long, void>)&ISceneView_SetDefaultLayerObjectRequiredFlags;
        native[2170] = (void*)(delegate* unmanaged<IntPtr, long, void>)&ISceneView_SetDefaultLayerObjectExcludedFlags;
        native[2171] = (void*)(delegate* unmanaged<IntPtr, long>)&ISceneView_GetDefaultLayerObjectRequiredFlags;
        native[2172] = (void*)(delegate* unmanaged<IntPtr, long>)&ISceneView_GetDefaultLayerObjectExcludedFlags;
        native[2173] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&ISceneView_AddWorldToRenderList;
        native[2174] = (void*)(delegate* unmanaged<IntPtr, IntPtr, IntPtr, int, IntPtr>)&ISceneView_FindOrCreateRenderTarget;
        native[2175] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&ISceneView_SetParent;
        native[2176] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&ISceneView_GetParent;
        native[2177] = (void*)(delegate* unmanaged<IntPtr, int>)&ISceneView_GetPriority;
        native[2178] = (void*)(delegate* unmanaged<IntPtr, int, void>)&ISceneView_SetPriority;
        native[2179] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&ISceneView_GetFrustum;
        native[2180] = (void*)(delegate* unmanaged<IntPtr, int>)&ISceneView_GetPostProcessEnabled;
        native[2181] = (void*)(delegate* unmanaged<IntPtr, int>)&ISceneView_GetToolsVisMode;
        native[2182] = (void*)(delegate* unmanaged[SuppressGCTransition]<IntPtr, int>)&Get__ISceneView_m_ViewUniqueId;
        native[2183] = (void*)(delegate* unmanaged[SuppressGCTransition]<IntPtr, int, void>)&Set__ISceneView_m_ViewUniqueId;
        native[2184] = (void*)(delegate* unmanaged[SuppressGCTransition]<IntPtr, int>)&Get__ISceneView_m_ManagedCameraId;
        native[2185] = (void*)(delegate* unmanaged[SuppressGCTransition]<IntPtr, int, void>)&Set__ISceneView_m_ManagedCameraId;
    }

    private static SceneViewData GetView(IntPtr self)
    {
        if (self == IntPtr.Zero) self = (IntPtr)(-1); // stable key for fallback
        lock (_views)
        {
            if (!_views.TryGetValue(self, out var data))
            {
                LogCall(nameof(GetView), minimal: true, message: $"create self=0x{self.ToInt64():X}");
                var window = PlatformFunctions.GetWindowHandle();
                data = new SceneViewData
                {
                    RenderAttributesPtr = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal(),
                    SwapChain = window != null ? (IntPtr)window : IntPtr.Zero
                };
                _views[self] = data;
            }
            return data;
        }
    }

    private static IntPtr CreateLayerForView(IntPtr self, IntPtr pszDebugName, RenderViewport* viewport, SceneLayerType layerType = SceneLayerType.Translucent)
    {
        string debugName = pszDebugName != IntPtr.Zero ? Marshal.PtrToStringUTF8(pszDebugName) ?? "RenderLayer" : "RenderLayer";
        var vp = viewport != null ? *viewport : new RenderViewport(0, 0, 1280, 720);
        var rect = vp.Rect;
        LogCall(nameof(CreateLayerForView), minimal: true, message: $"self=0x{self.ToInt64():X} name={debugName} vp=({rect.Width}x{rect.Height}) layer={layerType}");
        var data = GetView(self);
        lock (data.RenderLayers)
        {
            if (data.LayersByName.TryGetValue(debugName, out var existing))
            {
                // Mettre à jour le viewport si demandé et retourner la couche existante
                EmulatedSceneLayer.SetViewportManaged(existing, vp);
                return existing;
            }

            var handle = EmulatedSceneLayer.CreateLayer(debugName, vp, layerType);
            data.RenderLayers.Add(handle);
            data.LayersByName[debugName] = handle;
            return handle;
        }
    }

    [UnmanagedCallersOnly]
    public static RenderViewport ISceneView_GetMainViewport(IntPtr self) => GetView(self).MainViewport;

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_GetSwapChain(IntPtr self)
    {
        var swap = GetView(self).SwapChain;
        LogCall(nameof(ISceneView_GetSwapChain), minimal: true, message: $"self=0x{self.ToInt64():X} swap=0x{swap.ToInt64():X}");
        return swap;
    }

    [UnmanagedCallersOnly]
    public static void ISceneView_AddDependentView(IntPtr self, IntPtr pView, int nSlot)
    {
        LogCall(nameof(ISceneView_AddDependentView), minimal: true, message: $"self=0x{self.ToInt64():X} view=0x{pView.ToInt64():X} slot={nSlot}");
        var data = GetView(self);
        lock (data.DependentViews)
        {
            data.DependentViews.Add(pView);
    }
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_GetRenderAttributesPtr(IntPtr self)
    {
        LogCall(nameof(ISceneView_GetRenderAttributesPtr), minimal: true, message: $"self=0x{self.ToInt64():X}");
        var data = GetView(self);
        if (data.RenderAttributesPtr == IntPtr.Zero)
        {
            data.RenderAttributesPtr = RenderAttributes.RenderAttributes.CreateRenderAttributesInternal();
        }
        return data.RenderAttributesPtr;
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_AddRenderLayer(IntPtr self, IntPtr pszDebugName, RenderViewport* viewport, StringToken eShaderMode, IntPtr pAddBefore)
    {
        return CreateLayerForView(self, pszDebugName, viewport, SceneLayerType.Translucent);
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_AddManagedProceduralLayer(IntPtr self, IntPtr pszDebugName, RenderViewport* viewport, IntPtr renderCallback, IntPtr pAddBefore, int bDeleteWhenDone)
    {
        // Procedural layer modeled as a normal layer; callback not invoked yet.
        LogCall(nameof(ISceneView_AddManagedProceduralLayer), minimal: true, message: $"self=0x{self.ToInt64():X} namePtr=0x{pszDebugName.ToInt64():X} cb=0x{renderCallback.ToInt64():X} delete={bDeleteWhenDone}");
        return CreateLayerForView(self, pszDebugName, viewport, SceneLayerType.Translucent);
    }

    [UnmanagedCallersOnly]
    public static void ISceneView_SetDefaultLayerObjectRequiredFlags(IntPtr self, long nFlags)
    {
        LogCall(nameof(ISceneView_SetDefaultLayerObjectRequiredFlags), minimal: true, message: $"self=0x{self.ToInt64():X} flags={nFlags}");
        GetView(self).DefaultRequiredFlags = nFlags;
    }

    [UnmanagedCallersOnly]
    public static void ISceneView_SetDefaultLayerObjectExcludedFlags(IntPtr self, long nFlags)
    {
        LogCall(nameof(ISceneView_SetDefaultLayerObjectExcludedFlags), minimal: true, message: $"self=0x{self.ToInt64():X} flags={nFlags}");
        GetView(self).DefaultExcludedFlags = nFlags;
    }

    [UnmanagedCallersOnly]
    public static long ISceneView_GetDefaultLayerObjectRequiredFlags(IntPtr self) => GetView(self).DefaultRequiredFlags;

    [UnmanagedCallersOnly]
    public static long ISceneView_GetDefaultLayerObjectExcludedFlags(IntPtr self) => GetView(self).DefaultExcludedFlags;

    [UnmanagedCallersOnly]
    public static void ISceneView_AddWorldToRenderList(IntPtr self, IntPtr pWorld)
    {
        LogCall(nameof(ISceneView_AddWorldToRenderList), minimal: true, message: $"self=0x{self.ToInt64():X} world=0x{pWorld.ToInt64():X}");
        var data = GetView(self);
        lock (data.Worlds)
        {
            data.Worlds.Add(pWorld);
        }
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_FindOrCreateRenderTarget(IntPtr self, IntPtr pName, IntPtr hTexture, int nFlags)
    {
        var name = pName != IntPtr.Zero ? Marshal.PtrToStringUTF8(pName) ?? string.Empty : string.Empty;
        LogCall(nameof(ISceneView_FindOrCreateRenderTarget), minimal: true, message: $"self=0x{self.ToInt64():X} name={name} tex=0x{hTexture.ToInt64():X} flags=0x{nFlags:X}");
        return FindOrCreateRenderTargetManaged(self, name, hTexture, nFlags);
    }

    /// <summary>
    /// Helper managé pour créer/récupérer un render target handle (SceneViewRenderTargetHandle) à partir d'une texture.
    /// </summary>
    public static IntPtr FindOrCreateRenderTargetManaged(IntPtr self, string name, IntPtr texture, int flags)
    {
        LogCall(nameof(FindOrCreateRenderTargetManaged), minimal: false, message: $"self=0x{self.ToInt64():X} name={name} tex=0x{texture.ToInt64():X} flags=0x{flags:X}");
        var data = GetView(self);
        var key = (name ?? string.Empty, texture, flags);
        lock (data.RenderTargets)
        {
            if (data.RenderTargets.TryGetValue(key, out var handle))
                return handle;

            var rt = new RenderTargetData { Texture = texture, Flags = flags };
            int h = HandleManager.Register(rt);
            var hPtr = (IntPtr)h;
            data.RenderTargets[key] = hPtr;
            return hPtr;
        }
    }

    [UnmanagedCallersOnly]
    public static void ISceneView_SetParent(IntPtr self, IntPtr pParent)
    {
        LogCall(nameof(ISceneView_SetParent), minimal: true, message: $"self=0x{self.ToInt64():X} parent=0x{pParent.ToInt64():X}");
        GetView(self).Parent = pParent;
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_GetParent(IntPtr self)
    {
        var parent = GetView(self).Parent;
        LogCall(nameof(ISceneView_GetParent), minimal: true, message: $"self=0x{self.ToInt64():X} parent=0x{parent.ToInt64():X}");
        return parent;
    }

    [UnmanagedCallersOnly]
    public static int ISceneView_GetPriority(IntPtr self)
    {
        var prio = GetView(self).Priority;
        LogCall(nameof(ISceneView_GetPriority), minimal: true, message: $"self=0x{self.ToInt64():X} prio={prio}");
        return prio;
    }

    [UnmanagedCallersOnly]
    public static void ISceneView_SetPriority(IntPtr self, int nPriority)
    {
        LogCall(nameof(ISceneView_SetPriority), minimal: true, message: $"self=0x{self.ToInt64():X} prio={nPriority}");
        GetView(self).Priority = nPriority;
    }

    [UnmanagedCallersOnly]
    public static IntPtr ISceneView_GetFrustum(IntPtr self)
    {
        LogCall(nameof(ISceneView_GetFrustum), minimal: true, message: $"self=0x{self.ToInt64():X}");
        var data = GetView(self);
        if (data.FrustumPtr == IntPtr.Zero)
    {
            // Provide a stable non-null pointer for callers expecting a struct pointer.
            var frustum = new global::CFrustum { self = IntPtr.Zero };
            var handle = GCHandle.Alloc(frustum, GCHandleType.Pinned);
            data.FrustumPtr = GCHandle.ToIntPtr(handle);
        }
        return data.FrustumPtr;
    }

    [UnmanagedCallersOnly]
    public static int ISceneView_GetPostProcessEnabled(IntPtr self)
    {
        var enabled = GetView(self).PostProcessEnabled ? 1 : 0;
        LogCall(nameof(ISceneView_GetPostProcessEnabled), minimal: true, message: $"self=0x{self.ToInt64():X} enabled={enabled}");
        return enabled;
    }

    [UnmanagedCallersOnly]
    public static int ISceneView_GetToolsVisMode(IntPtr self)
    {
        var mode = GetView(self).ToolsVisMode;
        LogCall(nameof(ISceneView_GetToolsVisMode), minimal: true, message: $"self=0x{self.ToInt64():X} mode={mode}");
        return mode;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
    public static int Get__ISceneView_m_ViewUniqueId(IntPtr self)
    {
        var id = GetView(self).ViewUniqueId;
        LogCall(nameof(Get__ISceneView_m_ViewUniqueId), minimal: true, message: $"self=0x{self.ToInt64():X} id={id}");
        return id;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
    public static void Set__ISceneView_m_ViewUniqueId(IntPtr self, int value)
    {
        LogCall(nameof(Set__ISceneView_m_ViewUniqueId), minimal: true, message: $"self=0x{self.ToInt64():X} id={value}");
        GetView(self).ViewUniqueId = value;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
    public static int Get__ISceneView_m_ManagedCameraId(IntPtr self)
    {
        var id = GetView(self).ManagedCameraId;
        LogCall(nameof(Get__ISceneView_m_ManagedCameraId), minimal: true, message: $"self=0x{self.ToInt64():X} camId={id}");
        return id;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvSuppressGCTransition) })]
    public static void Set__ISceneView_m_ManagedCameraId(IntPtr self, int value)
    {
        LogCall(nameof(Set__ISceneView_m_ManagedCameraId), minimal: true, message: $"self=0x{self.ToInt64():X} camId={value}");
        GetView(self).ManagedCameraId = value;
    }
    }
