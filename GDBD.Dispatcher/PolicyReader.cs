using GDBD.Workers;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace GDBD.Dispatcher
{
	internal static class PolicyReader
	{
		internal sealed class FacadeListAnnotation
		{
			private static readonly int[] m_ServiceReader;

			private static readonly int[] queueReader;

			private static readonly int[] m_ProxyReader;

			private static readonly int[] m_RegistryReader;

			private int m_AttrReader;

			private int _ConfigurationReader;

			private int _CandidateReader;

			private int tokenizerReader;

			private int m_PrinterReader;

			private bool m_MappingReader;

			private StubReader mockReader;

			private CollectionReader _ObserverReader;

			private ErrorClassDispatcher m_DescriptorReader;

			private ComposerEventConsumer _ProducerReader;

			private ComposerEventConsumer _StructReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FacadeListAnnotation(byte[] reference)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				mockReader = new StubReader();
				_ObserverReader = new CollectionReader();
				m_AttrReader = 2;
				mockReader.GetIterator(reference, 0, reference.Length);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe bool DestroyIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_023c: Incompatible stack heights: 0 vs 1
				//IL_0246: Incompatible stack heights: 0 vs 1
				//IL_0252: Incompatible stack heights: 0 vs 1
				//IL_0258: Incompatible stack heights: 0 vs 1
				//IL_025e: Incompatible stack heights: 0 vs 1
				//IL_0264: Incompatible stack heights: 0 vs 1
				//IL_026a: Incompatible stack heights: 0 vs 2
				void* ptr = stackalloc byte[12];
				while (true)
				{
					IL_0013:
					((FacadeListAnnotation)/*Error near IL_0018: Stack underflow*/)._ObserverReader.TestIterator();
					int num = (int)/*Error near IL_024c: Stack underflow*/;
					while (true)
					{
						int num2 = num;
						int num3 = 258;
						while (true)
						{
							int num4;
							if (num2 >= num3)
							{
								int attrReader = ((FacadeListAnnotation)/*Error near IL_0036: Stack underflow*/).m_AttrReader;
								*(int*)(long)(IntPtr)(void*)/*Error near IL_0037: Stack underflow*/ = attrReader;
								int num5;
								int num6;
								switch (*(int*)(long)(IntPtr)(void*)/*Error near IL_003d: Stack underflow*/)
								{
								case 7:
									while (((num4 = _ProducerReader.CountIterator(mockReader)) & -256) == 0)
									{
										if (6u != 0)
										{
											_ = ((FacadeListAnnotation)/*Error near IL_0069: Stack underflow*/)._ObserverReader;
											((CollectionReader)/*Error near IL_0073: Stack underflow*/).StartIterator((int)/*Error near IL_0073: Stack underflow*/);
											if (--num >= 258)
											{
												continue;
											}
										}
										goto IL_0082;
									}
									if (num4 < 257)
									{
										goto IL_00b3;
									}
									goto IL_00d9;
								case 8:
									if (_ConfigurationReader > 0)
									{
										m_AttrReader = 8;
										*(int*)((byte*)ptr + 4) = mockReader.RemoveIterator(_ConfigurationReader);
										if (*(int*)((byte*)ptr + 4) < 0)
										{
											return false;
										}
										if (false)
										{
											goto IL_00d9;
										}
										mockReader.PostIterator(_ConfigurationReader);
										_CandidateReader += *(int*)((byte*)ptr + 4);
									}
									m_AttrReader = 9;
									goto case 9;
								case 9:
									if (false)
									{
										goto IL_0013;
									}
									num4 = _StructReader.CountIterator(mockReader);
									if (num4 < 0)
									{
										goto IL_0182;
									}
									tokenizerReader = m_ProxyReader[num4];
									_ConfigurationReader = m_RegistryReader[num4];
									goto case 10;
								case 10:
									{
										num5 = _ConfigurationReader;
										num6 = 0;
										goto IL_01a5;
									}
									IL_01fb:
									_ObserverReader.SelectIterator(_CandidateReader, tokenizerReader);
									num5 = num - _CandidateReader;
									if (6u != 0)
									{
										num = num5;
										m_AttrReader = 7;
										break;
									}
									goto IL_01cb;
									IL_00d9:
									_CandidateReader = m_ServiceReader[num4 - 257];
									_ConfigurationReader = queueReader[num4 - 257];
									goto case 8;
									IL_0082:
									if (5u != 0)
									{
										return true;
									}
									goto IL_01c7;
									IL_01a5:
									if (num5 > num6)
									{
										m_AttrReader = 10;
										*(int*)((byte*)ptr + 8) = mockReader.RemoveIterator(_ConfigurationReader);
										goto IL_01c7;
									}
									goto IL_01fb;
									IL_01c7:
									num5 = *(int*)((byte*)ptr + 8);
									goto IL_01cb;
									IL_01cb:
									num6 = 0;
									if (num6 != 0)
									{
										goto IL_01a5;
									}
									if (num5 < num6)
									{
										return false;
									}
									mockReader.PostIterator(_ConfigurationReader);
									tokenizerReader += *(int*)((byte*)ptr + 8);
									goto IL_01fb;
								}
								break;
							}
							return true;
							IL_00b3:
							num2 = num4;
							num3 = 0;
							if (num3 != 0)
							{
								continue;
							}
							goto IL_00bb;
							IL_0182:
							return false;
						}
						continue;
						IL_00bb:
						if (num2 < num3)
						{
							return false;
						}
						_StructReader = null;
						_ProducerReader = null;
						m_AttrReader = 2;
						return true;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe bool SetIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Incompatible stack heights: 0 vs 1
				//IL_024f: Incompatible stack heights: 0 vs 2
				//IL_0255: Incompatible stack heights: 0 vs 1
				//IL_025b: Incompatible stack heights: 0 vs 1
				//IL_0261: Incompatible stack heights: 0 vs 1
				//IL_0267: Incompatible stack heights: 0 vs 1
				//IL_026d: Incompatible stack heights: 0 vs 1
				//IL_0277: Incompatible stack heights: 0 vs 1
				int num = 12;
				int num5 = default(int);
				if (num != 0)
				{
					void* ptr = stackalloc byte[num];
					_ = /*Error near IL_001b: Stack underflow*/+ 4;
					int attrReader = ((FacadeListAnnotation)/*Error near IL_0025: Stack underflow*/).m_AttrReader;
					*(int*)(long)(IntPtr)(void*)/*Error near IL_0026: Stack underflow*/ = attrReader;
					while (true)
					{
						int num2;
						int num3;
						switch (*(int*)(long)(IntPtr)(/*Error near IL_002d: Stack underflow*/ + 4))
						{
						case 2:
							num2 = (((FacadeListAnnotation)/*Error near IL_0070: Stack underflow*/).m_MappingReader ? 1 : 0);
							if (0 == 0)
							{
								goto IL_0076;
							}
							goto IL_0241;
						case 3:
							num3 = (m_PrinterReader = mockReader.RemoveIterator(16));
							goto IL_0156;
						case 4:
							num3 = mockReader.RemoveIterator(16);
							if (false)
							{
								goto IL_0156;
							}
							goto IL_0185;
						case 5:
							break;
						case 6:
							if (!m_DescriptorReader.AssetIterator(mockReader))
							{
								return false;
							}
							_ProducerReader = m_DescriptorReader.CustomizeIterator();
							_StructReader = m_DescriptorReader.QueryIterator();
							m_AttrReader = 7;
							goto case 7;
						case 7:
						case 8:
						case 9:
						case 10:
							return DestroyIterator();
						case 12:
							goto IL_0238;
						default:
							{
								num2 = 0;
								goto IL_0241;
							}
							IL_0241:
							return (byte)num2 != 0;
							IL_0156:
							if (num3 < 0)
							{
								return false;
							}
							mockReader.PostIterator(16);
							m_AttrReader = 4;
							goto case 4;
						}
						goto IL_01a1;
						IL_0185:
						if (num3 < 0)
						{
							return false;
						}
						mockReader.PostIterator(16);
						m_AttrReader = 5;
						goto IL_01a1;
						IL_0076:
						if (num2 != 0)
						{
							((FacadeListAnnotation)/*Error near IL_0087: Stack underflow*/).m_AttrReader = 12;
							return false;
						}
						((FacadeListAnnotation)/*Error near IL_0098: Stack underflow*/).mockReader.RemoveIterator(3);
						*(_003F*)(long)(IntPtr)(void*)/*Error near IL_009f: Stack underflow*/ = /*Error near IL_009f: Stack underflow*/;
						if (*(int*)ptr < 0)
						{
							return false;
						}
						mockReader.PostIterator(3);
						int num4 = *(int*)ptr;
						if (8u != 0)
						{
							if ((num4 & 1) != 0)
							{
								if (7 == 0)
								{
									continue;
								}
								m_MappingReader = true;
							}
							num5 = *(int*)ptr >> 1;
							break;
						}
						goto IL_01d3;
						IL_01d3:
						if (num4 == 0)
						{
							m_AttrReader = 2;
							return true;
						}
						return !mockReader._0001();
						IL_01a1:
						*(int*)((byte*)ptr + 8) = _ObserverReader.DeleteIterator(mockReader, m_PrinterReader);
						m_PrinterReader -= *(int*)((byte*)ptr + 8);
						num4 = m_PrinterReader;
						goto IL_01d3;
					}
					goto IL_00d6;
				}
				goto IL_00d7;
				IL_00d7:
				switch (num)
				{
				case 0:
					break;
				case 1:
					_ProducerReader = ComposerEventConsumer._StateReader;
					_StructReader = ComposerEventConsumer.resolverReader;
					m_AttrReader = 7;
					goto IL_013e;
				case 2:
					m_DescriptorReader = new ErrorClassDispatcher();
					m_AttrReader = 6;
					goto IL_013e;
				default:
					goto IL_013e;
				}
				mockReader.ChangeIterator();
				if (1 == 0)
				{
					goto IL_00d6;
				}
				m_AttrReader = 3;
				goto IL_013e;
				IL_00d6:
				num = num5;
				goto IL_00d7;
				IL_0238:
				if (5 == 0)
				{
					goto IL_013e;
				}
				return false;
				IL_013e:
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int RateIterator(byte[] value, int cfg_amount, int filterX)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Incompatible stack heights: 0 vs 1
				//IL_00ac: Incompatible stack heights: 0 vs 1
				//IL_00b2: Incompatible stack heights: 0 vs 1
				//IL_00b8: Incompatible stack heights: 0 vs 2
				//IL_00be: Incompatible stack heights: 0 vs 2
				//IL_00c4: Incompatible stack heights: 0 vs 1
				//IL_00ca: Incompatible stack heights: 0 vs 1
				//IL_00d4: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[8];
				*(int*)(long)(IntPtr)(void*)/*Error near IL_0014: Stack underflow*/ = 0;
				int num;
				int num2;
				do
				{
					IL_0019:
					num = ((FacadeListAnnotation)/*Error near IL_001e: Stack underflow*/).m_AttrReader;
					num2 = 11;
					if (num2 == 0)
					{
						continue;
					}
					if (num != num2)
					{
						_ = /*Error near IL_0032: Stack underflow*/+ 4;
						_ = ((FacadeListAnnotation)/*Error near IL_003c: Stack underflow*/)._ObserverReader;
						((CollectionReader)/*Error near IL_00d4: Stack underflow*/).InvokeIterator((byte[])/*Error near IL_00d4: Stack underflow*/, (int)/*Error near IL_00d4: Stack underflow*/, (int)/*Error near IL_00d4: Stack underflow*/);
						*(_003F*)(long)(IntPtr)(void*)/*Error near IL_0051: Stack underflow*/ = /*Error near IL_0051: Stack underflow*/;
						cfg_amount += *(int*)((byte*)ptr + 4);
						*(int*)ptr += *(int*)((byte*)ptr + 4);
						filterX -= *(int*)((byte*)ptr + 4);
						if (filterX == 0)
						{
							return *(int*)ptr;
						}
					}
					if (SetIterator())
					{
						goto IL_0019;
					}
					num = _ObserverReader.ConcatIterator();
					num2 = 0;
				}
				while (num > num2 && m_AttrReader != 11);
				return *(int*)ptr;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FacadeListAnnotation()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_008d: Incompatible stack heights: 0 vs 1
				//IL_0097: Incompatible stack heights: 0 vs 1
				//IL_00a1: Incompatible stack heights: 0 vs 1
				//IL_00ab: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				while (true)
				{
					int num = 29;
					while (true)
					{
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						m_ServiceReader = (int[])/*Error near IL_0024: Stack underflow*/;
						while (0 == 0)
						{
							_ = new int[29]
							{
								0,
								0,
								0,
								0,
								0,
								0,
								0,
								0,
								1,
								1,
								1,
								1,
								2,
								2,
								2,
								2,
								3,
								3,
								3,
								3,
								4,
								4,
								4,
								4,
								5,
								5,
								5,
								5,
								0
							};
							queueReader = (int[])/*Error near IL_0041: Stack underflow*/;
							if (1 == 0)
							{
								continue;
							}
							goto IL_0047;
						}
						goto IL_007b;
						IL_005e:
						num = 30;
						if (num == 0)
						{
							continue;
						}
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						m_RegistryReader = (int[])/*Error near IL_007b: Stack underflow*/;
						goto IL_007b;
						IL_0047:
						_ = new int[30]
						{
							1,
							2,
							3,
							4,
							5,
							7,
							9,
							13,
							17,
							25,
							33,
							49,
							65,
							97,
							129,
							193,
							257,
							385,
							513,
							769,
							1025,
							1537,
							2049,
							3073,
							4097,
							6145,
							8193,
							12289,
							16385,
							24577
						};
						m_ProxyReader = (int[])/*Error near IL_005e: Stack underflow*/;
						goto IL_005e;
						IL_007b:
						if (false)
						{
							break;
						}
						if (0 == 0)
						{
							return;
						}
						goto IL_005e;
					}
				}
			}
		}

		internal sealed class StubReader
		{
			private byte[] _CodeReader;

			private int _TaskReader;

			private int _CustomerReader;

			private uint m_InterpreterReader;

			private int m_WatcherReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int RemoveIterator(int flagslast)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_002c: Invalid comparison between Unknown and I4
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Expected I4, but got Unknown
				//IL_00e4: Incompatible stack heights: 0 vs 1
				//IL_00ea: Incompatible stack heights: 0 vs 2
				//IL_00f0: Incompatible stack heights: 0 vs 1
				//IL_00f6: Incompatible stack heights: 0 vs 2
				//IL_00fc: Incompatible stack heights: 0 vs 1
				//IL_0102: Incompatible stack heights: 0 vs 1
				//IL_0108: Incompatible stack heights: 0 vs 2
				//IL_010e: Incompatible stack heights: 0 vs 2
				//IL_0114: Incompatible stack heights: 0 vs 1
				while (true)
				{
					_ = ((StubReader)/*Error near IL_000e: Stack underflow*/).m_WatcherReader;
					if (/*Error near IL_0018: Stack underflow*/ >= /*Error near IL_0018: Stack underflow*/)
					{
						break;
					}
					_ = ((StubReader)/*Error near IL_0022: Stack underflow*/)._TaskReader;
					int customerReader = ((StubReader)/*Error near IL_002c: Stack underflow*/)._CustomerReader;
					if ((int)/*Error near IL_0031: Stack underflow*/ == customerReader)
					{
						if (false)
						{
							break;
						}
						if (true)
						{
							return -1;
						}
					}
					else
					{
						if (7 == 0)
						{
							continue;
						}
						_ = ((StubReader)/*Error near IL_0054: Stack underflow*/).m_InterpreterReader;
						_ = ((StubReader)/*Error near IL_005e: Stack underflow*/)._CodeReader;
						int taskReader = ((StubReader)/*Error near IL_006d: Stack underflow*/)._TaskReader;
						((StubReader)/*Error near IL_0076: Stack underflow*/)._TaskReader = taskReader + 1;
						int num = (((byte[])/*Error near IL_0078: Stack underflow*/)[taskReader] & 0xFF) | ((_CodeReader[_TaskReader++] & 0xFF) << 8);
						int watcherReader = m_WatcherReader;
						_003F val = /*Error near IL_00aa: Stack underflow*/| (num << watcherReader);
						((StubReader)/*Error near IL_00af: Stack underflow*/).m_InterpreterReader = (uint)(int)val;
					}
					m_WatcherReader += 16;
					break;
				}
				long num2 = m_InterpreterReader;
				int num3 = 1;
				int num4 = flagslast;
				while (true)
				{
					if (0 == 0)
					{
						num3 <<= num4;
						if (false)
						{
							break;
						}
						num4 = 1;
					}
					if (num4 != 0)
					{
						num3 -= num4;
						break;
					}
				}
				return (int)(num2 & num3);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void PostIterator(int indexOfparam)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Expected I4, but got Unknown
				//IL_003b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Expected I4, but got Unknown
				//IL_0049: Incompatible stack heights: 0 vs 1
				//IL_004f: Incompatible stack heights: 0 vs 1
				//IL_0055: Incompatible stack heights: 0 vs 2
				//IL_005b: Incompatible stack heights: 0 vs 1
				//IL_0061: Incompatible stack heights: 0 vs 1
				//IL_0067: Incompatible stack heights: 0 vs 2
				while (true)
				{
					_ = ((StubReader)/*Error near IL_0013: Stack underflow*/).m_InterpreterReader;
					_003F val = /*Error near IL_001b: Stack underflow*/& 0x1F;
					_003F val2 = (ulong)/*Error near IL_001c: Stack underflow*/ >> (int)val;
					((StubReader)/*Error near IL_0021: Stack underflow*/).m_InterpreterReader = (uint)(int)val2;
					while (0 == 0)
					{
						_ = ((StubReader)/*Error near IL_0036: Stack underflow*/).m_WatcherReader;
						_003F val3 = /*Error near IL_003c: Stack underflow*/- /*Error near IL_003c: Stack underflow*/;
						((StubReader)/*Error near IL_0041: Stack underflow*/).m_WatcherReader = (int)val3;
						if (8u != 0)
						{
							return;
						}
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0010: Incompatible stack heights: 0 vs 1
				return ((StubReader)/*Error near IL_000e: Stack underflow*/).m_WatcherReader;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected I4, but got Unknown
				//IL_0040: Incompatible stack heights: 0 vs 1
				//IL_0046: Incompatible stack heights: 0 vs 2
				//IL_004c: Incompatible stack heights: 0 vs 2
				int num = ((StubReader)/*Error near IL_000e: Stack underflow*/)._CustomerReader;
				int num2;
				while (true)
				{
					num2 = ((StubReader)/*Error near IL_0018: Stack underflow*/)._TaskReader;
					if (false)
					{
						break;
					}
					num = /*Error near IL_001f: Stack underflow*/- num2;
					if (false)
					{
						continue;
					}
					num2 = ((StubReader)/*Error near IL_002f: Stack underflow*/).m_WatcherReader;
					break;
				}
				do
				{
					if (0 == 0)
					{
						num2 >>= 3;
					}
				}
				while (false);
				return /*Error near IL_003e: Stack underflow*/+ num2;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangeIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected I4, but got Unknown
				//IL_0041: Incompatible stack heights: 0 vs 1
				//IL_0047: Incompatible stack heights: 0 vs 1
				//IL_004d: Incompatible stack heights: 0 vs 2
				//IL_0053: Incompatible stack heights: 0 vs 1
				//IL_0059: Incompatible stack heights: 0 vs 1
				_ = ((StubReader)/*Error near IL_0013: Stack underflow*/).m_InterpreterReader;
				int watcherReader = ((StubReader)/*Error near IL_001d: Stack underflow*/).m_WatcherReader;
				_003F val = (ulong)/*Error near IL_0023: Stack underflow*/ >> (watcherReader & 7);
				((StubReader)/*Error near IL_0028: Stack underflow*/).m_InterpreterReader = (uint)(int)val;
				int watcherReader2 = ((StubReader)/*Error near IL_0037: Stack underflow*/).m_WatcherReader;
				((StubReader)/*Error near IL_003f: Stack underflow*/).m_WatcherReader = (watcherReader2 & -8);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0018: Invalid comparison between Unknown and I4
				//IL_001c: Incompatible stack heights: 0 vs 1
				//IL_0022: Incompatible stack heights: 0 vs 2
				_ = ((StubReader)/*Error near IL_000e: Stack underflow*/)._TaskReader;
				int customerReader = ((StubReader)/*Error near IL_0018: Stack underflow*/)._CustomerReader;
				return (int)/*Error near IL_001a: Stack underflow*/ == customerReader;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int CalculateIterator(byte[] asset, int counter_count, int insert_RESAt)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_011e: Incompatible stack heights: 0 vs 1
				//IL_0124: Incompatible stack heights: 0 vs 1
				//IL_012b: Incompatible stack heights: 0 vs 1
				//IL_0131: Incompatible stack heights: 0 vs 1
				//IL_0137: Incompatible stack heights: 0 vs 1
				//IL_013d: Incompatible stack heights: 0 vs 1
				//IL_0143: Incompatible stack heights: 0 vs 1
				//IL_0149: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[12];
				*(int*)(long)(IntPtr)(void*)/*Error near IL_0015: Stack underflow*/ = 0;
				while (m_WatcherReader > 0 && insert_RESAt > 0)
				{
					counter_count++;
					uint interpreterReader = ((StubReader)/*Error near IL_0032: Stack underflow*/).m_InterpreterReader;
					((sbyte[])/*Error near IL_0034: Stack underflow*/)[(long)/*Error near IL_0034: Stack underflow*/] = (sbyte)(byte)interpreterReader;
					uint interpreterReader2 = ((StubReader)/*Error near IL_0043: Stack underflow*/).m_InterpreterReader;
					((StubReader)/*Error near IL_004a: Stack underflow*/).m_InterpreterReader = interpreterReader2 >> 8;
					int watcherReader = ((StubReader)/*Error near IL_0059: Stack underflow*/).m_WatcherReader;
					((StubReader)/*Error near IL_0060: Stack underflow*/).m_WatcherReader = watcherReader - 8;
					insert_RESAt--;
					(*(int*)ptr)++;
				}
				if (insert_RESAt == 0)
				{
					return *(int*)ptr;
				}
				*(int*)((byte*)ptr + 4) = _CustomerReader - _TaskReader;
				if (insert_RESAt > *(int*)((byte*)ptr + 4))
				{
					insert_RESAt = *(int*)((byte*)ptr + 4);
				}
				Array.Copy(_CodeReader, _TaskReader, asset, counter_count, insert_RESAt);
				_TaskReader += insert_RESAt;
				if (((_TaskReader - _CustomerReader) & 1) != 0)
				{
					byte[] codeReader = _CodeReader;
					*(int*)((byte*)ptr + 8) = _TaskReader;
					_TaskReader = *(int*)((byte*)ptr + 8) + 1;
					m_InterpreterReader = (uint)(codeReader[*(int*)((byte*)ptr + 8)] & 0xFF);
					m_WatcherReader = 8;
				}
				return *(int*)ptr + insert_RESAt;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StubReader()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GetIterator(byte[] param, int counter_max, int start_tag)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001e: Invalid comparison between Unknown and I4
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Incompatible stack heights: 0 vs 1
				//IL_00ba: Incompatible stack heights: 0 vs 2
				//IL_00c4: Incompatible stack heights: 0 vs 1
				//IL_00ca: Incompatible stack heights: 0 vs 1
				//IL_00d0: Incompatible stack heights: 0 vs 1
				//IL_00d6: Expected I4, but got Unknown
				//IL_00dc: Incompatible stack heights: 0 vs 2
				//IL_00e2: Incompatible stack heights: 0 vs 1
				//IL_00e8: Incompatible stack heights: 0 vs 1
				int num;
				if (true)
				{
					_ = ((StubReader)/*Error near IL_0014: Stack underflow*/)._TaskReader;
					int customerReader = ((StubReader)/*Error near IL_001e: Stack underflow*/)._CustomerReader;
					if ((int)/*Error near IL_0023: Stack underflow*/ < customerReader)
					{
						new InvalidOperationException();
						throw /*Error near IL_0029: Stack underflow*/;
					}
					num = /*Error near IL_0034: Stack underflow*/+ /*Error near IL_0034: Stack underflow*/;
					_ = 0;
					if (/*Error near IL_0044: Stack underflow*/ > /*Error near IL_0044: Stack underflow*/|| /*Error near IL_0053: Stack underflow*/> /*Error near IL_0053: Stack underflow*/|| num > param.Length)
					{
						throw new ArgumentOutOfRangeException();
					}
					if ((start_tag & 1) == 0)
					{
						goto IL_009d;
					}
					m_InterpreterReader |= (uint)((param[counter_max++] & 0xFF) << m_WatcherReader);
				}
				m_WatcherReader += 8;
				goto IL_009d;
				IL_009d:
				_CodeReader = param;
				_TaskReader = counter_max;
				_CustomerReader = num;
			}
		}

		internal sealed class CollectionReader
		{
			private byte[] _RepositoryReader;

			private int serverReader;

			private int _FacadeReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartIterator(int num_reference)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0024: Expected I4, but got Unknown
				//IL_0034: Invalid comparison between Unknown and I4
				//IL_0091: Incompatible stack heights: 0 vs 1
				//IL_0097: Incompatible stack heights: 0 vs 1
				//IL_00a3: Incompatible stack heights: 0 vs 1
				//IL_00a9: Incompatible stack heights: 0 vs 1
				//IL_00b3: Incompatible stack heights: 0 vs 1
				//IL_00b9: Incompatible stack heights: 0 vs 1
				//IL_00bf: Incompatible stack heights: 0 vs 2
				//IL_00c5: Incompatible stack heights: 0 vs 1
				while (true)
				{
					int facadeReader = ((CollectionReader)/*Error near IL_0013: Stack underflow*/)._FacadeReader;
					_003F val = /*Error near IL_001f: Stack underflow*/+ 1;
					((CollectionReader)/*Error near IL_0024: Stack underflow*/)._FacadeReader = (int)val;
					while (0 == 0)
					{
						if ((int)/*Error near IL_0039: Stack underflow*/ != 32768)
						{
							if (8 == 0)
							{
								break;
							}
							_ = ((CollectionReader)/*Error near IL_0055: Stack underflow*/)._RepositoryReader;
							facadeReader = ((CollectionReader)/*Error near IL_0064: Stack underflow*/).serverReader;
							((CollectionReader)/*Error near IL_006d: Stack underflow*/).serverReader = facadeReader + 1;
							((sbyte[])/*Error near IL_0071: Stack underflow*/)[facadeReader] = (sbyte)(byte)num_reference;
							if (0 == 0)
							{
								if (0 == 0)
								{
									serverReader &= 32767;
									return;
								}
								continue;
							}
						}
						if (8 == 0)
						{
							break;
						}
						new InvalidOperationException();
						throw /*Error near IL_0045: Stack underflow*/;
					}
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void ListIterator(int indexOf_instance, int token, int proc_X)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected I4, but got Unknown
				//IL_0092: Incompatible stack heights: 0 vs 1
				//IL_0098: Incompatible stack heights: 0 vs 2
				//IL_009e: Incompatible stack heights: 0 vs 1
				//IL_00aa: Incompatible stack heights: 0 vs 1
				//IL_00b0: Incompatible stack heights: 0 vs 1
				//IL_00b6: Incompatible stack heights: 0 vs 1
				//IL_00bd: Incompatible stack heights: 0 vs 2
				//IL_00c3: Incompatible stack heights: 0 vs 1
				if (-1 == 0)
				{
					return;
				}
				while (true)
				{
					int num = token;
					int num2 = num - 1;
					if (2u != 0)
					{
						token = num2;
						if (num <= 0 || 5 == 0)
						{
							break;
						}
						_ = ((CollectionReader)/*Error near IL_001f: Stack underflow*/)._RepositoryReader;
						int num3 = ((CollectionReader)/*Error near IL_002e: Stack underflow*/).serverReader;
						_003F val = /*Error near IL_003a: Stack underflow*/+ 1;
						((CollectionReader)/*Error near IL_003f: Stack underflow*/).serverReader = (int)val;
						_ = ((CollectionReader)/*Error near IL_004e: Stack underflow*/)._RepositoryReader;
						indexOf_instance++;
						byte num4 = ((byte[])/*Error near IL_0058: Stack underflow*/)[(long)/*Error near IL_0058: Stack underflow*/];
						((sbyte[])/*Error near IL_0059: Stack underflow*/)[(long)/*Error near IL_0059: Stack underflow*/] = (sbyte)num4;
						int num5 = serverReader;
						((CollectionReader)/*Error near IL_006f: Stack underflow*/).serverReader = (num5 & 0x7FFF);
						num = indexOf_instance;
						if (3 == 0)
						{
							goto IL_007c;
						}
						num2 = 32767;
					}
					num &= num2;
					goto IL_007c;
					IL_007c:
					indexOf_instance = num;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SelectIterator(int sizeinstance, int sizecaller)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Expected I4, but got Unknown
				//IL_0020: Expected I4, but got Unknown
				//IL_002a: Invalid comparison between Unknown and I4
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Expected I4, but got Unknown
				//IL_00da: Incompatible stack heights: 0 vs 1
				//IL_00e0: Incompatible stack heights: 0 vs 1
				//IL_00e6: Incompatible stack heights: 0 vs 2
				//IL_00ec: Incompatible stack heights: 0 vs 1
				//IL_00f6: Incompatible stack heights: 0 vs 1
				//IL_00fc: Incompatible stack heights: 0 vs 1
				//IL_0102: Incompatible stack heights: 0 vs 2
				//IL_0108: Expected I4, but got Unknown
				//IL_010e: Incompatible stack heights: 0 vs 2
				_ = ((CollectionReader)/*Error near IL_0013: Stack underflow*/)._FacadeReader;
				_003F val = /*Error near IL_0019: Stack underflow*/+ /*Error near IL_0019: Stack underflow*/;
				int num = (int)val;
				((CollectionReader)/*Error near IL_0020: Stack underflow*/)._FacadeReader = (int)val;
				if ((int)/*Error near IL_002f: Stack underflow*/ > 32768)
				{
					new InvalidOperationException();
					throw /*Error near IL_0035: Stack underflow*/;
				}
				_ = ((CollectionReader)/*Error near IL_003f: Stack underflow*/).serverReader;
				int num2 = (/*Error near IL_0045: Stack underflow*/ - /*Error near IL_0045: Stack underflow*/) & 0x7FFF;
				_ = 32768;
				int num3 = /*Error near IL_005b: Stack underflow*/- /*Error near IL_005b: Stack underflow*/;
				if (num2 <= num3 && serverReader < num3)
				{
					if (sizeinstance <= sizecaller)
					{
						Array.Copy(_RepositoryReader, num2, _RepositoryReader, serverReader, sizeinstance);
						serverReader += sizeinstance;
						return;
					}
					while (sizeinstance-- > 0)
					{
						_RepositoryReader[serverReader++] = _RepositoryReader[num2++];
					}
				}
				else
				{
					ListIterator(num2, sizeinstance, sizecaller);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int DeleteIterator(StubReader spec, int column_pol)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Incompatible stack heights: 0 vs 1
				//IL_00e8: Incompatible stack heights: 0 vs 2
				//IL_00f2: Incompatible stack heights: 0 vs 1
				//IL_00f8: Incompatible stack heights: 0 vs 1
				//IL_0102: Incompatible stack heights: 0 vs 1
				//IL_010c: Incompatible stack heights: 0 vs 1
				//IL_0119: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[8];
				int num = 32768;
				if (num != 0)
				{
					int facadeReader = ((CollectionReader)/*Error near IL_0027: Stack underflow*/)._FacadeReader;
					num = /*Error near IL_0028: Stack underflow*/- facadeReader;
				}
				Math.Min((int)/*Error near IL_00f2: Stack underflow*/, num);
				((StubReader)/*Error near IL_0102: Stack underflow*/)._0002();
				Math.Min((int)/*Error near IL_010c: Stack underflow*/, (int)/*Error near IL_010c: Stack underflow*/);
				column_pol = (int)/*Error near IL_0113: Stack underflow*/;
				*(int*)(long)(IntPtr)(/*Error near IL_0048: Stack underflow*/ + 4) = 32768 - serverReader;
				if (column_pol > *(int*)((byte*)ptr + 4))
				{
					*(int*)ptr = spec.CalculateIterator(_RepositoryReader, serverReader, *(int*)((byte*)ptr + 4));
					if (*(int*)ptr == *(int*)((byte*)ptr + 4))
					{
						*(int*)ptr += spec.CalculateIterator(_RepositoryReader, 0, column_pol - *(int*)((byte*)ptr + 4));
					}
				}
				else
				{
					*(int*)ptr = spec.CalculateIterator(_RepositoryReader, serverReader, column_pol);
				}
				serverReader = ((serverReader + *(int*)ptr) & 0x7FFF);
				_FacadeReader += *(int*)ptr;
				return *(int*)ptr;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int TestIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_0015: Expected I4, but got Unknown
				//IL_0016: Incompatible stack heights: 0 vs 2
				_ = 32768;
				int facadeReader = ((CollectionReader)/*Error near IL_0013: Stack underflow*/)._FacadeReader;
				return /*Error near IL_0014: Stack underflow*/- facadeReader;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int ConcatIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0010: Incompatible stack heights: 0 vs 1
				return ((CollectionReader)/*Error near IL_000e: Stack underflow*/)._FacadeReader;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int InvokeIterator(byte[] key, int removeVISAt, int filter_max)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0039: Invalid comparison between Unknown and I4
				//IL_0090: Incompatible stack heights: 1 vs 2
				//IL_0095: Invalid comparison between Unknown and I4
				//IL_00b9: Incompatible stack heights: 1 vs 2
				//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bd: Expected I4, but got Unknown
				//IL_00ea: Incompatible stack heights: 1 vs 2
				//IL_00eb: Invalid comparison between Unknown and I4
				//IL_0102: Incompatible stack heights: 0 vs 1
				//IL_0108: Incompatible stack heights: 0 vs 1
				//IL_010e: Incompatible stack heights: 0 vs 1
				//IL_0114: Incompatible stack heights: 0 vs 1
				//IL_011a: Incompatible stack heights: 0 vs 1
				//IL_0127: Incompatible stack heights: 0 vs 1
				//IL_012d: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[12];
				int facadeReader;
				while (true)
				{
					int num = ((CollectionReader)/*Error near IL_001d: Stack underflow*/).serverReader;
					*(int*)(long)(IntPtr)(void*)/*Error near IL_001e: Stack underflow*/ = num;
					facadeReader = ((CollectionReader)/*Error near IL_002d: Stack underflow*/)._FacadeReader;
					if (1 == 0)
					{
						break;
					}
					if (6u != 0)
					{
						if ((int)/*Error near IL_003e: Stack underflow*/ > facadeReader)
						{
							filter_max = ((CollectionReader)/*Error near IL_0048: Stack underflow*/)._FacadeReader;
						}
						else
						{
							int num2 = ((CollectionReader)/*Error near IL_0061: Stack underflow*/).serverReader;
							int facadeReader2 = _FacadeReader;
							*(int*)(long)(IntPtr)(void*)/*Error near IL_0071: Stack underflow*/ = ((num2 - facadeReader2 + filter_max) & 0x7FFF);
						}
						*(int*)((byte*)ptr + 4) = filter_max;
						if (false)
						{
							continue;
						}
						if (0 == 0)
						{
							*(int*)((byte*)ptr + 8) = filter_max - *(int*)ptr;
							_ = *(int*)((byte*)ptr + 8);
							if (false)
							{
								goto IL_00ba;
							}
							if ((int)/*Error near IL_009a: Stack underflow*/ <= facadeReader)
							{
								goto IL_00c1;
							}
							Array.Copy(_RepositoryReader, 32768 - *(int*)((byte*)ptr + 8), key, removeVISAt, *(int*)((byte*)ptr + 8));
						}
						_ = *(int*)((byte*)ptr + 8);
					}
					goto IL_00ba;
					IL_00ba:
					removeVISAt = /*Error near IL_00bb: Stack underflow*/+ facadeReader;
					filter_max = *(int*)ptr;
					goto IL_00c1;
					IL_00c1:
					Array.Copy(_RepositoryReader, *(int*)ptr - filter_max, key, removeVISAt, filter_max);
					_FacadeReader -= *(int*)((byte*)ptr + 4);
					_ = _FacadeReader;
					_ = 0;
					break;
				}
				if ((int)/*Error near IL_00f0: Stack underflow*/ < facadeReader)
				{
					throw new InvalidOperationException();
				}
				return *(int*)((byte*)ptr + 4);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public CollectionReader()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_RepositoryReader = new byte[32768];
				base._002Ector();
			}
		}

		internal sealed class ComposerEventConsumer
		{
			private short[] _ManagerReader;

			public static readonly ComposerEventConsumer _StateReader;

			public static readonly ComposerEventConsumer resolverReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ComposerEventConsumer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_004f: Invalid comparison between Unknown and I4
				//IL_0080: Invalid comparison between Unknown and I4
				//IL_0108: Incompatible stack heights: 0 vs 1
				//IL_010e: Incompatible stack heights: 0 vs 1
				//IL_0114: Incompatible stack heights: 0 vs 1
				//IL_011a: Incompatible stack heights: 0 vs 1
				//IL_0120: Incompatible stack heights: 0 vs 1
				//IL_0126: Incompatible stack heights: 0 vs 1
				//IL_012c: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				byte[] array = new byte[288];
				int num = default(int);
				while (true)
				{
					IL_001c:
					if (0 == 0)
					{
						if (0 == 0)
						{
							num = 0;
						}
						if (-1 == 0)
						{
							goto IL_00b4;
						}
						while ((int)/*Error near IL_0054: Stack underflow*/ < 144)
						{
							num++;
							((sbyte[])/*Error near IL_0045: Stack underflow*/)[(long)/*Error near IL_0045: Stack underflow*/] = 8;
						}
						if (true)
						{
							while ((int)/*Error near IL_0085: Stack underflow*/ < 256)
							{
								if (false)
								{
									goto IL_001c;
								}
								num++;
								((sbyte[])/*Error near IL_0076: Stack underflow*/)[(long)/*Error near IL_0076: Stack underflow*/] = 9;
							}
							goto IL_0096;
						}
					}
					goto IL_00d2;
					IL_0096:
					int num2;
					int num3;
					while (true)
					{
						num2 = num;
						num3 = 280;
						if (num3 == 0)
						{
							break;
						}
						if (num2 < num3)
						{
							int num4 = num++;
							((sbyte[])/*Error near IL_0096: Stack underflow*/)[num4] = 7;
							continue;
						}
						goto IL_00b4;
					}
					goto IL_00e4;
					IL_00e1:
					num2 = num;
					num3 = 32;
					goto IL_00e4;
					IL_00d2:
					num = 0;
					goto IL_00e1;
					IL_00e4:
					if (num2 >= num3)
					{
						if (8u != 0)
						{
							break;
						}
						goto IL_0096;
					}
					array[num++] = 5;
					goto IL_00e1;
					IL_00b4:
					while (num < 288)
					{
						array[num++] = 8;
					}
					_StateReader = new ComposerEventConsumer(array);
					array = new byte[32];
					goto IL_00d2;
				}
				resolverReader = new ComposerEventConsumer(array);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ComposerEventConsumer(byte[] value)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				PrintIterator(value);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private unsafe void PrintIterator(byte[] setup)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_002d: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0337: Incompatible stack heights: 0 vs 1
				//IL_033d: Incompatible stack heights: 0 vs 1
				//IL_0343: Incompatible stack heights: 0 vs 2
				//IL_0349: Incompatible stack heights: 0 vs 1
				//IL_034f: Incompatible stack heights: 0 vs 1
				//IL_0355: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[64];
				int[] array = new int[16];
				int[] array2 = new int[16];
				*(int*)(long)(IntPtr)(/*Error near IL_002e: Stack underflow*/ + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < setup.Length)
				{
					_ = /*Error near IL_003d: Stack underflow*/+ 16;
					int num = *(int*)(long)(IntPtr)(/*Error near IL_004a: Stack underflow*/ + 12);
					byte num2 = ((byte[])/*Error near IL_004c: Stack underflow*/)[num];
					*(int*)(long)(IntPtr)(void*)/*Error near IL_004d: Stack underflow*/ = num2;
					if (*(int*)(long)(IntPtr)(/*Error near IL_0055: Stack underflow*/ + 16) > 0)
					{
						int num3 = *(int*)((byte*)ptr + 16);
						((int[])/*Error near IL_0067: Stack underflow*/)[num3]++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = 512;
				*(int*)((byte*)ptr + 20) = 1;
				while (*(int*)((byte*)ptr + 20) <= 15)
				{
					array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
					*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
					if (*(int*)((byte*)ptr + 20) >= 10)
					{
						*(int*)((byte*)ptr + 24) = (array2[*(int*)((byte*)ptr + 20)] & 0x1FF80);
						*(int*)((byte*)ptr + 28) = (*(int*)ptr & 0x1FF80);
						*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
					}
					(*(int*)((byte*)ptr + 20))++;
				}
				_ManagerReader = new short[*(int*)((byte*)ptr + 4)];
				*(int*)((byte*)ptr + 8) = 512;
				*(int*)((byte*)ptr + 32) = 15;
				while (*(int*)((byte*)ptr + 32) >= 10)
				{
					*(int*)((byte*)ptr + 36) = (*(int*)ptr & 0x1FF80);
					*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 40) = (*(int*)ptr & 0x1FF80);
					while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
					{
						_ManagerReader[SystemErrorFilter.CancelIterator(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
						*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
						*(int*)((byte*)ptr + 40) += 128;
					}
					(*(int*)((byte*)ptr + 32))--;
				}
				*(int*)((byte*)ptr + 44) = 0;
				while (*(int*)((byte*)ptr + 44) < setup.Length)
				{
					*(int*)((byte*)ptr + 48) = setup[*(int*)((byte*)ptr + 44)];
					if (*(int*)((byte*)ptr + 48) != 0)
					{
						*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
						do
						{
							*(int*)((byte*)ptr + 52) = SystemErrorFilter.CancelIterator(*(int*)ptr);
							if (*(int*)((byte*)ptr + 48) <= 9)
							{
								do
								{
									_ManagerReader[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
									*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
								}
								while (*(int*)((byte*)ptr + 52) < 512);
								continue;
							}
							*(int*)((byte*)ptr + 56) = _ManagerReader[*(int*)((byte*)ptr + 52) & 0x1FF];
							*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
							*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
							do
							{
								_ManagerReader[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
								*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
							}
							while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
						}
						while (false);
						array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
					}
					(*(int*)((byte*)ptr + 44))++;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int CountIterator(StubReader res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0052: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Incompatible stack heights: 1 vs 0
				//IL_0140: Incompatible stack heights: 0 vs 1
				//IL_0146: Incompatible stack heights: 0 vs 1
				//IL_014c: Incompatible stack heights: 0 vs 2
				//IL_0152: Incompatible stack heights: 0 vs 1
				//IL_0158: Incompatible stack heights: 0 vs 1
				//IL_0162: Expected I4, but got Unknown
				//IL_0168: Incompatible stack heights: 0 vs 1
				//IL_016e: Incompatible stack heights: 0 vs 1
				void* ptr;
				int num;
				int num2;
				if (0 == 0)
				{
					while (true)
					{
						ptr = stackalloc byte[16];
						if ((num = ((StubReader)/*Error near IL_0020: Stack underflow*/).RemoveIterator(9)) < 0)
						{
							break;
						}
						_ = ((ComposerEventConsumer)/*Error near IL_0032: Stack underflow*/)._ManagerReader;
						if ((num2 = ((short[])/*Error near IL_0038: Stack underflow*/)[(long)/*Error near IL_0038: Stack underflow*/]) >= 0)
						{
							if (0 == 0)
							{
								_003F val = /*Error near IL_0053: Stack underflow*/& 0xF;
								((StubReader)/*Error near IL_0162: Stack underflow*/).PostIterator((int)val);
								if (0 == 0)
								{
									return 16 >> 4;
								}
								continue;
							}
							goto IL_00cb;
						}
						goto IL_006b;
					}
					*(int*)((byte*)ptr + 12) = res._0001();
					num = res.RemoveIterator(*(int*)((byte*)ptr + 12));
					goto IL_010b;
				}
				goto IL_0114;
				IL_006b:
				*(int*)(long)(IntPtr)(void*)/*Error near IL_0070: Stack underflow*/ = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = (num2 & 0xF);
				if ((num = res.RemoveIterator(*(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = _ManagerReader[*(int*)ptr | (num >> 9)];
					res.PostIterator(num2 & 0xF);
					return num2 >> 4;
				}
				*(int*)((byte*)ptr + 8) = res._0001();
				num = res.RemoveIterator(*(int*)((byte*)ptr + 8));
				num2 = _ManagerReader[*(int*)ptr | (num >> 9)];
				goto IL_00cb;
				IL_00cb:
				if (4u != 0)
				{
					if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
					{
						res.PostIterator(num2 & 0xF);
						if (0 == 0)
						{
							return num2 >> 4;
						}
						goto IL_010b;
					}
					return -1;
				}
				goto IL_011b;
				IL_0137:
				return -1;
				IL_010b:
				num2 = _ManagerReader[num];
				goto IL_0114;
				IL_011b:
				if ((num2 & 0xF) <= *(int*)((byte*)ptr + 12))
				{
					res.PostIterator(num2 & 0xF);
					return num2 >> 4;
				}
				goto IL_0137;
				IL_0114:
				if (num2 >= 0)
				{
					goto IL_011b;
				}
				goto IL_0137;
			}
		}

		internal sealed class ErrorClassDispatcher
		{
			private static readonly int[] _PoolReader;

			private static readonly int[] m_ValReader;

			private byte[] invocationReader;

			private byte[] m_DefinitionReader;

			private ComposerEventConsumer _SystemReader;

			private int m_IdentifierReader;

			private int m_GetterReader;

			private int m_SetterReader;

			private int workerReader;

			private int _AdvisorReader;

			private int rulesReader;

			private byte m_ContextReader;

			private int _ParamReader;

			private static readonly int[] _PublisherReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ErrorClassDispatcher()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe bool AssetIterator(StubReader first)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_02d7: Incompatible stack heights: 0 vs 1
				//IL_02dd: Incompatible stack heights: 0 vs 1
				//IL_02e3: Incompatible stack heights: 0 vs 1
				//IL_02e9: Incompatible stack heights: 0 vs 1
				//IL_02ef: Incompatible stack heights: 0 vs 1
				//IL_02f9: Incompatible stack heights: 0 vs 1
				//IL_02ff: Incompatible stack heights: 0 vs 1
				//IL_0305: Incompatible stack heights: 0 vs 1
				void* ptr = stackalloc byte[16];
				while (true)
				{
					int identifierReader = ((ErrorClassDispatcher)/*Error near IL_001d: Stack underflow*/).m_IdentifierReader;
					*(int*)(long)(IntPtr)(void*)/*Error near IL_001e: Stack underflow*/ = identifierReader;
					switch (*(int*)(long)(IntPtr)(void*)/*Error near IL_0024: Stack underflow*/)
					{
					default:
						continue;
					case 0:
					{
						((StubReader)/*Error near IL_02f9: Stack underflow*/).RemoveIterator(5);
						((ErrorClassDispatcher)/*Error near IL_005b: Stack underflow*/).m_GetterReader = (int)/*Error near IL_005b: Stack underflow*/;
						if (((ErrorClassDispatcher)/*Error near IL_0065: Stack underflow*/).m_GetterReader < 0)
						{
							return false;
						}
						int getterReader = m_GetterReader;
						((ErrorClassDispatcher)/*Error near IL_0083: Stack underflow*/).m_GetterReader = getterReader + 257;
						first.PostIterator(5);
						m_IdentifierReader = 1;
						goto case 1;
					}
					case 1:
						m_SetterReader = first.RemoveIterator(5);
						if (m_SetterReader < 0)
						{
							return false;
						}
						m_SetterReader++;
						first.PostIterator(5);
						_AdvisorReader = m_GetterReader + m_SetterReader;
						m_DefinitionReader = new byte[_AdvisorReader];
						m_IdentifierReader = 2;
						goto case 2;
					case 2:
						workerReader = first.RemoveIterator(4);
						if (workerReader < 0)
						{
							return false;
						}
						workerReader += 4;
						first.PostIterator(4);
						invocationReader = new byte[19];
						_ParamReader = 0;
						m_IdentifierReader = 3;
						goto case 3;
					case 3:
						while (_ParamReader < workerReader)
						{
							*(int*)((byte*)ptr + 4) = first.RemoveIterator(3);
							if (*(int*)((byte*)ptr + 4) < 0)
							{
								return false;
							}
							first.PostIterator(3);
							invocationReader[_PublisherReader[_ParamReader]] = (byte)(*(int*)((byte*)ptr + 4));
							_ParamReader++;
						}
						_SystemReader = new ComposerEventConsumer(invocationReader);
						invocationReader = null;
						_ParamReader = 0;
						m_IdentifierReader = 4;
						goto case 4;
					case 4:
					{
						int num;
						while (((num = _SystemReader.CountIterator(first)) & -16) == 0)
						{
							byte[] definitionReader = m_DefinitionReader;
							*(int*)((byte*)ptr + 8) = _ParamReader;
							_ParamReader = *(int*)((byte*)ptr + 8) + 1;
							definitionReader[*(int*)((byte*)ptr + 8)] = (m_ContextReader = (byte)num);
							if (_ParamReader == _AdvisorReader)
							{
								return true;
							}
						}
						if (num < 0)
						{
							return false;
						}
						if (num >= 17)
						{
							m_ContextReader = 0;
						}
						rulesReader = num - 16;
						m_IdentifierReader = 5;
						break;
					}
					case 5:
						break;
					}
					*(int*)((byte*)ptr + 12) = m_ValReader[rulesReader];
					int num2 = first.RemoveIterator(*(int*)((byte*)ptr + 12));
					if (num2 < 0)
					{
						return false;
					}
					first.PostIterator(*(int*)((byte*)ptr + 12));
					num2 += _PoolReader[rulesReader];
					while (num2-- > 0)
					{
						byte[] definitionReader2 = m_DefinitionReader;
						*(int*)((byte*)ptr + 8) = _ParamReader;
						_ParamReader = *(int*)((byte*)ptr + 8) + 1;
						definitionReader2[*(int*)((byte*)ptr + 8)] = m_ContextReader;
					}
					if (_ParamReader == _AdvisorReader)
					{
						break;
					}
					m_IdentifierReader = 4;
				}
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ComposerEventConsumer CustomizeIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0044: Incompatible stack heights: 0 vs 1
				//IL_0050: Incompatible stack heights: 0 vs 1
				//IL_0056: Incompatible stack heights: 0 vs 3
				//IL_005c: Incompatible stack heights: 0 vs 2
				//IL_006c: Incompatible stack heights: 0 vs 1
				//IL_0076: Incompatible stack heights: 0 vs 1
				byte[] array = new byte[((ErrorClassDispatcher)/*Error near IL_000e: Stack underflow*/).m_GetterReader];
				_ = ((ErrorClassDispatcher)/*Error near IL_0022: Stack underflow*/).m_DefinitionReader;
				_ = 0;
				_ = 0;
				Array.Copy(length: ((ErrorClassDispatcher)/*Error near IL_0033: Stack underflow*/).m_GetterReader, sourceArray: (Array)/*Error near IL_0066: Stack underflow*/, sourceIndex: (int)/*Error near IL_0066: Stack underflow*/, destinationArray: (Array)/*Error near IL_0066: Stack underflow*/, destinationIndex: (int)/*Error near IL_0066: Stack underflow*/);
				new ComposerEventConsumer((byte[])/*Error near IL_0076: Stack underflow*/);
				return (ComposerEventConsumer)/*Error near IL_0043: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ComposerEventConsumer QueryIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_004d: Incompatible stack heights: 0 vs 1
				//IL_0059: Incompatible stack heights: 0 vs 1
				//IL_005f: Incompatible stack heights: 0 vs 2
				//IL_0065: Incompatible stack heights: 0 vs 2
				//IL_006b: Incompatible stack heights: 0 vs 2
				//IL_007b: Incompatible stack heights: 0 vs 1
				//IL_0085: Incompatible stack heights: 0 vs 1
				byte[] array = new byte[((ErrorClassDispatcher)/*Error near IL_000e: Stack underflow*/).m_SetterReader];
				_ = ((ErrorClassDispatcher)/*Error near IL_0022: Stack underflow*/).m_DefinitionReader;
				_ = ((ErrorClassDispatcher)/*Error near IL_002c: Stack underflow*/).m_GetterReader;
				_ = 0;
				Array.Copy(length: ((ErrorClassDispatcher)/*Error near IL_003c: Stack underflow*/).m_SetterReader, sourceArray: (Array)/*Error near IL_0075: Stack underflow*/, sourceIndex: (int)/*Error near IL_0075: Stack underflow*/, destinationArray: (Array)/*Error near IL_0075: Stack underflow*/, destinationIndex: (int)/*Error near IL_0075: Stack underflow*/);
				new ComposerEventConsumer((byte[])/*Error near IL_0085: Stack underflow*/);
				return (ComposerEventConsumer)/*Error near IL_004c: Stack underflow*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ErrorClassDispatcher()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_006e: Incompatible stack heights: 0 vs 1
				//IL_0078: Incompatible stack heights: 0 vs 1
				//IL_0082: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				while (true)
				{
					int num = 3;
					while (true)
					{
						IL_000e:
						RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
						_PoolReader = (int[])/*Error near IL_0023: Stack underflow*/;
						while (0 == 0)
						{
							num = 3;
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								m_ValReader = (int[])/*Error near IL_0045: Stack underflow*/;
								if (false)
								{
									continue;
								}
								num = 19;
							}
							if (num != 0)
							{
								RuntimeHelpers.InitializeArray(new int[num], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
								_PublisherReader = (int[])/*Error near IL_0068: Stack underflow*/;
								return;
							}
							goto IL_000e;
						}
						break;
					}
				}
			}
		}

		internal sealed class SystemErrorFilter
		{
			private static readonly int[] utilsReader;

			private static readonly byte[] _StrategyReader;

			private static readonly short[] infoReader;

			private static readonly byte[] m_ValueReader;

			private static readonly short[] _ParameterReader;

			private static readonly byte[] prototypeReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static short CancelIterator(int instance_end)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0033: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Incompatible stack heights: 0 vs 2
				//IL_0053: Incompatible stack heights: 0 vs 3
				//IL_0059: Incompatible stack heights: 0 vs 3
				//IL_005f: Incompatible stack heights: 0 vs 3
				_ = _StrategyReader;
				_003F val = /*Error near IL_0011: Stack underflow*/& 0xF;
				_ = ((byte[])/*Error near IL_0012: Stack underflow*/)[(long)val] << 12;
				_ = _StrategyReader;
				_003F val2 = (long)/*Error near IL_0021: Stack underflow*/ >> 4;
				byte num = ((byte[])/*Error near IL_0025: Stack underflow*/)[(long)(val2 & 0xF)];
				_ = (/*Error near IL_0028: Stack underflow*/ | (num << 8));
				_ = _StrategyReader;
				_003F val3 = (long)/*Error near IL_0034: Stack underflow*/ >> 8;
				byte num2 = ((byte[])/*Error near IL_0038: Stack underflow*/)[(long)(val3 & 0xF)];
				_ = (/*Error near IL_003b: Stack underflow*/ | (num2 << 4));
				_ = _StrategyReader;
				_003F val4 = (long)/*Error near IL_0048: Stack underflow*/ >> 12;
				byte num3 = ((byte[])/*Error near IL_0049: Stack underflow*/)[(long)val4];
				return (short)(/*Error near IL_004a: Stack underflow*/ | num3);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static SystemErrorFilter()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Invalid comparison between Unknown and I4
				//IL_01a6: Incompatible stack heights: 0 vs 1
				//IL_01b0: Incompatible stack heights: 0 vs 1
				//IL_01bc: Incompatible stack heights: 0 vs 2
				//IL_01c2: Incompatible stack heights: 0 vs 2
				//IL_01cc: Expected I4, but got Unknown
				//IL_01cc: Incompatible stack heights: 0 vs 1
				//IL_01d2: Incompatible stack heights: 0 vs 2
				//IL_01d8: Incompatible stack heights: 0 vs 1
				//IL_01de: Incompatible stack heights: 0 vs 2
				SingletonReader.PushGlobal();
				while (true)
				{
					_ = new int[19]
					{
						16,
						17,
						18,
						0,
						8,
						7,
						9,
						6,
						10,
						5,
						11,
						4,
						12,
						3,
						13,
						2,
						14,
						1,
						15
					};
					utilsReader = (int[])/*Error near IL_0024: Stack underflow*/;
					while (true)
					{
						IL_0024:
						_ = new byte[16]
						{
							0,
							8,
							4,
							12,
							2,
							10,
							6,
							14,
							1,
							9,
							5,
							13,
							3,
							11,
							7,
							15
						};
						_StrategyReader = (byte[])/*Error near IL_003b: Stack underflow*/;
						infoReader = new short[286];
						m_ValueReader = new byte[286];
						int num;
						if (0 == 0)
						{
							num = 0;
							goto IL_009f;
						}
						goto IL_00c7;
						IL_009f:
						if ((int)/*Error near IL_00a9: Stack underflow*/ < 144)
						{
							_ = infoReader;
							_ = 48;
							CancelIterator((int)((long)(/*Error near IL_007c: Stack underflow*/ + /*Error near IL_007c: Stack underflow*/) << 8));
							((short[])/*Error near IL_0084: Stack underflow*/)[(long)/*Error near IL_0084: Stack underflow*/] = (short)/*Error near IL_0084: Stack underflow*/;
							goto IL_0084;
						}
						goto IL_00d4;
						IL_00c7:
						m_ValueReader[num++] = 9;
						goto IL_00d4;
						IL_00d4:
						if (num < 256)
						{
							_ = infoReader;
							short num2 = CancelIterator(256 + num << 7);
							((short[])/*Error near IL_00c7: Stack underflow*/)[(long)/*Error near IL_00c7: Stack underflow*/] = num2;
							goto IL_00c7;
						}
						if (false)
						{
							break;
						}
						while (true)
						{
							int num3 = num;
							while (num3 >= 280)
							{
								while (num < 286)
								{
									infoReader[num] = CancelIterator(-88 + num << 8);
									m_ValueReader[num++] = 8;
								}
								_ParameterReader = new short[30];
								prototypeReader = new byte[30];
								if (0 == 0)
								{
									num = 0;
									while (true)
									{
										if (num < 30)
										{
											_ParameterReader[num] = CancelIterator(num << 11);
											if (2 == 0)
											{
												break;
											}
											prototypeReader[num] = 5;
											num3 = num;
											if (3 == 0)
											{
												goto IL_0113;
											}
											num = num3 + 1;
											continue;
										}
										return;
									}
									goto IL_0024;
								}
								goto IL_0084;
								IL_0113:;
							}
							infoReader[num] = CancelIterator(-256 + num << 9);
							if (7 == 0)
							{
								break;
							}
							m_ValueReader[num++] = 7;
						}
						break;
						IL_0084:
						if (0 == 0)
						{
							_ = m_ValueReader;
							num++;
							((sbyte[])/*Error near IL_009a: Stack underflow*/)[(long)/*Error near IL_009a: Stack underflow*/] = 8;
							goto IL_009f;
						}
						goto IL_00d4;
					}
				}
			}
		}

		internal sealed class RefIssuerImporter : MemoryStream
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int ExcludeIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001c: Expected I4, but got Unknown
				//IL_001d: Incompatible stack heights: 0 vs 1
				//IL_0027: Incompatible stack heights: 0 vs 1
				//IL_002d: Incompatible stack heights: 0 vs 1
				//IL_0037: Incompatible stack heights: 0 vs 1
				((Stream)/*Error near IL_0027: Stack underflow*/).ReadByte();
				((Stream)/*Error near IL_0037: Stack underflow*/).ReadByte();
				_003F val = (long)/*Error near IL_001a: Stack underflow*/ << 8;
				return /*Error near IL_001b: Stack underflow*/| val;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int SetupIterator()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_001a: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected I4, but got Unknown
				//IL_001e: Incompatible stack heights: 0 vs 1
				//IL_0028: Incompatible stack heights: 0 vs 1
				//IL_002e: Incompatible stack heights: 0 vs 1
				//IL_0038: Incompatible stack heights: 0 vs 1
				((RefIssuerImporter)/*Error near IL_0028: Stack underflow*/).ExcludeIterator();
				((RefIssuerImporter)/*Error near IL_0038: Stack underflow*/).ExcludeIterator();
				_003F val = (long)/*Error near IL_001b: Stack underflow*/ << 16;
				return /*Error near IL_001c: Stack underflow*/| val;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RefIssuerImporter(byte[] task)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector(task, writable: false);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RegisterIterator(Assembly spec, Assembly b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ICryptoTransform RestartIterator(byte[] value, byte[] b, bool loaddir)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			//IL_007c: Incompatible stack heights: 0 vs 1
			//IL_0082: Incompatible stack heights: 0 vs 1
			//IL_00a7: Incompatible stack heights: 0 vs 1
			new RijndaelManaged();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_00ad: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (false || (int)/*Error near IL_001e: Stack underflow*/ != 0)
					{
						goto IL_0047;
					}
					if (false)
					{
						continue;
					}
					((SymmetricAlgorithm)/*Error near IL_0076: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_0076: Stack underflow*/, (byte[])/*Error near IL_0076: Stack underflow*/);
					goto IL_004d;
					IL_004d:
					result = (ICryptoTransform)/*Error near IL_004e: Stack underflow*/;
					if (3u != 0)
					{
						break;
					}
					goto IL_0047;
					IL_0047:
					((SymmetricAlgorithm)/*Error near IL_004d: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_004d: Stack underflow*/, b);
					goto IL_004d;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && symmetricAlgorithm != null && 0 == 0)
				{
					((IDisposable)symmetricAlgorithm).Dispose();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ICryptoTransform SearchIterator(byte[] reference, byte[] second, bool verifyutil)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0048: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0060: Incompatible stack heights: 0 vs 1
			//IL_0066: Incompatible stack heights: 0 vs 1
			//IL_006c: Incompatible stack heights: 0 vs 1
			//IL_0076: Incompatible stack heights: 0 vs 1
			//IL_007c: Incompatible stack heights: 0 vs 1
			//IL_0082: Incompatible stack heights: 0 vs 1
			//IL_00a7: Incompatible stack heights: 0 vs 1
			new DESCryptoServiceProvider();
			DESCryptoServiceProvider dESCryptoServiceProvider = (DESCryptoServiceProvider)/*Error near IL_00ad: Stack underflow*/;
			try
			{
				ICryptoTransform result;
				while (true)
				{
					if (false || (int)/*Error near IL_001e: Stack underflow*/ != 0)
					{
						goto IL_0047;
					}
					if (false)
					{
						continue;
					}
					((SymmetricAlgorithm)/*Error near IL_0076: Stack underflow*/).CreateEncryptor((byte[])/*Error near IL_0076: Stack underflow*/, (byte[])/*Error near IL_0076: Stack underflow*/);
					goto IL_004d;
					IL_004d:
					result = (ICryptoTransform)/*Error near IL_004e: Stack underflow*/;
					if (3u != 0)
					{
						break;
					}
					goto IL_0047;
					IL_0047:
					((SymmetricAlgorithm)/*Error near IL_004d: Stack underflow*/).CreateDecryptor((byte[])/*Error near IL_004d: Stack underflow*/, second);
					goto IL_004d;
				}
				return result;
			}
			finally
			{
				if (6u != 0 && dESCryptoServiceProvider != null && 0 == 0)
				{
					((IDisposable)dESCryptoServiceProvider).Dispose();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe static byte[] ComputeIterator(byte[] i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0340: Incompatible stack heights: 0 vs 1
			//IL_0350: Incompatible stack heights: 0 vs 1
			//IL_035c: Incompatible stack heights: 0 vs 1
			//IL_0362: Incompatible stack heights: 0 vs 1
			//IL_0368: Incompatible stack heights: 0 vs 1
			//IL_036e: Incompatible stack heights: 0 vs 1
			byte* intPtr = stackalloc byte[42];
			void* ptr;
			if (5u != 0)
			{
				ptr = intPtr;
			}
			Assembly.GetCallingAssembly();
			Assembly assembly = (Assembly)/*Error near IL_0346: Stack underflow*/;
			Assembly.GetExecutingAssembly();
			Assembly assembly2 = (Assembly)/*Error near IL_0356: Stack underflow*/;
			if (/*Error near IL_0033: Stack underflow*/ != /*Error near IL_0033: Stack underflow*/&& !RegisterIterator((Assembly)/*Error near IL_0042: Stack underflow*/, (Assembly)/*Error near IL_0042: Stack underflow*/))
			{
				return null;
			}
			RefIssuerImporter refIssuerImporter = new RefIssuerImporter(i);
			byte[] array = new byte[0];
			*(int*)ptr = refIssuerImporter.SetupIterator();
			int num;
			if (*(int*)ptr == 67324752)
			{
				*(short*)((byte*)ptr + 40) = (short)refIssuerImporter.ExcludeIterator();
				*(int*)((byte*)ptr + 4) = refIssuerImporter.ExcludeIterator();
				*(int*)((byte*)ptr + 8) = refIssuerImporter.ExcludeIterator();
				if (*(int*)ptr == 67324752 && *(short*)((byte*)ptr + 40) == 20 && *(int*)((byte*)ptr + 4) == 0)
				{
					num = *(int*)((byte*)ptr + 8);
					while (num == 8)
					{
						num = refIssuerImporter.SetupIterator();
						if (4u != 0)
						{
							if (1 == 0)
							{
								continue;
							}
							goto IL_00d5;
						}
						goto IL_01ca;
					}
				}
				throw new FormatException("Wrong Header Signature");
			}
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr == 8223355)
			{
				num = *(int*)((byte*)ptr + 24);
				goto IL_01ca;
			}
			throw new FormatException("Unknown Header");
			IL_032a:
			refIssuerImporter.Close();
			refIssuerImporter = null;
			return array;
			IL_00d5:
			refIssuerImporter.SetupIterator();
			refIssuerImporter.SetupIterator();
			*(int*)((byte*)ptr + 12) = refIssuerImporter.SetupIterator();
			*(int*)((byte*)ptr + 16) = refIssuerImporter.ExcludeIterator();
			*(int*)((byte*)ptr + 20) = refIssuerImporter.ExcludeIterator();
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				refIssuerImporter.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				refIssuerImporter.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			long num2 = refIssuerImporter.Length;
			do
			{
				num2 -= refIssuerImporter.Position;
			}
			while (false);
			byte[] array2 = new byte[num2];
			refIssuerImporter.Read(array2, 0, array2.Length);
			FacadeListAnnotation facadeListAnnotation = new FacadeListAnnotation(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			facadeListAnnotation.RateIterator(array, 0, array.Length);
			array2 = null;
			goto IL_032a;
			IL_01ca:
			if (num == 1)
			{
				*(int*)((byte*)ptr + 28) = refIssuerImporter.SetupIterator();
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num3 = refIssuerImporter.SetupIterator();
					*(int*)((byte*)ptr + 36) = refIssuerImporter.SetupIterator();
					byte[] array3 = new byte[num3];
					refIssuerImporter.Read(array3, 0, array3.Length);
					new FacadeListAnnotation(array3).RateIterator(array, *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 36));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] reference = new byte[8]
				{
					76,
					118,
					197,
					23,
					11,
					245,
					6,
					75
				};
				byte[] second = new byte[8]
				{
					73,
					104,
					135,
					4,
					141,
					104,
					114,
					45
				};
				using (ICryptoTransform cryptoTransform = SearchIterator(reference, second, verifyutil: true))
				{
					array = ComputeIterator(cryptoTransform.TransformFinalBlock(i, 4, i.Length - 4));
				}
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] value = new byte[16]
				{
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1
				};
				byte[] b = new byte[16]
				{
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2
				};
				using (ICryptoTransform cryptoTransform2 = RestartIterator(value, b, loaddir: true))
				{
					array = ComputeIterator(cryptoTransform2.TransformFinalBlock(i, 4, i.Length - 4));
				}
			}
			goto IL_032a;
		}
	}
}
