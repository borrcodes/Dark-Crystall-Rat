using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Mocks
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
	public interface MapperIssuerMock
	{
		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item, [In] [Out] IntPtr cust);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid var1, out int cust);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid res, IntPtr token, [MarshalAs(UnmanagedType.Bool)] out bool res);

		void _0001([MarshalAs(UnmanagedType.Interface)] MapperIssuerMock first, int nextpol, [MarshalAs(UnmanagedType.Bool)] out bool state);

		void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, out int cont);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid instance, out long vis);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, out double cfg);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid init, out Guid result);

		void _0003([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item, out int b);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid asset, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder selection, int stateHigh, out int token2);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [MarshalAs(UnmanagedType.LPWStr)] out string b, out int tag);

		void _0004([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, out int cfg);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid v, [Out] [MarshalAs(UnmanagedType.LPArray)] byte[] attr, int resY, out int config2);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, out IntPtr ivk, out int third);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid def, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid ord, [MarshalAs(UnmanagedType.IUnknown)] out object consumer);

		void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid var1, IntPtr col);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task);

		void _0001();

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid init, int second_end);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, long counter);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, double visitor);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid attr);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, [In] [MarshalAs(UnmanagedType.LPWStr)] string col);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] vis, int consumer);

		void _0001([MarshalAs(UnmanagedType.LPStruct)] Guid task, [In] [MarshalAs(UnmanagedType.IUnknown)] object pred);

		void _0002();

		void _0003();

		void _0001(out int setup);

		void _0001(int init, out Guid ord, [In] [Out] IntPtr third);

		void _0001([In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock var1);
	}
}
