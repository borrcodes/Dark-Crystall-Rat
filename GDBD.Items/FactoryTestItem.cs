using GDBD.Workers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDBD.Items
{
	internal sealed class FactoryTestItem
	{
		private struct InvocationClientBridge
		{
			public long systemEvent;

			public long identifierEvent;
		}

		private struct TaskErrorFilter
		{
			public long _GetterEvent;

			public string m_SetterEvent;

			public string m_WorkerEvent;

			public long m_AdvisorEvent;

			public string _RulesEvent;
		}

		private struct SpecificationReaderMapper
		{
			public long _ContextEvent;

			public string[] _ParamEvent;
		}

		private byte[] m_ManagerEvent;

		private ulong _StateEvent;

		private string[] _ResolverEvent;

		private TaskErrorFilter[] _PoolEvent;

		private ushort valEvent;

		private byte[] m_InvocationEvent;

		private SpecificationReaderMapper[] definitionEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryTestItem(string value)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_InvocationEvent = new byte[10]
			{
				0,
				1,
				2,
				3,
				4,
				6,
				8,
				8,
				0,
				0
			};
			base._002Ector();
			if (!File.Exists(value))
			{
				return;
			}
			FileSystem.FileOpen(1, value, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared);
			string Value = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref Value, -1L);
			FileSystem.FileClose(1);
			m_ManagerEvent = Encoding.Default.GetBytes(Value);
			if (Encoding.Default.GetString(m_ManagerEvent, 0, 15).CompareTo("SQLite format 3") == 0 && m_ManagerEvent[52] == 0)
			{
				valEvent = (ushort)AwakeList(16, 2);
				_StateEvent = AwakeList(56, 4);
				if (decimal.Compare(new decimal(_StateEvent), 0m) == 0)
				{
					_StateEvent = 1uL;
				}
				RegisterList(100uL);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong AwakeList(int start_asset, int start_col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (start_col > 8 || start_col == 0)
			{
				return 0uL;
			}
			ulong num = 0uL;
			int num2 = start_col - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = ((num << 8) | m_ManagerEvent[start_asset + i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long UpdateList(int asset_min, int sum_cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			sum_cust++;
			byte[] array = new byte[8];
			int num = sum_cust - asset_min;
			bool flag = false;
			if (num == 0 || num > 9)
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(m_ManagerEvent[asset_min] & 0x7F);
				return BitConverter.ToInt64(array, 0);
			case 9:
				flag = true;
				break;
			}
			int num2 = 1;
			int num3 = 7;
			int num4 = 0;
			if (flag)
			{
				array[0] = m_ManagerEvent[sum_cust - 1];
				sum_cust--;
				num4 = 1;
			}
			for (int i = sum_cust - 1; i >= asset_min; i += -1)
			{
				if (i - 1 >= asset_min)
				{
					array[num4] = (byte)(((byte)(m_ManagerEvent[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(m_ManagerEvent[i - 1] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((byte)(m_ManagerEvent[i] >> ((num2 - 1) & 7)) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ReadList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return definitionEvent.Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string[] InterruptList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string[] array = null;
			int num = 0;
			int num2 = _PoolEvent.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (_PoolEvent[i].m_SetterEvent == "table")
				{
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[num] = _PoolEvent[i].m_WorkerEvent;
					num++;
				}
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CalcList(int first_Y, int visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first_Y >= definitionEvent.Length)
			{
				return null;
			}
			if (visitor >= definitionEvent[first_Y]._ParamEvent.Length)
			{
				return null;
			}
			return definitionEvent[first_Y]._ParamEvent[visitor];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string InstantiateList(int i_ID, string b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = -1;
			int num2 = _ResolverEvent.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (_ResolverEvent[i].ToLower().CompareTo(b.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return null;
			}
			return CalcList(i_ID, num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int ReflectList(int valueend)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (valueend > m_ManagerEvent.Length)
			{
				return 0;
			}
			int num = valueend + 8;
			for (int i = valueend; i <= num; i++)
			{
				if (i > m_ManagerEvent.Length - 1)
				{
					return 0;
				}
				if ((m_ManagerEvent[i] & 0x80) != 128)
				{
					return i;
				}
			}
			return valueend + 8;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ResetList(long nextvalue)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (nextvalue & 1) == 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RegisterList(ulong i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ManagerEvent[(uint)i] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(i), 3m)), 2)), 1m));
				int num2 = 0;
				if (_PoolEvent != null)
				{
					num2 = _PoolEvent.Length;
					_PoolEvent = (TaskErrorFilter[])Utils.CopyArray(_PoolEvent, new TaskErrorFilter[_PoolEvent.Length + num + 1]);
				}
				else
				{
					_PoolEvent = new TaskErrorFilter[num + 1];
				}
				int num3 = num;
				for (int j = 0; j <= num3; j++)
				{
					ulong num4 = AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(i), 8m), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(i), 100m) != 0)
					{
						num4 += i;
					}
					int num5 = ReflectList((int)num4);
					UpdateList((int)num4, num5);
					int num6 = ReflectList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					_PoolEvent[num2 + j]._GetterEvent = UpdateList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = ReflectList((int)num4);
					num6 = num5;
					long value = UpdateList((int)num4, num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = ReflectList(num5);
						array[num7] = UpdateList(num5, num6);
						if (array[num7] > 9)
						{
							if (ResetList(array[num7]))
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 13) / 2.0);
							}
							else
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 12) / 2.0);
							}
						}
						else
						{
							array[num7] = m_InvocationEvent[(int)array[num7]];
						}
						num7++;
					}
					while (num7 <= 4);
					if (decimal.Compare(new decimal(_StateEvent), 1m) == 0)
					{
						_PoolEvent[num2 + j].m_SetterEvent = Encoding.Default.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 2m) == 0)
					{
						_PoolEvent[num2 + j].m_SetterEvent = Encoding.Unicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 3m) == 0)
					{
						_PoolEvent[num2 + j].m_SetterEvent = Encoding.BigEndianUnicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(_StateEvent), 1m) == 0)
					{
						_PoolEvent[num2 + j].m_WorkerEvent = Encoding.Default.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 2m) == 0)
					{
						_PoolEvent[num2 + j].m_WorkerEvent = Encoding.Unicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 3m) == 0)
					{
						_PoolEvent[num2 + j].m_WorkerEvent = Encoding.BigEndianUnicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					_PoolEvent[num2 + j].m_AdvisorEvent = (long)AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(_StateEvent), 1m) == 0)
					{
						_PoolEvent[num2 + j]._RulesEvent = Encoding.Default.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 2m) == 0)
					{
						_PoolEvent[num2 + j]._RulesEvent = Encoding.Unicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(_StateEvent), 3m) == 0)
					{
						_PoolEvent[num2 + j]._RulesEvent = Encoding.BigEndianUnicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (m_ManagerEvent[(uint)i] != 5)
				{
					return;
				}
				int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(i), 3m)), 2)), 1m));
				for (int k = 0; k <= num8; k++)
				{
					ushort num9 = (ushort)AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(i), 12m), new decimal(k * 2))), 2);
					if (decimal.Compare(new decimal(i), 100m) == 0)
					{
						RegisterList(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(AwakeList(num9, 4)), 1m), new decimal(valEvent))));
					}
					else
					{
						RegisterList(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(AwakeList((int)(i + num9), 4)), 1m), new decimal(valEvent))));
					}
				}
				RegisterList(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(i), 8m)), 4)), 1m), new decimal(valEvent))));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RestartList(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = -1;
			int num2 = _PoolEvent.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (_PoolEvent[i].m_WorkerEvent.ToLower().CompareTo(value.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = _PoolEvent[num]._RulesEvent.Substring(_PoolEvent[num]._RulesEvent.IndexOf("(") + 1).Split(',');
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = array[j].TrimStart();
				int num4 = array[j].IndexOf(" ");
				if (num4 > 0)
				{
					array[j] = array[j].Substring(0, num4);
				}
				if (array[j].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				_ResolverEvent = (string[])Utils.CopyArray(_ResolverEvent, new string[j + 1]);
				_ResolverEvent[j] = array[j];
			}
			return SearchList((ulong)((_PoolEvent[num].m_AdvisorEvent - 1) * valEvent));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SearchList(ulong version_setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ManagerEvent[(uint)version_setup] == 13)
			{
				int num = Convert.ToInt32(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(version_setup), 3m)), 2)), 1m));
				int num2 = 0;
				if (definitionEvent != null)
				{
					num2 = definitionEvent.Length;
					definitionEvent = (SpecificationReaderMapper[])Utils.CopyArray(definitionEvent, new SpecificationReaderMapper[definitionEvent.Length + num + 1]);
				}
				else
				{
					definitionEvent = new SpecificationReaderMapper[num + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					InvocationClientBridge[] array = null;
					ulong num4 = AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(version_setup), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(version_setup), 100m) != 0)
					{
						num4 += version_setup;
					}
					int num5 = ReflectList((int)num4);
					UpdateList((int)num4, num5);
					int num6 = ReflectList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					definitionEvent[num2 + i]._ContextEvent = UpdateList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = ReflectList((int)num4);
					num6 = num5;
					long num7 = UpdateList((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (InvocationClientBridge[])Utils.CopyArray(array, new InvocationClientBridge[num9 + 1]);
						num5 = num6 + 1;
						num6 = ReflectList(num5);
						array[num9].identifierEvent = UpdateList(num5, num6);
						if (array[num9].identifierEvent > 9)
						{
							if (ResetList(array[num9].identifierEvent))
							{
								array[num9].systemEvent = (long)Math.Round((double)(array[num9].identifierEvent - 13) / 2.0);
							}
							else
							{
								array[num9].systemEvent = (long)Math.Round((double)(array[num9].identifierEvent - 12) / 2.0);
							}
						}
						else
						{
							array[num9].systemEvent = m_InvocationEvent[(int)array[num9].identifierEvent];
						}
						num8 = num8 + (num6 - num5) + 1;
						num9++;
					}
					definitionEvent[num2 + i]._ParamEvent = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].identifierEvent > 9)
						{
							if (!ResetList(array[j].identifierEvent))
							{
								if (decimal.Compare(new decimal(_StateEvent), 1m) == 0)
								{
									definitionEvent[num2 + i]._ParamEvent[j] = Encoding.Default.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].systemEvent);
								}
								else if (decimal.Compare(new decimal(_StateEvent), 2m) == 0)
								{
									definitionEvent[num2 + i]._ParamEvent[j] = Encoding.Unicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].systemEvent);
								}
								else if (decimal.Compare(new decimal(_StateEvent), 3m) == 0)
								{
									definitionEvent[num2 + i]._ParamEvent[j] = Encoding.BigEndianUnicode.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].systemEvent);
								}
							}
							else
							{
								definitionEvent[num2 + i]._ParamEvent[j] = Encoding.Default.GetString(m_ManagerEvent, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].systemEvent);
							}
						}
						else
						{
							definitionEvent[num2 + i]._ParamEvent[j] = Conversions.ToString(AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].systemEvent));
						}
						num10 += (int)array[j].systemEvent;
					}
				}
			}
			else if (m_ManagerEvent[(uint)version_setup] == 5)
			{
				int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(version_setup), 3m)), 2)), 1m));
				for (int k = 0; k <= num12; k++)
				{
					ushort num13 = (ushort)AwakeList(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(version_setup), 12m), new decimal(k * 2))), 2);
					SearchList(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(AwakeList((int)(version_setup + num13), 4)), 1m), new decimal(valEvent))));
				}
				SearchList(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(AwakeList(Convert.ToInt32(decimal.Add(new decimal(version_setup), 8m)), 4)), 1m), new decimal(valEvent))));
			}
			return true;
		}
	}
}
