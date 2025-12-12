using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bawstudios.OS27.Common;

namespace Bawstudios.OS27.Texture;

/// <summary>
/// Emulation module for CTextureBase functions (CTextureBase_*).
/// Handles textures loaded from resources.
/// </summary>
public static unsafe class TextureSystem
{
    /// <summary>
    /// Internal data for an emulated texture.
    /// Pattern identical to MaterialData in MaterialSystem.cs and ModelData in ModelSystem.cs
    /// </summary>
    public class TextureData
    {
        public string Name { get; set; } = "";
        public IntPtr BindingPtr { get; set; } = IntPtr.Zero; // Unique binding pointer (HandleManager handle)
        public bool IsError { get; set; } = false;
        public bool IsLoaded { get; set; } = true; // By default, considered loaded
        public uint OpenGLHandle { get; set; } = 0; // OpenGL handle of the texture
    }
    
    /// <summary>
    /// Gets texture data for a given handle (for use by RenderDevice and other modules).
    /// </summary>
    public static TextureData? GetTextureData(IntPtr textureHandle)
    {
        return HandleManager.Get<TextureData>((int)textureHandle);
    }
    
    /// <summary>
    /// Initializes the TextureSystem module by patching native functions.
    /// Indices depuis Interop.Engine.cs lignes 15954-15959 (1207-1212)
    /// </summary>
    public static void Init(void** native)
    {
        // Essential CTextureBase functions (indices 1207-1212 from Interop.Engine.cs)
        native[1207] = (void*)(delegate* unmanaged<IntPtr, void>)&CTextureBase_DestroyStrongHandle;
        native[1208] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsStrongHandleValid;
        native[1209] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsError;
        native[1210] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsStrongHandleLoaded;
        native[1211] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CTextureBase_CopyStrongHandle;
        native[1212] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CTextureBase_GetBindingPtr;
        
        Console.WriteLine("[NativeAOT] TextureSystem module initialized");
    }
    
    /// <summary>
    /// Helper to create a texture with an OpenGL handle (callable from managed code).
    /// Used by EngineExports.FindOrCreateTexture2.
    /// </summary>
    public static IntPtr CreateTextureWithOpenGLHandle(string resourceName, uint openGLHandle)
    {
        if (openGLHandle == 0) return IntPtr.Zero;
        
        // Chercher une texture existante avec ce handle OpenGL (O(1) via index)
        var existingTexture = HandleManager.FindByOpenGLHandle<TextureData>(openGLHandle);
        if (existingTexture != null && existingTexture.BindingPtr != IntPtr.Zero)
        {
            // Trouver un handle existant pour cette texture via le BindingHandle
            int existingBindingHandle = (int)existingTexture.BindingPtr;
            int existingHandle = HandleManager.GetHandleByBindingHandle(existingBindingHandle);
            if (existingHandle != 0)
            {
                // Obtenir tous les handles pour cette texture et retourner le premier
                var allHandles = HandleManager.GetAllHandles(existingHandle);
                if (allHandles.Length > 0)
                {
                    Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureWithOpenGLHandle: found existing texture with OpenGL handle {openGLHandle}");
                    return (IntPtr)allHandles[0];
                }
            }
        }
        
        // Create a new texture
        var textureData = new TextureData
        {
            Name = resourceName ?? "",
            OpenGLHandle = openGLHandle
        };
        
        // Enregistrer dans HandleManager pour obtenir un handle unique
        int handle = HandleManager.Register(textureData);
        if (handle == 0) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle(handle);
        textureData.BindingPtr = (IntPtr)bindingHandle;
        
        // Enregistrer dans l'index OpenGLHandle pour recherche O(1)
        HandleManager.RegisterOpenGLHandleIndex(openGLHandle, bindingHandle);
        
        // Enregistrer dans l'index Name si le nom est fourni
        if (!string.IsNullOrEmpty(resourceName))
        {
            HandleManager.RegisterNameIndex(resourceName, bindingHandle);
        }
        
        Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureWithOpenGLHandle: created texture {resourceName}, handle={handle}, OpenGL={openGLHandle}");
        return (IntPtr)handle;
    }
    
