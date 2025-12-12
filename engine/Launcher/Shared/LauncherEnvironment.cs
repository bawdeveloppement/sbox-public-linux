using System;
using System.IO;
using System.Reflection;

namespace Sandbox;

public static class LauncherEnvironment
{
	/// <summary>
	/// The folder containing sbox.exe
	/// </summary>
	public static string GamePath { get; set; }

	/// <summary>
	/// The folder containing Sandbox.Engine.dll
	/// </summary>
	public static string ManagedDllPath { get; set; }

	public static string PlatformName
	{
		get
		{
			if ( OperatingSystem.IsWindows() )
				return "win64";
			if ( OperatingSystem.IsLinux() )
				return "linuxsteamrt64";
			if ( OperatingSystem.IsMacOS() )
				return "osxarm64";

			throw new Exception( "Unsupported platform" );
		}
	}

	public static void Init()
	{
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

		GamePath = AppContext.BaseDirectory;

		// this exe is in the bin folder
		if ( GamePath.EndsWith( System.IO.Path.Combine( "bin", PlatformName ) ) )
		{
			// go up two folders
			GamePath = System.IO.Path.GetFullPath(GamePath);
		}

		// this exe is in the game folder
		ManagedDllPath = $"{GamePath}/bin/managed/";
		var nativeDllPath = $"{GamePath}/bin/{PlatformName}/";

		// Select the native library (source2 by default, fallback to source2 if the requested library does not exist)
		var requestedLib = NormalizeEngineLib( Environment.GetEnvironmentVariable( "SBOX_ENGINE_LIB" ) );
		var requestedEngine = Environment.GetEnvironmentVariable( "SBOX_ENGINE" );
		var defaultLib = GetDefaultEngineLibName();
		string resolvedLib = defaultLib;
		Console.WriteLine( $"[LauncherEnvironment] SBOX_ENGINE_LIB={requestedLib}, SBOX_ENGINE={requestedEngine}, default={defaultLib}" );

		// Priority 1: Explicit SBOX_ENGINE_LIB
		if ( !string.IsNullOrWhiteSpace( requestedLib ) )
		{
			resolvedLib = requestedLib;
		}
		// Priority 2 : SBOX_ENGINE (source2|os27)
		else if ( !string.IsNullOrWhiteSpace( requestedEngine ) )
		{
			var eng = requestedEngine.Trim().ToLowerInvariant();
			resolvedLib = eng switch
			{
				"os27" when OperatingSystem.IsLinux() => "libos27.so",
				"os27" when OperatingSystem.IsWindows() => "os27.dll",
				"os27" => "libos27.dylib",
				_ => defaultLib // source2 ou autre → défaut
			};
		}

		var candidatePath = Path.Combine( nativeDllPath, resolvedLib );
		if ( !File.Exists( candidatePath ) && !resolvedLib.Equals( defaultLib, StringComparison.OrdinalIgnoreCase ) )
		{
			Console.WriteLine( $"[Launcher] Lib moteur '{resolvedLib}' introuvable ({candidatePath}), fallback sur '{defaultLib}'." );
			resolvedLib = defaultLib;
			candidatePath = Path.Combine( nativeDllPath, resolvedLib );
		}
		else
		{
			Console.WriteLine( $"[Launcher] Lib moteur sélectionnée : '{resolvedLib}' ({nativeDllPath})." );
		}

		Environment.SetEnvironmentVariable( "SBOX_ENGINE_LIB", resolvedLib );

		// make the game dir our current dir
		Environment.CurrentDirectory = GamePath;
		Console.WriteLine( $"Current directory: {Environment.CurrentDirectory}" );
		//
		// Allows unit tests and csproj to find the engine path.
		//
		if ( System.Environment.GetEnvironmentVariable( "FACEPUNCH_ENGINE", EnvironmentVariableTarget.User ) != GamePath )
		{
			System.Environment.SetEnvironmentVariable( "FACEPUNCH_ENGINE", GamePath, EnvironmentVariableTarget.User );
		}

		UpdateNativeDllPath( nativeDllPath );
	}

	private static void UpdateNativeDllPath( string nativeDllPath )
	{
		// WARNING: this calls into Sandbox.Engine.dll - so we need to put it in
		// this method, which is executed AFTER CurrentDomain_AssemblyResolve is set
		// so that managed can find the correct dll
		NetCore.NativeDllPath = nativeDllPath;

		//
		// Put our native dll path first so that when looking up native dlls we'll
		// always use the ones from our folder first
		//
		var path = System.Environment.GetEnvironmentVariable( "PATH" );
		path = $"{nativeDllPath};{path}";
		System.Environment.SetEnvironmentVariable( "PATH", path );
	}

	private static Assembly CurrentDomain_AssemblyResolve( object sender, ResolveEventArgs args )
	{
		var trim = args.Name.Split( ',' )[0];

		var name = $"{ManagedDllPath}/{trim}.dll";

		// dlls with resources inside appear as a different name
		name = name.Replace( ".resources.dll", ".dll" );

		if ( System.IO.File.Exists( name ) )
		{
			return Assembly.LoadFrom( name );
		}

		return null;
	}

	static string NormalizeEngineLib( string? value )
	{
		if ( string.IsNullOrWhiteSpace( value ) )
			return string.Empty;

		return value.Trim();
	}

	static string GetDefaultEngineLibName()
	{
		if ( OperatingSystem.IsLinux() )
			return "libengine2.so";
		if ( OperatingSystem.IsWindows() )
			return "engine2.dll";
		return "libengine2.dylib";
	}
}
