using GDBD.Dispatcher;
using GDBD.Items;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Filter
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
	internal interface PolicyBroadcasterFilter
	{
		[PreserveSig]
		int _0001([In] SerializerTestItem def, [In] [MarshalAs(UnmanagedType.LPWStr)] string visitor);

		[PreserveSig]
		int _0001([In] SerializerTestItem first);

		[PreserveSig]
		int _0001(out MockListAnnotation v);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string config, out SerializerTestItem reg);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher reference, [In] RefBroadcasterDispatcher pred, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate tag);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher res);

		[PreserveSig]
		int _0002([In] RefBroadcasterDispatcher spec);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher ident, [In] RefBroadcasterDispatcher attr);

		[PreserveSig]
		int _0003([In] RefBroadcasterDispatcher ident);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string ident, [In] [MarshalAs(UnmanagedType.LPWStr)] string second);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string task, [In] [MarshalAs(UnmanagedType.LPWStr)] string token, out SerializerTestItem template);

		[PreserveSig]
		int _0001(IntPtr asset);

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0003();
	}
}
