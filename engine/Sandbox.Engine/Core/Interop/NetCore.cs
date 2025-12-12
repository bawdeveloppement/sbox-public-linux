internal static class NetCore
{
	/// <summary>
	/// Interop will try to load dlls from this path, e.g bin/win64/
	/// </summary>
	internal static string NativeDllPath { get; set; } = System.OperatingSystem.IsLinux() ? "bin/linuxsteamrt64/" : "bin/win64/";

	/// <summary>
	/// Native engine library name (default Source 2)
	/// </summary>
	internal static string EngineLibraryName { get; set; } = System.OperatingSystem.IsLinux()
		? "libengine2.so"
		: System.OperatingSystem.IsWindows() ? "engine2.dll" : "libengine2.dylib";

	/// <summary>
	/// From here we'll open the native dlls and inject our function pointers into them,
	/// and retrieve function pointers from them.
	/// </summary>
	internal static void InitializeInterop( string gameFolder )
	{
		// make sure currentdir to the game folder. This is just to setr a baseline for the rest
		// of the managed system to work with - since they can all assume CurrentDirectory is
		// where you would expect it to be instead of in the fucking bin folder.
		System.Environment.CurrentDirectory = gameFolder;

		// engine is always initialized
		Managed.SandboxEngine.NativeInterop.Initialize();

		// set engine paths etc
		if ( System.OperatingSystem.IsLinux() )
		{
			NativeEngine.EngineGlobal.Plat_SetModuleFilename( $"{gameFolder}/sbox" );
			NativeEngine.EngineGlobal.Plat_SetCurrentDirectory( $"{gameFolder}" );
		}
		else
		{
			NativeEngine.EngineGlobal.Plat_SetModuleFilename( $"{gameFolder}\\sbox.exe" );
			NativeEngine.EngineGlobal.Plat_SetCurrentDirectory( $"{gameFolder}" );
		}
	}
}
