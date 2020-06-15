using _0008;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Dispatcher
{
	[_0008._0012(0)]
	internal sealed class SetterComposer<[_0008._0012(2)] T> : ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable, ManagerErrorFilter
	{
		[_0008._0012(2)]
		private readonly IList workerComposer;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private readonly ICollection<T> _AdvisorComposer;

		[_0008._0012(2)]
		private object rulesComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Add(T config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				_AdvisorComposer.Add(config);
			}
			else
			{
				workerComposer.Add(config);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				_AdvisorComposer.Clear();
			}
			else
			{
				workerComposer.Clear();
			}
		}

		void IList.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}

		void ICollection<T>.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool _0001(T instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				return _AdvisorComposer.Contains(instance);
			}
			return workerComposer.Contains(instance);
		}

		bool ICollection<T>.Contains(T instance)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(T[] value, int map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				_AdvisorComposer.CopyTo(value, map);
			}
			else
			{
				workerComposer.CopyTo(value, map);
			}
		}

		void ICollection<T>.CopyTo(T[] value, int map)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(value, map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				return _AdvisorComposer.Count;
			}
			return workerComposer.Count;
		}

		int ICollection.get_Count()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		int ICollection<T>.get_Count()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				return _AdvisorComposer.IsReadOnly;
			}
			return workerComposer.IsReadOnly;
		}

		bool IList.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		bool ICollection<T>.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool _0002(T first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				return _AdvisorComposer.Remove(first);
			}
			bool num = workerComposer.Contains(first);
			if (num)
			{
				workerComposer.Remove(first);
			}
			return num;
		}

		bool ICollection<T>.Remove(T first)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerator<T> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IEnumerable<T> advisorComposer = _AdvisorComposer;
			return (advisorComposer ?? workerComposer.Cast<T>()).GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IEnumerable advisorComposer = _AdvisorComposer;
			return (advisorComposer ?? workerComposer).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(object init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_000a: Stack underflow*/)._0001(init);
			Add((T)init);
			return this._0001() - 1;
		}

		int IList.Add(object init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0001(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_000a: Stack underflow*/)._0001(res))
			{
				return _0001((T)res);
			}
			return false;
		}

		bool IList.Contains(object res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0002(object param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
			}
			if (((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_0021: Stack underflow*/)._0001(param))
			{
				return workerComposer.IndexOf((T)param);
			}
			return -1;
		}

		int IList.IndexOf(object param)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(int info_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
			}
			workerComposer.RemoveAt(info_start);
		}

		void IList.RemoveAt(int info_start)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(info_start);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(int config_offset, object vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
			}
			((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_0021: Stack underflow*/)._0001(vis);
			workerComposer.Insert(config_offset, (T)vis);
		}

		void IList.Insert(int config_offset, object vis)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(config_offset, vis);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				return _AdvisorComposer.IsReadOnly;
			}
			return workerComposer.IsFixedSize;
		}

		bool IList.get_IsFixedSize()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(object config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_000a: Stack underflow*/)._0001(config))
			{
				_0002((T)config);
			}
		}

		void IList.Remove(object config)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0001(int instance_min)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			return workerComposer[instance_min];
		}

		object IList.get_Item(int instance_min)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(instance_min);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(int previous_task, object map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_AdvisorComposer != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_0021: Stack underflow*/)._0001(map);
			workerComposer[previous_task] = (T)map;
		}

		void IList.set_Item(int previous_task, object map)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(previous_task, map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(Array value, int end_reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001((T[])value, end_reg);
		}

		void ICollection.CopyTo(Array value, int end_reg)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(value, end_reg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
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
			if (rulesComposer == null)
			{
				Interlocked.CompareExchange(ref rulesComposer, new object(), null);
			}
			return rulesComposer;
		}

		object ICollection.get_SyncRoot()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DisableProperty(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!((GDBD.Dispatcher.SetterComposer<T>)/*Error near IL_000a: Stack underflow*/)._0001(res))
			{
				throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".SelectReader(CultureInfo.InvariantCulture, res, typeof(T)), "value");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool VerifyProperty(object asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!(asset is T) && (asset != null || (typeof(T).FindClient() && !ResolverErrorFilter.PatchReader(typeof(T)))))
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((object)_AdvisorComposer) ?? ((object)workerComposer);
		}
	}
}
