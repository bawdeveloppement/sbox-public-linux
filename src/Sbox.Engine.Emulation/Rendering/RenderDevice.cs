using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Silk.NET.OpenGL;
using Sandbox;
using NativeEngine;
using Sbox.Engine.Emulation.Platform;
using Sbox.Engine.Emulation.Texture;

namespace Sbox.Engine.Emulation.Rendering;

/// <summary>
/// Module d'émulation pour RenderDevice (g_pRenderDevice_*).
/// Gère les opérations de rendu de base : textures, shaders, buffers, swap chains, etc.
/// </summary>
public static unsafe class RenderDevice
{
    /// <summary>
    /// Initialise les fonctions natives de RenderDevice.
    /// </summary>
    public static void Init(void** native)
    {
        // Indices depuis Interop.Engine.cs lignes 16217-16257
        native[1470] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRenderDevice_FindOrCreateSamplerState;
        native[1471] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_GetSamplerIndex;
        native[1472] = (void*)(delegate* unmanaged<IntPtr, void*>)&g_pRenderDevice_GetSwapChainInfo;
        native[1473] = (void*)(delegate* unmanaged<IntPtr, long, IntPtr>)&g_pRenderDevice_FindOrCreateFileTexture;
        // native[1474] est g_pRenderDevice_FindOrCreateTexture2 - déjà dans EngineExports.cs
        native[1475] = (void*)(delegate* unmanaged<IntPtr, Color32, void>)&g_pRenderDevice_ClearTexture;
        native[1476] = (void*)(delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, void>)&g_pRenderDevice_AsyncSetTextureData2;
        native[1477] = (void*)(delegate* unmanaged<IntPtr, long, IntPtr>)&g_pRenderDevice_GetSwapChainTexture;
        native[1478] = (void*)(delegate* unmanaged<IntPtr, float*, uint*, int>)&g_pRenderDevice_GetGPUFrameTimeMS;
        native[1479] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRenderDevice_GetTextureDesc;
        native[1480] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRenderDevice_GetOnDiskTextureDesc;
        native[1481] = (void*)(delegate* unmanaged<IntPtr, long>)&g_pRenderDevice_GetTextureMultisampleType;
        native[1482] = (void*)(delegate* unmanaged<uint, IntPtr>)&g_pRenderDevice_CreateRenderContext;
        native[1483] = (void*)(delegate* unmanaged<IntPtr, void>)&g_pRenderDevice_ReleaseRenderContext;
        native[1484] = (void*)(delegate* unmanaged<IntPtr, NativeRect*, int, int, NativeRect*, IntPtr, long, int, int>)&g_pRenderDevice_ReadTexturePixels;
        native[1485] = (void*)(delegate* unmanaged<IntPtr, void>)&g_pRenderDevice_DestroySwapChain;
        native[1486] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_Present;
        native[1487] = (void*)(delegate* unmanaged<void>)&g_pRenderDevice_Flush;
        native[1488] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_CanRenderToSwapChain;
        native[1489] = (void*)(delegate* unmanaged<int>)&g_pRenderDevice_IsUsing32BitDepthBuffer;
        native[1490] = (void*)(delegate* unmanaged<IntPtr, Vector2>)&g_pRenderDevice_GetBackbufferDimensions;
        native[1491] = (void*)(delegate* unmanaged<long, IntPtr, uint, IntPtr, IntPtr, IntPtr>)&g_pRenderDevice_CompileAndCreateShader;
        native[1492] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_GetTextureLastUsed;
        native[1493] = (void*)(delegate* unmanaged<uint, void>)&g_pRenderDevice_UnThrottleTextureStreamingForNFrames;
        native[1494] = (void*)(delegate* unmanaged<int>)&g_pRenderDevice_GetNumTextureLoadsInFlight;
        native[1495] = (void*)(delegate* unmanaged<int, void>)&g_pRenderDevice_SetForcePreloadStreamingData;
        native[1496] = (void*)(delegate* unmanaged<long>)&g_pRenderDevice_GetRenderDeviceAPI;
        native[1497] = (void*)(delegate* unmanaged<IntPtr, int, void>)&g_pRenderDevice_MarkTextureUsed;
        native[1498] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_IsTextureRenderTarget;
        native[1499] = (void*)(delegate* unmanaged<int>)&g_pRenderDevice_IsRayTracingSupported;
        native[1500] = (void*)(delegate* unmanaged<long, IntPtr, long, IntPtr, IntPtr>)&g_pRenderDevice_CreateGPUBuffer;
        native[1501] = (void*)(delegate* unmanaged<IntPtr, void>)&g_pRenderDevice_DestroyGPUBuffer;
        native[1502] = (void*)(delegate* unmanaged<IntPtr, uint, IntPtr, uint, int>)&g_pRenderDevice_ReadBuffer;
        native[1503] = (void*)(delegate* unmanaged<long, IntPtr>)&g_pRenderDevice_GetDeviceSpecificInfo;
        native[1504] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRenderDevice_GetGraphicsAPISpecificTextureHandle;
        native[1505] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRenderDevice_GetDeviceSpecificTexture;
        native[1506] = (void*)(delegate* unmanaged<IntPtr, byte, long, int>)&g_pRenderDevice_GetTextureViewIndex;
        native[1507] = (void*)(delegate* unmanaged<IntPtr, IntPtr, void>)&g_pRenderDevice_GetTextureResidencyInfo;
        native[1508] = (void*)(delegate* unmanaged<IntPtr, Vector4>)&g_pRenderDevice_GetSheetInfo;
        native[1509] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRenderDevice_GetSequenceCount;
        native[1510] = (void*)(delegate* unmanaged<IntPtr, int, IntPtr>)&g_pRenderDevice_GetSequence;
    }
    
