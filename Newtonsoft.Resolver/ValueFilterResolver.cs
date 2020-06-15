using _0008;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal static class ValueFilterResolver
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static char[] RegisterIssuer(GDBD.Workers.WrapperComposerWorker<char> v, int ID_vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v == null)
			{
				return new char[ID_vis];
			}
			return v._0001(ID_vis);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RestartIssuer(GDBD.Workers.WrapperComposerWorker<char> ident, char[] cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ident?._0001(cfg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static char[] SearchIssuer(GDBD.Workers.WrapperComposerWorker<char> res, int meancfg, char[] temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (res == null)
			{
				return new char[meancfg];
			}
			if (temp != null)
			{
				res._0001(temp);
			}
			return res._0001(meancfg);
		}
	}
}
