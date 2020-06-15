using GDBD.Maps;
using Newtonsoft.Candidates;
using System.Runtime.InteropServices;

namespace GDBD.Workers
{
	[ComImport]
	[Guid("C6E13340-30AC-11d0-A18C-00A0C9118956")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface RefEvent
	{
		[PreserveSig]
		int _0001([In] [MarshalAs(UnmanagedType.LPStruct)] PrototypeDicCandidate var1);

		[PreserveSig]
		int _0001([MarshalAs(UnmanagedType.LPStruct)] out PrototypeDicCandidate def);

		[PreserveSig]
		int _0001(out int def, out int token);

		[PreserveSig]
		int _0001([In] int res, [MarshalAs(UnmanagedType.LPStruct)] out PrototypeDicCandidate result, [In] [MarshalAs(UnmanagedType.LPStruct)] TokenizerIteratorMapping filter);
	}
}
