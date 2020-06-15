using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Newtonsoft.Pools
{
	[ComImport]
	[Guid("56a86897-0ad4-11ce-b03a-0020af0ba770")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	internal interface TestComposerPool
	{
		[PreserveSig]
		int _0001(out long def);

		[PreserveSig]
		int _0001([In] long mean_ident, [In] long no__connection, [In] IntPtr proc, out int attr2);

		[PreserveSig]
		int _0002([In] long first_low, [In] long second, [In] IntPtr util, out int pol2);

		[PreserveSig]
		int _0001([In] int instance_length);
	}
}
