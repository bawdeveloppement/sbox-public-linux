using System.Collections.Concurrent;

namespace Sbox.Engine.Emulation.Physics;

/// <summary>
/// Simple thread‑safe handle manager used by the NativeAOT exports.
/// Handles are ints starting at 1000 to avoid colliding with any existing engine handles.
/// </summary>
internal static class HandleManager
{
    private static int _nextHandle = 1000;
    private static readonly ConcurrentDictionary<int, object> _objects = new();

    public static int Register(object obj)
    {
        var handle = System.Threading.Interlocked.Increment(ref _nextHandle);
        _objects[handle] = obj;
        return handle;
    }

    public static T Get<T>(int handle) where T : class
    {
        return _objects.TryGetValue(handle, out var obj) ? obj as T : null;
    }

    public static void Unregister(int handle)
    {
        _objects.TryRemove(handle, out _);
    }
}
