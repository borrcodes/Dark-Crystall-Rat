using System.Runtime.InteropServices;

namespace GDBD.Dispatcher
{
	[ComImport]
	[Guid("56A86892-0AD4-11CE-B03A-0020AF0BA770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface SchemaBroadcasterDispatcher
	{
		[PreserveSig]
		int _0001([In] int previous_spec, [Out] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] RefBroadcasterDispatcher[] selection, out int filter);

		[PreserveSig]
		int _0001([In] int indexOfconfig);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001(out SchemaBroadcasterDispatcher i);
	}
}
