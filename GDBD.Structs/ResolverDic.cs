using GDBD.Mocks;
using Newtonsoft.Annotations;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	internal static class ResolverDic
	{
		private static bool _PoolDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_PoolDic)
			{
				int num = 2;
				OperatingSystem oSVersion = Environment.OSVersion;
				if (oSVersion.Version.Major == 6 && oSVersion.Version.Minor == 0)
				{
					num = 1;
				}
				ValDic.MapError((num << 16) | 0x70);
				_PoolDic = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PredicateIssuerMock EnableError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValDic.InsertError(out PredicateIssuerMock info);
			return info;
		}
	}
}
