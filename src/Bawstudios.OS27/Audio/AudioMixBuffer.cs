using System.Runtime.InteropServices;
using System;
using Bawstudios.OS27.Common;

namespace Bawstudios.OS27.Audio;

/// <summary>
/// Emulation module for AudioMixBuffer (CAudioMixBuffer_*).
/// Handles audio mixing buffers (512 float samples).
/// Exact signatures from Interop.Engine.cs line 194-203 and indices from line 14766-14775.
/// </summary>
public static unsafe class AudioMixBuffer
{
    /// <summary>
    /// Initializes the AudioMixBuffer module by patching all native functions.
    /// Exact signatures from Interop.Engine.cs line 194-203.
    /// Indices from Interop.Engine.cs line 14766-14775.
    /// </summary>
    public static void Init(void** native)
    {
        // AudioMixBuffer functions (indices 19-28 depuis Interop.Engine.cs ligne 14766-14775)
        native[19] = (void*)(delegate* unmanaged<IntPtr>)&CAudioMixBuffer_Create;
        native[20] = (void*)(delegate* unmanaged<IntPtr, void>)&CAudioMixBuffer_Dispose;
        native[21] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CAudioMixBuffer_GetDataPointer;
        native[22] = (void*)(delegate* unmanaged<IntPtr, void>)&CAudioMixBuffer_Silence;
        native[23] = (void*)(delegate* unmanaged<IntPtr, float>)&CAudioMixBuffer_AbsLevel;
        native[24] = (void*)(delegate* unmanaged<IntPtr, float>)&CAudioMixBuffer_AvergeLevel;
        native[25] = (void*)(delegate* unmanaged<IntPtr, float, float, void>)&CAudioMixBuffer_Ramp;
        native[26] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&CAudioMixBuffer_CopyFrom;
        native[27] = (void*)(delegate* unmanaged<IntPtr, IntPtr, float, void>)&CAudioMixBuffer_Mix;
        native[28] = (void*)(delegate* unmanaged<IntPtr, IntPtr, float, float, void>)&CAudioMixBuffer_MixRamp;
    }

    // ============================================================================
    // AudioMixBuffer Functions (CAudioMixBuffer_*)
    // Exact signatures from Interop.Engine.cs line 194-203
    // ============================================================================

    /// <summary>
    /// Crée un nouveau buffer de mixage audio.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr &gt;
    /// Retourne un handle vers un AudioMixBuffer (512 échantillons float).
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CAudioMixBuffer_Create()
    {
        var buf = new AudioMixBufferData();
        int handle = HandleManager.Register(buf);
        Console.WriteLine($"[NativeAOT] CAudioMixBuffer_Create: handle={handle}");
        return (IntPtr)handle;
    }

    /// <summary>
    /// Releases an audio mixing buffer.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_Dispose(IntPtr bufferPtr)
    {
        int handle = (int)bufferPtr;
        HandleManager.Unregister(handle);
        Console.WriteLine($"[NativeAOT] CAudioMixBuffer_Dispose: handle={handle}");
    }

    /// <summary>
    /// Retourne un pointeur vers les données du buffer.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CAudioMixBuffer_GetDataPointer(IntPtr bufferPtr)
    {
        int handle = (int)bufferPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(handle);
        if (buffer == null) return IntPtr.Zero;
        
        fixed (float* ptr = buffer.Data)
        {
            return (IntPtr)ptr;
        }
    }

    /// <summary>
    /// Sets all buffer samples to zero.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_Silence(IntPtr bufferPtr)
    {
        int handle = (int)bufferPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(handle);
        buffer?.Silence();
    }

    /// <summary>
    /// Calcule le niveau absolu du buffer (somme des valeurs absolues).
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, float &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static float CAudioMixBuffer_AbsLevel(IntPtr bufferPtr)
    {
        int handle = (int)bufferPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(handle);
        return buffer?.AbsLevel() ?? 0f;
    }

