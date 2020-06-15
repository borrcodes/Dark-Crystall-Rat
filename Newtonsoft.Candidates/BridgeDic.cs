using Newtonsoft.Expressions;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Candidates
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("F294ACFC-3146-4483-A7BF-ADDCA7C260E2")]
	internal interface BridgeDic
	{
		int _0001(int min_last, out IntPtr second);

		int _0001(int init, SigningOption selection);
	}
}
