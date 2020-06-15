using _0008;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal sealed class EventEventConsumer<[_0008._0012(2)] T, [_0008._0012(2)] TT>
	{
		private readonly IDictionary<T, TT> _InvocationComposer;

		private readonly IDictionary<TT, T> definitionComposer;

		private readonly string systemComposer;

		private readonly string m_IdentifierComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EventEventConsumer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector((IEqualityComparer<T>)EqualityComparer<T>.Default, (IEqualityComparer<TT>)EqualityComparer<TT>.Default);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EventEventConsumer(IEqualityComparer<T> reference, IEqualityComparer<TT> reg)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(reference, reg, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EventEventConsumer(IEqualityComparer<T> asset, IEqualityComparer<TT> cont, string dir, string caller2)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_InvocationComposer = new Dictionary<T, TT>(asset);
			definitionComposer = new Dictionary<TT, T>(cont);
			systemComposer = dir;
			m_IdentifierComposer = caller2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssetTest(T param, TT result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_InvocationComposer.TryGetValue(param, out TT value) && !value.Equals(result))
			{
				throw new ArgumentException(systemComposer.ListReader(CultureInfo.InvariantCulture, param));
			}
			if (definitionComposer.TryGetValue(result, out T value2) && !value2.Equals(param))
			{
				throw new ArgumentException(m_IdentifierComposer.ListReader(CultureInfo.InvariantCulture, result));
			}
			_InvocationComposer.Add(param, result);
			definitionComposer.Add(result, param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CustomizeTest(T asset, out TT counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InvocationComposer.TryGetValue(asset, out counter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool QueryTest(TT v, out T pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return definitionComposer.TryGetValue(v, out pred);
		}
	}
}
