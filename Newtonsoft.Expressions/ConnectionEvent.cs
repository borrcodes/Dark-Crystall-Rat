using GDBD.Bridges;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	internal sealed class ConnectionEvent
	{
		public readonly int m_InitializerEvent;

		public readonly BreakpointType m_ObjectEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ConnectionEvent(int versionfirst, BreakpointType cust)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_InitializerEvent = versionfirst;
			m_ObjectEvent = cust;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConnectionEvent CustomizeInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ConnectionEvent(-1, (BreakpointType)0);
		}
	}
}
