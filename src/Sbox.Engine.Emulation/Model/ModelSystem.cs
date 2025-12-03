using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Sbox.Engine.Emulation.Common;

namespace Sbox.Engine.Emulation.Model;

/// <summary>
/// Module d'émulation pour les fonctions CModel (CModel_*).
/// Gère les modèles 3D chargés depuis les ressources.
/// </summary>
public static unsafe class ModelSystem
{
    private static int _nextModelId = 2000000;
    
    /// <summary>
    /// Données internes pour un modèle émulé.
    /// Pattern identique à MaterialData dans MaterialSystem.cs
    /// </summary>
    internal class ModelData
    {
        public string Name { get; set; } = "";
        public int ReferenceCount { get; set; } = 1; // Compteur de références pour les handles forts
        public IntPtr BindingPtr { get; set; } = IntPtr.Zero; // Pointeur de binding unique (handle HandleManager)
        public bool IsError { get; set; } = false;
        public bool IsLoaded { get; set; } = true; // Par défaut, considéré comme chargé
    }
    
    // Dictionnaire pour mapper les handles vers les ModelData (pattern identique à MaterialSystem)
    internal static readonly Dictionary<IntPtr, ModelData> _modelHandles = new();
    
    /// <summary>
    /// Initialise le module ModelSystem en patchant les fonctions natives.
    /// Indices depuis Interop.Engine.cs lignes 15288-15351 (541-604)
    /// </summary>
    public static void Init(void** native)
    {
        // CModel functions essentielles (indices 541-546 depuis Interop.Engine.cs)
        native[541] = (void*)(delegate* unmanaged<IntPtr, void>)&CModel_DestroyStrongHandle;
        native[542] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_IsStrongHandleValid;
        native[543] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_IsError;
        native[544] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_IsStrongHandleLoaded;
        native[545] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CModel_CopyStrongHandle;
        native[546] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CModel_GetBindingPtr;
        
        // CModel functions supplémentaires (indices 547+)
        native[547] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&CModel_GetModelName;
        native[548] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_IsTranslucent;
        native[549] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_IsTranslucentTwoPass;
        native[550] = (void*)(delegate* unmanaged<IntPtr, int>)&CModel_HasPhysics;
        
        // TODO: Patcher les autres fonctions CModel_* (indices 551-604) quand elles seront implémentées
        
        // TODO: Implémenter les autres fonctions CModel_* (indices 551-604)
        // Pour l'instant, on implémente seulement les fonctions essentielles pour que le système fonctionne
        
        Console.WriteLine("[NativeAOT] ModelSystem module initialized");
    }
    
    /// <summary>
    /// Helper pour créer un modèle depuis une ressource (appelable depuis le code managé).
    /// Utilisé par EngineGlue.Glue_Resources_GetModel.
    /// </summary>
    public static IntPtr CreateModelFromResourceHelper(string resourceName)
    {
        if (string.IsNullOrEmpty(resourceName)) return IntPtr.Zero;
        
        // Chercher un modèle existant avec ce nom
        lock (_modelHandles)
        {
            foreach (var kvp in _modelHandles)
            {
                if (kvp.Value.Name.Equals(resourceName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"[NativeAOT] ModelSystem.CreateModelFromResourceHelper: found existing {resourceName}");
                    return kvp.Key;
                }
            }
        }
        
        // Créer un nouveau modèle
        var modelData = new ModelData
        {
            Name = resourceName,
            ReferenceCount = 1
        };
        
        // Enregistrer dans HandleManager pour obtenir un BindingPtr unique
        int bindingHandle = HandleManager.Register(modelData);
        modelData.BindingPtr = (IntPtr)bindingHandle;
        
        IntPtr modelHandle = (IntPtr)_nextModelId++;
        lock (_modelHandles)
        {
            _modelHandles[modelHandle] = modelData;
        }
        
        Console.WriteLine($"[NativeAOT] ModelSystem.CreateModelFromResourceHelper: created new {resourceName}, handle={modelHandle}");
        return modelHandle;
    }
    
