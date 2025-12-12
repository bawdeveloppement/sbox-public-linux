namespace Sandbox.Launcher.SboxAndroid;

/// <summary>
/// Environnement minimal Android : pas d'AssemblyResolve ni de PATH mangé.
/// </summary>
public static class LauncherEnvironment
{
    public static string NativeLibraryName
    {
        get
        {
            var env = System.Environment.GetEnvironmentVariable( "SBOX_ENGINE_LIB" );
            if ( string.IsNullOrWhiteSpace( env ) )
                return "libengine2.so";

            return env.Trim();
        }
    }
    public static string Abi => "arm64-v8a";
}