    /// <summary>
    /// Calculates the average level of the buffer (average of absolute values).
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, float &gt;
    /// Note: In Interop.Engine.cs line 199, the function is called "AvergeLevel" (typo in Source 2).
    /// </summary>
    [UnmanagedCallersOnly]
    public static float CAudioMixBuffer_AvergeLevel(IntPtr bufferPtr)
    {
        int handle = (int)bufferPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(handle);
        return buffer?.AverageLevel() ?? 0f;
    }

    /// <summary>
    /// Applique un rampe linéaire au buffer (multiplication par un facteur qui varie de a à b).
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, float, float, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_Ramp(IntPtr bufferPtr, float a, float b)
    {
        int handle = (int)bufferPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(handle);
        buffer?.Ramp(a, b);
    }

    /// <summary>
    /// Copies data from another buffer into this buffer.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_CopyFrom(IntPtr bufferPtr, IntPtr otherPtr)
    {
        int h = (int)bufferPtr;
        int o = (int)otherPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(h);
        var other = HandleManager.Get<AudioMixBufferData>(o);
        if (buffer != null && other != null) buffer.CopyFrom(other);
    }

    /// <summary>
    /// Mélange les données d'un autre buffer dans ce buffer avec un facteur d'échelle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr, float, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_Mix(IntPtr bufferPtr, IntPtr otherPtr, float factor)
    {
        int h = (int)bufferPtr;
        int o = (int)otherPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(h);
        var other = HandleManager.Get<AudioMixBufferData>(o);
        if (buffer != null && other != null) buffer.Mix(other, factor);
    }

    /// <summary>
    /// Mixes data from another buffer into this buffer with a scale ramp.
    /// Exact signature from Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr, float, float, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CAudioMixBuffer_MixRamp(IntPtr bufferPtr, IntPtr otherPtr, float a, float b)
    {
        int h = (int)bufferPtr;
        int o = (int)otherPtr;
        var buffer = HandleManager.Get<AudioMixBufferData>(h);
        var other = HandleManager.Get<AudioMixBufferData>(o);
        if (buffer != null && other != null) buffer.MixRamp(other, a, b);
    }

    /// <summary>
    /// Data for an audio mixing buffer (512 float samples).
    /// </summary>
    internal class AudioMixBufferData
    {
        public const int BufferSize = 512; // MIX_BUFFER_SIZE
        public float[] Data = new float[BufferSize];

        public void Silence()
        {
            Array.Clear(Data, 0, Data.Length);
        }

        public float AbsLevel()
        {
            float sum = 0f;
            for (int i = 0; i < Data.Length; i++) sum += Math.Abs(Data[i]);
            return sum;
        }

        public float AverageLevel()
        {
            if (Data.Length == 0) return 0f;
            float sum = 0f;
            for (int i = 0; i < Data.Length; i++) sum += Math.Abs(Data[i]);
            return sum / Data.Length;
        }

        public void Ramp(float a, float b)
        {
            int n = Data.Length;
            for (int i = 0; i < n; i++)
            {
                float t = n > 1 ? (float)i / (n - 1) : 0f;
                float factor = a + (b - a) * t;
                Data[i] *= factor;
            }
        }

        public void CopyFrom(AudioMixBufferData other)
        {
            int len = Math.Min(Data.Length, other.Data.Length);
            Array.Copy(other.Data, Data, len);
        }

        public void Mix(AudioMixBufferData other, float factor)
        {
            int len = Math.Min(Data.Length, other.Data.Length);
            for (int i = 0; i < len; i++) Data[i] += other.Data[i] * factor;
        }

        public void MixRamp(AudioMixBufferData other, float a, float b)
        {
            int len = Math.Min(Data.Length, other.Data.Length);
            for (int i = 0; i < len; i++)
            {
                float t = len > 1 ? (float)i / (len - 1) : 0f;
                float factor = a + (b - a) * t;
                Data[i] += other.Data[i] * factor;
            }
        }
    }
}

