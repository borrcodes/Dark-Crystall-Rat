using GDBD.Workers;
using Newtonsoft.Annotations;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Filters
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class ServerErrorFilter
	{
		public IntPtr m_WriterList;

		public int _RoleList;

		public int _CreatorList;

		public IntPtr _RuleList;

		public TextPaddingOptions _BridgeList;

		public int _ImporterList;

		public IntPtr _ReponseList;

		public IntPtr m_IndexerList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServerErrorFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
