using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Steamworks
{
	internal static class Platform
	{
		internal const int StructPlatformPackSize = 8;
		
#if WIN
		internal const string LibraryName = "steam_api64";
#else
		internal const string LibraryName = "libsteam_api";
#endif

		internal const CallingConvention CC = CallingConvention.Cdecl;
		internal const int StructPackSize = 4;
	}
}
