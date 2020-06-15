using GDBD.Bridges;
using System.Runtime.InteropServices;
using System.Security;

namespace GDBD.Specifications
{
	[ComImport]
	[SuppressUnmanagedCodeSecurity]
	[Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface DecoratorClassSpec
	{
		[PreserveSig]
		int _0001(out int key, out int counter);

		[PreserveSig]
		int _0001([In] int firstoffset, [In] int cfg);

		[PreserveSig]
		int _0002([In] int res_Z, [In] int no__pred);

		[PreserveSig]
		int _0001([In] int v_Y, out int attr);

		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.Bool)] bool applyinstance, [In] int length_counter, out int temp, out BreakpointType col2);
	}
}
