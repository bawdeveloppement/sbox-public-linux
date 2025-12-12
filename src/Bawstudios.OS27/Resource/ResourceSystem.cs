using System.Runtime.InteropServices;
using System.Collections.Generic;
using NativeEngine;

namespace Bawstudios.OS27.Resource;

/// <summary>
/// Module d'émulation pour ResourceSystem (g_pRsrcSystm_*).
/// Gère le chargement et la gestion des manifests.
/// </summary>
public static unsafe class ResourceSystem
{
    private static bool LogMinimal = true;
    private static bool LogAll = true;
    private static void LogCall(string name, bool minimal, string message = "")
    {
        if (!(LogAll || (LogMinimal && minimal))) return;
        Console.WriteLine($"[NativeAOT][Res] {name} {message}");
    }

    // État pour gérer les manifests de ressources
    private static readonly Dictionary<IntPtr, ResourceManifestData> _manifests = new();
    private static int _nextManifestId = 1;
    
    // Liste des manifests de code (pour GetAllCodeManifests)
    private static readonly List<string> _codeManifests = new();

    private class ResourceManifestData
    {
        public string Name { get; set; } = "";
        public bool IsLoaded { get; set; }
        public IntPtr Handle { get; set; }
        public bool IsCodeManifest { get; set; } // Indique si c'est un manifest de code
    }

    /// <summary>
    /// Initialise le module ResourceSystem en patchant toutes les fonctions natives.
    /// Signatures exactes depuis Interop.Engine.cs ligne 16262-16268.
    /// </summary>
    public static void Init(void** native)
    {
        LogCall(nameof(Init), minimal: true);
        // ResourceSystem functions (indices 1515-1521 depuis Interop.Engine.cs ligne 16262-16268)
        native[1515] = (void*)(delegate* unmanaged<void>)&g_pRsrcSystm_ReloadSymlinkedResidentResources;
        native[1516] = (void*)(delegate* unmanaged<void>)&g_pRsrcSystm_UpdateSimple;
        native[1517] = (void*)(delegate* unmanaged<int>)&g_pRsrcSystm_HasPendingWork;
        native[1518] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pRsrcSystm_LoadResourceInManifest;
        native[1519] = (void*)(delegate* unmanaged<IntPtr, void>)&g_pRsrcSystm_DestroyResourceManifest;
        native[1520] = (void*)(delegate* unmanaged<IntPtr, int>)&g_pRsrcSystm_IsManifestLoaded;
        native[1521] = (void*)(delegate* unmanaged<IntPtr, void>)&g_pRsrcSystm_GetAllCodeManifests;
    }

    // ============================================================================
    // ResourceSystem Functions (g_pRsrcSystm_*)
    // ============================================================================

    /// <summary>
    /// Recharge les ressources résidentes liées par symlink.
    /// Cette fonction est appelée pour mettre à jour les ressources après un changement de symlink.
    /// Signature: delegate* unmanaged&lt; void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pRsrcSystm_ReloadSymlinkedResidentResources()
    {
        LogCall(nameof(g_pRsrcSystm_ReloadSymlinkedResidentResources), minimal: true);
        // Stub implementation - sur Linux, les symlinks sont gérés par le système de fichiers
        // Cette fonction est principalement utilisée pour recharger les ressources après un changement de symlink
        // Pour l'émulation, on peut ignorer cette opération car le système de fichiers virtuel gère déjà les changements
    }

    /// <summary>
    /// Met à jour le système de ressources de manière simple (appelé chaque frame).
    /// Signature: delegate* unmanaged&lt; void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pRsrcSystm_UpdateSimple()
    {
        LogCall(nameof(g_pRsrcSystm_UpdateSimple), minimal: true);
        // Stub implementation - pas de mise à jour nécessaire pour l'émulation
        // Cette fonction est appelée chaque frame pour mettre à jour l'état des ressources
    }

    /// <summary>
    /// Vérifie s'il y a du travail en attente dans le système de ressources.
    /// Signature: delegate* unmanaged&lt; int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static int g_pRsrcSystm_HasPendingWork()
    {
        LogCall(nameof(g_pRsrcSystm_HasPendingWork), minimal: true);
        // Stub implementation - retourne 0 (pas de travail en attente)
        return 0;
    }

