using GDBD.Filter;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Newtonsoft.Consumers
{
	[ComImport]
	[Guid("6d6cbb60-a223-44aa-842f-a2f06750be6d")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[SuppressUnmanagedCodeSecurity]
	internal interface RepositoryList
	{
		[PreserveSig]
		int _0001(out int v);

		[PreserveSig]
		int _0001(int IDfirst, ref ServiceBroadcasterFilter counter);

		[PreserveSig]
		int _0001(int index_param, out IntPtr ivk);

		[PreserveSig]
		int _0002(out int first);

		[PreserveSig]
		int _0001(int idx_item, out Guid connection);

		[PreserveSig]
		int _0001(out Guid last, out int reg);
	}
}
