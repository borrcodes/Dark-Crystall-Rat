using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	internal sealed class ParameterRequestStrategy : ValueRequestStrategy
	{
		[CompilerGenerated]
		private int _RecordReader;

		[CompilerGenerated]
		private readonly bool eventReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RecordReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(int param_max)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RecordReader = param_max;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return eventReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterRequestStrategy(object config, bool haveb)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(config, (ChildRunStatus)2);
			eventReader = haveb;
		}
	}
}
