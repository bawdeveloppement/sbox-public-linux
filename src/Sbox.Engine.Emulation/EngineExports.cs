using System.Runtime.InteropServices;
using Sbox.Engine.Emulation.Generated;
using Sbox.Engine;
using NativeEngine;
using Silk.NET.Windowing;
using Silk.NET.Maths;
using System.IO;
using Silk.NET.SDL;
using Silk.NET.Windowing.Sdl;
using Silk.NET.Windowing.Glfw;
using Sandbox;
using Silk.NET.OpenGL;

namespace Sbox.Engine.Emulation;

public static unsafe class EngineExports
{
    private static bool _isReady = false;
    private static IWindow? _window;

    private static Silk.NET.OpenGL.GL? _gl;

    /// <summary>
    /// Main engine initialization function called by the managed runtime.
    /// This is the entry point that receives function pointers from both sides.
    /// </summary>
    [UnmanagedCallersOnly(EntryPoint = "igen_engine")]
    public static void IGenEngine(int hash, void* managedFunctions, void* nativeFunctions, int* structSizes)
    {
        Console.WriteLine($"[NativeAOT Engine] igen_engine called with hash: {hash}");

        void** managed = (void**)managedFunctions;
        void** native  = (void**)nativeFunctions;

        // 1. Store managed function pointers (Imports)
        EngineGlue.StoreImports(managed);

        // 2. Fill native function pointers (Exports)
        Exports.FillNativeFunctionsEngine(managed, native, structSizes);
        
        // 3. Patch native function pointers with our implementations
        // Indices calculated from engine.Generated.cs (LineNumber - 13)
        
        // CMtrlSystm2ppSys_Create: Line 511 -> Index 498
        native[498] = (void*)(delegate* unmanaged<void*, void*>)&CMtrlSystm2ppSys_Create;

        // CMtrlSystm2ppSys_Init: Line 513 -> Index 500
        native[500] = (void*)(delegate* unmanaged<void*, int>)&CMtrlSystm2ppSys_Init;

        // CMtrlSystm2ppSys_GetAppWindow: Line 516 -> Index 503
        native[503] = (void*)(delegate* unmanaged<void*, void*>)&CMtrlSystm2ppSys_GetAppWindow;

        // CMtrlSystm2ppSys_CreateAppWindow: Line 544 -> Index 531
        native[531] = (void*)(delegate* unmanaged<void*, void*, int, int, int, int, int, int, void*>)&CreateAppWindow;

        native[1421] = (void*)(delegate* unmanaged< void*, void*, void* >)&GetEngineSwapChainSize;

        native[1474] = (void*)(delegate* unmanaged< void*, int, void*, void*, int, void* >)&FindOrCreateTexture2;
        
        // global_Plat_MessageBox: Line 1584 -> Index 1571
        native[1571] = (void*)(delegate* unmanaged<void*, void*, void*>)&Plat_MessageBox;

        // global_Plat_SetCurrentFrame: Line 1591 -> Index 1578
        native[1578] = (void*)(delegate* unmanaged<ulong, void*>)&Plat_SetCurrentFrame;
        
        // global_GetGameRootFolder: Line 1602 -> Index 1589
        native[1589] = (void*)(delegate* unmanaged<void*>)&GetGameRootFolder;

        // global_SourceEnginePreInit: Line 1605 -> Index 1592
        native[1592] = (void*)(delegate* unmanaged<void*, void*, int>)&SourceEnginePreInit;
        
        // global_SourceEngineInit: Line 1606 -> Index 1593
        native[1593] = (void*)(delegate* unmanaged<void*, int>)&SourceEngineInit;
        
        // global_SourceEngineFrame: Line 1607 -> Index 1594
        native[1594] = (void*)(delegate* unmanaged<void*, double, double, int>)&SourceEngineFrame;
        
        // global_UpdateWindowSize: Line 1609 -> Index 1596
        native[1596] = (void*)(delegate* unmanaged<void*>)&UpdateWindowSize;

        _isReady = true;
    }

    [UnmanagedCallersOnly(EntryPoint = "Debug_Error")]
    public static void DebugError(IntPtr message)
    {
        string? msg = Marshal.PtrToStringUTF8(message);
        Console.WriteLine($"[NativeAOT ERROR] {msg}");
    }

