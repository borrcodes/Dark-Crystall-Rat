using System;
using System.Runtime.InteropServices;

namespace GDBD.Specifications
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ad4c1b00-4bf7-422f-9175-756693d9130d")]
	public interface ProcessClassSpec
	{
		void _0001(ref int config);

		void _0001(ref long first);

		void _0001(long no__first);

		void _0002(ref long param);

		void _0002(long row_var1);

		void _0001([MarshalAs(UnmanagedType.Bool)] ref bool info);

		void _0001(IntPtr setup, int insertCONTAt, ref int filter);

		void _0001(IntPtr reference, int version_b, IntPtr serv, IntPtr visitor2);

		void _0001(IntPtr i, ref int caller);

		void _0002(IntPtr reference, int tokencounter, ref int rule);

		void _0002(IntPtr spec, int end_b, IntPtr res, IntPtr ord2);

		void _0002(IntPtr last, ref int caller);

		void _0001(int lengthfirst, long no_token, int pool, ref long result2);

		void _0001();

		void _0002();
	}
}
