using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal sealed class MapperComposerPool : SystemPropertyStruct
	{
		[CompilerGenerated]
		private ParameterRequestStrategy _DicReader;

		[CompilerGenerated]
		private ParameterRequestStrategy m_ErrorReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new ParameterRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DicReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ParameterRequestStrategy v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_DicReader = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ParameterRequestStrategy _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ErrorReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(ParameterRequestStrategy init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ErrorReader = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapperComposerPool(string def, string reg)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001(new ParameterRequestStrategy(def, haveb: false));
			_0002(new ParameterRequestStrategy(reg, haveb: false));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ChildRunStatus _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ChildRunStatus)11;
		}
	}
}
