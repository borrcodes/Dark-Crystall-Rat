using _0008;
using GDBD.Bridges;
using GDBD.Structs;
using GDBD.Workers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal sealed class IssuerInstanceRule<[_0008._0012(2)] T, [_0008._0012(2)] TT> : IDictionary<T, TT>, ICollection<KeyValuePair<T, TT>>, IEnumerable<KeyValuePair<T, TT>>, IDictionary, ICollection, IEnumerable, ProcessComposer
	{
		[_0008._0012(0)]
		private struct TokenComposer<[_0008._0012(2)] T3, [_0008._0012(2)] G> : IEnumerator, IDictionaryEnumerator
		{
			[_0008._0012(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly IEnumerator<KeyValuePair<T3, G>> _DispatcherComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TokenComposer(IEnumerator<KeyValuePair<T3, G>> var1)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				ContextClientBridge.RunClient(var1, "e");
				_DispatcherComposer = var1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public DictionaryEntry _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (DictionaryEntry)_0003();
			}

			DictionaryEntry IDictionaryEnumerator.get_Entry()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public object _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001().Key;
			}

			object IDictionaryEnumerator.get_Key()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public object _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001().Value;
			}

			object IDictionaryEnumerator.get_Value()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0002();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public object _0003()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return new DictionaryEntry(_DispatcherComposer.Current.Key, _DispatcherComposer.Current.Value);
			}

			object IEnumerator.get_Current()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0003();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _DispatcherComposer.MoveNext();
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_DispatcherComposer.Reset();
			}

			void IEnumerator.Reset()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001();
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class FilterEventConsumer
		{
			[_0008._0012(0)]
			public static readonly FilterEventConsumer m_AccountComposer;

			[_0008._0012(0)]
			public static Func<DictionaryEntry, KeyValuePair<T, TT>> singletonComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FilterEventConsumer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				m_AccountComposer = new FilterEventConsumer();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FilterEventConsumer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal KeyValuePair<T, TT> QueryProperty(DictionaryEntry asset)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return new KeyValuePair<T, TT>((T)asset.Key, (TT)asset.Value);
			}
		}

		[_0008._0012(2)]
		private readonly IDictionary m_BaseComposer;

		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly IDictionary<T, TT> m_ProccesorComposer;

		[_0008._0012(2)]
		private object adapterComposer;

		public TT this[T item]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_BaseComposer != null)
				{
					return (TT)m_BaseComposer[item];
				}
				return this._0001()[item];
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_BaseComposer != null)
				{
					m_BaseComposer[item] = value;
				}
				else
				{
					this._0001()[item] = value;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IDictionary<T, TT> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ProccesorComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(T init, TT result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer.Add(init, result);
				return;
			}
			if (m_ProccesorComposer != null)
			{
				m_ProccesorComposer.Add(init, result);
				return;
			}
			throw new NotSupportedException();
		}

		void IDictionary<T, TT>.Add(T init, TT result)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(init, result);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(T i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.Contains(i);
			}
			return this._0001().ContainsKey(i);
		}

		bool IDictionary<T, TT>.ContainsKey(T i)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICollection<T> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.Keys.Cast<T>().ToList();
			}
			return this._0001().Keys;
		}

		ICollection<T> IDictionary<T, TT>.get_Keys()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0002(T res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				if (m_BaseComposer.Contains(res))
				{
					m_BaseComposer.Remove(res);
					return true;
				}
				return false;
			}
			return this._0001().Remove(res);
		}

		bool IDictionary<T, TT>.Remove(T res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(T i, [StatePropertyStruct] out TT _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				if (!m_BaseComposer.Contains(i))
				{
					_0003 = default(TT);
					return false;
				}
				_0003 = (TT)m_BaseComposer[i];
				return true;
			}
			return this._0001().TryGetValue(i, out _0003);
		}

		bool IDictionary<T, TT>.TryGetValue(T i, [StatePropertyStruct] out TT _0003)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i, out _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICollection<TT> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.Values.Cast<TT>().ToList();
			}
			return this._0001().Values;
		}

		ICollection<TT> IDictionary<T, TT>.get_Values()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(KeyValuePair<T, TT> ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				((IList)m_BaseComposer).Add(ident);
			}
			else
			{
				m_ProccesorComposer?.Add(ident);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer.Clear();
			}
			else
			{
				this._0001().Clear();
			}
		}

		void IDictionary.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}

		void ICollection<KeyValuePair<T, TT>>.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(KeyValuePair<T, TT> config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return ((IList)m_BaseComposer).Contains(config);
			}
			return this._0001().Contains(config);
		}

		bool ICollection<KeyValuePair<T, TT>>.Contains(KeyValuePair<T, TT> config)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(KeyValuePair<T, TT>[] last, int max_connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				foreach (DictionaryEntry item in m_BaseComposer)
				{
					last[max_connection++] = new KeyValuePair<T, TT>((T)item.Key, (TT)item.Value);
				}
			}
			else
			{
				this._0001().CopyTo(last, max_connection);
			}
		}

		void ICollection<KeyValuePair<T, TT>>.CopyTo(KeyValuePair<T, TT>[] last, int max_connection)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(last, max_connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.Count;
			}
			return this._0001().Count;
		}

		int ICollection.get_Count()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		int ICollection<KeyValuePair<T, TT>>.get_Count()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.IsReadOnly;
			}
			return this._0001().IsReadOnly;
		}

		bool IDictionary.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		bool ICollection<KeyValuePair<T, TT>>.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0002(KeyValuePair<T, TT> info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				if (m_BaseComposer.Contains(info.Key))
				{
					if (object.Equals(m_BaseComposer[info.Key], info.Value))
					{
						m_BaseComposer.Remove(info.Key);
						return true;
					}
					return false;
				}
				return true;
			}
			return this._0001().Remove(info);
		}

		bool ICollection<KeyValuePair<T, TT>>.Remove(KeyValuePair<T, TT> info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<KeyValuePair<T, TT>> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return (from DictionaryEntry asset in m_BaseComposer
					select new KeyValuePair<T, TT>((T)asset.Key, (TT)asset.Value)).GetEnumerator();
			}
			return this._0001().GetEnumerator();
		}

		IEnumerator<KeyValuePair<T, TT>> IEnumerable<KeyValuePair<T, TT>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(object config, object col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer.Add(config, col);
			}
			else
			{
				this._0001().Add((T)config, (TT)col);
			}
		}

		void IDictionary.Add(object config, object col)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(config, col);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0001(object spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer[spec];
			}
			return this._0001()[(T)spec];
		}

		object IDictionary.get_Item(object spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(object key, object second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer[key] = second;
			}
			else
			{
				this._0001()[(T)key] = (TT)second;
			}
		}

		void IDictionary.set_Item(object key, object second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(key, second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionaryEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.GetEnumerator();
			}
			return new TokenComposer<T, TT>(this._0001().GetEnumerator());
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0001(object v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProccesorComposer != null)
			{
				return m_ProccesorComposer.ContainsKey((T)v);
			}
			return m_BaseComposer.Contains(v);
		}

		bool IDictionary.Contains(object v)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProccesorComposer != null)
			{
				return false;
			}
			return m_BaseComposer.IsFixedSize;
		}

		bool IDictionary.get_IsFixedSize()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ICollection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProccesorComposer != null)
			{
				return m_ProccesorComposer.Keys.ToList();
			}
			return m_BaseComposer.Keys;
		}

		ICollection IDictionary.get_Keys()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(object item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer.Remove(item);
			}
			else
			{
				this._0001().Remove((T)item);
			}
		}

		void IDictionary.Remove(object item)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ICollection _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProccesorComposer != null)
			{
				return m_ProccesorComposer.Values.ToList();
			}
			return m_BaseComposer.Values;
		}

		ICollection IDictionary.get_Values()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(Array config, int selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				m_BaseComposer.CopyTo(config, selection);
			}
			else
			{
				this._0001().CopyTo((KeyValuePair<T, TT>[])config, selection);
			}
		}

		void ICollection.CopyTo(Array config, int selection)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(config, selection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer.IsSynchronized;
			}
			return false;
		}

		bool ICollection.get_IsSynchronized()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (adapterComposer == null)
			{
				Interlocked.CompareExchange(ref adapterComposer, new object(), null);
			}
			return adapterComposer;
		}

		object ICollection.get_SyncRoot()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BaseComposer != null)
			{
				return m_BaseComposer;
			}
			return this._0001();
		}
	}
}
