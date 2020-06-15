using GDBD.Items;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Resolver;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Filters
{
	internal sealed class CodeErrorFilter
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly byte[] _Producer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ulong m_Struct;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string[] _Stub;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly ushort _Task;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ImporterClassSpec[] m_Customer;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RepositoryPropertyStruct[] _Interpreter;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly byte[] _Watcher;

		public string[] Fields
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
			[MethodImpl(MethodImplOptions.NoInlining)]
			set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _Producer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private ulong _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_Struct;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int MoveEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private ushort _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private ImporterClassSpec[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_Customer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(ImporterClassSpec[] info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_Customer = info;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private RepositoryPropertyStruct[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _Interpreter;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(RepositoryPropertyStruct[] info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_Interpreter = info;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private byte[] _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _Watcher;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CodeErrorFilter(string config)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_Watcher = new byte[10]
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
			if (File.Exists(config))
			{
				FileSystem.FileOpen(1, config, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared);
				string Value = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref Value, -1L);
				FileSystem.FileClose(1);
				_Producer = Encoding.Default.GetBytes(Value);
				_Task = (ushort)FlushEvent(16, 2);
				m_Struct = FlushEvent(56, 4);
				if (decimal.Compare(new decimal(this._0001()), 0m) == 0)
				{
					m_Struct = 1uL;
				}
				LogoutEvent(100uL);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string[] AddEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string[] array = null;
			int num = 0;
			int num2 = this._0001().Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this._0001()[i].Type == "table")
				{
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[num] = this._0001()[i].Name;
					num++;
				}
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string EnableEvent(int version_item, int predmin)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (version_item >= this._0001().Length)
			{
				return null;
			}
			if (predmin >= this._0001()[version_item].AwakeRecord().Length)
			{
				return null;
			}
			return this._0001()[version_item].AwakeRecord()[predmin];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string MapEvent(int res_X, string visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = -1;
			int num2 = Fields.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (Fields[i].ToLower().Trim().CompareTo(visitor.ToLower().Trim()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return null;
			}
			return EnableEvent(res_X, num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool InsertEvent(string asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = -1;
			int num2 = this._0001().Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this._0001()[i].Name.ToLower().CompareTo(asset.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = this._0001()[num].PopRecord().Substring(this._0001()[num].PopRecord().IndexOf("(") + 1).Split(',');
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
				Fields = (string[])Utils.CopyArray(Fields, new string[j + 1]);
				Fields[j] = array[j];
			}
			return VisitEvent((ulong)((this._0001()[num].ViewRecord() - 1) * this._0001()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong FlushEvent(int info, int offset_attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (offset_attr > 8 || offset_attr == 0)
			{
				return 0uL;
			}
			ulong num = 0uL;
			for (int i = 0; i <= offset_attr - 1; i++)
			{
				num = ((num << 8) | this._0001()[info + i]);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long CreateEvent(int asset, int insert_CALLERAt)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			insert_CALLERAt++;
			byte[] array = new byte[8];
			int num = insert_CALLERAt - asset;
			bool flag = false;
			if (num == 0 || num > 9)
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(this._0001()[asset] & 0x7F);
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
				array[0] = this._0001()[insert_CALLERAt - 1];
				insert_CALLERAt--;
				num4 = 1;
			}
			for (int i = insert_CALLERAt - 1; i >= asset; i += -1)
			{
				if (i - 1 >= asset)
				{
					array[num4] = (byte)(((byte)(this._0001()[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(this._0001()[i - 1] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((byte)(this._0001()[i] >> ((num2 - 1) & 7)) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int StopEvent(int info_Y)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info_Y > this._0001().Length)
			{
				return 0;
			}
			int num = info_Y + 8;
			for (int i = info_Y; i <= num; i++)
			{
				if (i > this._0001().Length - 1)
				{
					return 0;
				}
				if ((this._0001()[i] & 0x80) != 128)
				{
					return i;
				}
			}
			return info_Y + 8;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CloneEvent(long value_low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (value_low & 1) == 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LogoutEvent(ulong previousfirst)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001()[(uint)previousfirst] == 13)
			{
				ushort num = (FlushEvent((previousfirst.CompareEvent<decimal>() + 3m).CompareEvent<int>(), 2).CompareEvent<decimal>() - 1m).CompareEvent<ushort>();
				int num2 = 0;
				if (this._0001() != null)
				{
					num2 = this._0001().Length;
					_0001((ImporterClassSpec[])Utils.CopyArray(this._0001(), new ImporterClassSpec[this._0001().Length + num + 1]));
				}
				else
				{
					_0001(new ImporterClassSpec[num + 1]);
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = FlushEvent((previousfirst.CompareEvent<decimal>() + 8m + (i * 2).CompareEvent<decimal>()).CompareEvent<int>(), 2);
					if (decimal.Compare(previousfirst.CompareEvent<decimal>(), 100m) != 0)
					{
						num4 += previousfirst;
					}
					int num5 = StopEvent(num4.CompareEvent<int>());
					CreateEvent(num4.CompareEvent<int>(), num5);
					int num6 = StopEvent((num4.CompareEvent<decimal>() + num5.CompareEvent<decimal>() - num4.CompareEvent<decimal>() + 1m).CompareEvent<int>());
					this._0001()[num2 + i].EnableRecord(CreateEvent((num4.CompareEvent<decimal>() + num5.CompareEvent<decimal>() - num4.CompareEvent<decimal>() + 1m).CompareEvent<int>(), num6));
					num4 = (num4.CompareEvent<decimal>() + num6.CompareEvent<decimal>() - num4.CompareEvent<decimal>() + 1m).CompareEvent<ulong>();
					num5 = StopEvent(num4.CompareEvent<int>());
					num6 = num5;
					long value = CreateEvent(num4.CompareEvent<int>(), num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = StopEvent(num5);
						array[num7] = CreateEvent(num5, num6);
						if (array[num7] > 9)
						{
							if (CloneEvent(array[num7]))
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
							array[num7] = _0002()[(int)array[num7]];
						}
						num7++;
					}
					while (num7 <= 4);
					Encoding encoding = Encoding.Default;
					decimal value2 = this._0001().CompareEvent<decimal>();
					if (!1m.Equals(value2))
					{
						if (!2m.Equals(value2))
						{
							if (3m.Equals(value2))
							{
								encoding = Encoding.BigEndianUnicode;
							}
						}
						else
						{
							encoding = Encoding.Unicode;
						}
					}
					else
					{
						encoding = Encoding.Default;
					}
					this._0001()[num2 + i].Type = encoding.GetString(this._0001(), Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					this._0001()[num2 + i].Name = encoding.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					this._0001()[num2 + i].ConnectRecord((long)FlushEvent(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]));
					this._0001()[num2 + i].NewRecord(encoding.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]));
				}
			}
			else
			{
				if (this._0001()[(uint)previousfirst] != 5)
				{
					return;
				}
				int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(FlushEvent(Convert.ToInt32(decimal.Add(new decimal(previousfirst), 3m)), 2)), 1m));
				for (int j = 0; j <= num8; j++)
				{
					ushort num9 = (ushort)FlushEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(previousfirst), 12m), new decimal(j * 2))), 2);
					if (decimal.Compare(new decimal(previousfirst), 100m) == 0)
					{
						LogoutEvent(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(FlushEvent(num9, 4)), 1m), new decimal(this._0001()))));
					}
					else
					{
						LogoutEvent(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(FlushEvent((int)(previousfirst + num9), 4)), 1m), new decimal(this._0001()))));
					}
				}
				LogoutEvent(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(FlushEvent(Convert.ToInt32(decimal.Add(new decimal(previousfirst), 8m)), 4)), 1m), new decimal(this._0001()))));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool VisitEvent(ulong size_setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001()[(uint)size_setup] == 13)
			{
				int num = Convert.ToInt32(decimal.Subtract(new decimal(FlushEvent(Convert.ToInt32(decimal.Add(new decimal(size_setup), 3m)), 2)), 1m));
				int num2 = 0;
				if (this._0001() != null)
				{
					num2 = this._0001().Length;
					_0001((RepositoryPropertyStruct[])Utils.CopyArray(this._0001(), new RepositoryPropertyStruct[this._0001().Length + num + 1]));
				}
				else
				{
					_0001(new RepositoryPropertyStruct[num + 1]);
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ContextFilterResolver[] array = null;
					ulong num4 = FlushEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(size_setup), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(size_setup), 100m) != 0)
					{
						num4 += size_setup;
					}
					int num5 = StopEvent((int)num4);
					CreateEvent((int)num4, num5);
					int num6 = StopEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					this._0001()[num2 + i].PushRecord(CreateEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6));
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = StopEvent((int)num4);
					num6 = num5;
					long num7 = CreateEvent((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (ContextFilterResolver[])Utils.CopyArray(array, new ContextFilterResolver[num9 + 1]);
						num5 = num6 + 1;
						num6 = StopEvent(num5);
						array[num9].Type = CreateEvent(num5, num6);
						if (array[num9].Type > 9)
						{
							if (CloneEvent(array[num9].Type))
							{
								array[num9].ResolveRecord((long)Math.Round((double)(array[num9].Type - 13) / 2.0));
							}
							else
							{
								array[num9].ResolveRecord((long)Math.Round((double)(array[num9].Type - 12) / 2.0));
							}
						}
						else
						{
							array[num9].ResolveRecord(_0002()[(int)array[num9].Type]);
						}
						num8 = num8 + (num6 - num5) + 1;
						num9++;
					}
					this._0001()[num2 + i].UpdateRecord(new string[array.Length - 1 + 1]);
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].Type > 9)
						{
							if (!CloneEvent(array[j].Type))
							{
								if (decimal.Compare(new decimal(this._0001()), 1m) == 0)
								{
									this._0001()[num2 + i].AwakeRecord()[j] = Encoding.Default.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].OrderRecord());
								}
								else if (decimal.Compare(new decimal(this._0001()), 2m) == 0)
								{
									this._0001()[num2 + i].AwakeRecord()[j] = Encoding.Unicode.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].OrderRecord());
								}
								else if (decimal.Compare(new decimal(this._0001()), 3m) == 0)
								{
									this._0001()[num2 + i].AwakeRecord()[j] = Encoding.BigEndianUnicode.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].OrderRecord());
								}
							}
							else
							{
								this._0001()[num2 + i].AwakeRecord()[j] = Encoding.Default.GetString(this._0001(), Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].OrderRecord());
							}
						}
						else
						{
							this._0001()[num2 + i].AwakeRecord()[j] = Convert.ToString(FlushEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].OrderRecord()));
						}
						num10 += (int)array[j].OrderRecord();
					}
				}
			}
			else if (this._0001()[(uint)size_setup] == 5)
			{
				int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(FlushEvent(Convert.ToInt32(decimal.Add(new decimal(size_setup), 3m)), 2)), 1m));
				for (int k = 0; k <= num12; k++)
				{
					ushort num13 = (ushort)FlushEvent(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(size_setup), 12m), new decimal(k * 2))), 2);
					VisitEvent(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(FlushEvent((int)(size_setup + num13), 4)), 1m), new decimal(this._0001()))));
				}
				VisitEvent(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(FlushEvent(Convert.ToInt32(decimal.Add(new decimal(size_setup), 8m)), 4)), 1m), new decimal(this._0001()))));
			}
			return true;
		}
	}
}
