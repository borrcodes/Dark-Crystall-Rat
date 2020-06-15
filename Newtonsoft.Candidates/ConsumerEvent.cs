using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Candidates
{
	[ComImport]
	[Guid("55272A00-42CB-11CE-8135-00AA004BB851")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface ConsumerEvent
	{
		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string instance, [In] [Out] [MarshalAs(UnmanagedType.Struct)] ref object token, [In] IntPtr role);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string first, [In] [MarshalAs(UnmanagedType.Struct)] ref object cfg);
	}
}
