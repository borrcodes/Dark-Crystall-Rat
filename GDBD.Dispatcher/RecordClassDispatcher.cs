using _0008;
using GDBD.Bridges;
using GDBD.Filter;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace GDBD.Dispatcher
{
	[global::_0008._0012(0)]
	public abstract class RecordClassDispatcher : IDisposable
	{
		internal enum ReportStatus
		{
			Start,
			Property,
			ObjectStart,
			Object,
			ArrayStart,
			Array,
			ConstructorStart,
			Constructor,
			Closed,
			Error
		}

		private static readonly ReportStatus[][] m_CandidateComposer;

		internal static readonly ReportStatus[][] tokenizerComposer;

		[global::_0008._0012(2)]
		private List<QueueError> m_PrinterComposer;

		private QueueError _MappingComposer;

		private ReportStatus mockComposer;

		private TimeState m_ObserverComposer;

		[CompilerGenerated]
		private bool _DescriptorComposer;

		[CompilerGenerated]
		private bool m_ProducerComposer;

		private FindDirection structComposer;

		private PsMaxLengths _StubComposer;

		private GraphGroupStyle m_CodeComposer;

		private ApplicationPartitionType taskComposer;

		[global::_0008._0012(2)]
		private string m_CustomerComposer;

		[global::_0008._0012(2)]
		private CultureInfo _InterpreterComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReportStatus[][] ConnectTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<ReportStatus[]> list = tokenizerComposer.ToList();
			ReportStatus[] item = tokenizerComposer[0];
			ReportStatus[] item2 = tokenizerComposer[7];
			ulong[] comparatorComposer = InfoFilterResolver.CreateIssuer(typeof(WatcherComposer)).comparatorComposer;
			foreach (ulong num in comparatorComposer)
			{
				if (list.Count <= (int)num)
				{
					WatcherComposer watcherComposer = (WatcherComposer)num;
					if ((uint)(watcherComposer - 7) <= 5u || (uint)(watcherComposer - 16) <= 1u)
					{
						list.Add(item2);
					}
					else
					{
						list.Add(item);
					}
				}
			}
			return list.ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RecordClassDispatcher()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			tokenizerComposer = new ReportStatus[8][]
			{
				new ReportStatus[10]
				{
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.ObjectStart,
					ReportStatus.ObjectStart,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.ObjectStart,
					ReportStatus.ObjectStart,
					ReportStatus.ObjectStart,
					ReportStatus.ObjectStart,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.ArrayStart,
					ReportStatus.ArrayStart,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.ArrayStart,
					ReportStatus.ArrayStart,
					ReportStatus.ArrayStart,
					ReportStatus.ArrayStart,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.ConstructorStart,
					ReportStatus.ConstructorStart,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.ConstructorStart,
					ReportStatus.ConstructorStart,
					ReportStatus.ConstructorStart,
					ReportStatus.ConstructorStart,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.Property,
					ReportStatus.Error,
					ReportStatus.Property,
					ReportStatus.Property,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.Start,
					ReportStatus.Property,
					ReportStatus.ObjectStart,
					ReportStatus.Object,
					ReportStatus.ArrayStart,
					ReportStatus.Array,
					ReportStatus.Constructor,
					ReportStatus.Constructor,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.Start,
					ReportStatus.Property,
					ReportStatus.ObjectStart,
					ReportStatus.Object,
					ReportStatus.ArrayStart,
					ReportStatus.Array,
					ReportStatus.Constructor,
					ReportStatus.Constructor,
					ReportStatus.Error,
					ReportStatus.Error
				},
				new ReportStatus[10]
				{
					ReportStatus.Start,
					ReportStatus.Object,
					ReportStatus.Error,
					ReportStatus.Error,
					ReportStatus.Array,
					ReportStatus.Array,
					ReportStatus.Constructor,
					ReportStatus.Constructor,
					ReportStatus.Error,
					ReportStatus.Error
				}
			};
			m_CandidateComposer = ConnectTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DescriptorComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool moveinfo)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_DescriptorComposer = moveinfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ProducerComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0003(bool isconfig)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ProducerComposer = isconfig;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = m_PrinterComposer?.Count ?? 0;
			if (ForgotTest() != 0)
			{
				num++;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlatformType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (mockComposer)
			{
			case ReportStatus.Error:
				return (PlatformType)0;
			case ReportStatus.Closed:
				return (PlatformType)1;
			case ReportStatus.ObjectStart:
			case ReportStatus.Object:
				return (PlatformType)2;
			case ReportStatus.ArrayStart:
			case ReportStatus.Array:
				return (PlatformType)3;
			case ReportStatus.ConstructorStart:
			case ReportStatus.Constructor:
				return (PlatformType)4;
			case ReportStatus.Property:
				return (PlatformType)5;
			case ReportStatus.Start:
				return (PlatformType)6;
			default:
				throw CollectionComposer.ListTest(this, "Invalid state: " + mockComposer, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MappingComposer._RegistryError == tagURLTEMPLATE.None || m_PrinterComposer == null)
			{
				return string.Empty;
			}
			return QueueError.SearchError(m_PrinterComposer, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MappingComposer._RegistryError == tagURLTEMPLATE.None)
			{
				return string.Empty;
			}
			QueueError? ord = (mockComposer != ReportStatus.ArrayStart && mockComposer != ReportStatus.ConstructorStart && mockComposer != ReportStatus.ObjectStart) ? new QueueError?(_MappingComposer) : null;
			return QueueError.SearchError(m_PrinterComposer, ord);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeState _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ObserverComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(TimeState res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (res < (TimeState)0 || res > (TimeState)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_ObserverComposer = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FindDirection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return structComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(FindDirection var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (var1 < (FindDirection)0 || var1 > (FindDirection)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			structComposer = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PsMaxLengths _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StubComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(PsMaxLengths first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first < (PsMaxLengths)0 || first > (PsMaxLengths)3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_StubComposer = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GraphGroupStyle _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_CodeComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(GraphGroupStyle def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def < (GraphGroupStyle)0 || def > (GraphGroupStyle)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_CodeComposer = def;
			_0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0004()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplicationPartitionType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return taskComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(ApplicationPartitionType last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last < (ApplicationPartitionType)0 || last > (ApplicationPartitionType)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			taskComposer = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_CustomerComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0007(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_CustomerComposer = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CultureInfo _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InterpreterComposer ?? CultureInfo.InvariantCulture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(CultureInfo ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_InterpreterComposer = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected RecordClassDispatcher()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			mockComposer = ReportStatus.Start;
			m_ObserverComposer = (TimeState)0;
			_StubComposer = (PsMaxLengths)3;
			_0002(moveinfo: true);
			_0003(isconfig: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void MoveTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MappingComposer.m_CandidateError)
			{
				_MappingComposer._AttrError++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopTest(tagURLTEMPLATE v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MappingComposer._RegistryError != 0)
			{
				if (m_PrinterComposer == null)
				{
					m_PrinterComposer = new List<QueueError>();
				}
				m_PrinterComposer.Add(_MappingComposer);
			}
			_MappingComposer = new QueueError(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private tagURLTEMPLATE NewTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueueError mappingComposer = _MappingComposer;
			if (m_PrinterComposer != null && m_PrinterComposer.Count > 0)
			{
				_MappingComposer = m_PrinterComposer[m_PrinterComposer.Count - 1];
				m_PrinterComposer.RemoveAt(m_PrinterComposer.Count - 1);
			}
			else
			{
				_MappingComposer = default(QueueError);
			}
			return mappingComposer._RegistryError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private tagURLTEMPLATE ForgotTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _MappingComposer._RegistryError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0002())
			{
				InstantiateTest();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartObject, tagURLTEMPLATE.Object);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0011()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RemoveTest(tagURLTEMPLATE.Object);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartArray, tagURLTEMPLATE.Array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _000F()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RemoveTest(tagURLTEMPLATE.Array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(string reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartConstructor, tagURLTEMPLATE.Constructor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0010()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RemoveTest(tagURLTEMPLATE.Constructor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0002(string task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PostTest(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(string init, bool injectcust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0002(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CollectTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalcTest(ForgotTest());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IncludeTest(TagTestItem value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PushTest(value, usetoken: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushTest(TagTestItem info, bool usetoken)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(info, "reader");
			_0001(info, usetoken, usedir: true, checkcaller2: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareTest(WatcherComposer asset, object caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (asset)
			{
			case WatcherComposer.None:
				break;
			case WatcherComposer.StartObject:
				this._0002();
				break;
			case WatcherComposer.StartArray:
				this._0003();
				break;
			case WatcherComposer.StartConstructor:
				ContextClientBridge.RunClient(caller, "value");
				_0001(caller.ToString());
				break;
			case WatcherComposer.PropertyName:
				ContextClientBridge.RunClient(caller, "value");
				_0002(caller.ToString());
				break;
			case WatcherComposer.Comment:
				_0005(caller?.ToString());
				break;
			case WatcherComposer.Integer:
				ContextClientBridge.RunClient(caller, "value");
				if (caller is BigInteger)
				{
					BigInteger bigInteger = (BigInteger)caller;
					_0001(bigInteger);
				}
				else
				{
					_0001(Convert.ToInt64(caller, CultureInfo.InvariantCulture));
				}
				break;
			case WatcherComposer.Float:
				ContextClientBridge.RunClient(caller, "value");
				if (caller is decimal)
				{
					decimal asset2 = (decimal)caller;
					_0001(asset2);
				}
				else if (caller is double)
				{
					double last = (double)caller;
					_0001(last);
				}
				else if (caller is float)
				{
					float init = (float)caller;
					_0001(init);
				}
				else
				{
					_0001(Convert.ToDouble(caller, CultureInfo.InvariantCulture));
				}
				break;
			case WatcherComposer.String:
				ContextClientBridge.RunClient(caller, "value");
				_0004(caller.ToString());
				break;
			case WatcherComposer.Boolean:
				ContextClientBridge.RunClient(caller, "value");
				_0001(Convert.ToBoolean(caller, CultureInfo.InvariantCulture));
				break;
			case WatcherComposer.Null:
				_0008();
				break;
			case WatcherComposer.Undefined:
				_000E();
				break;
			case WatcherComposer.EndObject:
				_0011();
				break;
			case WatcherComposer.EndArray:
				_000F();
				break;
			case WatcherComposer.EndConstructor:
				_0010();
				break;
			case WatcherComposer.Date:
				ContextClientBridge.RunClient(caller, "value");
				if (caller is DateTimeOffset)
				{
					DateTimeOffset last2 = (DateTimeOffset)caller;
					_0001(last2);
				}
				else
				{
					_0001(Convert.ToDateTime(caller, CultureInfo.InvariantCulture));
				}
				break;
			case WatcherComposer.Raw:
				_0006(caller?.ToString());
				break;
			case WatcherComposer.Bytes:
				ContextClientBridge.RunClient(caller, "value");
				if (caller is Guid)
				{
					Guid param = (Guid)caller;
					_0001(param);
				}
				else
				{
					_0001((byte[])caller);
				}
				break;
			default:
				throw CustomerListAnnotation.ConcatIssuer("token", asset, "Unexpected token type.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(TagTestItem ident, bool requiresconnection, bool usedir, bool checkcaller2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = UpdateTest(ident);
			do
			{
				if (usedir && ident._0001() == WatcherComposer.StartConstructor && string.Equals(ident._0001()?.ToString(), "Date", StringComparison.Ordinal))
				{
					InterruptTest(ident);
				}
				else if (checkcaller2 || ident._0001() != WatcherComposer.Comment)
				{
					PrepareTest(ident._0001(), ident._0001());
				}
			}
			while (num - 1 < ident._0003() - (RulesClientBridge.CalculateIssuer(ident._0001()) ? 1 : 0) && requiresconnection && ident._0001());
			if (AwakeTest(ident, requiresconnection, num))
			{
				throw CollectionComposer.ListTest(this, "Unexpected end when reading token.", null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AwakeTest(TagTestItem param, bool ispred, int indexOfdic)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = ReadTest(param);
			if (indexOfdic >= num)
			{
				if (ispred && indexOfdic == num)
				{
					return RulesClientBridge.GetIssuer(param._0001());
				}
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int UpdateTest(TagTestItem spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = spec._0001();
			if (watcherComposer == WatcherComposer.None)
			{
				return -1;
			}
			if (!RulesClientBridge.GetIssuer(watcherComposer))
			{
				return spec._0003() + 1;
			}
			return spec._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int ReadTest(TagTestItem param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = param._0001();
			if (watcherComposer == WatcherComposer.None)
			{
				return -1;
			}
			if (!RulesClientBridge.CalculateIssuer(watcherComposer))
			{
				return param._0003();
			}
			return param._0003() - 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InterruptTest(TagTestItem i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!RegistryBroadcasterFilter.PostIssuer(i, out DateTime reg, out string _0004))
			{
				throw CollectionComposer.ListTest(this, _0004, null);
			}
			_0001(reg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CalcTest(tagURLTEMPLATE first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (first)
			{
			case tagURLTEMPLATE.Object:
				_0011();
				break;
			case tagURLTEMPLATE.Array:
				_000F();
				break;
			case tagURLTEMPLATE.Constructor:
				_0010();
				break;
			default:
				throw CollectionComposer.ListTest(this, "Unexpected type when writing end: " + first, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InstantiateTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (this._0002() > 0)
			{
				CollectTests();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private WatcherComposer ReflectTest(tagURLTEMPLATE res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (res)
			{
			case tagURLTEMPLATE.Object:
				return WatcherComposer.EndObject;
			case tagURLTEMPLATE.Array:
				return WatcherComposer.EndArray;
			case tagURLTEMPLATE.Constructor:
				return WatcherComposer.EndConstructor;
			default:
				throw CollectionComposer.ListTest(this, "No close token for type: " + res, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetTest(tagURLTEMPLATE i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = RegisterTest(i);
			for (int j = 0; j < num; j++)
			{
				WatcherComposer setup = ReflectTest(NewTest());
				if (mockComposer == ReportStatus.Property)
				{
					_0008();
				}
				if (m_ObserverComposer == (TimeState)1 && mockComposer != ReportStatus.ObjectStart && mockComposer != ReportStatus.ArrayStart)
				{
					_0005();
				}
				_0001(setup);
				RestartTest();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int RegisterTest(tagURLTEMPLATE param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 0;
			if (_MappingComposer._RegistryError == param)
			{
				num = 1;
			}
			else
			{
				int num2 = this._0002() - 2;
				for (int num3 = num2; num3 >= 0; num3--)
				{
					int index = num2 - num3;
					if (m_PrinterComposer[index]._RegistryError == param)
					{
						num = num3 + 2;
						break;
					}
				}
			}
			if (num == 0)
			{
				throw CollectionComposer.ListTest(this, "No token to close.", null);
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RestartTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tagURLTEMPLATE tagURLTEMPLATE = ForgotTest();
			switch (tagURLTEMPLATE)
			{
			case tagURLTEMPLATE.Object:
				mockComposer = ReportStatus.Object;
				break;
			case tagURLTEMPLATE.Array:
				mockComposer = ReportStatus.Array;
				break;
			case tagURLTEMPLATE.Constructor:
				mockComposer = ReportStatus.Array;
				break;
			case tagURLTEMPLATE.None:
				mockComposer = ReportStatus.Start;
				break;
			default:
				throw CollectionComposer.ListTest(this, "Unknown JsonType: " + tagURLTEMPLATE, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(WatcherComposer setup)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0005()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0006()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0007()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SearchTest(WatcherComposer instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ReportStatus reportStatus = m_CandidateComposer[(int)instance][(int)mockComposer];
			if (reportStatus == ReportStatus.Error)
			{
				throw CollectionComposer.ListTest(this, "Token {0} in state {1} would result in an invalid JSON object.".SelectReader(CultureInfo.InvariantCulture, instance.ToString(), mockComposer.ToString()), null);
			}
			if ((mockComposer == ReportStatus.Object || mockComposer == ReportStatus.Array || mockComposer == ReportStatus.Constructor) && instance != WatcherComposer.Comment)
			{
				_0006();
			}
			if (m_ObserverComposer == (TimeState)1)
			{
				if (mockComposer == ReportStatus.Property)
				{
					_0007();
				}
				if (mockComposer == ReportStatus.Array || mockComposer == ReportStatus.ArrayStart || mockComposer == ReportStatus.Constructor || mockComposer == ReportStatus.ConstructorStart || (instance == WatcherComposer.PropertyName && mockComposer != 0))
				{
					_0005();
				}
			}
			mockComposer = reportStatus;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Undefined);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0003(string info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ChangeTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0006(string def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveTest();
			SearchTest(WatcherComposer.Undefined);
			_0003(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0004(string init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(int first_Low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(uint offset_reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(long asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(ulong specID)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(float init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(double last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(bool containstask)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Boolean);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(short keylow)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(ushort insertINSTANCEAt)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(char last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(byte version_var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(sbyte flags_var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(decimal asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(DateTime first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Date);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(DateTimeOffset last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Date);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(Guid param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(TimeSpan i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(int? reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!reference.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(reference.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(uint? def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!def.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(def.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(long? item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!item.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(item.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(ulong? reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!reference.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(reference.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(float? ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ident.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(ident.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(double? ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ident.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(ident.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(bool? item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!item.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(item.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(short? i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!i.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(i.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(ushort? first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!first.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(first.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(char? first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!first.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(first.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(byte? item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!item.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(item.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public virtual void _0001(sbyte? spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!spec.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(spec.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(decimal? res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!res.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(res.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(DateTime? first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!first.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(first.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(DateTimeOffset? config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!config.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(config.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(Guid? asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!asset.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(asset.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(TimeSpan? value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!value.HasValue)
			{
				_0008();
			}
			else
			{
				_0001(value.GetValueOrDefault());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(byte[] item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (item == null)
			{
				_0008();
			}
			else
			{
				GetTest(WatcherComposer.Bytes);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(Uri param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param == null)
			{
				_0008();
			}
			else
			{
				GetTest(WatcherComposer.String);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(object item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (item == null)
			{
				_0008();
				return;
			}
			if (item is BigInteger)
			{
				throw SetTest(this, item);
			}
			ComputeTest(this, HelperDicCandidate.PatchProperty(item.GetType()), item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0005(string def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StartTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0019()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0004(isinstance: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0019();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0004(bool isinstance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (mockComposer != ReportStatus.Closed && isinstance)
			{
				this._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ComputeTest(RecordClassDispatcher var1, SettingsSerializeAs attr, object temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (true)
			{
				switch (attr)
				{
				case (SettingsSerializeAs)2:
					var1._0001((char)temp);
					return;
				case (SettingsSerializeAs)3:
					var1._0001((temp == null) ? null : new char?((char)temp));
					return;
				case (SettingsSerializeAs)4:
					var1._0001((bool)temp);
					return;
				case (SettingsSerializeAs)5:
					var1._0001((temp == null) ? null : new bool?((bool)temp));
					return;
				case (SettingsSerializeAs)6:
					var1._0001((sbyte)temp);
					return;
				case (SettingsSerializeAs)7:
					var1._0001((temp == null) ? null : new sbyte?((sbyte)temp));
					return;
				case (SettingsSerializeAs)8:
					var1._0001((short)temp);
					return;
				case (SettingsSerializeAs)9:
					var1._0001((temp == null) ? null : new short?((short)temp));
					return;
				case (SettingsSerializeAs)10:
					var1._0001((ushort)temp);
					return;
				case (SettingsSerializeAs)11:
					var1._0001((temp == null) ? null : new ushort?((ushort)temp));
					return;
				case (SettingsSerializeAs)12:
					var1._0001((int)temp);
					return;
				case (SettingsSerializeAs)13:
					var1._0001((temp == null) ? null : new int?((int)temp));
					return;
				case (SettingsSerializeAs)14:
					var1._0001((byte)temp);
					return;
				case (SettingsSerializeAs)15:
					var1._0001((temp == null) ? null : new byte?((byte)temp));
					return;
				case (SettingsSerializeAs)16:
					var1._0001((uint)temp);
					return;
				case (SettingsSerializeAs)17:
					var1._0001((temp == null) ? null : new uint?((uint)temp));
					return;
				case (SettingsSerializeAs)18:
					var1._0001((long)temp);
					return;
				case (SettingsSerializeAs)19:
					var1._0001((temp == null) ? null : new long?((long)temp));
					return;
				case (SettingsSerializeAs)20:
					var1._0001((ulong)temp);
					return;
				case (SettingsSerializeAs)21:
					var1._0001((temp == null) ? null : new ulong?((ulong)temp));
					return;
				case (SettingsSerializeAs)22:
					var1._0001((float)temp);
					return;
				case (SettingsSerializeAs)23:
					var1._0001((temp == null) ? null : new float?((float)temp));
					return;
				case (SettingsSerializeAs)24:
					var1._0001((double)temp);
					return;
				case (SettingsSerializeAs)25:
					var1._0001((temp == null) ? null : new double?((double)temp));
					return;
				case (SettingsSerializeAs)26:
					var1._0001((DateTime)temp);
					return;
				case (SettingsSerializeAs)27:
					var1._0001((temp == null) ? null : new DateTime?((DateTime)temp));
					return;
				case (SettingsSerializeAs)28:
					var1._0001((DateTimeOffset)temp);
					return;
				case (SettingsSerializeAs)29:
					var1._0001((temp == null) ? null : new DateTimeOffset?((DateTimeOffset)temp));
					return;
				case (SettingsSerializeAs)30:
					var1._0001((decimal)temp);
					return;
				case (SettingsSerializeAs)31:
					var1._0001((temp == null) ? null : new decimal?((decimal)temp));
					return;
				case (SettingsSerializeAs)32:
					var1._0001((Guid)temp);
					return;
				case (SettingsSerializeAs)33:
					var1._0001((temp == null) ? null : new Guid?((Guid)temp));
					return;
				case (SettingsSerializeAs)34:
					var1._0001((TimeSpan)temp);
					return;
				case (SettingsSerializeAs)35:
					var1._0001((temp == null) ? null : new TimeSpan?((TimeSpan)temp));
					return;
				case (SettingsSerializeAs)36:
					var1._0001((BigInteger)temp);
					return;
				case (SettingsSerializeAs)37:
					var1._0001((temp == null) ? null : new BigInteger?((BigInteger)temp));
					return;
				case (SettingsSerializeAs)38:
					var1._0001((Uri)temp);
					return;
				case (SettingsSerializeAs)39:
					var1._0004((string)temp);
					return;
				case (SettingsSerializeAs)40:
					var1._0001((byte[])temp);
					return;
				case (SettingsSerializeAs)41:
					var1._0008();
					return;
				}
				IConvertible convertible = temp as IConvertible;
				if (convertible != null)
				{
					DestroyTest(convertible, out attr, out temp);
					continue;
				}
				if (temp == null)
				{
					var1._0008();
					return;
				}
				throw SetTest(var1, temp);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DestroyTest(IConvertible reference, out SettingsSerializeAs ord, out object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StateErrorFilter stateErrorFilter = HelperDicCandidate.ValidateProperty(reference);
			ord = ((stateErrorFilter._0001() == (SettingsSerializeAs)1) ? ((SettingsSerializeAs)39) : stateErrorFilter._0001());
			Type conversionType = (stateErrorFilter._0001() == (SettingsSerializeAs)1) ? typeof(string) : stateErrorFilter._0001();
			res = reference.ToType(conversionType, CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static CollectionComposer SetTest(RecordClassDispatcher i, object reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CollectionComposer.ListTest(i, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".ListReader(CultureInfo.InvariantCulture, reg.GetType()), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RateTest(WatcherComposer key, object b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (key)
			{
			case WatcherComposer.StartObject:
				CalculateTest(key, tagURLTEMPLATE.Object);
				break;
			case WatcherComposer.StartArray:
				CalculateTest(key, tagURLTEMPLATE.Array);
				break;
			case WatcherComposer.StartConstructor:
				CalculateTest(key, tagURLTEMPLATE.Constructor);
				break;
			case WatcherComposer.PropertyName:
			{
				string text = b as string;
				if (text == null)
				{
					throw new ArgumentException("A name is required when setting property name state.", "value");
				}
				PostTest(text);
				break;
			}
			case WatcherComposer.Comment:
				StartTest();
				break;
			case WatcherComposer.Raw:
				ChangeTest();
				break;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Null:
			case WatcherComposer.Undefined:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
				GetTest(key);
				break;
			case WatcherComposer.EndObject:
				RemoveTest(tagURLTEMPLATE.Object);
				break;
			case WatcherComposer.EndArray:
				RemoveTest(tagURLTEMPLATE.Array);
				break;
			case WatcherComposer.EndConstructor:
				RemoveTest(tagURLTEMPLATE.Constructor);
				break;
			default:
				throw new ArgumentOutOfRangeException("token");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RemoveTest(tagURLTEMPLATE spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ResetTest(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void PostTest(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_MappingComposer.m_ConfigurationError = i;
			SearchTest(WatcherComposer.PropertyName);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ChangeTest()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CalculateTest(WatcherComposer res, tagURLTEMPLATE cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveTest();
			SearchTest(res);
			PopTest(cont);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void GetTest(WatcherComposer init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveTest();
			SearchTest(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void StartTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			SearchTest(WatcherComposer.Comment);
		}
	}
}
