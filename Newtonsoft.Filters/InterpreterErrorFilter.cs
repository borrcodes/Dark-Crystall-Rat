using Newtonsoft.Pools;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Filters
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	[Guid("56a868c0-0ad4-11ce-b03a-0020af0ba770")]
	[ComVisible(true)]
	internal interface InterpreterErrorFilter
	{
		[PreserveSig]
		int _0001(out IntPtr instance);

		[PreserveSig]
		int _0001([MarshalAs(UnmanagedType.I4)] out dateorder reference, out IntPtr cont, out IntPtr field, int remove_SETUP2At);

		[PreserveSig]
		int _0001(int indexlast, out int second);

		[PreserveSig]
		int _0001(int meanres);

		[PreserveSig]
		int _0002(int length_v);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.I4)] dateorder init, IntPtr cfg, IntPtr dir);

		[PreserveSig]
		int _0001(IntPtr last, int visitor_high, IntPtr dir);

		[PreserveSig]
		int _0003(int setup_amount);

		[PreserveSig]
		int _0001(out int var1);
	}
}
