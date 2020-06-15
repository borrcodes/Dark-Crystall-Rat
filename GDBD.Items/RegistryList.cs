using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	internal sealed class RegistryList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RegistryList()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StopDic(byte[] info, byte[] selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num2 = default(int);
			int num3;
			while (true)
			{
				int num = info.Length;
				if (0 == 0)
				{
					num2 = num;
				}
				if (false)
				{
					break;
				}
				if (num2 != selection.Length)
				{
					return false;
				}
				if (0 == 0)
				{
					if (uint.MaxValue != 0)
					{
						num3 = 0;
					}
					break;
				}
			}
			while (num2 != 0)
			{
				int num4 = num2;
				int num5 = 1;
				if (num5 != 0)
				{
					int num6 = num4 - num5;
					if (0 == 0)
					{
						num2 = num6;
					}
					if (2 == 0)
					{
						continue;
					}
					num4 = num3;
					num5 = (info[num2] ^ selection[num2]);
				}
				int num7 = num4 | num5;
				if (true)
				{
					num3 = num7;
				}
			}
			return num3 == 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] CloneDic(byte[] first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first != null)
			{
				return (byte[])first.Clone();
			}
			return null;
		}
	}
}