    [UnmanagedCallersOnly]
    public static void* CMtrlSystm2ppSys_Create(void* createInfo)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_Create");
        return (void*)1; // Return a dummy non-null pointer
    }

    [UnmanagedCallersOnly]
    public static int CMtrlSystm2ppSys_Init(void* self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_Init");
        return 1; // Success
    }

    [UnmanagedCallersOnly]
    public static void* CMtrlSystm2ppSys_GetAppWindow(void* self)
    {
        Console.WriteLine("[NativeAOT] CMtrlSystm2ppSys_GetAppWindow");
        return (void*)1; // Return dummy window handle
    }

    [UnmanagedCallersOnly]
    public static void* FindOrCreateTexture2(void* pResourceName, int bIsAnonymous, void* pDescriptor, void* data, int dataSize)
    {
        var gl = _gl;

        var desc = (TextureCreationConfig_t*)pDescriptor;

        if (desc->m_nWidth <= 0)
            desc->m_nWidth = 1;

        if (desc->m_nHeight <= 0)
            desc->m_nHeight = 1;

        if (desc->m_nDepth <= 0)
            desc->m_nDepth = 1;

        if (desc->m_nNumMipLevels <= 0)
            desc->m_nNumMipLevels = 1;

        if (desc->m_nImageFormat == ImageFormat.None)
            desc->m_nImageFormat = ImageFormat.RGBA8888;

        desc->m_nDisplayRectWidth = desc->m_nWidth;
        desc->m_nDisplayRectHeight = desc->m_nHeight;

        uint tex;
        gl.GenTextures(1, out tex);
        gl.BindTexture(GLEnum.Texture2D, tex);

        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureMinFilter, (int)GLEnum.Linear);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureMagFilter, (int)GLEnum.Linear);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureWrapS, (int)GLEnum.ClampToEdge);
        gl.TexParameter(GLEnum.Texture2D, GLEnum.TextureWrapT, (int)GLEnum.ClampToEdge);

        gl.TexImage2D(
            GLEnum.Texture2D,
            0,
            (int)GLEnum.Rgba8,
            (uint)desc->m_nWidth,
            (uint)desc->m_nHeight,
            0,
            GLEnum.Rgba,
            GLEnum.UnsignedByte,
            data
        );
        return (void*)tex;
    }

    [UnmanagedCallersOnly]
    public static void* Plat_MessageBox(void* title, void* message)
    {
        string? t = Marshal.PtrToStringUTF8((IntPtr)title);
        string? m = Marshal.PtrToStringUTF8((IntPtr)message);
        Console.WriteLine($"[NativeAOT MESSAGEBOX] {t}: {m}");
        return null;
    }

    [UnmanagedCallersOnly]
    public static void* Plat_SetCurrentFrame(ulong frame)
    {
        // Console.WriteLine($"[NativeAOT] Plat_SetCurrentFrame({frame})");
        return null;
    }

    [UnmanagedCallersOnly]
    public static void* GetGameRootFolder()
    {
        string cwd = Directory.GetCurrentDirectory();
        Console.WriteLine($"[NativeAOT] GetGameRootFolder: {cwd}");
        return (void*)Marshal.StringToHGlobalAnsi(cwd); // Leak memory for now
    }

    [UnmanagedCallersOnly]
    public static int SourceEnginePreInit(void* lpCmdLine, void* appDict)
    {
        Console.WriteLine("[NativeAOT] SourceEnginePreInit");
        return 1; // Success
    }

    // Internal helper that can be called directly
    private static void* CreateAppWindowInternal(string title, int w, int h)
    {
        Console.WriteLine($"[NativeAOT] Creating Window: {title} ({w}x{h})");

        // Register GLFW as the windowing platform (try GLFW instead of SDL)
        GlfwWindowing.Use();

        var options = WindowOptions.Default;
        options.Size = new Vector2D<int>(w > 0 ? w : 1280, h > 0 ? h : 720);
        options.Title = title;
        options.API = GraphicsAPI.Default;
        options.ShouldSwapAutomatically = false; // We control swapping in Frame

        _window = Silk.NET.Windowing.Window.Create(options);
        _window.Initialize();
        _window.MakeCurrent();

        _gl = Silk.NET.OpenGL.GL.GetApi(_window);
        Console.WriteLine($"[NativeAOT] Window Initialized");
        return (void*)1;
    }

    [UnmanagedCallersOnly]
    public static void* CreateAppWindow(void* self, void* pTitle, int nPlatWindowFlags, int x, int y, int w, int h, int nRefreshRateHz)
    {
        string title = Marshal.PtrToStringUTF8((IntPtr)pTitle) ?? "S&box NativeAOT";
        return CreateAppWindowInternal(title, w, h);
    }

    [UnmanagedCallersOnly]
    public static void* GetEngineSwapChainSize( void* w, void* h )
    {
        if (_window == null)
            return null;

        var fb = _window.FramebufferSize;

        *(int*)w = fb.X;
        *(int*)h = fb.Y;

        return null;
    }

    [UnmanagedCallersOnly]
    public static int SourceEngineInit(void* appDict)
    {
        Console.WriteLine("[NativeAOT] SourceEngineInit - Forcing Window Creation");
        
        // Force create window
        CreateAppWindowInternal("S&box NativeAOT", 1280, 720);
        
        return 1; // Success
    }

    [UnmanagedCallersOnly]
    public static int SourceEngineFrame(void* appDict, double currentTime, double previousTime)
    {
        if (_window == null) return 0;

        _window.DoEvents();
        
        if (_window.IsClosing) return 0;

        _window.DoUpdate();
        _window.DoRender();
        _window.SwapBuffers();
        
        return 1;
    }

    [UnmanagedCallersOnly]
    public static void* UpdateWindowSize()
    {
        Console.WriteLine("[NativeAOT] UpdateWindowSize");
        return null;
    }

    private static GL GetGL()
    {
        if (_gl != null)
            return _gl;

        if (_window == null)
            throw new Exception("Window not initialized");

        _gl = GL.GetApi(_window);
        return _gl;
    }
}
