using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace GDBD.Workers
{
	[ComImport]
	[Guid("29840822-5B84-11D0-BD3B-00A0C911CE86")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface InterceptorComposerWorker
	{
		[PreserveSig]
		int _0001([In] ref Guid reference, out IEnumMoniker counter, [In] int previous_rule);
	}
}
