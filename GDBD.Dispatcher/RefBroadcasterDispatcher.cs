using GDBD.Structs;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Dispatcher
{
	[ComImport]
	[Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface RefBroadcasterDispatcher
	{
		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher v, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate ivk);

		[PreserveSig]
		int _0002([In] RefBroadcasterDispatcher param, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate cust);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001(out RefBroadcasterDispatcher param);

		[PreserveSig]
		int _0001([Out] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate v);

		[PreserveSig]
		int _0001(out ServerPropertyStruct def);

		[PreserveSig]
		int _0001(out ChildType var1);

		[PreserveSig]
		int _0001([MarshalAs(UnmanagedType.LPWStr)] out string first);

		[PreserveSig]
		int _0002([In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate last);

		[PreserveSig]
		int _0001(IntPtr spec);

		[PreserveSig]
		int _0001(IntPtr setup, [In] [Out] ref int pol);

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0003();

		[PreserveSig]
		int _0004();

		[PreserveSig]
		int _0001(long first_count, long cont_offset, double pool);
	}
}
