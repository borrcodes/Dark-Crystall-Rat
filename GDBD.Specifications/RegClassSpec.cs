using GDBD.Mocks;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Specifications
{
	[ComImport]
	[Guid("E7FE2E12-661C-40DA-92F9-4F002AB67627")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface RegClassSpec
	{
		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item, [In] [MarshalAs(UnmanagedType.LPWStr)] string caller, [In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock consumer, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup2, [MarshalAs(UnmanagedType.Interface)] out object t3);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [In] [MarshalAs(UnmanagedType.IUnknown)] object pred, [In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock tag, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid attr2, [MarshalAs(UnmanagedType.Interface)] out object ord3);
	}
}
