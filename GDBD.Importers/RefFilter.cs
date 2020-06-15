using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	internal sealed class RefFilter : SchemaFilter
	{
		private readonly uint[][][] _ThreadFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(byte[] config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ThreadFilter[0] = new uint[16][];
			_ThreadFilter[1] = new uint[16][];
			_ThreadFilter[0][0] = new uint[4];
			_ThreadFilter[1][0] = new uint[4];
			_ThreadFilter[1][8] = MappingIteratorMapping.DisableDic(config);
			int num = default(int);
			if (0 == 0)
			{
				num = 4;
			}
			uint[] array = default(uint[]);
			while (true)
			{
				if (num >= 1)
				{
					uint[] obj = (uint[])_ThreadFilter[1][num + num].Clone();
					if (0 == 0)
					{
						array = obj;
					}
					uint[] first = array;
					if (0 == 0)
					{
						MappingIteratorMapping.VerifyDic(first);
					}
					_ThreadFilter[1][num] = array;
					int num2 = num >> 1;
					if (4u != 0)
					{
						num = num2;
					}
					continue;
				}
				uint[] obj2 = (uint[])_ThreadFilter[1][1].Clone();
				uint[] array2;
				if (5u != 0)
				{
					array2 = obj2;
				}
				if (0 == 0)
				{
					MappingIteratorMapping.VerifyDic(array2);
				}
				_ThreadFilter[0][8] = array2;
				for (int num3 = 4; num3 >= 1; num3 >>= 1)
				{
					uint[] array3 = (uint[])_ThreadFilter[0][num3 + num3].Clone();
					MappingIteratorMapping.VerifyDic(array3);
					_ThreadFilter[0][num3] = array3;
				}
				int num4 = 0;
				while (true)
				{
					for (int i = 2; i < 16; i += i)
					{
						for (int j = 1; j < i; j++)
						{
							uint[] array4 = (uint[])_ThreadFilter[num4][i].Clone();
							MappingIteratorMapping.OrderDic(array4, _ThreadFilter[num4][j]);
							_ThreadFilter[num4][i + j] = array4;
						}
					}
					if (++num4 == 32)
					{
						return;
					}
					if (false)
					{
						break;
					}
					if (num4 > 1)
					{
						_ThreadFilter[num4] = new uint[16][];
						_ThreadFilter[num4][0] = new uint[4];
						for (int num5 = 8; num5 > 0; num5 >>= 1)
						{
							uint[] array5 = (uint[])_ThreadFilter[num4 - 2][num5].Clone();
							MappingIteratorMapping.PatchDic(array5);
							_ThreadFilter[num4][num5] = array5;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(byte[] instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint[] array = new uint[4];
			uint[] array2;
			if (7u != 0)
			{
				array2 = array;
			}
			int num;
			if (6u != 0)
			{
				num = 15;
			}
			while (num >= 0)
			{
				uint[] obj = _ThreadFilter[num + num][instance[num] & 0xF];
				uint[] array3;
				if (6u != 0)
				{
					array3 = obj;
				}
				uint[] array4;
				(array4 = array2)[0] = (array4[0] ^ array3[0]);
				(array4 = array2)[1] = (array4[1] ^ array3[1]);
				(array4 = array2)[2] = (array4[2] ^ array3[2]);
				(array4 = array2)[3] = (array4[3] ^ array3[3]);
				uint[] obj2 = _ThreadFilter[num + num + 1][(instance[num] & 0xF0) >> 4];
				if (4u != 0)
				{
					array3 = obj2;
				}
				(array4 = array2)[0] = (array4[0] ^ array3[0]);
				(array4 = array2)[1] = (array4[1] ^ array3[1]);
				(array4 = array2)[2] = (array4[2] ^ array3[2]);
				(array4 = array2)[3] = (array4[3] ^ array3[3]);
				int num2 = num - 1;
				if (7u != 0)
				{
					num = num2;
				}
			}
			uint positionlast = array2[0];
			if (0 == 0)
			{
				QueueList.MapDic(positionlast, instance, 0);
			}
			QueueList.MapDic(array2[1], instance, 4);
			QueueList.MapDic(array2[2], instance, 8);
			QueueList.MapDic(array2[3], instance, 12);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ThreadFilter = new uint[32][][];
			base._002Ector();
		}
	}
}
