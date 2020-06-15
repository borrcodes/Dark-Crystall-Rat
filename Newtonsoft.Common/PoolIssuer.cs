using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	[_0008._0012(0)]
	internal class PoolIssuer : ParserFilterResolver, IComparable, IFormattable, IConvertible, IEquatable<PoolIssuer>, IComparable<PoolIssuer>
	{
		[_0008._0012(new byte[]
		{
			0,
			1
		})]
		private sealed class DefinitionIssuer : GDBD.Bridges.SetterClientBridge<PoolIssuer>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public DefinitionIssuer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		private Newtonsoft.Rules.UnicodeCategory _ValIssuer;

		[_0008._0012(2)]
		private object m_InvocationIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal PoolIssuer(object key, Newtonsoft.Rules.UnicodeCategory ord)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_InvocationIssuer = key;
			_ValIssuer = ord;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolIssuer(PoolIssuer config)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(config._0001(), ((ParserFilterResolver)config)._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolIssuer(long num_reference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(num_reference, Newtonsoft.Rules.UnicodeCategory.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolIssuer(string setup)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(setup, Newtonsoft.Rules.UnicodeCategory.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolIssuer(object var1)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(var1, ConnectRequest(null, var1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int CreateRequest(BigInteger value, object attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = value.CompareTo(HelperDicCandidate.RunProperty(attr));
			if (num != 0)
			{
				return num;
			}
			if (attr is decimal)
			{
				decimal num2 = (decimal)attr;
				return 0m.CompareTo(Math.Abs(num2 - Math.Truncate(num2)));
			}
			if (attr is double || attr is float)
			{
				double num3 = Convert.ToDouble(attr, CultureInfo.InvariantCulture);
				return 0.0.CompareTo(Math.Abs(num3 - Math.Truncate(num3)));
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int StopRequest(Newtonsoft.Rules.UnicodeCategory key, object attr, object pool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr == pool)
			{
				return 0;
			}
			if (pool == null)
			{
				return 1;
			}
			if (attr == null)
			{
				return -1;
			}
			switch (key)
			{
			case Newtonsoft.Rules.UnicodeCategory.Integer:
				if (attr is BigInteger)
				{
					BigInteger value3 = (BigInteger)attr;
					return CreateRequest(value3, pool);
				}
				if (pool is BigInteger)
				{
					BigInteger value4 = (BigInteger)pool;
					return -CreateRequest(value4, attr);
				}
				if (attr is ulong || pool is ulong || attr is decimal || pool is decimal)
				{
					return Convert.ToDecimal(attr, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(pool, CultureInfo.InvariantCulture));
				}
				if (attr is float || pool is float || attr is double || pool is double)
				{
					return CloneRequest(attr, pool);
				}
				return Convert.ToInt64(attr, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(pool, CultureInfo.InvariantCulture));
			case Newtonsoft.Rules.UnicodeCategory.Float:
				if (attr is BigInteger)
				{
					BigInteger value7 = (BigInteger)attr;
					return CreateRequest(value7, pool);
				}
				if (pool is BigInteger)
				{
					BigInteger value8 = (BigInteger)pool;
					return -CreateRequest(value8, attr);
				}
				if (attr is ulong || pool is ulong || attr is decimal || pool is decimal)
				{
					return Convert.ToDecimal(attr, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(pool, CultureInfo.InvariantCulture));
				}
				return CloneRequest(attr, pool);
			case Newtonsoft.Rules.UnicodeCategory.Comment:
			case Newtonsoft.Rules.UnicodeCategory.String:
			case Newtonsoft.Rules.UnicodeCategory.Raw:
			{
				string strA = Convert.ToString(attr, CultureInfo.InvariantCulture);
				string strB = Convert.ToString(pool, CultureInfo.InvariantCulture);
				return string.CompareOrdinal(strA, strB);
			}
			case Newtonsoft.Rules.UnicodeCategory.Boolean:
			{
				bool flag = Convert.ToBoolean(attr, CultureInfo.InvariantCulture);
				bool value2 = Convert.ToBoolean(pool, CultureInfo.InvariantCulture);
				return flag.CompareTo(value2);
			}
			case Newtonsoft.Rules.UnicodeCategory.Date:
			{
				if (attr is DateTime)
				{
					DateTime dateTime = (DateTime)attr;
					DateTime value5 = (!(pool is DateTimeOffset)) ? Convert.ToDateTime(pool, CultureInfo.InvariantCulture) : ((DateTimeOffset)pool).DateTime;
					return dateTime.CompareTo(value5);
				}
				DateTimeOffset dateTimeOffset = (DateTimeOffset)attr;
				DateTimeOffset other = (pool is DateTimeOffset) ? ((DateTimeOffset)pool) : new DateTimeOffset(Convert.ToDateTime(pool, CultureInfo.InvariantCulture));
				return dateTimeOffset.CompareTo(other);
			}
			case Newtonsoft.Rules.UnicodeCategory.Bytes:
			{
				byte[] array = pool as byte[];
				if (array == null)
				{
					throw new ArgumentException("Object must be of type byte[].");
				}
				return CustomerListAnnotation.PrintIssuer(attr as byte[], array);
			}
			case Newtonsoft.Rules.UnicodeCategory.Guid:
			{
				if (!(pool is Guid))
				{
					throw new ArgumentException("Object must be of type Guid.");
				}
				Guid guid = (Guid)attr;
				Guid value6 = (Guid)pool;
				return guid.CompareTo(value6);
			}
			case Newtonsoft.Rules.UnicodeCategory.Uri:
			{
				Uri uri = pool as Uri;
				if (uri == null)
				{
					throw new ArgumentException("Object must be of type Uri.");
				}
				Uri uri2 = (Uri)attr;
				return Comparer<string>.Default.Compare(uri2.ToString(), uri.ToString());
			}
			case Newtonsoft.Rules.UnicodeCategory.TimeSpan:
			{
				if (!(pool is TimeSpan))
				{
					throw new ArgumentException("Object must be of type TimeSpan.");
				}
				TimeSpan timeSpan = (TimeSpan)attr;
				TimeSpan value = (TimeSpan)pool;
				return timeSpan.CompareTo(value);
			}
			default:
				throw CustomerListAnnotation.ConcatIssuer("valueType", key, "Unexpected value type: {0}".ListReader(CultureInfo.InvariantCulture, key));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int CloneRequest(object asset, object map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			double def = Convert.ToDouble(asset, CultureInfo.InvariantCulture);
			double num = Convert.ToDouble(map, CultureInfo.InvariantCulture);
			if (IteratorComposerPool.DeleteIssuer(def, num))
			{
				return 0;
			}
			return def.CompareTo(num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PoolIssuer LogoutRequest(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(value, Newtonsoft.Rules.UnicodeCategory.Comment);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PoolIssuer VisitRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(null, Newtonsoft.Rules.UnicodeCategory.Null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PoolIssuer ViewRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PoolIssuer(null, Newtonsoft.Rules.UnicodeCategory.Undefined);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Newtonsoft.Rules.UnicodeCategory ConnectRequest(Newtonsoft.Rules.UnicodeCategory? config, object result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (result == null)
			{
				return Newtonsoft.Rules.UnicodeCategory.Null;
			}
			if (result == DBNull.Value)
			{
				return Newtonsoft.Rules.UnicodeCategory.Null;
			}
			if (result is string)
			{
				return MoveRequest(config);
			}
			if (result is long || result is int || result is short || result is sbyte || result is ulong || result is uint || result is ushort || result is byte)
			{
				return Newtonsoft.Rules.UnicodeCategory.Integer;
			}
			if (result is Enum)
			{
				return Newtonsoft.Rules.UnicodeCategory.Integer;
			}
			if (result is BigInteger)
			{
				return Newtonsoft.Rules.UnicodeCategory.Integer;
			}
			if (result is double || result is float || result is decimal)
			{
				return Newtonsoft.Rules.UnicodeCategory.Float;
			}
			if (result is DateTime)
			{
				return Newtonsoft.Rules.UnicodeCategory.Date;
			}
			if (result is DateTimeOffset)
			{
				return Newtonsoft.Rules.UnicodeCategory.Date;
			}
			if (result is byte[])
			{
				return Newtonsoft.Rules.UnicodeCategory.Bytes;
			}
			if (result is bool)
			{
				return Newtonsoft.Rules.UnicodeCategory.Boolean;
			}
			if (result is Guid)
			{
				return Newtonsoft.Rules.UnicodeCategory.Guid;
			}
			if (result is Uri)
			{
				return Newtonsoft.Rules.UnicodeCategory.Uri;
			}
			if (result is TimeSpan)
			{
				return Newtonsoft.Rules.UnicodeCategory.TimeSpan;
			}
			throw new ArgumentException("Could not determine JSON object type for type {0}.".ListReader(CultureInfo.InvariantCulture, result.GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Newtonsoft.Rules.UnicodeCategory MoveRequest(Newtonsoft.Rules.UnicodeCategory? def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!def.HasValue)
			{
				return Newtonsoft.Rules.UnicodeCategory.String;
			}
			Newtonsoft.Rules.UnicodeCategory valueOrDefault = def.GetValueOrDefault();
			if (valueOrDefault == Newtonsoft.Rules.UnicodeCategory.Comment || valueOrDefault == Newtonsoft.Rules.UnicodeCategory.String || valueOrDefault == Newtonsoft.Rules.UnicodeCategory.Raw)
			{
				return def.GetValueOrDefault();
			}
			return Newtonsoft.Rules.UnicodeCategory.String;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.UnicodeCategory _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ValIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InvocationIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher task, BroadcasterError[] counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (counter != null && counter.Length != 0 && m_InvocationIssuer != null)
			{
				BroadcasterError broadcasterError = PrototypeError.LogoutComposer(counter, m_InvocationIssuer.GetType());
				if (broadcasterError != null && broadcasterError._0001())
				{
					broadcasterError._0001(task, m_InvocationIssuer, PrototypeError.FillComposer());
					return;
				}
			}
			switch (_ValIssuer)
			{
			case Newtonsoft.Rules.UnicodeCategory.Comment:
				task._0005(m_InvocationIssuer?.ToString());
				break;
			case Newtonsoft.Rules.UnicodeCategory.Raw:
				task._0006(m_InvocationIssuer?.ToString());
				break;
			case Newtonsoft.Rules.UnicodeCategory.Null:
				task._0008();
				break;
			case Newtonsoft.Rules.UnicodeCategory.Undefined:
				task._000E();
				break;
			case Newtonsoft.Rules.UnicodeCategory.Integer:
			{
				object invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is int)
				{
					int first_Low = (int)invocationIssuer;
					task._0001(first_Low);
					break;
				}
				invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is long)
				{
					long asset2 = (long)invocationIssuer;
					task._0001(asset2);
					break;
				}
				invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is ulong)
				{
					ulong specID = (ulong)invocationIssuer;
					task._0001(specID);
					break;
				}
				invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is BigInteger)
				{
					BigInteger bigInteger = (BigInteger)invocationIssuer;
					task._0001(bigInteger);
				}
				else
				{
					task._0001(Convert.ToInt64(m_InvocationIssuer, CultureInfo.InvariantCulture));
				}
				break;
			}
			case Newtonsoft.Rules.UnicodeCategory.Float:
			{
				object invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is decimal)
				{
					decimal asset = (decimal)invocationIssuer;
					task._0001(asset);
					break;
				}
				invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is double)
				{
					double last = (double)invocationIssuer;
					task._0001(last);
					break;
				}
				invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is float)
				{
					float init = (float)invocationIssuer;
					task._0001(init);
				}
				else
				{
					task._0001(Convert.ToDouble(m_InvocationIssuer, CultureInfo.InvariantCulture));
				}
				break;
			}
			case Newtonsoft.Rules.UnicodeCategory.String:
				task._0004(m_InvocationIssuer?.ToString());
				break;
			case Newtonsoft.Rules.UnicodeCategory.Boolean:
				task._0001(Convert.ToBoolean(m_InvocationIssuer, CultureInfo.InvariantCulture));
				break;
			case Newtonsoft.Rules.UnicodeCategory.Date:
			{
				object invocationIssuer = m_InvocationIssuer;
				if (invocationIssuer is DateTimeOffset)
				{
					DateTimeOffset last2 = (DateTimeOffset)invocationIssuer;
					task._0001(last2);
				}
				else
				{
					task._0001(Convert.ToDateTime(m_InvocationIssuer, CultureInfo.InvariantCulture));
				}
				break;
			}
			case Newtonsoft.Rules.UnicodeCategory.Bytes:
				task._0001((byte[])m_InvocationIssuer);
				break;
			case Newtonsoft.Rules.UnicodeCategory.Guid:
				task._0001((m_InvocationIssuer != null) ? ((Guid?)m_InvocationIssuer) : null);
				break;
			case Newtonsoft.Rules.UnicodeCategory.TimeSpan:
				task._0001((m_InvocationIssuer != null) ? ((TimeSpan?)m_InvocationIssuer) : null);
				break;
			case Newtonsoft.Rules.UnicodeCategory.Uri:
				task._0001((Uri)m_InvocationIssuer);
				break;
			default:
				throw CustomerListAnnotation.ConcatIssuer("Type", _ValIssuer, "Unexpected token type.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool PopRequest(PoolIssuer last, PoolIssuer selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last != selection)
			{
				if (last._ValIssuer == selection._ValIssuer)
				{
					return StopRequest(last._ValIssuer, last.m_InvocationIssuer, selection.m_InvocationIssuer) == 0;
				}
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(PoolIssuer init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return false;
			}
			return PopRequest(this, init);
		}

		bool IEquatable<PoolIssuer>.Equals(PoolIssuer init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = config as PoolIssuer;
			if (poolIssuer != null)
			{
				return this._0001(poolIssuer);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_InvocationIssuer == null)
			{
				return 0;
			}
			return m_InvocationIssuer.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_InvocationIssuer == null)
			{
				return string.Empty;
			}
			return m_InvocationIssuer.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001(IFormatProvider spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001((string)null, spec);
		}

		string IConvertible.ToString(IFormatProvider spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001(string asset, IFormatProvider ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_InvocationIssuer == null)
			{
				return string.Empty;
			}
			IFormattable formattable = m_InvocationIssuer as IFormattable;
			if (formattable != null)
			{
				return formattable.ToString(asset, ord);
			}
			return m_InvocationIssuer.ToString();
		}

		string IFormattable.ToString(string asset, IFormatProvider ord)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(asset, ord);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override DynamicMetaObject _0001(Expression last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new WorkerClientBridge<PoolIssuer>(last, this, new DefinitionIssuer());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(object key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (key == null)
			{
				return 1;
			}
			PoolIssuer poolIssuer = key as PoolIssuer;
			object pool;
			Newtonsoft.Rules.UnicodeCategory key2;
			if (poolIssuer != null)
			{
				pool = poolIssuer._0001();
				key2 = ((_ValIssuer == Newtonsoft.Rules.UnicodeCategory.String && _ValIssuer != poolIssuer._ValIssuer) ? poolIssuer._ValIssuer : _ValIssuer);
			}
			else
			{
				pool = key;
				key2 = _ValIssuer;
			}
			return StopRequest(key2, m_InvocationIssuer, pool);
		}

		int IComparable.CompareTo(object key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001(PoolIssuer key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (key == null)
			{
				return 1;
			}
			return StopRequest((_ValIssuer == Newtonsoft.Rules.UnicodeCategory.String && _ValIssuer != key._ValIssuer) ? key._ValIssuer : _ValIssuer, m_InvocationIssuer, key.m_InvocationIssuer);
		}

		int IComparable<PoolIssuer>.CompareTo(PoolIssuer key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new TypeCode _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_InvocationIssuer == null)
			{
				return TypeCode.Empty;
			}
			return (m_InvocationIssuer as IConvertible)?.GetTypeCode() ?? TypeCode.Object;
		}

		TypeCode IConvertible.GetTypeCode()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0001(IFormatProvider setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		bool IConvertible.ToBoolean(IFormatProvider setup)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char _0001(IFormatProvider last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		char IConvertible.ToChar(IFormatProvider last)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private sbyte _0001(IFormatProvider init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		sbyte IConvertible.ToSByte(IFormatProvider init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte _0001(IFormatProvider def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		byte IConvertible.ToByte(IFormatProvider def)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private short _0001(IFormatProvider key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		short IConvertible.ToInt16(IFormatProvider key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ushort _0001(IFormatProvider def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		ushort IConvertible.ToUInt16(IFormatProvider def)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(IFormatProvider task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		int IConvertible.ToInt32(IFormatProvider task)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint _0001(IFormatProvider init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		uint IConvertible.ToUInt32(IFormatProvider init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long _0001(IFormatProvider param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		long IConvertible.ToInt64(IFormatProvider param)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ulong _0001(IFormatProvider i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		ulong IConvertible.ToUInt64(IFormatProvider i)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float _0001(IFormatProvider i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		float IConvertible.ToSingle(IFormatProvider i)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private double _0001(IFormatProvider res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		double IConvertible.ToDouble(IFormatProvider res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private decimal _0001(IFormatProvider config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		decimal IConvertible.ToDecimal(IFormatProvider config)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DateTime _0001(IFormatProvider setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ParserFilterResolver._0001((ParserFilterResolver)this);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider setup)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0001(Type param, IFormatProvider visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return StartClass(param);
		}

		object IConvertible.ToType(Type param, IFormatProvider visitor)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(param, visitor);
		}
	}
}
