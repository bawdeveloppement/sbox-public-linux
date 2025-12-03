using System;
using System.Runtime.InteropServices;

namespace Sbox.Engine.Emulation.Steam;

/// <summary>
/// Module d'émulation pour les fonctions Steam API globales (globalSteam_*).
/// Sur Linux, Steam n'est pas toujours disponible, donc ces fonctions retournent des valeurs par défaut.
/// Note: Les interfaces Steam retournent IntPtr.Zero pour indiquer qu'elles ne sont pas disponibles.
/// </summary>
public static unsafe class SteamAPI
{
    /// <summary>
    /// Initialise le module Steam en patchant les fonctions natives.
    /// </summary>
    public static void Init(void** native)
    {
        // Index calculés depuis Interop.Engine.cs
        // Les indices commencent à 1608 pour les fonctions Steam
        
        native[1608] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamHTMLSurface;
        native[1609] = (void*)(delegate* unmanaged<void>)&globalSteam_SteamAPI_RunCallbacks;
        native[1610] = (void*)(delegate* unmanaged<void>)&globalSteam_SteamGameServer_RunCallbacks;
        native[1611] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamUser;
        native[1612] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamFriends;
        native[1613] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamNetworkingMessages;
        native[1614] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamNetworkingUtils;
        native[1615] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamMatchmaking;
        native[1616] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamGameServer;
        native[1617] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamApps;
        native[1618] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamUtils;
        native[1619] = (void*)(delegate* unmanaged<int>)&globalSteam_SteamGameServer_BSecure;
        native[1620] = (void*)(delegate* unmanaged<ulong>)&globalSteam_SteamGameServer_GetSteamID;
        native[1621] = (void*)(delegate* unmanaged<void>)&globalSteam_SteamGameServer_Shutdown;
        native[1622] = (void*)(delegate* unmanaged<void>)&globalSteam_SteamGameServer_ReleaseCurrentThreadMemory;
        native[1623] = (void*)(delegate* unmanaged<IntPtr>)&globalSteam_SteamNetworkingSockets;
        native[1624] = (void*)(delegate* unmanaged<int, int, IntPtr, void>)&globalSteam_SteamGameServer_Init;
        
        Console.WriteLine("[NativeAOT] SteamAPI module initialized (Linux emulation - Steam not available)");
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamHTMLSurface.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamHTMLSurface()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Exécute les callbacks Steam API.
    /// Sur Linux sans Steam, c'est un no-op.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void globalSteam_SteamAPI_RunCallbacks()
    {
        // Steam n'est pas disponible, rien à faire
    }
    
    /// <summary>
    /// Exécute les callbacks Steam Game Server API.
    /// Sur Linux sans Steam, c'est un no-op.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void globalSteam_SteamGameServer_RunCallbacks()
    {
        // Steam n'est pas disponible, rien à faire
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamUser.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamUser()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamFriends.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamFriends()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamNetworkingMessages.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamNetworkingMessages()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamNetworkingUtils.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamNetworkingUtils()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamMatchmaking.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamMatchmaking()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamGameServer.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamGameServer()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamApps.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamApps()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamUtils.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamUtils()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Retourne si le serveur Steam Game Server est sécurisé.
    /// Sur Linux sans Steam, retourne 0 (false).
    /// </summary>
    [UnmanagedCallersOnly]
    public static int globalSteam_SteamGameServer_BSecure()
    {
        // Steam n'est pas disponible
        return 0; // false
    }
    
    /// <summary>
    /// Retourne le SteamID du serveur Steam Game Server.
    /// Sur Linux sans Steam, retourne 0.
    /// </summary>
    [UnmanagedCallersOnly]
    public static ulong globalSteam_SteamGameServer_GetSteamID()
    {
        // Steam n'est pas disponible
        return 0;
    }
    
    /// <summary>
    /// Arrête le serveur Steam Game Server.
    /// Sur Linux sans Steam, c'est un no-op.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void globalSteam_SteamGameServer_Shutdown()
    {
        // Steam n'est pas disponible, rien à faire
    }
    
    /// <summary>
    /// Libère la mémoire du thread courant pour Steam Game Server.
    /// Sur Linux sans Steam, c'est un no-op.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void globalSteam_SteamGameServer_ReleaseCurrentThreadMemory()
    {
        // Steam n'est pas disponible, rien à faire
    }
    
    /// <summary>
    /// Retourne un pointeur vers l'interface SteamNetworkingSockets.
    /// Sur Linux sans Steam, retourne IntPtr.Zero.
    /// </summary>
    [UnmanagedCallersOnly]
    public static IntPtr globalSteam_SteamNetworkingSockets()
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        return IntPtr.Zero;
    }
    
    /// <summary>
    /// Initialise le serveur Steam Game Server.
    /// Sur Linux sans Steam, c'est un no-op.
    /// Signature: delegate* unmanaged&lt; int gamePort, int queryPort, IntPtr serverVersion, void &gt;
    /// </summary>
    [UnmanagedCallersOnly]
    public static void globalSteam_SteamGameServer_Init(int gamePort, int queryPort, IntPtr serverVersion)
    {
        // Steam n'est pas disponible sur Linux dans cette émulation
        // Le moteur peut continuer sans Steam, donc on ne fait rien
    }
}

