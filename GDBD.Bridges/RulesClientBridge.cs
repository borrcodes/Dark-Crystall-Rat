using Newtonsoft.Candidates;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	internal static class RulesClientBridge
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CalculateIssuer(WatcherComposer config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((uint)(config - 13) <= 2u)
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GetIssuer(WatcherComposer def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((uint)(def - 1) <= 2u)
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool StartIssuer(WatcherComposer def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((uint)(def - 7) <= 5u || (uint)(def - 16) <= 1u)
			{
				return true;
			}
			return false;
		}
	}
}
