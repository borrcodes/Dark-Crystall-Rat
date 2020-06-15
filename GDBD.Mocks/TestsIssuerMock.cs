using GDBD.Dispatcher;
using Newtonsoft.Common;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace GDBD.Mocks
{
	[ComImport]
	[Guid("6A2E0670-28E4-11D0-A18c-00A0C9118956")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface TestsIssuerMock
	{
		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher param, [MarshalAs(UnmanagedType.I4)] out TargetEntryState pol);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher res, [In] [MarshalAs(UnmanagedType.I4)] TargetEntryState connection);

		[PreserveSig]
		int _0002([In] RefBroadcasterDispatcher item, [MarshalAs(UnmanagedType.I4)] out TargetEntryState b);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher param, [MarshalAs(UnmanagedType.I8)] out long pol);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher def, [In] int ID_visitor, [In] Size dir, out long config2);

		[PreserveSig]
		int _0001([In] RefBroadcasterDispatcher setup, [In] int second_amount, [In] Size filter, out int second2, out IntPtr pol3);
	}
}
