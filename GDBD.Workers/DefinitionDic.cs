using GDBD.Mocks;
using Newtonsoft.Candidates;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Workers
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c40a00f2-b93a-4d80-ae8c-5a1c634f58e4")]
	public interface DefinitionDic : MapperIssuerMock
	{
		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, [In] [Out] IntPtr connection);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, out int b);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, IntPtr col, [MarshalAs(UnmanagedType.Bool)] out bool temp);

		new void _0001([MarshalAs(UnmanagedType.Interface)] MapperIssuerMock init, int caller_min, [MarshalAs(UnmanagedType.Bool)] out bool proc);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, out int reg);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, out long reg);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, out double pred);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, out Guid b);

		new void _0003([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, out int token);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid instance, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder cfg, int consumerhigh, out int var12);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, [MarshalAs(UnmanagedType.LPWStr)] out string col, out int c);

		new void _0004([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, out int second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [Out] [MarshalAs(UnmanagedType.LPArray)] byte[] col, int consumer_length, out int param2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid instance, out IntPtr connection, out int comp);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid attr, [MarshalAs(UnmanagedType.IUnknown)] out object res);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, IntPtr result);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid init);

		new void _0001();

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, int maxresult);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid res, long ID_counter);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid instance, double col);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid counter);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [In] [MarshalAs(UnmanagedType.LPWStr)] string vis);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] token, int filter_Z);

		new void _0001([MarshalAs(UnmanagedType.LPStruct)] Guid setup, [In] [MarshalAs(UnmanagedType.IUnknown)] object cust);

		new void _0002();

		new void _0003();

		new void _0001(out int reference);

		new void _0001(int lengthitem, out Guid counter, [In] [Out] IntPtr res);

		new void _0001([In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock ident);

		void _0002(out int reference);

		void _0001(int num_asset);

		void _0001(out long spec);

		void _0001(long last_length);

		void _0002(out long last);

		void _0002(long flags_last);

		void _0003(out int first);

		void _0001(int end_ident, out InvocationDic attr);

		void _0001(out InvocationDic info);

		void _0001(InvocationDic reference);

		void _0002(int num_first);

		void _0004();

		void _0004(out int last);

		void _0002(InvocationDic param);
	}
}
