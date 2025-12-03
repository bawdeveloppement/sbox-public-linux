using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sbox.Engine.Emulation.Common;

namespace Sbox.Engine.Emulation.Texture;

/// <summary>
/// Module d'émulation pour les fonctions CTextureBase (CTextureBase_*).
/// Gère les textures chargées depuis les ressources.
/// </summary>
public static unsafe class TextureSystem
{
    private static int _nextTextureId = 1000000;
    
    /// <summary>
    /// Données internes pour une texture émulée.
    /// Pattern identique à MaterialData dans MaterialSystem.cs et ModelData dans ModelSystem.cs
    /// </summary>
    public class TextureData
    {
        public string Name { get; set; } = "";
        public int ReferenceCount { get; set; } = 1; // Compteur de références pour les handles forts
        public IntPtr BindingPtr { get; set; } = IntPtr.Zero; // Pointeur de binding unique (handle HandleManager)
        public bool IsError { get; set; } = false;
        public bool IsLoaded { get; set; } = true; // Par défaut, considéré comme chargé
        public uint OpenGLHandle { get; set; } = 0; // Handle OpenGL de la texture
    }
    
    // Dictionnaire pour mapper les handles vers les TextureData (pattern identique à MaterialSystem)
    internal static readonly Dictionary<IntPtr, TextureData> _textureHandles = new();
    
    /// <summary>
    /// Obtient les données de texture pour un handle donné (pour utilisation par RenderDevice et autres modules).
    /// </summary>
    public static TextureData? GetTextureData(IntPtr textureHandle)
    {
        lock (_textureHandles)
        {
            return _textureHandles.TryGetValue(textureHandle, out var data) ? data : null;
        }
    }
    
    /// <summary>
    /// Initialise le module TextureSystem en patchant les fonctions natives.
    /// Indices depuis Interop.Engine.cs lignes 15954-15959 (1207-1212)
    /// </summary>
    public static void Init(void** native)
    {
        // CTextureBase functions essentielles (indices 1207-1212 depuis Interop.Engine.cs)
        native[1207] = (void*)(delegate* unmanaged<IntPtr, void>)&CTextureBase_DestroyStrongHandle;
        native[1208] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsStrongHandleValid;
        native[1209] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsError;
        native[1210] = (void*)(delegate* unmanaged<IntPtr, int>)&CTextureBase_IsStrongHandleLoaded;
        native[1211] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CTextureBase_CopyStrongHandle;
        native[1212] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CTextureBase_GetBindingPtr;
        
        Console.WriteLine("[NativeAOT] TextureSystem module initialized");
    }
    
    /// <summary>
    /// Helper pour créer une texture avec un handle OpenGL (appelable depuis le code managé).
    /// Utilisé par EngineExports.FindOrCreateTexture2.
    /// </summary>
    public static IntPtr CreateTextureWithOpenGLHandle(string resourceName, uint openGLHandle)
    {
        if (openGLHandle == 0) return IntPtr.Zero;
        
        // Chercher une texture existante avec ce handle OpenGL
        lock (_textureHandles)
        {
            foreach (var kvp in _textureHandles)
            {
                if (kvp.Value.OpenGLHandle == openGLHandle)
                {
                    Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureWithOpenGLHandle: found existing texture with OpenGL handle {openGLHandle}");
                    return kvp.Key;
                }
            }
        }
        
        // Créer une nouvelle texture
        var textureData = new TextureData
        {
            Name = resourceName ?? "",
            ReferenceCount = 1,
            OpenGLHandle = openGLHandle
        };
        
        // Enregistrer dans HandleManager pour obtenir un BindingPtr unique
        int bindingHandle = HandleManager.Register(textureData);
        textureData.BindingPtr = (IntPtr)bindingHandle;
        
        IntPtr textureHandle = (IntPtr)_nextTextureId++;
        lock (_textureHandles)
        {
            _textureHandles[textureHandle] = textureData;
        }
        
        Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureWithOpenGLHandle: created texture {resourceName}, handle={textureHandle}, OpenGL={openGLHandle}");
        return textureHandle;
    }
    
