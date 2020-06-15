using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Candidates
{
	[ComImport]
	[Guid("045FA593-8799-42b8-BC8D-8968C6453507")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface InvocationDic
	{
		void _0001(out IntPtr v, out int connection, out int dir);

		void _0001();

		void _0001(out int param);

		void _0001(int remove_INSTANCEAt);

		void _0002(out int instance);
	}
}
