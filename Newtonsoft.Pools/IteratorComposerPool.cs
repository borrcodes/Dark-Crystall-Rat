using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal static class IteratorComposerPool
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ListIssuer(ulong indexOf_asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (indexOf_asset < 10000000000L)
			{
				if (indexOf_asset < 10)
				{
					return 1;
				}
				if (indexOf_asset < 100)
				{
					return 2;
				}
				if (indexOf_asset < 1000)
				{
					return 3;
				}
				if (indexOf_asset < 10000)
				{
					return 4;
				}
				if (indexOf_asset < 100000)
				{
					return 5;
				}
				if (indexOf_asset < 1000000)
				{
					return 6;
				}
				if (indexOf_asset < 10000000)
				{
					return 7;
				}
				if (indexOf_asset < 100000000)
				{
					return 8;
				}
				if (indexOf_asset < 1000000000)
				{
					return 9;
				}
				return 10;
			}
			if (indexOf_asset < 100000000000L)
			{
				return 11;
			}
			if (indexOf_asset < 1000000000000L)
			{
				return 12;
			}
			if (indexOf_asset < 10000000000000L)
			{
				return 13;
			}
			if (indexOf_asset < 100000000000000L)
			{
				return 14;
			}
			if (indexOf_asset < 1000000000000000L)
			{
				return 15;
			}
			if (indexOf_asset < 10000000000000000L)
			{
				return 16;
			}
			if (indexOf_asset < 100000000000000000L)
			{
				return 17;
			}
			if (indexOf_asset < 1000000000000000000L)
			{
				return 18;
			}
			if (indexOf_asset < 10000000000000000000uL)
			{
				return 19;
			}
			return 20;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static char SelectIssuer(int initX)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (initX <= 9)
			{
				return (char)(initX + 48);
			}
			return (char)(initX - 10 + 97);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DeleteIssuer(double def, double counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == counter)
			{
				return true;
			}
			double num = (Math.Abs(def) + Math.Abs(counter) + 10.0) * 2.2204460492503131E-16;
			double num2 = def - counter;
			if (0.0 - num < num2)
			{
				return num > num2;
			}
			return false;
		}
	}
}
