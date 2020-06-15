using _0008;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	[_0008._0012(0)]
	internal static class GetterTest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ChangeReader(this InvocationTest init, char connection, int filterPosition, int col2_low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = Array.IndexOf(init._0001(), connection, init._0001() + filterPosition, col2_low);
			if (num == -1)
			{
				return -1;
			}
			return num - init._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CalculateReader(this InvocationTest i, string ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ord.Length > i._0002())
			{
				return false;
			}
			char[] array = i._0001();
			for (int j = 0; j < ord.Length; j++)
			{
				if (ord[j] != array[j + i._0001()])
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool GetReader(this InvocationTest first, string caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (caller.Length > first._0002())
			{
				return false;
			}
			char[] array = first._0001();
			int num = first._0001() + first._0002() - caller.Length;
			for (int i = 0; i < caller.Length; i++)
			{
				if (caller[i] != array[i + num])
				{
					return false;
				}
			}
			return true;
		}
	}
}
