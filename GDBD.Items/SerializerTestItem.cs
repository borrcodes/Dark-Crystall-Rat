using GDBD.Dispatcher;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Items
{
	[ComImport]
	[Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface SerializerTestItem
	{
		[PreserveSig]
		int _0001(out Guid item);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0001(long column_key);

		[PreserveSig]
		int _0001(int IDinstance, out int cont);

		[PreserveSig]
		int _0001([In] IntPtr param);

		[PreserveSig]
		int _0001(out IntPtr def);

		[PreserveSig]
		int _0001(out SchemaBroadcasterDispatcher value);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string init, out RefBroadcasterDispatcher ord);

		[PreserveSig]
		int _0001(out BroadcasterFilter res);

		[PreserveSig]
		int _0001([In] ProcessEventEntry reference, [In] [MarshalAs(UnmanagedType.LPWStr)] string second);

		[PreserveSig]
		int _0001([MarshalAs(UnmanagedType.LPWStr)] out string key);
	}
}
