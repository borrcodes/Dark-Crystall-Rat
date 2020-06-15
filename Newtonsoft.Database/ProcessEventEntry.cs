using GDBD.Dispatcher;
using GDBD.Items;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Database
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
	internal interface ProcessEventEntry
	{
		[PreserveSig]
		int _0001([In] SerializerTestItem v, [In] [MarshalAs(UnmanagedType.LPWStr)] string counter);

		[PreserveSig]
		int _0001([In] SerializerTestItem i);

		[PreserveSig]
		int _0001(out IntPtr init);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string asset, out SerializerTestItem map);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher config, [In] RefBroadcasterDispatcher visitor, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate comp);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher init);

		[PreserveSig]
		int _0002([In] RefBroadcasterDispatcher instance);

		[PreserveSig]
		int _0001();
	}
}
