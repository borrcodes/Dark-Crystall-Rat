using GDBD.Items;
using System.Runtime.InteropServices;

namespace Newtonsoft.Annotations
{
	[ComImport]
	[Guid("56A86893-0AD4-11CE-B03A-0020AF0BA770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface MockListAnnotation
	{
		[PreserveSig]
		int _0001([In] int endspec, [Out] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] SerializerTestItem[] caller, out int role);

		[PreserveSig]
		int _0001([In] int end_info);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001(out MockListAnnotation asset);
	}
}
