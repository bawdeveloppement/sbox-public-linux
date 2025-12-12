using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Threading;
using Bawstudios.OS27.Common;

namespace Bawstudios.OS27.Audio;

/// <summary>
/// Emulation module for DspPreset (DspPreset_*).
/// Handles DSP (Digital Signal Processing) presets for audio effects.
/// Exact signatures from Interop.Engine.cs line 6134-6138 and indices from line 16065-16069.
/// </summary>
public static unsafe class DspPreset
{
    // État pour gérer les presets et leurs instances via HandleManager
    private static readonly Dictionary<int, HashSet<int>> _presetInstances = new();
    private static readonly object _lock = new();
    private static int _nameCounter = 1;

    private class DspPresetData
    {
        public string Name { get; set; } = "";
        public bool IsFinished { get; set; }
        public List<DspProcessorData> Processors { get; } = new();
    }

    private class DspProcessorData
    {
        public int Type { get; set; }
        public float[] Parameters { get; set; } = Array.Empty<float>();
    }

    private class DspInstanceData
    {
        public IntPtr PresetHandle { get; set; }
        public int Channels { get; set; }
        public bool Active { get; set; }
    }

    /// <summary>
    /// Initializes the DspPreset module by patching all native functions.
    /// Exact signatures from Interop.Engine.cs line 6134-6138.
    /// Indices from Interop.Engine.cs line 16065-16069.
    /// </summary>
    public static void Init(void** native)
    {
        // DspPreset functions (indices 1318-1322 depuis Interop.Engine.cs ligne 16065-16069)
        native[1318] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&DspPreset_Create;
        native[1319] = (void*)(delegate* unmanaged<IntPtr, void>)&DspPreset_Dispose;
        native[1320] = (void*)(delegate* unmanaged<IntPtr, int, float*, uint, void>)&DspPreset_AddProcessor;
        native[1321] = (void*)(delegate* unmanaged<IntPtr, void>)&DspPreset_FinishBuilding;
        native[1322] = (void*)(delegate* unmanaged<IntPtr, int, IntPtr>)&DspPreset_Instantiate;
    }

    // ============================================================================
    // DspPreset Functions (DspPreset_*)
    // Exact signatures from Interop.Engine.cs line 6134-6138
    // ============================================================================

    /// <summary>
    /// Creates a new DSP preset.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr DspPreset_Create(IntPtr namePtr)
    {
        string? name = Marshal.PtrToStringUTF8(namePtr);
        if (string.IsNullOrEmpty(name))
            name = $"dsp_preset_{Interlocked.Increment(ref _nameCounter)}";

        var preset = new DspPresetData { Name = name };

        int handle = HandleManager.Register(preset);
        if (handle == 0)
        {
            Console.WriteLine("[NativeAOT] DspPreset_Create: failed to register handle");
            return IntPtr.Zero;
        }

        lock (_lock)
        {
            _presetInstances[handle] = new HashSet<int>();
        }

        Console.WriteLine($"[NativeAOT] DspPreset_Create: {name} -> handle={handle}");
        return (IntPtr)handle;
    }

    /// <summary>
    /// Releases a DSP preset.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void DspPreset_Dispose(IntPtr self)
    {
        int handle = (int)self;

        // Clean up associated instances
        lock (_lock)
        {
            if (_presetInstances.TryGetValue(handle, out var instances))
            {
                foreach (var inst in instances)
                {
                    HandleManager.Unregister(inst);
                }
                _presetInstances.Remove(handle);
            }
        }

        HandleManager.Unregister(handle);
        Console.WriteLine($"[NativeAOT] DspPreset_Dispose: handle={self}");
    }

    /// <summary>
    /// Adds a DSP processor to the preset.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, int, float*, uint, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void DspPreset_AddProcessor(IntPtr self, int nType, float* prms, uint prmsCount)
    {
        int handle = (int)self;
        var preset = HandleManager.Get<DspPresetData>(handle);
        if (preset == null)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_AddProcessor: Invalid preset handle={self}");
            return;
        }

        if (preset.IsFinished)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_AddProcessor: Preset {preset.Name} is already finished");
            return;
        }

        // Validate pointers and sizes
        if (prms == null || prmsCount == 0)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_AddProcessor: {preset.Name} type={nType} with no parameters");
            preset.Processors.Add(new DspProcessorData { Type = nType, Parameters = Array.Empty<float>() });
            return;
        }

        float[] parameters = new float[prmsCount];
        for (uint i = 0; i < prmsCount; i++)
        {
            parameters[i] = prms[i];
        }

        preset.Processors.Add(new DspProcessorData
        {
            Type = nType,
            Parameters = parameters
        });

        Console.WriteLine($"[NativeAOT] DspPreset_AddProcessor: {preset.Name} type={nType} params={prmsCount}");
    }

    /// <summary>
    /// Finalise la construction du preset DSP (ne peut plus être modifié).
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void DspPreset_FinishBuilding(IntPtr self)
    {
        int handle = (int)self;
        var preset = HandleManager.Get<DspPresetData>(handle);
        if (preset == null)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_FinishBuilding: Invalid preset handle={self}");
            return;
        }

        preset.IsFinished = true;
        Console.WriteLine($"[NativeAOT] DspPreset_FinishBuilding: {preset.Name} finished with {preset.Processors.Count} processors");
    }

    /// <summary>
    /// Instantiates a DSP preset for a given number of channels.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, int, IntPtr &gt;
    /// Returns a handle to a DSP instance (for use with OpenAL).
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr DspPreset_Instantiate(IntPtr self, int channels)
    {
        int handle = (int)self;
        var preset = HandleManager.Get<DspPresetData>(handle);
        if (preset == null)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_Instantiate: Invalid preset handle={self}");
            return IntPtr.Zero;
        }

        if (!preset.IsFinished)
        {
            // Auto-finish si oublié côté appelant pour rester tolérant.
            preset.IsFinished = true;
        }

        // Create an active instance for the requested preset
        var instance = new DspInstanceData
        {
            PresetHandle = self,
            Channels = Math.Max(1, channels),
            Active = true
        };

        int instHandle = HandleManager.Register(instance);
        if (instHandle == 0)
        {
            Console.WriteLine($"[NativeAOT] DspPreset_Instantiate: failed to register instance for {preset.Name}");
            return IntPtr.Zero;
        }

        lock (_lock)
        {
            if (!_presetInstances.TryGetValue(handle, out var set))
            {
                set = new HashSet<int>();
                _presetInstances[handle] = set;
            }
            set.Add(instHandle);
        }

        Console.WriteLine($"[NativeAOT] DspPreset_Instantiate: {preset.Name} -> inst={instHandle} channels={channels}");
        return (IntPtr)instHandle;
    }
}

