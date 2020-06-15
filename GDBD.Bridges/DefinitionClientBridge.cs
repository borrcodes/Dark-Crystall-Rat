using System;
using System.Runtime.InteropServices;

namespace GDBD.Bridges
{
	[ComImport]
	[Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface DefinitionClientBridge
	{
		[PreserveSig]
		int _0001(double spec, IntPtr selection);

		[PreserveSig]
		int _0001(double reference, IntPtr result, int third_Position);
	}
}
