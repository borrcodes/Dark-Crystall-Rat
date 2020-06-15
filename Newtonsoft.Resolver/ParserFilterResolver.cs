using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal abstract class ParserFilterResolver : Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver>, IEnumerable<ParserFilterResolver>, IdentifierClientBridge, IEnumerable, IDynamicMetaObjectProvider, ICloneable
	{
		private sealed class WatcherListAnnotation
		{
			internal readonly int m_QueueIssuer;

			internal readonly int _ProxyIssuer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public WatcherListAnnotation(int numkey, int sum_cfg)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				m_QueueIssuer = numkey;
				_ProxyIssuer = sum_cfg;
			}
		}

		[_0008._0012(2)]
		private ConfigurationIssuer _IssuerIssuer;

		[_0008._0012(2)]
		private ParserFilterResolver _ReaderIssuer;

		[_0008._0012(2)]
		private ParserFilterResolver m_ClientIssuer;

		[_0008._0012(2)]
		private object _BroadcasterIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] _ClassIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] m_RequestIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] _IteratorIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] testsIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] methodIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] m_AuthenticationIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] mapperIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] predicateIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] policyIssuer;

		private static readonly Newtonsoft.Rules.UnicodeCategory[] m_ServiceIssuer;

		[_0008._0012(2)]
		public virtual ParserFilterResolver this[object def]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				throw new InvalidOperationException("Cannot access child value on {0}.".ListReader(CultureInfo.InvariantCulture, GetType()));
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				throw new InvalidOperationException("Cannot set child value on {0}.".ListReader(CultureInfo.InvariantCulture, GetType()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConfigurationIssuer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IssuerIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0001(ConfigurationIssuer first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerIssuer = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserFilterResolver _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ConfigurationIssuer configurationIssuer = this._0001();
			if (configurationIssuer == null)
			{
				return this;
			}
			while (((ParserFilterResolver)configurationIssuer)._0001() != null)
			{
				configurationIssuer = ((ParserFilterResolver)configurationIssuer)._0001();
			}
			return configurationIssuer;
		}

		internal abstract ParserFilterResolver _0001();

		public abstract Newtonsoft.Rules.UnicodeCategory _0001();

		public abstract bool _0001();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserFilterResolver _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ClientIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0004(ParserFilterResolver ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ClientIssuer = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserFilterResolver _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReaderIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0005(ParserFilterResolver instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ReaderIssuer = instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() == null)
			{
				return string.Empty;
			}
			List<QueueError> list = new List<QueueError>();
			ParserFilterResolver parserFilterResolver = null;
			for (ParserFilterResolver parserFilterResolver2 = this; parserFilterResolver2 != null; parserFilterResolver2 = parserFilterResolver2._0001())
			{
				QueueError item;
				switch (parserFilterResolver2._0001())
				{
				case Newtonsoft.Rules.UnicodeCategory.Property:
				{
					WatcherIssuer watcherIssuer = (WatcherIssuer)parserFilterResolver2;
					item = new QueueError(tagURLTEMPLATE.Object)
					{
						m_ConfigurationError = watcherIssuer._0001()
					};
					list.Add(item);
					break;
				}
				case Newtonsoft.Rules.UnicodeCategory.Array:
				case Newtonsoft.Rules.UnicodeCategory.Constructor:
					if (parserFilterResolver != null)
					{
						int attrError = ((IList<ParserFilterResolver>)parserFilterResolver2).IndexOf(parserFilterResolver);
						item = new QueueError(tagURLTEMPLATE.Array)
						{
							_AttrError = attrError
						};
						list.Add(item);
					}
					break;
				}
				parserFilterResolver = parserFilterResolver2;
			}
			list.CallTest();
			return QueueError.SearchError(list, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ParserFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ParserFilterResolver _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Cannot access child value on {0}.".ListReader(CultureInfo.InvariantCulture, GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ParserFilterResolver _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Cannot access child value on {0}.".ListReader(CultureInfo.InvariantCulture, GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GDBD.Structs.PoolPropertyStruct<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return GDBD.Structs.PoolPropertyStruct<ParserFilterResolver>.producerIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_IssuerIssuer == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			_IssuerIssuer._0001(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyClass(ParserFilterResolver reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_IssuerIssuer == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			_IssuerIssuer._0002(this, reference);
		}

		public abstract void _0001(RecordClassDispatcher spec, BroadcasterError[] col);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetClass((TimeState)1, new BroadcasterError[0]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string SetClass(TimeState reference, BroadcasterError[] visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				StatusDicCandidate statusDicCandidate = new StatusDicCandidate(stringWriter);
				statusDicCandidate._0001(reference);
				_0001(statusDicCandidate, visitor);
				return stringWriter.ToString();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static PoolIssuer RateClass(ParserFilterResolver instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance == null)
			{
				throw new ArgumentNullException("value");
			}
			WatcherIssuer watcherIssuer = instance as WatcherIssuer;
			if (watcherIssuer != null)
			{
				instance = watcherIssuer._0004();
			}
			return instance as PoolIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string RemoveClass(ParserFilterResolver param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "token");
			WatcherIssuer watcherIssuer = param as WatcherIssuer;
			if (watcherIssuer != null)
			{
				param = watcherIssuer._0004();
			}
			return param._0001().ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool PostClass(ParserFilterResolver key, Newtonsoft.Rules.UnicodeCategory[] map, bool isstate)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (Array.IndexOf(map, key._0001()) == -1)
			{
				if (isstate)
				{
					if (key._0001() != Newtonsoft.Rules.UnicodeCategory.Null)
					{
						return key._0001() == Newtonsoft.Rules.UnicodeCategory.Undefined;
					}
					return true;
				}
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _0001(ParserFilterResolver value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(value);
			if (poolIssuer == null || !PostClass(poolIssuer, _ClassIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".ListReader(CultureInfo.InvariantCulture, RemoveClass(value)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value2 = (BigInteger)obj;
				return Convert.ToBoolean((int)value2);
			}
			return Convert.ToBoolean(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTimeOffset _0001(ParserFilterResolver def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(def);
			if (poolIssuer == null || !PostClass(poolIssuer, policyIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".ListReader(CultureInfo.InvariantCulture, RemoveClass(def)));
			}
			object obj = poolIssuer._0001();
			if (obj is DateTimeOffset)
			{
				return (DateTimeOffset)obj;
			}
			string text = poolIssuer._0001() as string;
			if (text != null)
			{
				return DateTimeOffset.Parse(text, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(poolIssuer._0001(), CultureInfo.InvariantCulture));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool? _0001(ParserFilterResolver first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(first);
			if (poolIssuer == null || !PostClass(poolIssuer, _ClassIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".ListReader(CultureInfo.InvariantCulture, RemoveClass(first)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return Convert.ToBoolean((int)value);
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToBoolean(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long _0001(ParserFilterResolver config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(config);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".ListReader(CultureInfo.InvariantCulture, RemoveClass(config)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (long)value;
			}
			return Convert.ToInt64(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTime? _0001(ParserFilterResolver param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(param);
			if (poolIssuer == null || !PostClass(poolIssuer, policyIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".ListReader(CultureInfo.InvariantCulture, RemoveClass(param)));
			}
			object obj = poolIssuer._0001();
			if (obj is DateTimeOffset)
			{
				return ((DateTimeOffset)obj).DateTime;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToDateTime(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTimeOffset? _0001(ParserFilterResolver v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(v);
			if (poolIssuer == null || !PostClass(poolIssuer, policyIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".ListReader(CultureInfo.InvariantCulture, RemoveClass(v)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			object obj = poolIssuer._0001();
			if (obj is DateTimeOffset)
			{
				return (DateTimeOffset)obj;
			}
			string text = poolIssuer._0001() as string;
			if (text != null)
			{
				return DateTimeOffset.Parse(text, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(poolIssuer._0001(), CultureInfo.InvariantCulture));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal? _0001(ParserFilterResolver first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(first);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".ListReader(CultureInfo.InvariantCulture, RemoveClass(first)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (decimal)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToDecimal(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double? _0001(ParserFilterResolver last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(last);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Double.".ListReader(CultureInfo.InvariantCulture, RemoveClass(last)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (double)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToDouble(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static char? _0001(ParserFilterResolver v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(v);
			if (poolIssuer == null || !PostClass(poolIssuer, predicateIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Char.".ListReader(CultureInfo.InvariantCulture, RemoveClass(v)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (char)(ushort)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToChar(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int _0001(ParserFilterResolver v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(v);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".ListReader(CultureInfo.InvariantCulture, RemoveClass(v)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (int)value;
			}
			return Convert.ToInt32(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static short _0001(ParserFilterResolver task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(task);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".ListReader(CultureInfo.InvariantCulture, RemoveClass(task)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (short)value;
			}
			return Convert.ToInt16(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static ushort _0001(ParserFilterResolver param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(param);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".ListReader(CultureInfo.InvariantCulture, RemoveClass(param)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (ushort)value;
			}
			return Convert.ToUInt16(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static char _0001(ParserFilterResolver task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(task);
			if (poolIssuer == null || !PostClass(poolIssuer, predicateIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Char.".ListReader(CultureInfo.InvariantCulture, RemoveClass(task)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (char)(ushort)value;
			}
			return Convert.ToChar(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte _0001(ParserFilterResolver setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(setup);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".ListReader(CultureInfo.InvariantCulture, RemoveClass(setup)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (byte)value;
			}
			return Convert.ToByte(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static sbyte _0001(ParserFilterResolver task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(task);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".ListReader(CultureInfo.InvariantCulture, RemoveClass(task)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (sbyte)value;
			}
			return Convert.ToSByte(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int? _0001(ParserFilterResolver ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(ident);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".ListReader(CultureInfo.InvariantCulture, RemoveClass(ident)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (int)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToInt32(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static short? _0001(ParserFilterResolver config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(config);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".ListReader(CultureInfo.InvariantCulture, RemoveClass(config)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (short)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToInt16(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static ushort? _0001(ParserFilterResolver init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(init);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".ListReader(CultureInfo.InvariantCulture, RemoveClass(init)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (ushort)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToUInt16(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte? _0001(ParserFilterResolver key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (key == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(key);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".ListReader(CultureInfo.InvariantCulture, RemoveClass(key)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (byte)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToByte(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static sbyte? _0001(ParserFilterResolver i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(i);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".ListReader(CultureInfo.InvariantCulture, RemoveClass(i)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (sbyte)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToSByte(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DateTime _0001(ParserFilterResolver v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(v);
			if (poolIssuer == null || !PostClass(poolIssuer, policyIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".ListReader(CultureInfo.InvariantCulture, RemoveClass(v)));
			}
			object obj = poolIssuer._0001();
			if (obj is DateTimeOffset)
			{
				return ((DateTimeOffset)obj).DateTime;
			}
			return Convert.ToDateTime(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static long? _0001(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (spec == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(spec);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".ListReader(CultureInfo.InvariantCulture, RemoveClass(spec)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (long)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToInt64(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float? _0001(ParserFilterResolver first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(first);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Single.".ListReader(CultureInfo.InvariantCulture, RemoveClass(first)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (float)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToSingle(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static decimal _0001(ParserFilterResolver setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(setup);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".ListReader(CultureInfo.InvariantCulture, RemoveClass(setup)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (decimal)value;
			}
			return Convert.ToDecimal(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static uint? _0001(ParserFilterResolver item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (item == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(item);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".ListReader(CultureInfo.InvariantCulture, RemoveClass(item)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (uint)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToUInt32(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static ulong? _0001(ParserFilterResolver ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(ident);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".ListReader(CultureInfo.InvariantCulture, RemoveClass(ident)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (ulong)value;
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return Convert.ToUInt64(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static double _0001(ParserFilterResolver reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(reference);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Double.".ListReader(CultureInfo.InvariantCulture, RemoveClass(reference)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (double)value;
			}
			return Convert.ToDouble(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float _0001(ParserFilterResolver ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(ident);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Single.".ListReader(CultureInfo.InvariantCulture, RemoveClass(ident)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (float)value;
			}
			return Convert.ToSingle(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string _0002(ParserFilterResolver init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(init);
			if (poolIssuer == null || !PostClass(poolIssuer, testsIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to String.".ListReader(CultureInfo.InvariantCulture, RemoveClass(init)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			byte[] array = poolIssuer._0001() as byte[];
			if (array != null)
			{
				return Convert.ToBase64String(array);
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				return ((BigInteger)obj).ToString(CultureInfo.InvariantCulture);
			}
			return Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static uint _0001(ParserFilterResolver item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(item);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".ListReader(CultureInfo.InvariantCulture, RemoveClass(item)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (uint)value;
			}
			return Convert.ToUInt32(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public static ulong _0001(ParserFilterResolver instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(instance);
			if (poolIssuer == null || !PostClass(poolIssuer, m_RequestIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".ListReader(CultureInfo.InvariantCulture, RemoveClass(instance)));
			}
			object obj = poolIssuer._0001();
			if (obj is BigInteger)
			{
				BigInteger value = (BigInteger)obj;
				return (ulong)value;
			}
			return Convert.ToUInt64(poolIssuer._0001(), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Guid _0001(ParserFilterResolver value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(value);
			if (poolIssuer == null || !PostClass(poolIssuer, methodIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".ListReader(CultureInfo.InvariantCulture, RemoveClass(value)));
			}
			byte[] array = poolIssuer._0001() as byte[];
			if (array != null)
			{
				return new Guid(array);
			}
			object obj = poolIssuer._0001();
			if (obj is Guid)
			{
				return (Guid)obj;
			}
			return new Guid(Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Guid? _0001(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (spec == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(spec);
			if (poolIssuer == null || !PostClass(poolIssuer, methodIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".ListReader(CultureInfo.InvariantCulture, RemoveClass(spec)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			byte[] array = poolIssuer._0001() as byte[];
			if (array != null)
			{
				return new Guid(array);
			}
			object obj = poolIssuer._0001();
			Guid value;
			if (obj is Guid)
			{
				Guid guid = (Guid)obj;
				value = guid;
			}
			else
			{
				value = new Guid(Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture));
			}
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TimeSpan _0001(ParserFilterResolver asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(asset);
			if (poolIssuer == null || !PostClass(poolIssuer, m_AuthenticationIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".ListReader(CultureInfo.InvariantCulture, RemoveClass(asset)));
			}
			object obj = poolIssuer._0001();
			if (obj is TimeSpan)
			{
				return (TimeSpan)obj;
			}
			return HelperDicCandidate.ResolveProperty(Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TimeSpan? _0001(ParserFilterResolver first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(first);
			if (poolIssuer == null || !PostClass(poolIssuer, m_AuthenticationIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".ListReader(CultureInfo.InvariantCulture, RemoveClass(first)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			object obj = poolIssuer._0001();
			TimeSpan value;
			if (obj is TimeSpan)
			{
				TimeSpan timeSpan = (TimeSpan)obj;
				value = timeSpan;
			}
			else
			{
				value = HelperDicCandidate.ResolveProperty(Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture));
			}
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Uri _0001(ParserFilterResolver def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == null)
			{
				return null;
			}
			PoolIssuer poolIssuer = RateClass(def);
			if (poolIssuer == null || !PostClass(poolIssuer, mapperIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to Uri.".ListReader(CultureInfo.InvariantCulture, RemoveClass(def)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			Uri uri = poolIssuer._0001() as Uri;
			if ((object)uri == null)
			{
				return new Uri(Convert.ToString(poolIssuer._0001(), CultureInfo.InvariantCulture));
			}
			return uri;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BigInteger ChangeClass(ParserFilterResolver res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(res);
			if (poolIssuer == null || !PostClass(poolIssuer, _IteratorIssuer, isstate: false))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".ListReader(CultureInfo.InvariantCulture, RemoveClass(res)));
			}
			return HelperDicCandidate.RunProperty(poolIssuer._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BigInteger? CalculateClass(ParserFilterResolver value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = RateClass(value);
			if (poolIssuer == null || !PostClass(poolIssuer, _IteratorIssuer, isstate: true))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".ListReader(CultureInfo.InvariantCulture, RemoveClass(value)));
			}
			if (poolIssuer._0001() == null)
			{
				return null;
			}
			return HelperDicCandidate.RunProperty(poolIssuer._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParserFilterResolver _0001(int idx_instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(idx_instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParserFilterResolver _0001(string ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(ident);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((IEnumerable<ParserFilterResolver>)this).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator<ParserFilterResolver> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001()._0001();
		}

		IEnumerator<ParserFilterResolver> IEnumerable<ParserFilterResolver>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver> _0002(object init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this[init];
		}

		Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver> Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver>._0001(object init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagTestItem GetClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new DatabaseDicCandidate(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object StartClass(Type v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ProcConsumer._0001() == null)
			{
				bool counter;
				SettingsSerializeAs settingsSerializeAs = HelperDicCandidate.FindProperty(v, out counter);
				if (counter)
				{
					if (this._0001() == Newtonsoft.Rules.UnicodeCategory.String)
					{
						try
						{
							return ListClass(v, PrototypeError.FillComposer());
						}
						catch (Exception innerException)
						{
							Type type = v.LoginClient() ? v : Nullable.GetUnderlyingType(v);
							throw new ArgumentException("Could not convert '{0}' to {1}.".SelectReader(CultureInfo.InvariantCulture, _0002(this), type.Name), innerException);
						}
					}
					if (this._0001() == Newtonsoft.Rules.UnicodeCategory.Integer)
					{
						return Enum.ToObject(v.LoginClient() ? v : Nullable.GetUnderlyingType(v), ((PoolIssuer)this)._0001());
					}
				}
				switch (settingsSerializeAs)
				{
				case (SettingsSerializeAs)5:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)4:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)3:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)2:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)6:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)7:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)15:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)14:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)9:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)8:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)11:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)10:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)13:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)12:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)17:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)16:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)19:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)18:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)21:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)20:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)23:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)22:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)25:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)24:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)31:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)30:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)27:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)26:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)29:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)28:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)39:
					return _0002(this);
				case (SettingsSerializeAs)33:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)32:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)38:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)35:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)34:
					return ParserFilterResolver._0001(this);
				case (SettingsSerializeAs)37:
					return CalculateClass(this);
				case (SettingsSerializeAs)36:
					return ChangeClass(this);
				}
			}
			return ListClass(v, PrototypeError.FillComposer());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ListClass(Type reference, PrototypeError second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(second, "jsonSerializer");
			using (DatabaseDicCandidate asset = new DatabaseDicCandidate(this))
			{
				return second.AddComposer(asset, reference);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParserFilterResolver SelectClass(TagTestItem param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return DeleteClass(param, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParserFilterResolver DeleteClass(TagTestItem param, CodeIteratorMapping vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "reader");
			if (!((param._0001() == WatcherComposer.None) ? ((vis != null && vis._0001() == (XlOLEVerb)0) ? param.WriteError() : param._0001()) : (param._0001() != WatcherComposer.Comment || vis == null || vis._0001() != 0 || param.WriteError())))
			{
				throw ContextError.CheckComposer(param, "Error reading JToken from JsonReader.");
			}
			IdentifierClientBridge last = param as IdentifierClientBridge;
			switch (param._0001())
			{
			case WatcherComposer.StartObject:
				return DecoratorReaderMapper.VerifyRequest(param, vis);
			case WatcherComposer.StartArray:
				return InstanceClassDispatcher.AssetClass(param, vis);
			case WatcherComposer.StartConstructor:
				return IndexerReaderMapper.WriteClass(param, vis);
			case WatcherComposer.PropertyName:
				return WatcherIssuer.OrderRequest(param, vis);
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
			{
				PoolIssuer poolIssuer4 = new PoolIssuer(param._0001());
				poolIssuer4.TestClass(last, vis);
				return poolIssuer4;
			}
			case WatcherComposer.Comment:
			{
				PoolIssuer poolIssuer3 = PoolIssuer.LogoutRequest(param._0001().ToString());
				poolIssuer3.TestClass(last, vis);
				return poolIssuer3;
			}
			case WatcherComposer.Null:
			{
				PoolIssuer poolIssuer2 = PoolIssuer.VisitRequest();
				poolIssuer2.TestClass(last, vis);
				return poolIssuer2;
			}
			case WatcherComposer.Undefined:
			{
				PoolIssuer poolIssuer = PoolIssuer.ViewRequest();
				poolIssuer.TestClass(last, vis);
				return poolIssuer;
			}
			default:
				throw ContextError.CheckComposer(param, "Error reading JToken from JsonReader. Unexpected token: {0}".ListReader(CultureInfo.InvariantCulture, param._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void TestClass(IdentifierClientBridge last, CodeIteratorMapping col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((col == null || col._0001() == (ResourceDictionaryLocation)1) && last != null && last._0002())
			{
				ConcatClass(last._0001(), last._0002());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ConcatClass(int reference_High, int reg_Y)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PrintClass(new WatcherListAnnotation(reference_High, reg_Y));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0014()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CountClass<WatcherListAnnotation>() != null;
		}

		bool IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0014();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CountClass<WatcherListAnnotation>()?.m_QueueIssuer ?? 0;
		}

		int IdentifierClientBridge._0001()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CountClass<WatcherListAnnotation>()?._ProxyIssuer ?? 0;
		}

		int IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual DynamicMetaObject _0001(Expression res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new WorkerClientBridge<ParserFilterResolver>(res, this, new GDBD.Bridges.SetterClientBridge<ParserFilterResolver>());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicMetaObject _0002(Expression task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001(task);
		}

		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression task)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return InvokeClass();
		}

		object ICloneable.Clone()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserFilterResolver InvokeClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintClass(object instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (_BroadcasterIssuer == null)
			{
				_BroadcasterIssuer = ((!(instance is object[])) ? instance : new object[1]
				{
					instance
				});
				return;
			}
			object[] array = _BroadcasterIssuer as object[];
			if (array == null)
			{
				_BroadcasterIssuer = new object[2]
				{
					_BroadcasterIssuer,
					instance
				};
				return;
			}
			int i;
			for (i = 0; i < array.Length && array[i] != null; i++)
			{
			}
			if (i == array.Length)
			{
				Array.Resize(ref array, i * 2);
				_BroadcasterIssuer = array;
			}
			array[i] = instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T CountClass<T>() where T : class
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_BroadcasterIssuer != null)
			{
				object[] array = _BroadcasterIssuer as object[];
				if (array == null)
				{
					return _BroadcasterIssuer as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T val = obj as T;
					if (val != null)
					{
						return val;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParserFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ClassIssuer = new Newtonsoft.Rules.UnicodeCategory[6]
			{
				Newtonsoft.Rules.UnicodeCategory.Integer,
				Newtonsoft.Rules.UnicodeCategory.Float,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Boolean
			};
			m_RequestIssuer = new Newtonsoft.Rules.UnicodeCategory[6]
			{
				Newtonsoft.Rules.UnicodeCategory.Integer,
				Newtonsoft.Rules.UnicodeCategory.Float,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Boolean
			};
			_IteratorIssuer = new Newtonsoft.Rules.UnicodeCategory[7]
			{
				Newtonsoft.Rules.UnicodeCategory.Integer,
				Newtonsoft.Rules.UnicodeCategory.Float,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Boolean,
				Newtonsoft.Rules.UnicodeCategory.Bytes
			};
			testsIssuer = new Newtonsoft.Rules.UnicodeCategory[11]
			{
				Newtonsoft.Rules.UnicodeCategory.Date,
				Newtonsoft.Rules.UnicodeCategory.Integer,
				Newtonsoft.Rules.UnicodeCategory.Float,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Boolean,
				Newtonsoft.Rules.UnicodeCategory.Bytes,
				Newtonsoft.Rules.UnicodeCategory.Guid,
				Newtonsoft.Rules.UnicodeCategory.TimeSpan,
				Newtonsoft.Rules.UnicodeCategory.Uri
			};
			methodIssuer = new Newtonsoft.Rules.UnicodeCategory[5]
			{
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Guid,
				Newtonsoft.Rules.UnicodeCategory.Bytes
			};
			m_AuthenticationIssuer = new Newtonsoft.Rules.UnicodeCategory[4]
			{
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.TimeSpan
			};
			mapperIssuer = new Newtonsoft.Rules.UnicodeCategory[4]
			{
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Uri
			};
			predicateIssuer = new Newtonsoft.Rules.UnicodeCategory[5]
			{
				Newtonsoft.Rules.UnicodeCategory.Integer,
				Newtonsoft.Rules.UnicodeCategory.Float,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw
			};
			policyIssuer = new Newtonsoft.Rules.UnicodeCategory[4]
			{
				Newtonsoft.Rules.UnicodeCategory.Date,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw
			};
			m_ServiceIssuer = new Newtonsoft.Rules.UnicodeCategory[5]
			{
				Newtonsoft.Rules.UnicodeCategory.Bytes,
				Newtonsoft.Rules.UnicodeCategory.String,
				Newtonsoft.Rules.UnicodeCategory.Comment,
				Newtonsoft.Rules.UnicodeCategory.Raw,
				Newtonsoft.Rules.UnicodeCategory.Integer
			};
		}
	}
}
