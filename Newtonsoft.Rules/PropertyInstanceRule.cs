using GDBD.Filter;
using GDBD.Maps;
using Newtonsoft.Common;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Rules
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1CB9AD4C-DBFA-4c32-B178-C2F568A703B2")]
	internal interface PropertyInstanceRule
	{
		[PreserveSig]
		int _0001(CompositingMode res, BreakBinarySubtractionValues caller, long positionrule, long last2_max, [In] RefList pol3, [In] ref Guid token4);

		int _0001(out uint i);

		[return: MarshalAs(UnmanagedType.I8)]
		long _0001();

		int _0001(out int v);

		[PreserveSig]
		int _0001(CompositingMode def, [In] RefList map, IntPtr filter);

		int _0001(out IntPtr var1);

		int _0001(out long asset, out long connection);

		int _0001();

		int _0002();

		int _0003();

		int _0001(IntPtr var1);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid i, [MarshalAs(UnmanagedType.IUnknown)] out object connection);
	}
}
