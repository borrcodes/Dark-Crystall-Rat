using GDBD.Bridges;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Items
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6B652FFF-11FE-4FCE-92AD-0266B5D7C78F")]
	internal interface ComparatorEvent
	{
		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.Bool)] bool explicitparam);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate first);

		[PreserveSig]
		int _0002([Out] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate spec);

		[PreserveSig]
		int _0002([In] [MarshalAs(UnmanagedType.Bool)] bool isparam);

		[PreserveSig]
		int _0001(ref int ident, IntPtr token);

		[PreserveSig]
		int _0001(IntPtr res);

		[PreserveSig]
		int _0001(DefinitionClientBridge i, int endcont);
	}
}
