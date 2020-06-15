using GDBD.Dispatcher;
using GDBD.Items;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace GDBD.Mocks
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("36B73882-C2C8-11CF-8B46-00805F6CEF60")]
	internal interface MethodIssuerMock
	{
		[PreserveSig]
		int _0001([In] SerializerTestItem def, [In] [MarshalAs(UnmanagedType.LPWStr)] string attr);

		[PreserveSig]
		int _0001([In] SerializerTestItem task);

		[PreserveSig]
		int _0001(out MockListAnnotation key);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string init, out SerializerTestItem selection);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher init, [In] RefBroadcasterDispatcher cfg, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate control);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher i);

		[PreserveSig]
		int _0002([In] RefBroadcasterDispatcher ident);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher task, [In] RefBroadcasterDispatcher result);

		[PreserveSig]
		int _0003([In] RefBroadcasterDispatcher first);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string var1, [In] [MarshalAs(UnmanagedType.LPWStr)] string reg);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string param, [In] [MarshalAs(UnmanagedType.LPWStr)] string reg, out SerializerTestItem helper);

		[PreserveSig]
		int _0001(IntPtr asset);

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0003();

		[PreserveSig]
		int _0001([In] IMoniker def, [In] IBindCtx col, [In] [MarshalAs(UnmanagedType.LPWStr)] string control, out SerializerTestItem instance2);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher first, [In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate map);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher init, [In] int lengthconnection, [In] IntPtr rule);
	}
}