    // ========== Sampler State Functions ==========
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_FindOrCreateSamplerState(IntPtr samplerDesc)
    {
        // TODO: cast CSamplerStateDesc samplerDesc
        // TODO: Implémenter la gestion des sampler states
        Console.WriteLine("[NativeAOT] g_pRenderDevice_FindOrCreateSamplerState");
        throw new NotImplementedException( "g_pRenderDevice_FindOrCreateSamplerState not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetSamplerIndex(IntPtr samplerState)
    {
        // TODO: Implémenter
        Console.WriteLine("[NativeAOT] g_pRenderDevice_GetSamplerIndex");
        throw new NotImplementedException( "g_pRenderDevice_GetSamplerIndex not implemented" );
    }
    
    // ========== Swap Chain Functions ==========
    
    [UnmanagedCallersOnly]
    public static void* g_pRenderDevice_GetSwapChainInfo(IntPtr swapChain)
    {
        var glfw = PlatformFunctions.GetGlfw();
        var windowHandle = PlatformFunctions.GetWindowHandle();
        
        if (glfw == null || windowHandle == null)
        {
            return null;
        }
        
        glfw.GetFramebufferSize(windowHandle, out int width, out int height);
        
        // Allouer une structure RenderDeviceInfo_t temporaire
        // Note: Cette allocation pourrait fuir, mais c'est temporaire
        var info = new RenderDeviceInfo_t();
        return Unsafe.AsPointer(ref info);
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetSwapChainTexture(IntPtr swapChain, long bufferType)
    {
        // Pour OpenGL, le swap chain texture est généralement le backbuffer
        // Retourner un handle spécial pour le backbuffer
        Console.WriteLine("[NativeAOT] g_pRenderDevice_GetSwapChainTexture");
        throw new NotImplementedException( "g_pRenderDevice_GetSwapChainTexture not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_DestroySwapChain(IntPtr hSwapChain)
    {
        // Pas de destruction nécessaire pour GLFW
        Console.WriteLine("[NativeAOT] g_pRenderDevice_DestroySwapChain");
        throw new NotImplementedException("g_pRenderDevice_DestroySwapChain not implemented");
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_Present(IntPtr chain)
    {
        var glfw = PlatformFunctions.GetGlfw();
        var windowHandle = PlatformFunctions.GetWindowHandle();
        
        if (glfw == null || windowHandle == null) return 0;
        
        glfw.SwapBuffers(windowHandle);
        return 1;
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_CanRenderToSwapChain(IntPtr chain)
    {
        // Toujours possible avec OpenGL
        throw new NotImplementedException( "g_pRenderDevice_CanRenderToSwapChain not implemented, we could use OpenGL ES or any other RenderAPI" );
    }
    
    [UnmanagedCallersOnly]
    public static Vector2 g_pRenderDevice_GetBackbufferDimensions(IntPtr chain)
    {
        var glfw = PlatformFunctions.GetGlfw();
        var windowHandle = PlatformFunctions.GetWindowHandle();
        
        if (glfw == null || windowHandle == null)
        {
            return new Vector2(1280, 720); // Default
        }
        
        glfw.GetFramebufferSize(windowHandle, out int width, out int height);
        return new Vector2(width, height);
    }
    
    // ========== Texture Functions ==========
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_FindOrCreateFileTexture(IntPtr pFileName, long nLoadMode)
    {
        // TODO: Charger une texture depuis un fichier
        Console.WriteLine("[NativeAOT] g_pRenderDevice_FindOrCreateFileTexture");
        throw new NotImplementedException(
            "g_pRenderDevice_FindOrCreateFileTexture not implemented, we could use OpenGL ES or any other RenderAPI" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_ClearTexture(IntPtr hTexture, Color32 color)
    {
        var gl = PlatformFunctions.GetGL();
        if (gl == null) return;
        
        // Récupérer le handle OpenGL depuis TextureSystem
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null || textureData.OpenGLHandle == 0) return;
        
        gl.BindTexture(GLEnum.Texture2D, textureData.OpenGLHandle);
        
        // Créer un buffer temporaire avec la couleur
        byte[] colorData = new byte[4] { color.r, color.g, color.b, color.a };
        
        fixed (byte* data = colorData)
        {
            gl.TexSubImage2D(GLEnum.Texture2D, 0, 0, 0, 1, 1, GLEnum.Rgba, GLEnum.UnsignedByte, data);
        }
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_AsyncSetTextureData2(IntPtr hTexture, IntPtr pData, int nDataSize, IntPtr rect)
    {
        // TODO: Cast param Rect3D* rect
        var gl = PlatformFunctions.GetGL();
        if (gl == null) return;
        
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null || textureData.OpenGLHandle == 0) return;
        
        gl.BindTexture(GLEnum.Texture2D, textureData.OpenGLHandle);
        
        // TODO: Implémenter la mise à jour asynchrone des données de texture
        throw new NotImplementedException(
            "g_pRenderDevice_AsyncSetTextureData2 not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetTextureDesc(IntPtr hTexture)
    {
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null)
        {
            return IntPtr.Zero;
        }
        
        // Allouer une structure CTextureDesc temporaire
        // Note: Cette allocation pourrait fuir, mais c'est temporaire
        var desc = new CTextureDesc
        {
            m_nWidth = 1,
            m_nHeight = 1,
            m_nDepth = 1,
            m_nNumMipLevels = 1,
            m_nImageFormat = ImageFormat.RGBA8888
        };
        
        // TODO: Stocker les vraies dimensions dans TextureData
        return (IntPtr)Unsafe.AsPointer(ref desc);
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetOnDiskTextureDesc(IntPtr hTexture)
    {
        // Pour l'instant, identique à GetTextureDesc
        // Note: On ne peut pas appeler directement une fonction [UnmanagedCallersOnly]
        // Donc on duplique le code
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null)
        {
            return IntPtr.Zero;
        }
        
        var desc = new CTextureDesc
        {
            m_nWidth = 1,
            m_nHeight = 1,
            m_nDepth = 1,
            m_nNumMipLevels = 1,
            m_nImageFormat = ImageFormat.RGBA8888
        };
        
        return (IntPtr)Unsafe.AsPointer(ref desc);
    }
    
    [UnmanagedCallersOnly]
    public static long g_pRenderDevice_GetTextureMultisampleType(IntPtr hTexture)
    {
        // OpenGL n'utilise généralement pas de multisampling pour les textures 2D simples
        // return (long)RenderMultisampleType.RENDER_MULTISAMPLE_NONE;

        throw new NotImplementedException(
            "g_pRenderDevice_GetTextureMultisampleType not implemented because we want multi-api conditions" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetTextureLastUsed(IntPtr hTexture)
    {
        // Retourner un frame number fictif
        throw new NotImplementedException(
            "g_pRenderDevice_GetTextureLastUsed not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_MarkTextureUsed(IntPtr hTexture, int requiredMipSize)
    {
        // No-op pour l'instant
        Console.WriteLine($"[NativeAOT] g_pRenderDevice_MarkTextureUsed: requiredMipSize={requiredMipSize}");
        throw new NotImplementedException(
            "g_pRenderDevice_MarkTextureUsed not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_IsTextureRenderTarget(IntPtr hTexture)
    {
        // Pour l'instant, aucune texture n'est un render target
        throw new NotImplementedException(
            "g_pRenderDevice_IsTextureRenderTarget not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetTextureViewIndex(IntPtr hTexture, byte nViewType, long nDimension)
    {
        // Retourner un index de vue fictif
        throw new NotImplementedException(
            "g_pRenderDevice_GetTextureViewIndex not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_GetTextureResidencyInfo(IntPtr hTexture, IntPtr pResidencyInfo)
    {
        // No-op pour l'instant
        Console.WriteLine("[NativeAOT] g_pRenderDevice_GetTextureResidencyInfo");
        throw new NotImplementedException(
            "g_pRenderDevice_GetTextureResidencyInfo not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static Vector4 g_pRenderDevice_GetSheetInfo(IntPtr texture)
    {
        // Retourner des valeurs par défaut pour les sprite sheets
        // Vector4 contient les informations de sheet (uv offset, scale, etc.)
        // return new Vector4(0, 0, 1, 1); // Pas de sheet par défaut

        throw new NotImplementedException(
            "g_pRenderDevice_GetSheetInfo not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetSequenceCount(IntPtr texture)
    {
        // Retourner 0 car la plupart des textures n'ont pas de séquences d'animation
        // Les textures animées (sprite sheets) auront un nombre > 0
        throw new NotImplementedException(
            "g_pRenderDevice_GetSequenceCount not implemented, you should handle this case if the texture is animated texture" );
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetSequence(IntPtr texture, int index)
    {
        // Retourner une structure SheetSequence_t par défaut
        var seq = new SheetSequence_t
        {
            m_flTotalTime = 0.0f,
            m_bClamp = true
        };
        
        return (IntPtr)Unsafe.AsPointer(ref seq);
    }
    
    // ========== Render Context Functions ==========
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_CreateRenderContext(uint flags)
    {
        // Utiliser EmulatedRenderContext existant
        Console.WriteLine($"[NativeAOT] g_pRenderDevice_CreateRenderContext: flags={flags}");
        throw new NotImplementedException(
            "g_pRenderDevice_CreateRenderContext not implemented" );
        
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_ReleaseRenderContext(IntPtr context)
    {
        // No-op pour l'instant
        Console.WriteLine("[NativeAOT] g_pRenderDevice_ReleaseRenderContext");
        throw new NotImplementedException(
            "g_pRenderDevice_ReleaseRenderContext not implemented" );
    }
    
    // ========== Shader Functions ==========
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_CompileAndCreateShader(long nType, IntPtr pProgram, uint nBufLen, IntPtr pShaderVersion, IntPtr pDebugName)
    {
        // TODO: Compiler et créer un shader OpenGL
        Console.WriteLine("[NativeAOT] g_pRenderDevice_CompileAndCreateShader");
        throw new NotImplementedException(
            "g_pRenderDevice_CompileAndCreateShader not implemented" );
    }
    
    // ========== GPU Buffer Functions ==========
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_CreateGPUBuffer(long nType, IntPtr pDesc, long nInitialDataSize, IntPtr pInitialData)
    {
        // TODO: Créer un buffer GPU OpenGL
        Console.WriteLine("[NativeAOT] g_pRenderDevice_CreateGPUBuffer");
        throw new NotImplementedException(
            "g_pRenderDevice_CreateGPUBuffer not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_DestroyGPUBuffer(IntPtr hBuffer)
    {
        // TODO: Détruire le buffer GPU
        Console.WriteLine("[NativeAOT] g_pRenderDevice_DestroyGPUBuffer");
        throw new NotImplementedException(
            "g_pRenderDevice_DestroyGPUBuffer not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_ReadBuffer(IntPtr hBuffer, uint nOffset, IntPtr pData, uint nDataSize)
    {
        // TODO: Lire les données du buffer GPU
        Console.WriteLine("[NativeAOT] g_pRenderDevice_ReadBuffer");
        throw new NotImplementedException(
            "g_pRenderDevice_ReadBuffer not implemented" );
    }
    
    // ========== Utility Functions ==========
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetGPUFrameTimeMS(IntPtr swapChain, float* pGpuFrameTimeMsOut, uint* pFrameNumberOut)
    {
        // Retourner des valeurs fictives
        if (pGpuFrameTimeMsOut != null)
            *pGpuFrameTimeMsOut = 16.67f; // ~60 FPS
        if (pFrameNumberOut != null)
            *pFrameNumberOut = 0;
        throw new NotImplementedException(
            "g_pRenderDevice_IsUsing32BitDepthBuffer not implemented, depend of the device. 3.0 era, support every device / every arch" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_Flush()
    {
        var gl = PlatformFunctions.GetGL();
        gl?.Flush();
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_IsUsing32BitDepthBuffer()
    {
        // OpenGL utilise généralement 24 bits pour le depth buffer
        throw new NotImplementedException(
            "g_pRenderDevice_IsUsing32BitDepthBuffer not implemented, depend of the device. 3.0 era, support every device / every arch" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_UnThrottleTextureStreamingForNFrames(uint nNumberOfFramesForUnthrottledTextureLoading)
    {
        // No-op pour l'instant
        Console.WriteLine($"[NativeAOT] g_pRenderDevice_UnThrottleTextureStreamingForNFrames: {nNumberOfFramesForUnthrottledTextureLoading}");
        throw new NotImplementedException(
            "g_pRenderDevice_UnThrottleTextureStreamingForNFrames not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_GetNumTextureLoadsInFlight()
    {
        throw new NotImplementedException(
            "g_pRenderDevice_GetNumTextureLoadsInFlight not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static void g_pRenderDevice_SetForcePreloadStreamingData(int bForcePreload)
    {
        // No-op pour l'instant
        Console.WriteLine($"[NativeAOT] g_pRenderDevice_SetForcePreloadStreamingData: {bForcePreload}");
        throw new NotImplementedException(
            "g_pRenderDevice_SetForcePreloadStreamingData not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static long g_pRenderDevice_GetRenderDeviceAPI()
    {
        // Retourner OpenGL comme API
        // Valeur depuis NativeEngine.RenderDeviceAPI (généralement 0 pour OpenGL)
        throw new NotImplementedException(
            "g_pRenderDevice_GetRenderDeviceAPI not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_IsRayTracingSupported()
    {
        // OpenGL ne supporte pas le ray tracing natif
        throw new NotImplementedException(
            "g_pRenderDevice_IsRayTracingSupported not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetDeviceSpecificInfo(long nInfoType)
    {
        // Retourner null pour l'instant
        throw new NotImplementedException(
            "g_pRenderDevice_GetDeviceSpecificInfo not implemented" );
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetGraphicsAPISpecificTextureHandle(IntPtr hTexture)
    {
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null)
            return IntPtr.Zero;
        
        // Retourner un pointeur vers le handle OpenGL
        // Note: On ne peut pas prendre l'adresse d'une propriété, donc on utilise une variable locale
        uint handle = textureData.OpenGLHandle;
        return (IntPtr)(&handle);
    }
    
    [UnmanagedCallersOnly]
    public static IntPtr g_pRenderDevice_GetDeviceSpecificTexture(IntPtr hTexture)
    {
        // Identique à GetGraphicsAPISpecificTextureHandle pour OpenGL
        // Note: On ne peut pas appeler directement une fonction [UnmanagedCallersOnly]
        // Donc on duplique le code
        var textureData = TextureSystem.GetTextureData(hTexture);
        if (textureData == null)
            return IntPtr.Zero;
        
        // Retourner un pointeur vers le handle OpenGL
        // Note: On ne peut pas prendre l'adresse d'une propriété, donc on utilise une variable locale
        uint handle = textureData.OpenGLHandle;
        return (IntPtr)(&handle);
    }
    
    [UnmanagedCallersOnly]
    public static int g_pRenderDevice_ReadTexturePixels(IntPtr hTexture, NativeRect* pSrcRect, int nSrcSlice, int nSrcMip, NativeRect
        * pDstRect, IntPtr pData, long dstFormat, int nDstStride)
    {
        // TODO: Lire les pixels de la texture
        Console.WriteLine("[NativeAOT] g_pRenderDevice_ReadTexturePixels");
        throw new NotImplementedException(
            "g_pRenderDevice_ReadTexturePixels not implemented" );
    }
}

