using GDBD.Importers;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Rules
{
	internal sealed class EventInstanceRule : ParamsIssuerImporter
	{
		private static readonly byte[] m_SingletonFilter;

		private static readonly byte[] m_ModelFilter;

		private static readonly byte[] m_MessageFilter;

		private static readonly uint[] _ProductFilter;

		private static readonly uint[] interceptorFilter;

		private static readonly uint[] _AlgoFilter;

		private static readonly uint[] _AnnotationFilter;

		private static readonly uint[] _ExporterFilter;

		private static readonly uint[] m_VisitorFilter;

		private static readonly uint[] m_GlobalFilter;

		private static readonly uint[] m_WrapperFilter;

		private int paramsFilter;

		private uint[,] _TemplateFilter;

		private uint m_ExpressionFilter;

		private uint m_ConfigFilter;

		private uint connectionFilter;

		private uint initializerFilter;

		private bool m_ObjectFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint DefineInstance(uint setup_X, int token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = (int)setup_X;
			int num2 = token;
			int num3 = 31;
			while (true)
			{
				num2 &= num3;
				while (true)
				{
					num = (int)((uint)num >> num2);
					num2 = (int)setup_X;
					if (0 == 0)
					{
						num3 = ((32 - token) & 0x1F);
						if (false)
						{
							break;
						}
						num2 <<= num3;
						if (4u != 0)
						{
							return (uint)(num | num2);
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint CollectInstance(uint reference_max)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint num = (reference_max & 0x7F7F7F7F) << 1;
			int num2 = (int)reference_max;
			while (true)
			{
				int num3;
				if (0 == 0)
				{
					num3 = -2139062144;
					goto IL_0019;
				}
				goto IL_001c;
				IL_0019:
				num2 = (int)((uint)(num2 & num3) >> 7);
				goto IL_001c;
				IL_001c:
				num3 = 27;
				if (num3 != 0)
				{
					num2 *= num3;
					if (4u != 0)
					{
						break;
					}
					continue;
				}
				goto IL_0019;
			}
			return (uint)((int)num ^ num2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint SortInstance(uint indexlast)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint num = CollectInstance(indexlast);
			uint num2 = default(uint);
			if (0 == 0)
			{
				num2 = num;
			}
			uint num4;
			uint num6 = default(uint);
			uint num7 = default(uint);
			do
			{
				uint num3 = CollectInstance(num2);
				if (8u != 0)
				{
					num4 = num3;
				}
				uint num5 = CollectInstance(num4);
				do
				{
					if (0 == 0)
					{
						num6 = num5;
					}
					num5 = (indexlast ^ num6);
				}
				while (false);
				if (0 == 0)
				{
					num7 = num5;
				}
			}
			while (false);
			int num8 = (int)(num2 ^ num4);
			uint num9 = num6;
			do
			{
				num8 ^= (int)num9;
				num9 = DefineInstance(num2 ^ num7, 8);
				if (0 == 0)
				{
					num8 ^= (int)num9;
					num9 = DefineInstance(num4 ^ num7, 16);
				}
			}
			while (false);
			return (uint)(num8 ^ (int)num9 ^ (int)DefineInstance(num7, 24));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint CallInstance(uint position_i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (uint)(m_SingletonFilter[position_i & 0xFF] | (m_SingletonFilter[(position_i >> 8) & 0xFF] << 8) | (m_SingletonFilter[(position_i >> 16) & 0xFF] << 16) | (m_SingletonFilter[(position_i >> 24) & 0xFF] << 24));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint[,] PublishInstance(byte[] key, bool iscol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = key.Length / 4;
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = num;
			}
			int num3 = num2;
			int num4 = 4;
			int num8 = default(int);
			while (true)
			{
				int num5;
				int num6;
				if (num3 != num4)
				{
					num5 = num2;
					num6 = 6;
					goto IL_0019;
				}
				goto IL_002b;
				IL_0019:
				if (num5 != num6)
				{
					num3 = num2;
					num4 = 8;
					if (num4 == 0)
					{
						continue;
					}
					if (num3 != num4)
					{
						break;
					}
				}
				goto IL_002b;
				IL_002b:
				if (num2 * 4 != key.Length)
				{
					break;
				}
				paramsFilter = num2 + 6;
				uint[,] array = new uint[paramsFilter + 1, 4];
				uint[,] array2;
				if (2u != 0)
				{
					array2 = array;
				}
				int num7;
				if (5u != 0)
				{
					num7 = 0;
				}
				if (0 == 0)
				{
					num8 = 0;
				}
				while (true)
				{
					if (num8 < key.Length)
					{
						if (0 == 0)
						{
							int num9 = num7 >> 2;
							int num10 = num7 & 3;
							uint num11 = QueueList.CreateDic(key, num8);
							if (0 == 0)
							{
								array2[num9, num10] = num11;
							}
							int num12 = num8 + 4;
							if (0 == 0)
							{
								num8 = num12;
							}
							num7++;
							continue;
						}
						goto IL_016b;
					}
					num5 = paramsFilter;
					num6 = 1;
					if (num6 == 0)
					{
						break;
					}
					int num13 = num5 + num6;
					int num14 = 2;
					while (true)
					{
						IL_00b9:
						int num15 = num13 << num14;
						uint num17;
						for (int i = num2; i < num15; array2[i >> 2, i & 3] = (array2[i - num2 >> 2, (i - num2) & 3] ^ num17), i++)
						{
							uint num16 = array2[i - 1 >> 2, (i - 1) & 3];
							if (6u != 0)
							{
								num17 = num16;
								num13 = i;
								num14 = num2;
								if (7 == 0)
								{
									goto IL_00b9;
								}
								if (num13 % num14 != 0)
								{
									if (num2 > 6 && i % num2 == 4)
									{
										num17 = CallInstance(num17);
									}
									continue;
								}
								num16 = CallInstance(DefineInstance(num17, 8));
							}
							num17 = (num16 ^ m_MessageFilter[i / num2 - 1]);
						}
						break;
					}
					int num18;
					if (!iscol)
					{
						num18 = 1;
						goto IL_01a1;
					}
					goto IL_01ae;
					IL_016b:
					for (int j = 0; j < 4; j++)
					{
						array2[num18, j] = SortInstance(array2[num18, j]);
					}
					num18++;
					goto IL_01a1;
					IL_01a1:
					if (num18 < paramsFilter)
					{
						goto IL_016b;
					}
					goto IL_01ae;
					IL_01ae:
					return array2;
				}
				goto IL_0019;
			}
			throw new ArgumentException("Key length not 128/192/256 bits.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EventInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(bool setupreguired, AccountFilter connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!(connection is MapperList) && 0 == 0)
			{
				throw new ArgumentException("invalid parameter passed to AES init - " + connection.GetType().ToString());
			}
			if (0 == 0)
			{
				_TemplateFilter = PublishInstance(((MapperList)connection).AddDic(), setupreguired);
			}
			m_ObjectFilter = setupreguired;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return 16;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int _0001(byte[] reference, int indexb, byte[] rule, int no__selection2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_TemplateFilter == null)
			{
				throw new InvalidOperationException("AES engine not initialised");
			}
			int num = indexb + 16;
			int num2 = reference.Length;
			IntPtr intPtr = (IntPtr)num2;
			do
			{
				if (num > num2)
				{
					throw new ReaderComposerPool("input buffer too short");
				}
				num = no__selection2 + 16;
				intPtr = (IntPtr)(void*)rule.LongLength;
			}
			while (false);
			if (num > (int)(long)intPtr)
			{
				throw new ReaderComposerPool("output buffer too short");
			}
			while (true)
			{
				if (0 == 0)
				{
					WriteInstance(reference, indexb);
				}
				while (true)
				{
					if (m_ObjectFilter)
					{
						uint[,] templateFilter = _TemplateFilter;
						if (0 == 0)
						{
							LoginDic(templateFilter);
						}
					}
					else if (0 == 0)
					{
						uint[,] templateFilter2 = _TemplateFilter;
						if (0 == 0)
						{
							CheckDic(templateFilter2);
						}
					}
					if (false)
					{
						break;
					}
					if (0 == 0)
					{
						RevertInstance(rule, no__selection2);
					}
					if (5u != 0)
					{
						return 16;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteInstance(byte[] value, int selection_count)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (0 == 0)
			{
				m_ExpressionFilter = QueueList.CreateDic(value, selection_count);
				if (8u != 0)
				{
					m_ConfigFilter = QueueList.CreateDic(value, selection_count + 4);
					goto IL_002c;
				}
				goto IL_003b;
			}
			return;
			IL_003b:
			if (0 == 0)
			{
				initializerFilter = QueueList.CreateDic(value, selection_count + 12);
				return;
			}
			goto IL_002c;
			IL_002c:
			connectionFilter = QueueList.CreateDic(value, selection_count + 8);
			goto IL_003b;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevertInstance(byte[] value, int insert_ATTRAt)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (false)
			{
				return;
			}
			uint expressionFilter = m_ExpressionFilter;
			while (true)
			{
				if (0 == 0)
				{
					QueueList.FlushDic(expressionFilter, value, insert_ATTRAt);
				}
				uint configFilter = m_ConfigFilter;
				int c = insert_ATTRAt + 4;
				if (0 == 0)
				{
					QueueList.FlushDic(configFilter, value, c);
				}
				while (true)
				{
					expressionFilter = connectionFilter;
					if (7 == 0)
					{
						break;
					}
					int c2 = insert_ATTRAt + 8;
					if (0 == 0)
					{
						QueueList.FlushDic(expressionFilter, value, c2);
					}
					if (0 == 0)
					{
						uint row_ident = initializerFilter;
						int c3 = insert_ATTRAt + 12;
						if (4u != 0)
						{
							QueueList.FlushDic(row_ident, value, c3);
						}
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoginDic(uint[,] key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ExpressionFilter ^= key[0, 0];
			m_ConfigFilter ^= key[0, 1];
			connectionFilter ^= key[0, 2];
			initializerFilter ^= key[0, 3];
			int num;
			if (8u != 0)
			{
				num = 1;
			}
			uint num4 = default(uint);
			uint num6 = default(uint);
			uint num10 = default(uint);
			while (true)
			{
				int num2 = num;
				uint num7;
				uint num8;
				uint num9;
				while (true)
				{
					if (num2 < paramsFilter - 1)
					{
						uint num3 = _ProductFilter[m_ExpressionFilter & 0xFF] ^ interceptorFilter[(m_ConfigFilter >> 8) & 0xFF] ^ _AlgoFilter[(connectionFilter >> 16) & 0xFF] ^ _AnnotationFilter[initializerFilter >> 24] ^ key[num, 0];
						if (0 == 0)
						{
							num4 = num3;
						}
						uint num5 = _ProductFilter[m_ConfigFilter & 0xFF] ^ interceptorFilter[(connectionFilter >> 8) & 0xFF] ^ _AlgoFilter[(initializerFilter >> 16) & 0xFF] ^ _AnnotationFilter[m_ExpressionFilter >> 24] ^ key[num, 1];
						if (0 == 0)
						{
							num6 = num5;
						}
						num7 = (_ProductFilter[connectionFilter & 0xFF] ^ interceptorFilter[(initializerFilter >> 8) & 0xFF] ^ _AlgoFilter[(m_ExpressionFilter >> 16) & 0xFF]);
						num8 = _AnnotationFilter[m_ConfigFilter >> 24];
						break;
					}
					num2 = (int)(_ProductFilter[m_ExpressionFilter & 0xFF] ^ interceptorFilter[(m_ConfigFilter >> 8) & 0xFF] ^ _AlgoFilter[(connectionFilter >> 16) & 0xFF] ^ _AnnotationFilter[initializerFilter >> 24]);
					if (5u != 0)
					{
						num4 = (uint)(num2 ^ (int)key[num, 0]);
						num6 = (_ProductFilter[m_ConfigFilter & 0xFF] ^ interceptorFilter[(connectionFilter >> 8) & 0xFF] ^ _AlgoFilter[(initializerFilter >> 16) & 0xFF] ^ _AnnotationFilter[m_ExpressionFilter >> 24] ^ key[num, 1]);
						num9 = (_ProductFilter[connectionFilter & 0xFF] ^ interceptorFilter[(initializerFilter >> 8) & 0xFF] ^ _AlgoFilter[(m_ExpressionFilter >> 16) & 0xFF] ^ _AnnotationFilter[m_ConfigFilter >> 24] ^ key[num, 2]);
						num7 = (_ProductFilter[initializerFilter & 0xFF] ^ interceptorFilter[(m_ExpressionFilter >> 8) & 0xFF] ^ _AlgoFilter[(m_ConfigFilter >> 16) & 0xFF]);
						num8 = _AnnotationFilter[connectionFilter >> 24];
						if (8 == 0)
						{
							break;
						}
						num10 = (num7 ^ num8 ^ key[num++, 3]);
						m_ExpressionFilter = (uint)(m_SingletonFilter[num4 & 0xFF] ^ (m_SingletonFilter[(num6 >> 8) & 0xFF] << 8) ^ (m_SingletonFilter[(num9 >> 16) & 0xFF] << 16) ^ (m_SingletonFilter[num10 >> 24] << 24) ^ (int)key[num, 0]);
						m_ConfigFilter = (uint)(m_SingletonFilter[num6 & 0xFF] ^ (m_SingletonFilter[(num9 >> 8) & 0xFF] << 8) ^ (m_SingletonFilter[(num10 >> 16) & 0xFF] << 16) ^ (m_SingletonFilter[num4 >> 24] << 24) ^ (int)key[num, 1]);
						connectionFilter = (uint)(m_SingletonFilter[num9 & 0xFF] ^ (m_SingletonFilter[(num10 >> 8) & 0xFF] << 8) ^ (m_SingletonFilter[(num4 >> 16) & 0xFF] << 16) ^ (m_SingletonFilter[num6 >> 24] << 24) ^ (int)key[num, 2]);
						initializerFilter = (uint)(m_SingletonFilter[num10 & 0xFF] ^ (m_SingletonFilter[(num4 >> 8) & 0xFF] << 8) ^ (m_SingletonFilter[(num6 >> 16) & 0xFF] << 16) ^ (m_SingletonFilter[num9 >> 24] << 24) ^ (int)key[num, 3]);
						return;
					}
				}
				uint num11 = num7 ^ num8 ^ key[num, 2];
				if (7u != 0)
				{
					num9 = num11;
				}
				uint num12 = _ProductFilter[initializerFilter & 0xFF] ^ interceptorFilter[(m_ExpressionFilter >> 8) & 0xFF] ^ _AlgoFilter[(m_ConfigFilter >> 16) & 0xFF] ^ _AnnotationFilter[connectionFilter >> 24];
				int num13 = num;
				int num14 = num13 + 1;
				if (0 == 0)
				{
					num = num14;
				}
				uint num15 = num12 ^ key[num13, 3];
				if (0 == 0)
				{
					num10 = num15;
				}
				m_ExpressionFilter = (_ProductFilter[num4 & 0xFF] ^ interceptorFilter[(num6 >> 8) & 0xFF] ^ _AlgoFilter[(num9 >> 16) & 0xFF] ^ _AnnotationFilter[num10 >> 24] ^ key[num, 0]);
				m_ConfigFilter = (_ProductFilter[num6 & 0xFF] ^ interceptorFilter[(num9 >> 8) & 0xFF] ^ _AlgoFilter[(num10 >> 16) & 0xFF] ^ _AnnotationFilter[num4 >> 24] ^ key[num, 1]);
				connectionFilter = (_ProductFilter[num9 & 0xFF] ^ interceptorFilter[(num10 >> 8) & 0xFF] ^ _AlgoFilter[(num4 >> 16) & 0xFF] ^ _AnnotationFilter[num6 >> 24] ^ key[num, 2]);
				initializerFilter = (_ProductFilter[num10 & 0xFF] ^ interceptorFilter[(num4 >> 8) & 0xFF] ^ _AlgoFilter[(num6 >> 16) & 0xFF] ^ _AnnotationFilter[num9 >> 24] ^ key[num++, 3]);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckDic(uint[,] init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ExpressionFilter ^= init[paramsFilter, 0];
			m_ConfigFilter ^= init[paramsFilter, 1];
			connectionFilter ^= init[paramsFilter, 2];
			initializerFilter ^= init[paramsFilter, 3];
			int num = paramsFilter - 1;
			int num2;
			if (0 == 0)
			{
				num2 = num;
			}
			uint num4 = default(uint);
			uint num6;
			uint num8;
			uint num13 = default(uint);
			while (num2 > 1)
			{
				uint num3 = _ExporterFilter[m_ExpressionFilter & 0xFF] ^ m_VisitorFilter[(initializerFilter >> 8) & 0xFF] ^ m_GlobalFilter[(connectionFilter >> 16) & 0xFF] ^ m_WrapperFilter[m_ConfigFilter >> 24] ^ init[num2, 0];
				if (0 == 0)
				{
					num4 = num3;
				}
				uint num5 = _ExporterFilter[m_ConfigFilter & 0xFF] ^ m_VisitorFilter[(m_ExpressionFilter >> 8) & 0xFF] ^ m_GlobalFilter[(initializerFilter >> 16) & 0xFF] ^ m_WrapperFilter[connectionFilter >> 24] ^ init[num2, 1];
				if (5u != 0)
				{
					num6 = num5;
				}
				uint num7 = _ExporterFilter[connectionFilter & 0xFF] ^ m_VisitorFilter[(m_ConfigFilter >> 8) & 0xFF] ^ m_GlobalFilter[(m_ExpressionFilter >> 16) & 0xFF] ^ m_WrapperFilter[initializerFilter >> 24] ^ init[num2, 2];
				if (8u != 0)
				{
					num8 = num7;
				}
				uint num9 = _ExporterFilter[initializerFilter & 0xFF] ^ m_VisitorFilter[(connectionFilter >> 8) & 0xFF] ^ m_GlobalFilter[(m_ConfigFilter >> 16) & 0xFF] ^ m_WrapperFilter[m_ExpressionFilter >> 24];
				int num10 = num2;
				int num11 = num10 - 1;
				if (8u != 0)
				{
					num2 = num11;
				}
				uint num12 = num9 ^ init[num10, 3];
				if (0 == 0)
				{
					num13 = num12;
				}
				m_ExpressionFilter = (_ExporterFilter[num4 & 0xFF] ^ m_VisitorFilter[(num13 >> 8) & 0xFF] ^ m_GlobalFilter[(num8 >> 16) & 0xFF] ^ m_WrapperFilter[num6 >> 24] ^ init[num2, 0]);
				m_ConfigFilter = (_ExporterFilter[num6 & 0xFF] ^ m_VisitorFilter[(num4 >> 8) & 0xFF] ^ m_GlobalFilter[(num13 >> 16) & 0xFF] ^ m_WrapperFilter[num8 >> 24] ^ init[num2, 1]);
				connectionFilter = (_ExporterFilter[num8 & 0xFF] ^ m_VisitorFilter[(num6 >> 8) & 0xFF] ^ m_GlobalFilter[(num4 >> 16) & 0xFF] ^ m_WrapperFilter[num13 >> 24] ^ init[num2, 2]);
				initializerFilter = (_ExporterFilter[num13 & 0xFF] ^ m_VisitorFilter[(num8 >> 8) & 0xFF] ^ m_GlobalFilter[(num6 >> 16) & 0xFF] ^ m_WrapperFilter[num4 >> 24] ^ init[num2--, 3]);
			}
			num4 = (_ExporterFilter[m_ExpressionFilter & 0xFF] ^ m_VisitorFilter[(initializerFilter >> 8) & 0xFF] ^ m_GlobalFilter[(connectionFilter >> 16) & 0xFF] ^ m_WrapperFilter[m_ConfigFilter >> 24] ^ init[num2, 0]);
			num6 = (_ExporterFilter[m_ConfigFilter & 0xFF] ^ m_VisitorFilter[(m_ExpressionFilter >> 8) & 0xFF] ^ m_GlobalFilter[(initializerFilter >> 16) & 0xFF] ^ m_WrapperFilter[connectionFilter >> 24] ^ init[num2, 1]);
			num8 = (_ExporterFilter[connectionFilter & 0xFF] ^ m_VisitorFilter[(m_ConfigFilter >> 8) & 0xFF] ^ m_GlobalFilter[(m_ExpressionFilter >> 16) & 0xFF] ^ m_WrapperFilter[initializerFilter >> 24] ^ init[num2, 2]);
			num13 = (_ExporterFilter[initializerFilter & 0xFF] ^ m_VisitorFilter[(connectionFilter >> 8) & 0xFF] ^ m_GlobalFilter[(m_ConfigFilter >> 16) & 0xFF] ^ m_WrapperFilter[m_ExpressionFilter >> 24] ^ init[num2, 3]);
			m_ExpressionFilter = (uint)(m_ModelFilter[num4 & 0xFF] ^ (m_ModelFilter[(num13 >> 8) & 0xFF] << 8) ^ (m_ModelFilter[(num8 >> 16) & 0xFF] << 16) ^ (m_ModelFilter[num6 >> 24] << 24) ^ (int)init[0, 0]);
			m_ConfigFilter = (uint)(m_ModelFilter[num6 & 0xFF] ^ (m_ModelFilter[(num4 >> 8) & 0xFF] << 8) ^ (m_ModelFilter[(num13 >> 16) & 0xFF] << 16) ^ (m_ModelFilter[num8 >> 24] << 24) ^ (int)init[0, 1]);
			connectionFilter = (uint)(m_ModelFilter[num8 & 0xFF] ^ (m_ModelFilter[(num6 >> 8) & 0xFF] << 8) ^ (m_ModelFilter[(num4 >> 16) & 0xFF] << 16) ^ (m_ModelFilter[num13 >> 24] << 24) ^ (int)init[0, 2]);
			initializerFilter = (uint)(m_ModelFilter[num13 & 0xFF] ^ (m_ModelFilter[(num8 >> 8) & 0xFF] << 8) ^ (m_ModelFilter[(num6 >> 16) & 0xFF] << 16) ^ (m_ModelFilter[num4 >> 24] << 24) ^ (int)init[0, 3]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static EventInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			byte[] array = new byte[256];
			if (4u != 0)
			{
				RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			}
			m_SingletonFilter = array;
			while (true)
			{
				byte[] array2 = new byte[256];
				if (2u != 0)
				{
					RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				m_ModelFilter = array2;
				byte[] array3 = new byte[30];
				if (0 == 0)
				{
					RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				m_MessageFilter = array3;
				uint[] array4 = new uint[256];
				if (3u != 0)
				{
					RuntimeHelpers.InitializeArray(array4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				_ProductFilter = array4;
				uint[] array5 = new uint[256];
				if (5u != 0)
				{
					RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				}
				interceptorFilter = array5;
				while (uint.MaxValue != 0)
				{
					uint[] array6 = new uint[256];
					if (0 == 0)
					{
						RuntimeHelpers.InitializeArray(array6, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					}
					_AlgoFilter = array6;
					_AnnotationFilter = new uint[256]
					{
						3332727651u,
						4169432188u,
						4003034999u,
						4136467323u,
						4279104242u,
						3602738027u,
						3736170351u,
						2438251973u,
						1615867952u,
						33751297u,
						3467208551u,
						1451043627u,
						3877240574u,
						3043153879u,
						1306962859u,
						3969545846u,
						2403715786u,
						530416258u,
						2302724553u,
						4203183485u,
						4011195130u,
						3001768281u,
						2395555655u,
						4211863792u,
						1106029997u,
						3009926356u,
						1610457762u,
						1173008303u,
						599760028u,
						1408738468u,
						3835064946u,
						2606481600u,
						1975695287u,
						3776773629u,
						1034851219u,
						1282024998u,
						1817851446u,
						2118205247u,
						4110612471u,
						2203045068u,
						1750873140u,
						1374987685u,
						3509904869u,
						4178113009u,
						3801313649u,
						2876496088u,
						1649619249u,
						708777237u,
						135005188u,
						2505230279u,
						1181033251u,
						2640233411u,
						807933976u,
						933336726u,
						168756485u,
						800430746u,
						235472647u,
						607523346u,
						463175808u,
						3745374946u,
						3441880043u,
						1315514151u,
						2144187058u,
						3936318837u,
						303761673u,
						496927619u,
						1484008492u,
						875436570u,
						908925723u,
						3702681198u,
						3035519578u,
						1543217312u,
						2767606354u,
						1984772923u,
						3076642518u,
						2110698419u,
						1383803177u,
						3711886307u,
						1584475951u,
						328696964u,
						2801095507u,
						3110654417u,
						0u,
						3240947181u,
						1080041504u,
						3810524412u,
						2043195825u,
						3069008731u,
						3569248874u,
						2370227147u,
						1742323390u,
						1917532473u,
						2497595978u,
						2564049996u,
						2968016984u,
						2236272591u,
						3144405200u,
						3307925487u,
						1340451498u,
						3977706491u,
						2261074755u,
						2597801293u,
						1716859699u,
						294946181u,
						2328839493u,
						3910203897u,
						67502594u,
						4269899647u,
						2700103760u,
						2017737788u,
						632987551u,
						1273211048u,
						2733855057u,
						1576969123u,
						2160083008u,
						92966799u,
						1068339858u,
						566009245u,
						1883781176u,
						4043634165u,
						1675607228u,
						2009183926u,
						2943736538u,
						1113792801u,
						540020752u,
						3843751935u,
						4245615603u,
						3211645650u,
						2169294285u,
						403966988u,
						641012499u,
						3274697964u,
						3202441055u,
						899848087u,
						2295088196u,
						775493399u,
						2472002756u,
						1441965991u,
						4236410494u,
						2051489085u,
						3366741092u,
						3135724893u,
						841685273u,
						3868554099u,
						3231735904u,
						429425025u,
						2664517455u,
						2743065820u,
						1147544098u,
						1417554474u,
						1001099408u,
						193169544u,
						2362066502u,
						3341414126u,
						1809037496u,
						675025940u,
						2809781982u,
						3168951902u,
						371002123u,
						2910247899u,
						3678134496u,
						1683370546u,
						1951283770u,
						337512970u,
						2463844681u,
						201983494u,
						1215046692u,
						3101973596u,
						2673722050u,
						3178157011u,
						1139780780u,
						3299238498u,
						967348625u,
						832869781u,
						3543655652u,
						4069226873u,
						3576883175u,
						2336475336u,
						1851340599u,
						3669454189u,
						25988493u,
						2976175573u,
						2631028302u,
						1239460265u,
						3635702892u,
						2902087254u,
						4077384948u,
						3475368682u,
						3400492389u,
						4102978170u,
						1206496942u,
						270010376u,
						1876277946u,
						4035475576u,
						1248797989u,
						1550986798u,
						941890588u,
						1475454630u,
						1942467764u,
						2538718918u,
						3408128232u,
						2709315037u,
						3902567540u,
						1042358047u,
						2531085131u,
						1641856445u,
						226921355u,
						260409994u,
						3767562352u,
						2084716094u,
						1908716981u,
						3433719398u,
						2430093384u,
						100991747u,
						4144101110u,
						470945294u,
						3265487201u,
						1784624437u,
						2935576407u,
						1775286713u,
						395413126u,
						2572730817u,
						975641885u,
						666476190u,
						3644383713u,
						3943954680u,
						733190296u,
						573772049u,
						3535497577u,
						2842745305u,
						126455438u,
						866620564u,
						766942107u,
						1008868894u,
						361924487u,
						3374377449u,
						2269761230u,
						2868860245u,
						1350051880u,
						2776293343u,
						59739276u,
						1509466529u,
						159418761u,
						437718285u,
						1708834751u,
						3610371814u,
						2227585602u,
						3501746280u,
						2193834305u,
						699439513u,
						1517759789u,
						504434447u,
						2076946608u,
						2835108948u,
						1842789307u,
						742004246u
					};
					int num = 256;
					if (num != 0)
					{
						uint[] array7 = new uint[num];
						RuntimeHelpers.InitializeArray(array7, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						_ExporterFilter = array7;
						if (7 == 0)
						{
							continue;
						}
						num = 256;
					}
					uint[] array8 = new uint[num];
					RuntimeHelpers.InitializeArray(array8, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					m_VisitorFilter = array8;
					m_GlobalFilter = new uint[256]
					{
						4098969767u,
						1098797925u,
						387629988u,
						658151006u,
						2872822635u,
						2636116293u,
						4205620056u,
						3813380867u,
						807425530u,
						1991112301u,
						3431502198u,
						49620300u,
						3847224535u,
						717608907u,
						891715652u,
						1656065955u,
						2984135002u,
						3123013403u,
						3930429454u,
						4267565504u,
						801309301u,
						1283527408u,
						1183687575u,
						3547055865u,
						2399397727u,
						2450888092u,
						1841294202u,
						1385552473u,
						3201576323u,
						1951978273u,
						3762891113u,
						3381544136u,
						3262474889u,
						2398386297u,
						1486449470u,
						3106397553u,
						3787372111u,
						2297436077u,
						550069932u,
						3464344634u,
						3747813450u,
						451248689u,
						1368875059u,
						1398949247u,
						1689378935u,
						1807451310u,
						2180914336u,
						150574123u,
						1215322216u,
						1167006205u,
						3734275948u,
						2069018616u,
						1940595667u,
						1265820162u,
						534992783u,
						1432758955u,
						3954313000u,
						3039757250u,
						3313932923u,
						936617224u,
						674296455u,
						3206787749u,
						50510442u,
						384654466u,
						3481938716u,
						2041025204u,
						133427442u,
						1766760930u,
						3664104948u,
						84334014u,
						886120290u,
						2797898494u,
						775200083u,
						4087521365u,
						2315596513u,
						4137973227u,
						2198551020u,
						1614850799u,
						1901987487u,
						1857900816u,
						557775242u,
						3717610758u,
						1054715397u,
						3863824061u,
						1418835341u,
						3295741277u,
						100954068u,
						1348534037u,
						2551784699u,
						3184957417u,
						1082772547u,
						3647436702u,
						3903896898u,
						2298972299u,
						434583643u,
						3363429358u,
						2090944266u,
						1115482383u,
						2230896926u,
						0u,
						2148107142u,
						724715757u,
						287222896u,
						1517047410u,
						251526143u,
						2232374840u,
						2923241173u,
						758523705u,
						252339417u,
						1550328230u,
						1536938324u,
						908343854u,
						168604007u,
						1469255655u,
						4004827798u,
						2602278545u,
						3229634501u,
						3697386016u,
						2002413899u,
						303830554u,
						2481064634u,
						2696996138u,
						574374880u,
						454171927u,
						151915277u,
						2347937223u,
						3056449960u,
						504678569u,
						4049044761u,
						1974422535u,
						2582559709u,
						2141453664u,
						33005350u,
						1918680309u,
						1715782971u,
						4217058430u,
						1133213225u,
						600562886u,
						3988154620u,
						3837289457u,
						836225756u,
						1665273989u,
						2534621218u,
						3330547729u,
						1250262308u,
						3151165501u,
						4188934450u,
						700935585u,
						2652719919u,
						3000824624u,
						2249059410u,
						3245854947u,
						3005967382u,
						1890163129u,
						2484206152u,
						3913753188u,
						4238918796u,
						4037024319u,
						2102843436u,
						857927568u,
						1233635150u,
						953795025u,
						3398237858u,
						3566745099u,
						4121350017u,
						2057644254u,
						3084527246u,
						2906629311u,
						976020637u,
						2018512274u,
						1600822220u,
						2119459398u,
						2381758995u,
						3633375416u,
						959340279u,
						3280139695u,
						1570750080u,
						3496574099u,
						3580864813u,
						634368786u,
						2898803609u,
						403744637u,
						2632478307u,
						1004239803u,
						650971512u,
						1500443672u,
						2599158199u,
						1334028442u,
						2514904430u,
						4289363686u,
						3156281551u,
						368043752u,
						3887782299u,
						1867173430u,
						2682967049u,
						2955531900u,
						2754719666u,
						1059729699u,
						2781229204u,
						2721431654u,
						1316239292u,
						2197595850u,
						2430644432u,
						2805143000u,
						82922136u,
						3963746266u,
						3447656016u,
						2434215926u,
						1299615190u,
						4014165424u,
						2865517645u,
						2531581700u,
						3516851125u,
						1783372680u,
						750893087u,
						1699118929u,
						1587348714u,
						2348899637u,
						2281337716u,
						201010753u,
						1739807261u,
						3683799762u,
						283718486u,
						3597472583u,
						3617229921u,
						2704767500u,
						4166618644u,
						334203196u,
						2848910887u,
						1639396809u,
						484568549u,
						1199193265u,
						3533461983u,
						4065673075u,
						337148366u,
						3346251575u,
						4149471949u,
						4250885034u,
						1038029935u,
						1148749531u,
						2949284339u,
						1756970692u,
						607661108u,
						2747424576u,
						488010435u,
						3803974693u,
						1009290057u,
						234832277u,
						2822336769u,
						201907891u,
						3034094820u,
						1449431233u,
						3413860740u,
						852848822u,
						1816687708u,
						3100656215u
					};
					m_WrapperFilter = new uint[256]
					{
						1364240372u,
						2119394625u,
						449029143u,
						982933031u,
						1003187115u,
						535905693u,
						2896910586u,
						1267925987u,
						542505520u,
						2918608246u,
						2291234508u,
						4112862210u,
						1341970405u,
						3319253802u,
						645940277u,
						3046089570u,
						3729349297u,
						627514298u,
						1167593194u,
						1575076094u,
						3271718191u,
						2165502028u,
						2376308550u,
						1808202195u,
						65494927u,
						362126482u,
						3219880557u,
						2514114898u,
						3559752638u,
						1490231668u,
						1227450848u,
						2386872521u,
						1969916354u,
						4101536142u,
						2573942360u,
						668823993u,
						3199619041u,
						4028083592u,
						3378949152u,
						2108963534u,
						1662536415u,
						3850514714u,
						2539664209u,
						1648721747u,
						2984277860u,
						3146034795u,
						4263288961u,
						4187237128u,
						1884842056u,
						2400845125u,
						2491903198u,
						1387788411u,
						2871251827u,
						1927414347u,
						3814166303u,
						1714072405u,
						2986813675u,
						788775605u,
						2258271173u,
						3550808119u,
						821200680u,
						598910399u,
						45771267u,
						3982262806u,
						2318081231u,
						2811409529u,
						4092654087u,
						1319232105u,
						1707996378u,
						114671109u,
						3508494900u,
						3297443494u,
						882725678u,
						2728416755u,
						87220618u,
						2759191542u,
						188345475u,
						1084944224u,
						1577492337u,
						3176206446u,
						1056541217u,
						2520581853u,
						3719169342u,
						1296481766u,
						2444594516u,
						1896177092u,
						74437638u,
						1627329872u,
						421854104u,
						3600279997u,
						2311865152u,
						1735892697u,
						2965193448u,
						126389129u,
						3879230233u,
						2044456648u,
						2705787516u,
						2095648578u,
						4173930116u,
						0u,
						159614592u,
						843640107u,
						514617361u,
						1817080410u,
						4261150478u,
						257308805u,
						1025430958u,
						908540205u,
						174381327u,
						1747035740u,
						2614187099u,
						607792694u,
						212952842u,
						2467293015u,
						3033700078u,
						463376795u,
						2152711616u,
						1638015196u,
						1516850039u,
						471210514u,
						3792353939u,
						3236244128u,
						1011081250u,
						303896347u,
						235605257u,
						4071475083u,
						767142070u,
						348694814u,
						1468340721u,
						2940995445u,
						4005289369u,
						2751291519u,
						4154402305u,
						1555887474u,
						1153776486u,
						1530167035u,
						2339776835u,
						3420243491u,
						3060333805u,
						3093557732u,
						3620396081u,
						1108378979u,
						322970263u,
						2216694214u,
						2239571018u,
						3539484091u,
						2920362745u,
						3345850665u,
						491466654u,
						3706925234u,
						233591430u,
						2010178497u,
						728503987u,
						2845423984u,
						301615252u,
						1193436393u,
						2831453436u,
						2686074864u,
						1457007741u,
						586125363u,
						2277985865u,
						3653357880u,
						2365498058u,
						2553678804u,
						2798617077u,
						2770919034u,
						3659959991u,
						1067761581u,
						753179962u,
						1343066744u,
						1788595295u,
						1415726718u,
						4139914125u,
						2431170776u,
						777975609u,
						2197139395u,
						2680062045u,
						1769771984u,
						1873358293u,
						3484619301u,
						3359349164u,
						279411992u,
						3899548572u,
						3682319163u,
						3439949862u,
						1861490777u,
						3959535514u,
						2208864847u,
						3865407125u,
						2860443391u,
						554225596u,
						4024887317u,
						3134823399u,
						1255028335u,
						3939764639u,
						701922480u,
						833598116u,
						707863359u,
						3325072549u,
						901801634u,
						1949809742u,
						4238789250u,
						3769684112u,
						857069735u,
						4048197636u,
						1106762476u,
						2131644621u,
						389019281u,
						1989006925u,
						1129165039u,
						3428076970u,
						3839820950u,
						2665723345u,
						1276872810u,
						3250069292u,
						1182749029u,
						2634345054u,
						22885772u,
						4201870471u,
						4214112523u,
						3009027431u,
						2454901467u,
						3912455696u,
						1829980118u,
						2592891351u,
						930745505u,
						1502483704u,
						3951639571u,
						3471714217u,
						3073755489u,
						3790464284u,
						2050797895u,
						2623135698u,
						1430221810u,
						410635796u,
						1941911495u,
						1407897079u,
						1599843069u,
						3742658365u,
						2022103876u,
						3397514159u,
						3107898472u,
						942421028u,
						3261022371u,
						376619805u,
						3154912738u,
						680216892u,
						4282488077u,
						963707304u,
						148812556u,
						3634160820u,
						1687208278u,
						2069988555u,
						3580933682u,
						1215585388u,
						3494008760u
					};
					return;
				}
			}
		}
	}
}
