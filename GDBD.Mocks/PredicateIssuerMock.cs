using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Mocks
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("44AE0FA8-EA31-4109-8D2E-4CAE4997C555")]
	public interface PredicateIssuerMock : MapperIssuerMock
	{
		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid v, [In] [Out] IntPtr result);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, out int vis);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, IntPtr second, [MarshalAs(UnmanagedType.Bool)] out bool comp);

		new void _0001([MarshalAs(UnmanagedType.Interface)] MapperIssuerMock i, int mincont, [MarshalAs(UnmanagedType.Bool)] out bool dic);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, out int attr);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid asset, out long pred);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, out double second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, out Guid visitor);

		new void _0003([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, out int second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid reference, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder visitor, int start_dir, out int cont2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, [MarshalAs(UnmanagedType.LPWStr)] out string pol, out int role);

		new void _0004([In] [MarshalAs(UnmanagedType.LPStruct)] Guid var1, out int pol);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [Out] [MarshalAs(UnmanagedType.LPArray)] byte[] map, int insert_CAt, out int def2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, out IntPtr map, out int consumer);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid vis, [MarshalAs(UnmanagedType.IUnknown)] out object control);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid reference, IntPtr visitor);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info);

		new void _0001();

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, int visitorcount);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, long insert_CFGAt);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, double cont);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid last, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid second);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid value, [In] [MarshalAs(UnmanagedType.LPWStr)] string pred);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] connection, int idx_template);

		new void _0001([MarshalAs(UnmanagedType.LPStruct)] Guid key, [In] [MarshalAs(UnmanagedType.IUnknown)] object vis);

		new void _0002();

		new void _0003();

		new void _0001(out int spec);

		new void _0001(int flagsdef, out Guid connection, [In] [Out] IntPtr control);

		new void _0001([In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock param);

		void _0001(out Guid value);

		void _0001([MarshalAs(UnmanagedType.Bool)] out bool asset);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.Interface)] PredicateIssuerMock key, ref int col);

		void _0001([In] Guid res, ref IntPtr col);

		void _0003([In] Guid last, [In] IntPtr second);
	}
}
