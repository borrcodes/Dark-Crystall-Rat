using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	internal sealed class PageFilterResolver
	{
		[CompilerGenerated]
		private ParameterRequestStrategy _ConfigIssuer;

		[CompilerGenerated]
		private SystemPropertyStruct connectionIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ParameterRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ConfigIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ParameterRequestStrategy task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ConfigIssuer = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public SystemPropertyStruct _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return connectionIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(SystemPropertyStruct task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			connectionIssuer = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PageFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
