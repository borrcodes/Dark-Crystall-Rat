using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Importers
{
	[global::_0008._0012(0)]
	internal abstract class ConfigurationIssuer : ParserFilterResolver, IEnumerable<ParserFilterResolver>, IList<ParserFilterResolver>, ICollection<ParserFilterResolver>, IList, ICollection, IEnumerable, ITypedList, IBindingList, INotifyCollectionChanged
	{
		[global::_0008._0012(2)]
		internal ListChangedEventHandler _CandidateIssuer;

		[global::_0008._0012(2)]
		internal AddingNewEventHandler tokenizerIssuer;

		[global::_0008._0012(2)]
		internal NotifyCollectionChangedEventHandler _PrinterIssuer;

		[global::_0008._0012(2)]
		private object mappingIssuer;

		private bool m_MockIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(ListChangedEventHandler item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_CandidateIssuer = (ListChangedEventHandler)Delegate.Combine(_CandidateIssuer, item);
		}

		void IBindingList.add_ListChanged(ListChangedEventHandler item)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(ListChangedEventHandler init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_CandidateIssuer = (ListChangedEventHandler)Delegate.Remove(_CandidateIssuer, init);
		}

		void IBindingList.remove_ListChanged(ListChangedEventHandler init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(NotifyCollectionChangedEventHandler task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_PrinterIssuer = (NotifyCollectionChangedEventHandler)Delegate.Combine(_PrinterIssuer, task);
		}

		void INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler task)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(NotifyCollectionChangedEventHandler key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_PrinterIssuer = (NotifyCollectionChangedEventHandler)Delegate.Remove(_PrinterIssuer, key);
		}

		void INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(key);
		}

		protected new abstract IList<ParserFilterResolver> _0001();

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ConfigurationIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ConfigurationIssuer(ConfigurationIssuer reference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector();
			ContextClientBridge.RunClient(reference, "other");
			int num = 0;
			foreach (ParserFilterResolver item in (IEnumerable<ParserFilterResolver>)reference)
			{
				ManageClass(num, item, ignoretag: false);
				num++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CustomizeClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_MockIssuer)
			{
				throw new InvalidOperationException("Cannot change {0} during a collection change event.".ListReader(CultureInfo.InvariantCulture, GetType()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(AddingNewEventArgs item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tokenizerIssuer?.Invoke(this, item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(ListChangedEventArgs param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ListChangedEventHandler candidateIssuer = _CandidateIssuer;
			if (candidateIssuer != null)
			{
				m_MockIssuer = true;
				try
				{
					candidateIssuer(this, param);
				}
				finally
				{
					m_MockIssuer = false;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(NotifyCollectionChangedEventArgs key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			NotifyCollectionChangedEventHandler printerIssuer = _PrinterIssuer;
			if (printerIssuer != null)
			{
				m_MockIssuer = true;
				try
				{
					printerIssuer(this, key);
				}
				finally
				{
					m_MockIssuer = false;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Count > 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ParserFilterResolver _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<ParserFilterResolver> list = this._0001();
			if (list.Count <= 0)
			{
				return null;
			}
			return list[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ParserFilterResolver _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<ParserFilterResolver> list = this._0001();
			int count = list.Count;
			if (count <= 0)
			{
				return null;
			}
			return list[count - 1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GDBD.Structs.PoolPropertyStruct<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new GDBD.Structs.PoolPropertyStruct<ParserFilterResolver>(this._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool QueryClass(object item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (item is IEnumerable && !(item is string) && !(item is ParserFilterResolver))
			{
				return !(item is byte[]);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ParserFilterResolver CancelClass(ParserFilterResolver first, bool removevis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first == null)
			{
				return PoolIssuer.VisitRequest();
			}
			if (removevis)
			{
				return first;
			}
			if (first._0001() != null || first == this || (first._0001() && base._0005() == first))
			{
				first = first._0001();
			}
			return first;
		}

		internal new abstract int _0001(ParserFilterResolver setup);

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(int version_instance, ParserFilterResolver cust, bool stripcomp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<ParserFilterResolver> list = this._0001();
			if (version_instance > list.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
			}
			CustomizeClass();
			cust = CancelClass(cust, stripcomp);
			ParserFilterResolver parserFilterResolver = (version_instance == 0) ? null : list[version_instance - 1];
			ParserFilterResolver parserFilterResolver2 = (version_instance == list.Count) ? null : list[version_instance];
			_0001(cust, null);
			cust._0001(this);
			cust._0005(parserFilterResolver);
			parserFilterResolver?._0004(cust);
			cust._0004(parserFilterResolver2);
			parserFilterResolver2?._0005(cust);
			list.Insert(version_instance, cust);
			if (_CandidateIssuer != null)
			{
				_0001(new ListChangedEventArgs(ListChangedType.ItemAdded, version_instance));
			}
			if (_PrinterIssuer != null)
			{
				_0001(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, cust, version_instance));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new virtual void _0001(int item_end)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<ParserFilterResolver> list = this._0001();
			if (item_end < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (item_end >= list.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			CustomizeClass();
			ParserFilterResolver parserFilterResolver = list[item_end];
			ParserFilterResolver parserFilterResolver2 = (item_end == 0) ? null : list[item_end - 1];
			ParserFilterResolver parserFilterResolver3 = (item_end == list.Count - 1) ? null : list[item_end + 1];
			parserFilterResolver2?._0004(parserFilterResolver3);
			parserFilterResolver3?._0005(parserFilterResolver2);
			parserFilterResolver._0001((ConfigurationIssuer)null);
			parserFilterResolver._0005(null);
			parserFilterResolver._0004(null);
			list.RemoveAt(item_end);
			if (_CandidateIssuer != null)
			{
				_0001(new ListChangedEventArgs(ListChangedType.ItemDeleted, item_end));
			}
			if (_PrinterIssuer != null)
			{
				_0001(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, parserFilterResolver, item_end));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new virtual bool _0001(ParserFilterResolver last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last != null)
			{
				int num = this._0001(last);
				if (num >= 0)
				{
					this._0001(num);
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new virtual ParserFilterResolver _0001(int lengthinit)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001()[lengthinit];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(int lastY, ParserFilterResolver cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<ParserFilterResolver> list = this._0001();
			if (lastY < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (lastY >= list.Count)
			{
				throw new ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			ParserFilterResolver parserFilterResolver = list[lastY];
			if (!ExcludeClass(parserFilterResolver, cust))
			{
				CustomizeClass();
				cust = CancelClass(cust, removevis: false);
				_0001(cust, parserFilterResolver);
				ParserFilterResolver parserFilterResolver2 = (lastY == 0) ? null : list[lastY - 1];
				ParserFilterResolver parserFilterResolver3 = (lastY == list.Count - 1) ? null : list[lastY + 1];
				cust._0001(this);
				cust._0005(parserFilterResolver2);
				parserFilterResolver2?._0004(cust);
				cust._0004(parserFilterResolver3);
				parserFilterResolver3?._0005(cust);
				list[lastY] = cust;
				parserFilterResolver._0001((ConfigurationIssuer)null);
				parserFilterResolver._0005(null);
				parserFilterResolver._0004(null);
				if (_CandidateIssuer != null)
				{
					_0001(new ListChangedEventArgs(ListChangedType.ItemChanged, lastY));
				}
				if (_PrinterIssuer != null)
				{
					_0001(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, cust, parserFilterResolver, lastY));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new virtual void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CustomizeClass();
			IList<ParserFilterResolver> list = this._0001();
			foreach (ParserFilterResolver item in list)
			{
				item._0001((ConfigurationIssuer)null);
				item._0005(null);
				item._0004(null);
			}
			list.Clear();
			if (_CandidateIssuer != null)
			{
				_0001(new ListChangedEventArgs(ListChangedType.Reset, -1));
			}
			if (_PrinterIssuer != null)
			{
				_0001(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0002(ParserFilterResolver last, ParserFilterResolver counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last != null && last._0001() == this)
			{
				int lastY = this._0001(last);
				_0001(lastY, counter);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new virtual bool _0002(ParserFilterResolver def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(def) != -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(Array task, int flagscaller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task == null)
			{
				throw new ArgumentNullException("array");
			}
			if (flagscaller < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (flagscaller >= task.Length && flagscaller != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (get_Count() > task.Length - flagscaller)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (ParserFilterResolver item in this._0001())
			{
				task.SetValue(item, flagscaller + num);
				num++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ExcludeClass(ParserFilterResolver instance, ParserFilterResolver caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PoolIssuer poolIssuer = instance as PoolIssuer;
			if (poolIssuer != null)
			{
				if (caller == null)
				{
					return ((ParserFilterResolver)poolIssuer)._0001() == Newtonsoft.Rules.UnicodeCategory.Null;
				}
				return poolIssuer.Equals(caller);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(ParserFilterResolver v, ParserFilterResolver pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(v, "o");
			if (v._0001() == Newtonsoft.Rules.UnicodeCategory.Property)
			{
				throw new ArgumentException("Can not add {0} to {1}.".SelectReader(CultureInfo.InvariantCulture, v.GetType(), GetType()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Add(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageClass(this._0001().Count, res, ignoretag: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetupClass(ParserFilterResolver v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageClass(this._0001().Count, v, ignoretag: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ManageClass(int flags_init, object cfg, bool ignoretag)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (QueryClass(cfg))
			{
				IEnumerable obj = (IEnumerable)cfg;
				int num = flags_init;
				foreach (object item in obj)
				{
					ManageClass(num, item, ignoretag);
					num++;
				}
			}
			else
			{
				ParserFilterResolver cust = InitClass(cfg);
				_0001(flags_init, cust, ignoretag);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ParserFilterResolver InitClass(object v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParserFilterResolver parserFilterResolver = v as ParserFilterResolver;
			if (parserFilterResolver != null)
			{
				return parserFilterResolver;
			}
			return new PoolIssuer(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefineClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CollectClass(TagTestItem asset, CodeIteratorMapping selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = asset._0003();
			if (!asset._0001())
			{
				throw ContextError.CheckComposer(asset, "Error reading {0} from JsonReader.".ListReader(CultureInfo.InvariantCulture, GetType().Name));
			}
			SortClass(asset, selection);
			if (asset._0003() > num)
			{
				throw ContextError.CheckComposer(asset, "Unexpected end of content while loading {0}.".ListReader(CultureInfo.InvariantCulture, GetType().Name));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SortClass(TagTestItem setup, CodeIteratorMapping cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(setup, "r");
			IdentifierClientBridge identifierClientBridge = setup as IdentifierClientBridge;
			ConfigurationIssuer configurationIssuer = this;
			do
			{
				WatcherIssuer watcherIssuer = configurationIssuer as WatcherIssuer;
				if (watcherIssuer != null && watcherIssuer._0004() != null)
				{
					if (configurationIssuer == this)
					{
						break;
					}
					configurationIssuer = ((ParserFilterResolver)configurationIssuer)._0001();
				}
				switch (setup._0001())
				{
				case WatcherComposer.StartArray:
				{
					InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
					instanceClassDispatcher.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(instanceClassDispatcher);
					configurationIssuer = instanceClassDispatcher;
					break;
				}
				case WatcherComposer.EndArray:
					if (configurationIssuer == this)
					{
						return;
					}
					configurationIssuer = ((ParserFilterResolver)configurationIssuer)._0001();
					break;
				case WatcherComposer.StartObject:
				{
					DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper();
					decoratorReaderMapper.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(decoratorReaderMapper);
					configurationIssuer = decoratorReaderMapper;
					break;
				}
				case WatcherComposer.EndObject:
					if (configurationIssuer == this)
					{
						return;
					}
					configurationIssuer = ((ParserFilterResolver)configurationIssuer)._0001();
					break;
				case WatcherComposer.StartConstructor:
				{
					IndexerReaderMapper indexerReaderMapper = new IndexerReaderMapper(setup._0001().ToString());
					indexerReaderMapper.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(indexerReaderMapper);
					configurationIssuer = indexerReaderMapper;
					break;
				}
				case WatcherComposer.EndConstructor:
					if (configurationIssuer == this)
					{
						return;
					}
					configurationIssuer = ((ParserFilterResolver)configurationIssuer)._0001();
					break;
				case WatcherComposer.Integer:
				case WatcherComposer.Float:
				case WatcherComposer.String:
				case WatcherComposer.Boolean:
				case WatcherComposer.Date:
				case WatcherComposer.Bytes:
				{
					PoolIssuer poolIssuer = new PoolIssuer(setup._0001());
					poolIssuer.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(poolIssuer);
					break;
				}
				case WatcherComposer.Comment:
					if (cust != null && cust._0001() == (XlOLEVerb)1)
					{
						PoolIssuer poolIssuer = PoolIssuer.LogoutRequest(setup._0001().ToString());
						poolIssuer.TestClass(identifierClientBridge, cust);
						configurationIssuer.Add(poolIssuer);
					}
					break;
				case WatcherComposer.Null:
				{
					PoolIssuer poolIssuer = PoolIssuer.VisitRequest();
					poolIssuer.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(poolIssuer);
					break;
				}
				case WatcherComposer.Undefined:
				{
					PoolIssuer poolIssuer = PoolIssuer.ViewRequest();
					poolIssuer.TestClass(identifierClientBridge, cust);
					configurationIssuer.Add(poolIssuer);
					break;
				}
				case WatcherComposer.PropertyName:
				{
					WatcherIssuer watcherIssuer2 = CallClass(setup, cust, identifierClientBridge, configurationIssuer);
					if (watcherIssuer2 != null)
					{
						configurationIssuer = watcherIssuer2;
					}
					else
					{
						setup.AssetError();
					}
					break;
				}
				default:
					throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".ListReader(CultureInfo.InvariantCulture, setup._0001()));
				case WatcherComposer.None:
					break;
				}
			}
			while (setup._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static WatcherIssuer CallClass(TagTestItem first, CodeIteratorMapping reg, IdentifierClientBridge util, ConfigurationIssuer col2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ColorMatrixFlag colorMatrixFlag = reg?._0001() ?? ((ColorMatrixFlag)0);
			DecoratorReaderMapper obj = (DecoratorReaderMapper)col2;
			string text = first._0001().ToString();
			WatcherIssuer watcherIssuer = obj.DisableRequest(text, StringComparison.Ordinal);
			if (watcherIssuer != null)
			{
				switch (colorMatrixFlag)
				{
				case (ColorMatrixFlag)1:
					return null;
				case (ColorMatrixFlag)2:
					throw ContextError.CheckComposer(first, "Property with the name '{0}' already exists in the current JSON object.".ListReader(CultureInfo.InvariantCulture, text));
				}
			}
			WatcherIssuer watcherIssuer2 = new WatcherIssuer(text);
			watcherIssuer2.TestClass(util, reg);
			if (watcherIssuer == null)
			{
				col2.Add(watcherIssuer2);
			}
			else
			{
				watcherIssuer.DestroyClass(watcherIssuer2);
			}
			return watcherIssuer2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string _0001(PropertyDescriptor[] v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return string.Empty;
		}

		string ITypedList.GetListName(PropertyDescriptor[] v)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PropertyDescriptorCollection _0001(PropertyDescriptor[] spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (((ParserFilterResolver)this)._0002() as ICustomTypeDescriptor)?.GetProperties();
		}

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0003(ParserFilterResolver init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(init);
		}

		int IList<ParserFilterResolver>.IndexOf(ParserFilterResolver init)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0004(int def, ParserFilterResolver second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(def, second, stripcomp: false);
		}

		void IList<ParserFilterResolver>.Insert(int def, ParserFilterResolver second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0004(def, second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0003(int next_param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001(next_param);
		}

		void IList<ParserFilterResolver>.RemoveAt(int next_param)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0003(next_param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParserFilterResolver _0003(int asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(asset);
		}

		ParserFilterResolver IList<ParserFilterResolver>.get_Item(int asset)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0005(int item_length, ParserFilterResolver second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(item_length, second);
		}

		void IList<ParserFilterResolver>.set_Item(int item_length, ParserFilterResolver second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0005(item_length, second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new void _0002(ParserFilterResolver item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Add(item);
		}

		void ICollection<ParserFilterResolver>.Add(ParserFilterResolver item)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new void _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001();
		}

		void ICollection<ParserFilterResolver>.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0005();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new bool _0005(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0002(spec);
		}

		bool ICollection<ParserFilterResolver>.Contains(ParserFilterResolver spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0005(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(ParserFilterResolver[] instance, int version_cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(instance, version_cfg);
		}

		void ICollection<ParserFilterResolver>.CopyTo(ParserFilterResolver[] instance, int version_cfg)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(instance, version_cfg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool ICollection<ParserFilterResolver>.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0006(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(spec);
		}

		bool ICollection<ParserFilterResolver>.Remove(ParserFilterResolver spec)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0006(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParserFilterResolver PublishClass(object task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task == null)
			{
				return null;
			}
			ParserFilterResolver parserFilterResolver = task as ParserFilterResolver;
			if (parserFilterResolver != null)
			{
				return parserFilterResolver;
			}
			throw new ArgumentException("Argument is not a JToken.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(object key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Add(PublishClass(key));
			return get_Count() - 1;
		}

		int IList.Add(object key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new void _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001();
		}

		void IList.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0006();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0002(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0002(PublishClass(res));
		}

		bool IList.Contains(object res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0002(object info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(PublishClass(info));
		}

		int IList.IndexOf(object info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(int iPtr, object visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(iPtr, PublishClass(visitor), stripcomp: false);
		}

		void IList.Insert(int iPtr, object visitor)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(iPtr, visitor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new bool _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool IList.get_IsFixedSize()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0005();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new bool _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool IList.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0006();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(object info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001(PublishClass(info));
		}

		void IList.Remove(object info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0004(int offsetkey)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001(offsetkey);
		}

		void IList.RemoveAt(int offsetkey)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0004(offsetkey);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new object _0001(int spec_offset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001(spec_offset);
		}

		object IList.get_Item(int spec_offset)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(spec_offset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(int sumfirst, object counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(sumfirst, PublishClass(counter));
		}

		void IList.set_Item(int sumfirst, object counter)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(sumfirst, counter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(Array init, int cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(init, cust);
		}

		void ICollection.CopyTo(Array init, int cust)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(init, cust);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int get_Count()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new bool _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool ICollection.get_IsSynchronized()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0007();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (mappingIssuer == null)
			{
				Interlocked.CompareExchange(ref mappingIssuer, new object(), null);
			}
			return mappingIssuer;
		}

		object ICollection.get_SyncRoot()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(PropertyDescriptor last)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		void IBindingList.AddIndex(PropertyDescriptor last)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new object _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
			_0001(addingNewEventArgs);
			if (addingNewEventArgs.NewObject == null)
			{
				throw new ListenerTestItem("Could not determine new value to add to '{0}'.".ListReader(CultureInfo.InvariantCulture, GetType()));
			}
			ParserFilterResolver parserFilterResolver = addingNewEventArgs.NewObject as ParserFilterResolver;
			if (parserFilterResolver == null)
			{
				throw new ListenerTestItem("New item to be added to collection must be compatible with {0}.".ListReader(CultureInfo.InvariantCulture, typeof(ParserFilterResolver)));
			}
			Add(parserFilterResolver);
			return parserFilterResolver;
		}

		object IBindingList.AddNew()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		bool IBindingList.get_AllowEdit()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0008();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		bool IBindingList.get_AllowNew()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._000E();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _000F()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		bool IBindingList.get_AllowRemove()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0001(PropertyDescriptor item, ListSortDirection vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotSupportedException();
		}

		void IBindingList.ApplySort(PropertyDescriptor item, ListSortDirection vis)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(item, vis);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(PropertyDescriptor i, object selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotSupportedException();
		}

		int IBindingList.Find(PropertyDescriptor i, object selection)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(i, selection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0010()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool IBindingList.get_IsSorted()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0010();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0002(PropertyDescriptor setup)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		void IBindingList.RemoveIndex(PropertyDescriptor setup)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new void _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotSupportedException();
		}

		void IBindingList.RemoveSort()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0007();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new ListSortDirection _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ListSortDirection.Ascending;
		}

		ListSortDirection IBindingList.get_SortDirection()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new PropertyDescriptor _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		PropertyDescriptor IBindingList.get_SortProperty()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0011()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		bool IBindingList.get_SupportsChangeNotification()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0012()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool IBindingList.get_SupportsSearching()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0012();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0013()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool IBindingList.get_SupportsSorting()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0013();
		}
	}
}