    /// <summary>
    /// Helper to create a texture from a resource (callable from managed code).
    /// Used by EngineGlue.Glue_Resources_GetTexture.
    /// </summary>
    public static IntPtr CreateTextureFromResourceHelper(string resourceName)
    {
        if (string.IsNullOrEmpty(resourceName)) return IntPtr.Zero;
        
        // Chercher une texture existante avec ce nom (O(1) via index)
        var existingTexture = HandleManager.FindByName<TextureData>(resourceName);
        if (existingTexture != null && existingTexture.BindingPtr != IntPtr.Zero)
        {
            // Trouver un handle existant pour cette texture via le BindingHandle
            int existingBindingHandle = (int)existingTexture.BindingPtr;
            int existingHandle = HandleManager.GetHandleByBindingHandle(existingBindingHandle);
            if (existingHandle != 0)
            {
                // Obtenir tous les handles pour cette texture et retourner le premier
                var allHandles = HandleManager.GetAllHandles(existingHandle);
                if (allHandles.Length > 0)
                {
                    Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureFromResourceHelper: found existing {resourceName}");
                    return (IntPtr)allHandles[0];
                }
            }
        }
        
        // Create a new texture
        var textureData = new TextureData
        {
            Name = resourceName
        };
        
        // Enregistrer dans HandleManager pour obtenir un handle unique
        int handle = HandleManager.Register(textureData);
        if (handle == 0) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle(handle);
        textureData.BindingPtr = (IntPtr)bindingHandle;
        
        // Enregistrer dans l'index Name pour recherche O(1)
        HandleManager.RegisterNameIndex(resourceName, bindingHandle);
        
        Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureFromResourceHelper: created new {resourceName}, handle={handle}");
        return (IntPtr)handle;
    }
    
    /// <summary>
    /// Releases a strong texture handle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CTextureBase_DestroyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return;
        
        var textureData = HandleManager.Get<TextureData>((int)self);
        if (textureData != null)
        {
            // Nettoyer les index secondaires avant Unregister
            if (textureData.OpenGLHandle != 0)
            {
                HandleManager.UnindexOpenGLHandle(textureData.OpenGLHandle);
            }
            if (!string.IsNullOrEmpty(textureData.Name))
            {
                HandleManager.UnindexName(textureData.Name);
            }
        }
        
        HandleManager.Unregister((int)self);
        Console.WriteLine($"[NativeAOT] CTextureBase_DestroyStrongHandle: {self}");
    }
    
    /// <summary>
    /// Checks if a strong texture handle is valid.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsStrongHandleValid(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        return HandleManager.Exists((int)self) ? 1 : 0;
    }
    
    /// <summary>
    /// Checks if a texture is in error.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsError(IntPtr self)
    {
        if (self == IntPtr.Zero) return 1; // Null = erreur
        
        var textureData = HandleManager.Get<TextureData>((int)self);
        if (textureData != null)
        {
            return textureData.IsError ? 1 : 0;
        }
        
        return 1; // Handle invalide = erreur
    }
    
    /// <summary>
    /// Checks if a texture is loaded.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsStrongHandleLoaded(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        var textureData = HandleManager.Get<TextureData>((int)self);
        if (textureData != null)
        {
            return textureData.IsLoaded ? 1 : 0;
        }
        
        return 0;
    }
    
    /// <summary>
    /// Creates a copy of a strong texture handle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CTextureBase_CopyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        int newHandle = HandleManager.CopyHandle((int)self);
        if (newHandle != 0)
        {
            Console.WriteLine($"[NativeAOT] CTextureBase_CopyStrongHandle: {self} -> {newHandle} (refs={HandleManager.GetReferenceCount((int)self)})");
            return (IntPtr)newHandle;
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient le pointeur de binding d'une texture.
    /// Le binding pointer est un identifiant unique qui identifie la texture native,
    /// used to compare if two handles point to the same texture.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CTextureBase_GetBindingPtr(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        int bindingHandle = HandleManager.GetBindingHandle((int)self);
        return bindingHandle != 0 ? (IntPtr)bindingHandle : IntPtr.Zero;
    }
}

