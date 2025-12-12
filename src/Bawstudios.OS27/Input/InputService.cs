using System;
using System.Runtime.InteropServices;
using Bawstudios.OS27.Platform;
using Silk.NET.GLFW;

namespace Bawstudios.OS27.Input;

/// <summary>
/// Emulation module for InputService (g_pInputService_*).
/// Handles input functions (keyboard, mouse, etc.) via GLFW.
/// </summary>
public static unsafe class InputService
{
    /// <summary>
    /// Initialise le module InputService en patchant les fonctions natives.
    /// Indices depuis Interop.Engine.cs lignes 16295-16300 :
    /// - g_pInputService_IsAppActive: 1430
    /// - g_pInputService_HasMouseFocus: 1431
    /// - g_pInputService_Key_NameForBinding: 1432
    /// - g_pInputService_GetBinding: 1433
    /// - g_pInputService_SetCursorPosition: 1434
    /// - g_pInputService_Pump: 1435
    /// </summary>
    public static void Init(void** native)
    {
        // Indices 1430-1435
        native[1430] = (void*)(delegate* unmanaged<int>)&g_pInputService_IsAppActive;
        native[1431] = (void*)(delegate* unmanaged<int>)&g_pInputService_HasMouseFocus;
        native[1432] = (void*)(delegate* unmanaged<IntPtr, IntPtr>)&g_pInputService_Key_NameForBinding;
        native[1433] = (void*)(delegate* unmanaged<long, IntPtr>)&g_pInputService_GetBinding;
        native[1434] = (void*)(delegate* unmanaged<int, int, void>)&g_pInputService_SetCursorPosition;
        native[1435] = (void*)(delegate* unmanaged<void>)&g_pInputService_Pump;
        
        Console.WriteLine("[NativeAOT] InputService module initialized");
    }
    
    /// <summary>
    /// Check if the application is active (window has focus).
    /// 
    /// **Source 2 behavior**: Returns if the application has focus.
    /// **Emulation behavior**: Uses GLFW to check if the window has focus.
    /// </summary>
    /// <returns>1 if app is active, 0 otherwise</returns>
    [UnmanagedCallersOnly]
    public static int g_pInputService_IsAppActive()
    {
        var windowHandle = PlatformFunctions.GetWindowHandle();
        var glfw = PlatformFunctions.GetGlfw();
        
        if (windowHandle == null || glfw == null)
            return 0;
        
        bool focused = glfw.GetWindowAttrib(windowHandle, WindowAttributeGetter.Focused);
        return focused ? 1 : 0;
    }
    
    /// <summary>
    /// Check if the window has mouse focus.
    /// 
    /// **Source 2 behavior**: Returns if the window has mouse focus.
    /// **Emulation behavior**: Uses GLFW to check if the window has mouse focus.
    /// </summary>
    /// <returns>1 if mouse has focus, 0 otherwise</returns>
    [UnmanagedCallersOnly]
    public static int g_pInputService_HasMouseFocus()
    {
        var windowHandle = PlatformFunctions.GetWindowHandle();
        var glfw = PlatformFunctions.GetGlfw();
        
        if (windowHandle == null || glfw == null)
            return 0;
        
        // GLFW doesn't have a direct function to check mouse focus
        // We check if the window has focus and if the cursor is in the window
        bool focused = glfw.GetWindowAttrib(windowHandle, WindowAttributeGetter.Focused);
        bool hovered = glfw.GetWindowAttrib(windowHandle, WindowAttributeGetter.Hovered);
        
        return (focused && hovered) ? 1 : 0;
    }
    
    /// <summary>
    /// Get the key name for a binding string.
    /// 
    /// **Source 2 behavior**: Returns the key name corresponding to a binding.
    /// **Emulation behavior**: Returns an empty string for now (not implemented).
    /// </summary>
    /// <param name="binding">Pointer to binding string (UTF-8)</param>
    /// <returns>Pointer to key name string (UTF-8), or IntPtr.Zero</returns>
    [UnmanagedCallersOnly]
    public static IntPtr g_pInputService_Key_NameForBinding(IntPtr binding)
    {
        if (binding == IntPtr.Zero)
            return IntPtr.Zero;
        
        string? bindingStr = Marshal.PtrToStringUTF8(binding);
        if (string.IsNullOrEmpty(bindingStr))
            return IntPtr.Zero;
        
        throw new NotImplementedException("g_pInputService_Key_NameForBinding requires binding->key name mapping");
    }
    
    /// <summary>
    /// Get the binding string for a button code.
    /// 
    /// **Source 2 behavior**: Returns the binding corresponding to a button code.
    /// **Emulation behavior**: Returns an empty string for now (not implemented).
    /// </summary>
    /// <param name="button">Button code (ButtonCode)</param>
    /// <returns>Pointer to binding string (UTF-8), or IntPtr.Zero</returns>
    [UnmanagedCallersOnly]
    public static IntPtr g_pInputService_GetBinding(long button)
    {
        throw new NotImplementedException("g_pInputService_GetBinding requires button code -> binding mapping");
    }
    
    /// <summary>
    /// Set the cursor position in window coordinates.
    /// 
    /// **Source 2 behavior**: Sets the cursor position in window coordinates.
    /// **Emulation behavior**: Uses GLFW to set the cursor position.
    /// </summary>
    /// <param name="x">X position in pixels</param>
    /// <param name="y">Y position in pixels</param>
    [UnmanagedCallersOnly]
    public static void g_pInputService_SetCursorPosition(int x, int y)
    {
        var windowHandle = PlatformFunctions.GetWindowHandle();
        var glfw = PlatformFunctions.GetGlfw();
        
        if (windowHandle == null || glfw == null)
            return;
        
        glfw.SetCursorPos(windowHandle, x, y);
    }
    
    /// <summary>
    /// Pump input events (process keyboard, mouse, etc.).
    /// 
    /// **Source 2 behavior**: Processes pending input events.
    /// **Emulation behavior**: Calls glfw.PollEvents() to process GLFW events.
    /// </summary>
    [UnmanagedCallersOnly]
    public static void g_pInputService_Pump()
    {
        var glfw = PlatformFunctions.GetGlfw();
        
        if (glfw == null)
            return;
        
        // PollEvents processes all pending events (keyboard, mouse, window, etc.)
        glfw.PollEvents();
    }
}

