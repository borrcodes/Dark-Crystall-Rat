using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	internal sealed class QueueList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private QueueList()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MapDic(uint positionlast, byte[] connection, int role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			connection[role] = (byte)(positionlast >> 24);
			connection[++role] = (byte)(positionlast >> 16);
			connection[++role] = (byte)(positionlast >> 8);
			connection[++role] = (byte)positionlast;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint InsertDic(byte[] task, int idx_reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = task[idx_reg];
			int num2 = 24;
			int num5;
			uint num4 = default(uint);
			while (true)
			{
				int num3 = num << num2;
				if (0 == 0)
				{
					num4 = (uint)num3;
				}
				num5 = (int)num4;
				if (4u != 0)
				{
					if (false)
					{
						break;
					}
					int num6 = task[++idx_reg];
					do
					{
						num6 <<= 16;
					}
					while (-1 == 0);
					num5 |= num6;
				}
				if (true)
				{
					num4 = (uint)num5;
				}
				num = (int)num4;
				num2 = task[++idx_reg] << 8;
				if (0 == 0)
				{
					int num7 = num | num2;
					if (6u != 0)
					{
						num4 = (uint)num7;
					}
					num5 = (int)(num4 | task[++idx_reg]);
					break;
				}
			}
			if (0 == 0)
			{
				num4 = (uint)num5;
			}
			return num4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FlushDic(uint row_ident, byte[] ord, int c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ord[c] = (byte)row_ident;
			ord[++c] = (byte)(row_ident >> 8);
			ord[++c] = (byte)(row_ident >> 16);
			ord[++c] = (byte)(row_ident >> 24);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint CreateDic(byte[] value, int connection_X)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint num2;
			do
			{
				byte num = value[connection_X];
				if (6u != 0)
				{
					num2 = num;
				}
				int num3 = (int)num2 | (value[++connection_X] << 8);
				if (2u != 0)
				{
					num2 = (uint)num3;
				}
				int num4 = (int)num2 | (value[++connection_X] << 16);
				if (0 == 0)
				{
					num2 = (uint)num4;
				}
			}
			while (false);
			int num5 = (int)num2 | (value[++connection_X] << 24);
			if (2u != 0)
			{
				num2 = (uint)num5;
			}
			return num2;
		}
	}
}