    /// <summary>
    /// Charge une ressource dans un manifest.
    /// Cette fonction charge un manifest de ressources depuis le système de fichiers.
    /// Signature: delegate* unmanaged&lt; IntPtr, IntPtr &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr g_pRsrcSystm_LoadResourceInManifest(IntPtr name)
    {
        LogCall(nameof(g_pRsrcSystm_LoadResourceInManifest), minimal: true, message: $"name=0x{name.ToInt64():X}");
        if (name == IntPtr.Zero)
        {
            LogCall(nameof(g_pRsrcSystm_LoadResourceInManifest), minimal: true, message: "name is null");
            return IntPtr.Zero;
        }
        
        string? nameStr = Marshal.PtrToStringUTF8(name);
        LogCall(nameof(g_pRsrcSystm_LoadResourceInManifest), minimal: true, message: $"nameStr={nameStr}");
        
        if (string.IsNullOrEmpty(nameStr))
            return IntPtr.Zero;
        
        // Vérifier si le manifest existe déjà
        foreach (var kvp in _manifests)
        {
            if (kvp.Value.Name == nameStr)
            {
                LogCall(nameof(g_pRsrcSystm_LoadResourceInManifest), minimal: true, message: $"exists handle=0x{kvp.Key.ToInt64():X}");
                return kvp.Key;
            }
        }
        
        // Créer un nouveau manifest
        var manifest = new ResourceManifestData
        {
            Name = nameStr,
            IsLoaded = true,
            Handle = (IntPtr)_nextManifestId++,
            IsCodeManifest = nameStr.Contains("code", StringComparison.OrdinalIgnoreCase) || 
                            nameStr.EndsWith(".code", StringComparison.OrdinalIgnoreCase)
        };
        
        _manifests[manifest.Handle] = manifest;
        
        // Si c'est un manifest de code, l'ajouter à la liste
        if (manifest.IsCodeManifest && !_codeManifests.Contains(nameStr))
        {
            _codeManifests.Add(nameStr);
        }
        
        LogCall(nameof(g_pRsrcSystm_LoadResourceInManifest), minimal: true, message: $"created handle=0x{manifest.Handle.ToInt64():X} isCode={manifest.IsCodeManifest}");
        return manifest.Handle;
    }

    /// <summary>
    /// Détruit un manifest de ressources.
    /// Signature: delegate* unmanaged&lt; IntPtr, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pRsrcSystm_DestroyResourceManifest(IntPtr manifest)
    {
        LogCall(nameof(g_pRsrcSystm_DestroyResourceManifest), minimal: true, message: $"handle=0x{manifest.ToInt64():X}");
        if (manifest == IntPtr.Zero) return;
        
        if (_manifests.Remove(manifest))
        {
            LogCall(nameof(g_pRsrcSystm_DestroyResourceManifest), minimal: true, message: "destroyed");
        }
    }

    /// <summary>
    /// Vérifie si un manifest est chargé.
    /// Signature: delegate* unmanaged&lt; IntPtr, int &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static int g_pRsrcSystm_IsManifestLoaded(IntPtr manifest)
    {
        LogCall(nameof(g_pRsrcSystm_IsManifestLoaded), minimal: true, message: $"handle=0x{manifest.ToInt64():X}");
        if (manifest == IntPtr.Zero) return 0;
        
        if (_manifests.TryGetValue(manifest, out var manifestData))
        {
            return manifestData.IsLoaded ? 1 : 0;
        }
        
        return 0;
    }

    /// <summary>
    /// Récupère tous les manifests de code.
    /// Cette fonction remplit un CUtlVectorString avec les noms des manifests de code.
    /// Signature exacte depuis Interop.Engine.cs: delegate* unmanaged&lt; IntPtr, void &gt;
    /// Le paramètre values est un pointeur vers un CUtlVectorString natif.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pRsrcSystm_GetAllCodeManifests(IntPtr values)
    {
        LogCall(nameof(g_pRsrcSystm_GetAllCodeManifests), minimal: true, message: $"values=0x{values.ToInt64():X}");
        if (values == IntPtr.Zero)
        {
            LogCall(nameof(g_pRsrcSystm_GetAllCodeManifests), minimal: true, message: "values is null");
            return;
        }
        
        throw new NotImplementedException("g_pRsrcSystm_GetAllCodeManifests requires CUtlVectorString native append support");
    }
}