    /// <summary>
    /// Helper pour créer une texture depuis une ressource (appelable depuis le code managé).
    /// Utilisé par EngineGlue.Glue_Resources_GetTexture.
    /// </summary>
    public static IntPtr CreateTextureFromResourceHelper(string resourceName)
    {
        if (string.IsNullOrEmpty(resourceName)) return IntPtr.Zero;
        
        // Chercher une texture existante avec ce nom
        lock (_textureHandles)
        {
            foreach (var kvp in _textureHandles)
            {
                if (kvp.Value.Name.Equals(resourceName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureFromResourceHelper: found existing {resourceName}");
                    return kvp.Key;
                }
            }
        }
        
        // Créer une nouvelle texture
        var textureData = new TextureData
        {
            Name = resourceName,
            ReferenceCount = 1
        };
        
        // Enregistrer dans HandleManager pour obtenir un BindingPtr unique
        int bindingHandle = HandleManager.Register(textureData);
        textureData.BindingPtr = (IntPtr)bindingHandle;
        
        IntPtr textureHandle = (IntPtr)_nextTextureId++;
        lock (_textureHandles)
        {
            _textureHandles[textureHandle] = textureData;
        }
        
        Console.WriteLine($"[NativeAOT] TextureSystem.CreateTextureFromResourceHelper: created new {resourceName}, handle={textureHandle}");
        return textureHandle;
    }
    
    /// <summary>
    /// Libère un handle fort de texture.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CTextureBase_DestroyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return;
        
        lock (_textureHandles)
        {
            if (_textureHandles.TryGetValue(self, out var textureData))
            {
                // Décrémenter le compteur de références
                textureData.ReferenceCount--;
                
                // Si plus de références, libérer la texture
                if (textureData.ReferenceCount <= 0)
                {
                    // Libérer le BindingPtr depuis HandleManager
                    if (textureData.BindingPtr != IntPtr.Zero)
                    {
                        HandleManager.Unregister((int)textureData.BindingPtr);
                    }
                    
                    _textureHandles.Remove(self);
                    Console.WriteLine($"[NativeAOT] CTextureBase_DestroyStrongHandle: {self} (freed)");
                }
                else
                {
                    Console.WriteLine($"[NativeAOT] CTextureBase_DestroyStrongHandle: {self} (refs={textureData.ReferenceCount})");
                }
            }
        }
    }
    
    /// <summary>
    /// Vérifie si un handle fort de texture est valide.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsStrongHandleValid(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        lock (_textureHandles)
        {
            return _textureHandles.ContainsKey(self) ? 1 : 0;
        }
    }
    
    /// <summary>
    /// Vérifie si une texture est en erreur.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsError(IntPtr self)
    {
        if (self == IntPtr.Zero) return 1; // Null = erreur
        
        lock (_textureHandles)
        {
            if (_textureHandles.TryGetValue(self, out var textureData))
            {
                return textureData.IsError ? 1 : 0;
            }
        }
        
        return 1; // Handle invalide = erreur
    }
    
    /// <summary>
    /// Vérifie si une texture est chargée.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CTextureBase_IsStrongHandleLoaded(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        lock (_textureHandles)
        {
            if (_textureHandles.TryGetValue(self, out var textureData))
            {
                return textureData.IsLoaded ? 1 : 0;
            }
        }
        
        return 0;
    }
    
    /// <summary>
    /// Crée une copie d'un handle fort de texture.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CTextureBase_CopyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        lock (_textureHandles)
        {
            if (_textureHandles.TryGetValue(self, out var textureData))
            {
                // Incrémenter le compteur de références
                textureData.ReferenceCount++;
                
                // Créer un nouveau handle qui pointe vers le même TextureData
                IntPtr newHandle = (IntPtr)_nextTextureId++;
                _textureHandles[newHandle] = textureData;
                
                Console.WriteLine($"[NativeAOT] CTextureBase_CopyStrongHandle: {self} -> {newHandle} (refs={textureData.ReferenceCount})");
                return newHandle;
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient le pointeur de binding d'une texture.
    /// Le binding pointer est un identifiant unique qui identifie la texture native,
    /// utilisé pour comparer si deux handles pointent vers la même texture.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CTextureBase_GetBindingPtr(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        lock (_textureHandles)
        {
            if (_textureHandles.TryGetValue(self, out var textureData))
            {
                return textureData.BindingPtr;
            }
        }
        
        return IntPtr.Zero;
    }
}

