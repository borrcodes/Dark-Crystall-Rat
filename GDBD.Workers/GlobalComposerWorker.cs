using GDBD.Mocks;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Workers
{
	[ComImport]
	[Guid("7FEE9E9A-4A89-47a6-899C-B6A53A70FB67")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface GlobalComposerWorker : MapperIssuerMock
	{
		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid var1, [In] [Out] IntPtr col);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, out int second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, IntPtr caller, [MarshalAs(UnmanagedType.Bool)] out bool temp);

		new void _0001([MarshalAs(UnmanagedType.Interface)] MapperIssuerMock instance, int cfg_Low, [MarshalAs(UnmanagedType.Bool)] out bool rule);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item, out int second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, out long selection);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, out double token);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, out Guid map);

		new void _0003([In] [MarshalAs(UnmanagedType.LPStruct)] Guid v, out int pred);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder selection, int numfilter, out int value2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [MarshalAs(UnmanagedType.LPWStr)] out string token, out int tag);

		new void _0004([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, out int pol);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid res, [Out] [MarshalAs(UnmanagedType.LPArray)] byte[] pred, int remove_COMPAt, out int init2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, out IntPtr visitor, out int pool);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid counter, [MarshalAs(UnmanagedType.IUnknown)] out object res);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid var1, IntPtr pred);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid v);

		new void _0001();

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid spec, int token_amount);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, long ivk);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item, double selection);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid asset, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid cust);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, [In] [MarshalAs(UnmanagedType.LPWStr)] string attr);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] ord, int c_length);

		new void _0001([MarshalAs(UnmanagedType.LPStruct)] Guid res, [In] [MarshalAs(UnmanagedType.IUnknown)] object reg);

		new void _0002();

		new void _0003();

		new void _0001(out int task);

		new void _0001(int i_High, out Guid selection, [In] [Out] IntPtr serv);

		new void _0001([In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock v);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, [MarshalAs(UnmanagedType.Interface)] out object visitor);

		void _0004();

		void _0005();
	}
}
