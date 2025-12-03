using System.Collections.Concurrent;

namespace Sbox.Engine.Emulation.Common;

/// <summary>
/// Gestionnaire centralisé de handles pour tous les objets émulés.
/// Thread-safe, utilise ConcurrentDictionary pour la sécurité multi-thread.
/// Les handles commencent à 1000 pour éviter les collisions avec les handles natifs.
/// </summary>
public static class HandleManager
{
    private static int _nextHandle = 1000;
    private static readonly ConcurrentDictionary<int, object> _objects = new();
    
    /// <summary>
    /// Enregistre un objet et retourne un handle unique.
    /// </summary>
    public static int Register(object obj)
    {
        var handle = System.Threading.Interlocked.Increment(ref _nextHandle);
        _objects[handle] = obj;
        return handle;
    }
    
    /// <summary>
    /// Récupère un objet par son handle.
    /// </summary>
    public static T? Get<T>(int handle) where T : class
    {
        return _objects.TryGetValue(handle, out var obj) ? obj as T : null;
    }
    
    /// <summary>
    /// Libère un handle et son objet associé.
    /// </summary>
    public static void Unregister(int handle)
    {
        _objects.TryRemove(handle, out _);
    }
    
    /// <summary>
    /// Vérifie si un handle existe.
    /// </summary>
    public static bool Exists(int handle)
    {
        return _objects.ContainsKey(handle);
    }
}

