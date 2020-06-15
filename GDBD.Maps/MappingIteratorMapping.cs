using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	internal abstract class MappingIteratorMapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint[] DisableDic(byte[] task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint[] array2 = default(uint[]);
			do
			{
				uint[] array = new uint[4];
				if (0 == 0)
				{
					array2 = array;
				}
				array2[0] = QueueList.InsertDic(task, 0);
			}
			while (2 == 0);
			array2[1] = QueueList.InsertDic(task, 4);
			array2[2] = QueueList.InsertDic(task, 8);
			array2[3] = QueueList.InsertDic(task, 12);
			return array2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VerifyDic(uint[] first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool flag;
			do
			{
				int num = (int)first[3];
				if (4u != 0)
				{
					num &= 1;
				}
				bool num2 = num != 0;
				if (4u != 0)
				{
					flag = num2;
				}
			}
			while (-1 == 0);
			if (0 == 0)
			{
				FindDic(first);
			}
			if (7 == 0 || flag)
			{
				uint[] array;
				(array = first)[0] = (uint)((int)array[0] ^ -520093696);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PatchDic(uint[] res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num;
			if (0 == 0)
			{
				num = 8;
				goto IL_000b;
			}
			goto IL_0017;
			IL_000b:
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = num;
			}
			goto IL_002f;
			IL_0017:
			if (0 == 0)
			{
				VerifyDic(res);
			}
			num = num2 - 1;
			if (7 == 0)
			{
				goto IL_000b;
			}
			if (uint.MaxValue != 0)
			{
				num2 = num;
			}
			goto IL_002f;
			IL_002f:
			while (num2 == 0)
			{
				if (false)
				{
					continue;
				}
				return;
			}
			goto IL_0017;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FindDic(uint[] asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = default(int);
			if (0 == 0)
			{
				num = 0;
			}
			int num2 = 0;
			while (true)
			{
				uint num3;
				if (true)
				{
					num3 = (uint)num2;
				}
				while (true)
				{
					uint num4 = asset[num];
					uint num5;
					if (8u != 0)
					{
						num5 = num4;
					}
					if (8 == 0)
					{
						continue;
					}
					asset[num] = ((num5 >> 1) | num3);
					if (uint.MaxValue != 0)
					{
						if (++num == 4)
						{
							return;
						}
						num2 = (int)num5;
						if (false)
						{
							break;
						}
						int num6 = num2 << 31;
						if (4u != 0)
						{
							num3 = (uint)num6;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ValidateDic(byte[] value, byte[] cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = default(int);
			if (0 == 0)
			{
				num = 15;
			}
			while (true)
			{
				int num2;
				int num3;
				if (4u != 0)
				{
					num2 = num;
					num3 = 0;
					if (num3 != 0 || num3 != 0)
					{
						goto IL_0023;
					}
					if (num2 < num3)
					{
						break;
					}
				}
				byte[] array;
				byte[] array2 = array = value;
				int num4 = num;
				IntPtr intPtr = (IntPtr)num4;
				array2[num4] = (byte)(array[(long)intPtr] ^ cust[num]);
				num2 = num;
				num3 = 1;
				goto IL_0023;
				IL_0023:
				int num5 = num2 - num3;
				if (7u != 0)
				{
					num = num5;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OrderDic(uint[] setup, uint[] pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = default(int);
			do
			{
				if (0 == 0)
				{
					num = 3;
				}
				while (true)
				{
					int num2 = num;
					if (false)
					{
						goto IL_0020;
					}
					int num3 = 0;
					goto IL_0037;
					IL_0037:
					if (num2 < num3)
					{
						break;
					}
					uint[] array;
					uint[] array2 = array = setup;
					int num4 = num;
					IntPtr intPtr = (IntPtr)num4;
					array2[num4] = (array[(long)intPtr] ^ pred[num]);
					num2 = num;
					goto IL_0020;
					IL_0020:
					num3 = 1;
					if (num3 != 0)
					{
						int num5 = num2 - num3;
						if (4u != 0)
						{
							num = num5;
						}
						continue;
					}
					goto IL_0037;
				}
			}
			while (false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected MappingIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
