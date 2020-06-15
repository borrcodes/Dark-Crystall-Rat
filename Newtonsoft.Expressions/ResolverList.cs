using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Newtonsoft.Expressions
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	[Guid("59eff8b9-938c-4a26-82f2-95cb84cdc837")]
	public interface ResolverList
	{
		[PreserveSig]
		int _0002(int flags_ident);

		[PreserveSig]
		int _0002(out int last);

		[PreserveSig]
		int _0002(IntPtr info, IntPtr map);
	}
}
