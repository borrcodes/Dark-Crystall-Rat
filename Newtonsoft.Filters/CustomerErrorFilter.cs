using System.Runtime.InteropServices;

namespace Newtonsoft.Filters
{
	[ComImport]
	[Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	internal interface CustomerErrorFilter
	{
		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0003();

		[PreserveSig]
		int _0001(int setup, out int cfg);

		[PreserveSig]
		int _0001(string res);

		[PreserveSig]
		int _0001([In] string var1, [MarshalAs(UnmanagedType.IDispatch)] out object b);

		[PreserveSig]
		int _0001([MarshalAs(UnmanagedType.IDispatch)] out object i);

		[PreserveSig]
		int _0002([MarshalAs(UnmanagedType.IDispatch)] out object ident);

		[PreserveSig]
		int _0004();
	}
}
