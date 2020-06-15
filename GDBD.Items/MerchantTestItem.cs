using GDBD.Mappers;
using GDBD.Mocks;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Items
{
	[ComImport]
	[Guid("DF598932-F10C-4E39-BBA2-C308F101DAA3")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface MerchantTestItem : MapperIssuerMock
	{
		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, [In] [Out] IntPtr pol);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid reference, out int result);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid key, IntPtr ord, [MarshalAs(UnmanagedType.Bool)] out bool state);

		new void _0001([MarshalAs(UnmanagedType.Interface)] MapperIssuerMock param, int caller, [MarshalAs(UnmanagedType.Bool)] out bool util);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid def, out int pol);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, out long reg);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, out double result);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param, out Guid result);

		new void _0003([In] [MarshalAs(UnmanagedType.LPStruct)] Guid first, out int cfg);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder col, int pool_Position, out int cont2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid spec, [MarshalAs(UnmanagedType.LPWStr)] out string result, out int helper);

		new void _0004([In] [MarshalAs(UnmanagedType.LPStruct)] Guid setup, out int map);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid ident, [Out] [MarshalAs(UnmanagedType.LPArray)] byte[] map, int comp_Position, out int last2);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, out IntPtr pred, out int control);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid asset, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid vis, [MarshalAs(UnmanagedType.IUnknown)] out object dir);

		new void _0002([In] [MarshalAs(UnmanagedType.LPStruct)] Guid instance, IntPtr ivk);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid param);

		new void _0001();

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid info, int ivk);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid task, long b);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, double selection);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid pol);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid config, [In] [MarshalAs(UnmanagedType.LPWStr)] string result);

		new void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid res, [In] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] attr, int helper_Position);

		new void _0001([MarshalAs(UnmanagedType.LPStruct)] Guid setup, [In] [MarshalAs(UnmanagedType.IUnknown)] object reg);

		new void _0002();

		new void _0003();

		new void _0001(out int last);

		new void _0001(int reference, out Guid selection, [In] [Out] IntPtr filter);

		new void _0001([In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock instance);

		void _0001(out TemplateNodeSelectionState i);

		void _0001(out Guid first);

		void _0002([MarshalAs(UnmanagedType.Error)] out int spec);

		void _0001([Out] IntPtr info);
	}
}
