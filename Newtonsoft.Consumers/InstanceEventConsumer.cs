using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal sealed class InstanceEventConsumer : IFormatterConverter
	{
		private readonly BroadcasterInstanceRule m_CustomerProperty;

		private readonly CollectionProperty interpreterProperty;

		[_0008._0012(2)]
		private readonly ProductInstanceExpression watcherProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstanceEventConsumer(BroadcasterInstanceRule last, CollectionProperty vis, ProductInstanceExpression comp)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(last, "reader");
			ContextClientBridge.RunClient(vis, "contract");
			m_CustomerProperty = last;
			interpreterProperty = vis;
			watcherProperty = comp;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private T SetupClient<[_0008._0012(2)] T>(object spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(spec, "value");
			return (T)Convert.ChangeType(((PoolIssuer)spec)._0001(), typeof(T), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001(object first, Type second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(first, "value");
			ParserFilterResolver parserFilterResolver = first as ParserFilterResolver;
			if (parserFilterResolver == null)
			{
				throw new ArgumentException("Value is not a JToken.", "value");
			}
			return m_CustomerProperty.InterruptBroadcaster(parserFilterResolver, second, interpreterProperty, watcherProperty);
		}

		object IFormatterConverter.Convert(object first, Type second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(first, second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001(object key, TypeCode col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(key, "value");
			PoolIssuer poolIssuer = key as PoolIssuer;
			return Convert.ChangeType((poolIssuer != null) ? poolIssuer._0001() : key, col, CultureInfo.InvariantCulture);
		}

		object IFormatterConverter.Convert(object key, TypeCode col)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key, col);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<bool>(value);
		}

		bool IFormatterConverter.ToBoolean(object value)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte _0001(object def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<byte>(def);
		}

		byte IFormatterConverter.ToByte(object def)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public char _0001(object info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<char>(info);
		}

		char IFormatterConverter.ToChar(object info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateTime _0001(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<DateTime>(value);
		}

		DateTime IFormatterConverter.ToDateTime(object value)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public decimal _0001(object spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<decimal>(spec);
		}

		decimal IFormatterConverter.ToDecimal(object spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double _0001(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<double>(res);
		}

		double IFormatterConverter.ToDouble(object res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public short _0001(object i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<short>(i);
		}

		short IFormatterConverter.ToInt16(object i)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001(object v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<int>(v);
		}

		int IFormatterConverter.ToInt32(object v)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public long _0001(object asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<long>(asset);
		}

		long IFormatterConverter.ToInt64(object asset)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public sbyte _0001(object first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<sbyte>(first);
		}

		sbyte IFormatterConverter.ToSByte(object first)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public float _0001(object info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<float>(info);
		}

		float IFormatterConverter.ToSingle(object info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001(object spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<string>(spec);
		}

		string IFormatterConverter.ToString(object spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ushort _0001(object spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<ushort>(spec);
		}

		ushort IFormatterConverter.ToUInt16(object spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public uint _0001(object setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<uint>(setup);
		}

		uint IFormatterConverter.ToUInt32(object setup)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ulong _0001(object i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetupClient<ulong>(i);
		}

		ulong IFormatterConverter.ToUInt64(object i)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i);
		}
	}
}
