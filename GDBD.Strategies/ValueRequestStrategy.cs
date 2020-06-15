using GDBD.Structs;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	internal class ValueRequestStrategy : SystemPropertyStruct
	{
		private readonly object m_ThreadIssuer;

		private readonly ChildRunStatus consumerIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueRequestStrategy(object first, ChildRunStatus map)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_ThreadIssuer = first;
			consumerIssuer = map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ThreadIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ChildRunStatus _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return consumerIssuer;
		}
	}
}