    /// <summary>
    /// Libère un handle fort de modèle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void CModel_DestroyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return;
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                // Décrémenter le compteur de références
                modelData.ReferenceCount--;
                
                // Si plus de références, libérer le modèle
                if (modelData.ReferenceCount <= 0)
                {
                    // Libérer le BindingPtr depuis HandleManager
                    if (modelData.BindingPtr != IntPtr.Zero)
                    {
                        HandleManager.Unregister((int)modelData.BindingPtr);
                    }
                    
                    _modelHandles.Remove(self);
                    Console.WriteLine($"[NativeAOT] CModel_DestroyStrongHandle: {self} (freed)");
                }
                else
                {
                    Console.WriteLine($"[NativeAOT] CModel_DestroyStrongHandle: {self} (refs={modelData.ReferenceCount})");
                }
            }
        }
    }
    
    /// <summary>
    /// Vérifie si un handle fort de modèle est valide.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CModel_IsStrongHandleValid(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        lock (_modelHandles)
        {
            return _modelHandles.ContainsKey(self) ? 1 : 0;
        }
    }
    
    /// <summary>
    /// Vérifie si un modèle est en erreur.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CModel_IsError(IntPtr self)
    {
        if (self == IntPtr.Zero) return 1; // Null = erreur
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                return modelData.IsError ? 1 : 0;
            }
        }
        
        return 1; // Handle invalide = erreur
    }
    
    /// <summary>
    /// Vérifie si un modèle est chargé.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CModel_IsStrongHandleLoaded(IntPtr self)
    {
        if (self == IntPtr.Zero) return 0;
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                return modelData.IsLoaded ? 1 : 0;
            }
        }
        
        return 0;
    }
    
    /// <summary>
    /// Crée une copie d'un handle fort de modèle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CModel_CopyStrongHandle(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                // Incrémenter le compteur de références
                modelData.ReferenceCount++;
                
                // Créer un nouveau handle qui pointe vers le même ModelData
                IntPtr newHandle = (IntPtr)_nextModelId++;
                _modelHandles[newHandle] = modelData;
                
                Console.WriteLine($"[NativeAOT] CModel_CopyStrongHandle: {self} -> {newHandle} (refs={modelData.ReferenceCount})");
                return newHandle;
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient le pointeur de binding d'un modèle.
    /// Le binding pointer est un identifiant unique qui identifie le modèle natif,
    /// utilisé pour comparer si deux handles pointent vers le même modèle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged[SuppressGCTransition]&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IntPtr CModel_GetBindingPtr(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                return modelData.BindingPtr;
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Obtient le nom d'un modèle.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr CModel_GetModelName(IntPtr self)
    {
        if (self == IntPtr.Zero) return IntPtr.Zero;
        
        lock (_modelHandles)
        {
            if (_modelHandles.TryGetValue(self, out var modelData))
            {
                // Allouer de la mémoire pour le nom (le moteur est responsable de la libération)
                return Marshal.StringToHGlobalAnsi(modelData.Name);
            }
        }
        
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Vérifie si un modèle est translucide.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CModel_IsTranslucent(IntPtr self)
    {
        // TODO: Implémenter la logique réelle basée sur les matériaux du modèle
        throw new NotImplementedException("CModel_IsTranslucent not implemented");
    }
    
    /// <summary>
    /// Vérifie si un modèle nécessite un rendu en deux passes (translucide).
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CModel_IsTranslucentTwoPass(IntPtr self)
    {
        // TODO: Implémenter la logique réelle
        throw new NotImplementedException( "CModel_IsTranslucentTwoPass not implemented" );
    }
    
    /// <summary>
    /// Vérifie si un modèle a de la physique.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static int CModel_HasPhysics(IntPtr self)
    {
        // TODO: Implémenter la logique réelle basée sur les données du modèle
        throw new NotImplementedException( "CModel_HasPhysics not implemented" );
    }
}

