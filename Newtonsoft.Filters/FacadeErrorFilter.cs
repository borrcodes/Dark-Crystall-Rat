using GDBD.Strategies;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Filters
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct FacadeErrorFilter
	{
		private short _MessageList;

		private short productList;

		private int interceptorList;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		private string algoList;

		private DockPreference annotationList;

		private short m_ExporterList;

		private short visitorList;

		private Guid _GlobalList;

		private Guid _WrapperList;

		private Guid paramsList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return algoList;
		}
	}
}
