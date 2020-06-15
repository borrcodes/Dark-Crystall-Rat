using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Mappers
{
	[_0008._0012(0)]
	public sealed class DecoratorReaderMapper : ConfigurationIssuer, IDictionary<string, ParserFilterResolver>, ICollection<KeyValuePair<string, ParserFilterResolver>>, IEnumerable<KeyValuePair<string, ParserFilterResolver>>, IEnumerable, ICustomTypeDescriptor, INotifyPropertyChanged, INotifyPropertyChanging
	{
		[_0008._0012(new byte[]
		{
			0,
			1
		})]
		private sealed class InvocationErrorFilter : GDBD.Bridges.SetterClientBridge<DecoratorReaderMapper>
		{
			[Serializable]
			[CompilerGenerated]
			private sealed class DicClassDispatcher
			{
				[_0008._0012(0)]
				public static readonly DicClassDispatcher m_CustomerIssuer;

				[_0008._0012(0)]
				public static Func<WatcherIssuer, string> _InterpreterIssuer;

				[MethodImpl(MethodImplOptions.NoInlining)]
				static DicClassDispatcher()
				{
					//Discarded unreachable code: IL_0002, IL_0006
					//IL_0003: Incompatible stack heights: 0 vs 1
					//IL_0007: Incompatible stack heights: 0 vs 1
					SingletonReader.PushGlobal();
					m_CustomerIssuer = new DicClassDispatcher();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				public DicClassDispatcher()
				{
					//Discarded unreachable code: IL_0002, IL_0006
					//IL_0003: Incompatible stack heights: 0 vs 1
					//IL_0007: Incompatible stack heights: 0 vs 1
					SingletonReader.PushGlobal();
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string ValidateRequest(WatcherIssuer setup)
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					return setup._0001();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override IEnumerable<string> _0001(DecoratorReaderMapper config)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return from setup in config.CheckRequest()
					select setup._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public InvocationErrorFilter()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		private readonly ManagerIssuer _StubIssuer;

		[_0008._0012(2)]
		[CompilerGenerated]
		private PropertyChangedEventHandler _CodeIssuer;

		[_0008._0012(2)]
		[CompilerGenerated]
		private PropertyChangingEventHandler taskIssuer;

		[_0008._0012(2)]
		public override ParserFilterResolver this[object init]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(init, "key");
				string text = init as string;
				if (text == null)
				{
					throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(init)));
				}
				return this[text];
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(init, "key");
				string text = init as string;
				if (text == null)
				{
					throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(init)));
				}
				this[text] = value;
			}
		}

		[_0008._0012(2)]
		public ParserFilterResolver this[string param]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(param, "propertyName");
				return DisableRequest(param, StringComparison.Ordinal)?._0004();
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				WatcherIssuer watcherIssuer = DisableRequest(ident, StringComparison.Ordinal);
				if (watcherIssuer != null)
				{
					watcherIssuer._0003(value);
					return;
				}
				this._0002(ident);
				_0002(ident, value);
				this._0001(ident);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IList<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StubIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(PropertyChangedEventHandler first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyChangedEventHandler propertyChangedEventHandler = _CodeIssuer;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, first);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref _CodeIssuer, value, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		void INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler first)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(PropertyChangedEventHandler instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyChangedEventHandler propertyChangedEventHandler = _CodeIssuer;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, instance);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref _CodeIssuer, value, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}

		void INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler instance)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(PropertyChangingEventHandler reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyChangingEventHandler propertyChangingEventHandler = taskIssuer;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value = (PropertyChangingEventHandler)Delegate.Combine(propertyChangingEventHandler2, reference);
				propertyChangingEventHandler = Interlocked.CompareExchange(ref taskIssuer, value, propertyChangingEventHandler2);
			}
			while ((object)propertyChangingEventHandler != propertyChangingEventHandler2);
		}

		void INotifyPropertyChanging.add_PropertyChanging(PropertyChangingEventHandler reference)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(PropertyChangingEventHandler def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyChangingEventHandler propertyChangingEventHandler = taskIssuer;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value = (PropertyChangingEventHandler)Delegate.Remove(propertyChangingEventHandler2, def);
				propertyChangingEventHandler = Interlocked.CompareExchange(ref taskIssuer, value, propertyChangingEventHandler2);
			}
			while ((object)propertyChangingEventHandler != propertyChangingEventHandler2);
		}

		void INotifyPropertyChanging.remove_PropertyChanging(PropertyChangingEventHandler def)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoratorReaderMapper()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_StubIssuer = new ManagerIssuer();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoratorReaderMapper(DecoratorReaderMapper setup)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_StubIssuer = new ManagerIssuer();
			base._002Ector(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int _0001(ParserFilterResolver info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info == null)
			{
				return -1;
			}
			return _StubIssuer.MapRequest(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(int indexOf_info, ParserFilterResolver ivk, bool isfilter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ivk == null || ivk._0001() != Newtonsoft.Rules.UnicodeCategory.Comment)
			{
				base._0001(indexOf_info, ivk, isfilter);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(ParserFilterResolver config, ParserFilterResolver selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(config, "o");
			if (config._0001() != Newtonsoft.Rules.UnicodeCategory.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".SelectReader(CultureInfo.InvariantCulture, config.GetType(), GetType()));
			}
			WatcherIssuer watcherIssuer = (WatcherIssuer)config;
			if (selection != null)
			{
				WatcherIssuer watcherIssuer2 = (WatcherIssuer)selection;
				if (watcherIssuer._0001() == watcherIssuer2._0001())
				{
					return;
				}
			}
			if (_StubIssuer.EnableRequest(watcherIssuer._0001(), out selection))
			{
				throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".SelectReader(CultureInfo.InvariantCulture, watcherIssuer._0001(), GetType()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RevertClass(WatcherIssuer v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001(v._0001());
			if (_CandidateIssuer != null)
			{
				_0001(new ListChangedEventArgs(ListChangedType.ItemChanged, ((ConfigurationIssuer)this)._0001((ParserFilterResolver)v)));
			}
			if (_PrinterIssuer != null)
			{
				_0001(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, v, v, ((ConfigurationIssuer)this)._0001((ParserFilterResolver)v)));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void LoginRequest(WatcherIssuer info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0002(info._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new DecoratorReaderMapper(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.UnicodeCategory _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Newtonsoft.Rules.UnicodeCategory.Object;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<WatcherIssuer> CheckRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StubIssuer.Cast<WatcherIssuer>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WatcherIssuer DisableRequest(string i, StringComparison token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i == null)
			{
				return null;
			}
			if (_StubIssuer.EnableRequest(i, out ParserFilterResolver _0003))
			{
				return (WatcherIssuer)_0003;
			}
			if (token != StringComparison.Ordinal)
			{
				for (int j = 0; j < _StubIssuer.Count; j++)
				{
					WatcherIssuer watcherIssuer = (WatcherIssuer)_StubIssuer[j];
					if (string.Equals(watcherIssuer._0001(), i, token))
					{
						return watcherIssuer;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DecoratorReaderMapper VerifyRequest(TagTestItem config, CodeIteratorMapping col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(config, "reader");
			if (config._0001() == WatcherComposer.None && !config._0001())
			{
				throw ContextError.CheckComposer(config, "Error reading JObject from JsonReader.");
			}
			config.RevertError();
			if (config._0001() != WatcherComposer.StartObject)
			{
				throw ContextError.CheckComposer(config, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".ListReader(CultureInfo.InvariantCulture, config._0001()));
			}
			DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper();
			decoratorReaderMapper.TestClass(config as IdentifierClientBridge, col);
			decoratorReaderMapper.CollectClass(config, col);
			return decoratorReaderMapper;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DecoratorReaderMapper PatchRequest(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return FindRequest(instance, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DecoratorReaderMapper FindRequest(string config, CodeIteratorMapping second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (TagTestItem tagTestItem = new RequestComposerPool(new StringReader(config)))
			{
				DecoratorReaderMapper result = VerifyRequest(tagTestItem, second);
				while (tagTestItem._0001())
				{
				}
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher setup, BroadcasterError[] cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			setup._0002();
			for (int i = 0; i < _StubIssuer.Count; i++)
			{
				_StubIssuer[i]._0001(setup, cfg);
			}
			setup._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(string v, ParserFilterResolver selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Add(new WatcherIssuer(v, selection));
		}

		void IDictionary<string, ParserFilterResolver>.Add(string v, ParserFilterResolver selection)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(v, selection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0001(string init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(init, "propertyName");
			return _StubIssuer.FillRequest(init);
		}

		bool IDictionary<string, ParserFilterResolver>.ContainsKey(string init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new ICollection<string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StubIssuer._0001();
		}

		ICollection<string> IDictionary<string, ParserFilterResolver>.get_Keys()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0002(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherIssuer watcherIssuer = DisableRequest(res, StringComparison.Ordinal);
			if (watcherIssuer == null)
			{
				return false;
			}
			watcherIssuer.ComputeClass();
			return true;
		}

		bool IDictionary<string, ParserFilterResolver>.Remove(string res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(string ident, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out ParserFilterResolver _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherIssuer watcherIssuer = DisableRequest(ident, StringComparison.Ordinal);
			if (watcherIssuer == null)
			{
				_0003 = null;
				return false;
			}
			_0003 = watcherIssuer._0004();
			return true;
		}

		bool IDictionary<string, ParserFilterResolver>.TryGetValue(string ident, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out ParserFilterResolver _0003)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(ident, out _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new ICollection<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotImplementedException();
		}

		ICollection<ParserFilterResolver> IDictionary<string, ParserFilterResolver>.get_Values()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(KeyValuePair<string, ParserFilterResolver> init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Add(new WatcherIssuer(init.Key, init.Value));
		}

		void ICollection<KeyValuePair<string, ParserFilterResolver>>.Add(KeyValuePair<string, ParserFilterResolver> init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DefineClass();
		}

		void ICollection<KeyValuePair<string, ParserFilterResolver>>.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0001(KeyValuePair<string, ParserFilterResolver> v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherIssuer watcherIssuer = DisableRequest(v.Key, StringComparison.Ordinal);
			if (watcherIssuer == null)
			{
				return false;
			}
			return watcherIssuer._0004() == v.Value;
		}

		bool ICollection<KeyValuePair<string, ParserFilterResolver>>.Contains(KeyValuePair<string, ParserFilterResolver> v)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(KeyValuePair<string, ParserFilterResolver>[] reference, int counter_Y)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference == null)
			{
				throw new ArgumentNullException("array");
			}
			if (counter_Y < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (counter_Y >= reference.Length && counter_Y != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (get_Count() > reference.Length - counter_Y)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (WatcherIssuer item in _StubIssuer)
			{
				reference[counter_Y + num] = new KeyValuePair<string, ParserFilterResolver>(item._0001(), item._0004());
				num++;
			}
		}

		void ICollection<KeyValuePair<string, ParserFilterResolver>>.CopyTo(KeyValuePair<string, ParserFilterResolver>[] reference, int counter_Y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(reference, counter_Y);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool ICollection<KeyValuePair<string, ParserFilterResolver>>.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0002(KeyValuePair<string, ParserFilterResolver> task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!((ICollection<KeyValuePair<string, ParserFilterResolver>>)this).Contains(task))
			{
				return false;
			}
			((IDictionary<string, ParserFilterResolver>)this).Remove(task.Key);
			return true;
		}

		bool ICollection<KeyValuePair<string, ParserFilterResolver>>.Remove(KeyValuePair<string, ParserFilterResolver> task)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new IEnumerator<KeyValuePair<string, ParserFilterResolver>> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new _0001(0)
			{
				_0003 = this
			};
		}

		IEnumerator<KeyValuePair<string, ParserFilterResolver>> IEnumerable<KeyValuePair<string, ParserFilterResolver>>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected new virtual void _0001(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_CodeIssuer?.Invoke(this, new PropertyChangedEventArgs(i));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0002(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			taskIssuer?.Invoke(this, new PropertyChangingEventArgs(instance));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new PropertyDescriptorCollection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((ICustomTypeDescriptor)this).GetProperties((Attribute[])null);
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PropertyDescriptorCollection _0001(Attribute[] key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyDescriptor[] array = new PropertyDescriptor[get_Count()];
			int num = 0;
			using (IEnumerator<KeyValuePair<string, ParserFilterResolver>> enumerator = this._0001())
			{
				while (enumerator.MoveNext())
				{
					array[num] = new FacadeIssuer(enumerator.Current.Key);
					num++;
				}
			}
			return new PropertyDescriptorCollection(array);
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new AttributeCollection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return AttributeCollection.Empty;
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		string ICustomTypeDescriptor.GetClassName()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new TypeConverter _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new TypeConverter();
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new EventDescriptor _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new PropertyDescriptor _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0001(Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		object ICustomTypeDescriptor.GetEditor(Type info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private EventDescriptorCollection _0001(Attribute[] var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return EventDescriptorCollection.Empty;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] var1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new EventDescriptorCollection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return EventDescriptorCollection.Empty;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object _0001(PropertyDescriptor instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance is FacadeIssuer)
			{
				return this;
			}
			return null;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor instance)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override DynamicMetaObject _0001(Expression def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new WorkerClientBridge<DecoratorReaderMapper>(def, this, new InvocationErrorFilter());
		}
	}
}
