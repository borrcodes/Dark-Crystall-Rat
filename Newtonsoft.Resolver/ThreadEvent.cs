using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Items;
using GDBD.Structs;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Resolver
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("93E5A4E0-2D50-11d2-ABFA-00A0C9C6E38D")]
	internal interface ThreadEvent
	{
		[PreserveSig]
		int _0001([In] PolicyBroadcasterFilter key);

		[PreserveSig]
		int _0001(out PolicyBroadcasterFilter task);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid asset, [In] [MarshalAs(UnmanagedType.LPWStr)] string selection, out SerializerTestItem res, out IntPtr var12);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid map, [In] SerializerTestItem tag, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid key2, [MarshalAs(UnmanagedType.IUnknown)] out object map3);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid init, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid result, [In] [MarshalAs(UnmanagedType.IUnknown)] object comp, [In] SerializerTestItem key2, [In] SerializerTestItem config3);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid second, [In] [MarshalAs(UnmanagedType.Interface)] SerializerTestItem role, [In] long idxsetup2, [In] long attr3X, [In] short length_v4, [In] short connection5_X);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string def, [In] long position_ord);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPWStr)] string i, [In] [MarshalAs(UnmanagedType.LPWStr)] string cont, [In] [MarshalAs(UnmanagedType.Bool)] bool applytag, [In] IntPtr cust2);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.IUnknown)] object def, [In] ChildType cfg, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid temp, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid v2, [In] [MarshalAs(UnmanagedType.Bool)] bool containscont3, [In] int indexvalue4, [MarshalAs(UnmanagedType.Interface)] out RefBroadcasterDispatcher counter5);
	}
}
