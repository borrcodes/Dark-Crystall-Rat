using Newtonsoft.Database;
using System.Runtime.InteropServices;

namespace Newtonsoft.Consumers
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	[ComVisible(false)]
	internal struct BroadcasterFilter
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string m_ClassFilter;

		public ProcessEventEntry m_RequestFilter;
	}
}
