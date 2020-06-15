using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Dispatcher
{
	[_0008._0012(0)]
	internal sealed class InstanceClassDispatcher : ConfigurationIssuer, IEnumerable<ParserFilterResolver>, IList<ParserFilterResolver>, ICollection<ParserFilterResolver>, IEnumerable
	{
		private readonly List<ParserFilterResolver> attrIssuer;

		[_0008._0012(2)]
		public override ParserFilterResolver this[object item]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(item, "key");
				if (!(item is int))
				{
					throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Int32 array index expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(item)));
				}
				return ((ConfigurationIssuer)this)._0001((int)item);
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(def, "key");
				if (!(def is int))
				{
					throw new ArgumentException("Set JArray values with invalid key value: {0}. Int32 array index expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(def)));
				}
				_0001((int)def, value);
			}
		}

		public ParserFilterResolver this[int length_def]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return ((ConfigurationIssuer)this)._0001(length_def);
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_0001(insert_CONFIGAt, value);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IList<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return attrIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.UnicodeCategory _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Newtonsoft.Rules.UnicodeCategory.Array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstanceClassDispatcher()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			attrIssuer = new List<ParserFilterResolver>();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstanceClassDispatcher(InstanceClassDispatcher instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			attrIssuer = new List<ParserFilterResolver>();
			base._002Ector(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstanceClassDispatcher(object ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			attrIssuer = new List<ParserFilterResolver>();
			base._002Ector();
			Add(ident);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new InstanceClassDispatcher(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static InstanceClassDispatcher AssetClass(TagTestItem item, CodeIteratorMapping ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (item._0001() == WatcherComposer.None && !item._0001())
			{
				throw ContextError.CheckComposer(item, "Error reading JArray from JsonReader.");
			}
			item.RevertError();
			if (item._0001() != WatcherComposer.StartArray)
			{
				throw ContextError.CheckComposer(item, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".ListReader(CultureInfo.InvariantCulture, item._0001()));
			}
			InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
			instanceClassDispatcher.TestClass(item as IdentifierClientBridge, ivk);
			instanceClassDispatcher.CollectClass(item, ivk);
			return instanceClassDispatcher;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher param, BroadcasterError[] token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			param._0003();
			for (int i = 0; i < attrIssuer.Count; i++)
			{
				attrIssuer[i]._0001(param, token);
			}
			param._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int _0001(ParserFilterResolver asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (asset == null)
			{
				return -1;
			}
			return attrIssuer.SortTest(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new int _0002(ParserFilterResolver reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((ConfigurationIssuer)this)._0001(reference);
		}

		int IList<ParserFilterResolver>.IndexOf(ParserFilterResolver reference)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0002(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003(int config, ParserFilterResolver caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(config, caller, stripcomp: false);
		}

		void IList<ParserFilterResolver>.Insert(int config, ParserFilterResolver caller)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0003(config, caller);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(int maxvalue)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((ConfigurationIssuer)this)._0001(maxvalue);
		}

		void IList<ParserFilterResolver>.RemoveAt(int maxvalue)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002(maxvalue);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new IEnumerator<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((ParserFilterResolver)this)._0001()._0001();
		}

		IEnumerator<ParserFilterResolver> IEnumerable<ParserFilterResolver>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(ParserFilterResolver asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Add((object)asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((ConfigurationIssuer)this)._0001();
		}

		void ICollection<ParserFilterResolver>.Clear()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0003(ParserFilterResolver info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((ConfigurationIssuer)this)._0002(info);
		}

		bool ICollection<ParserFilterResolver>.Contains(ParserFilterResolver info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(ParserFilterResolver[] res, int reg_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001((Array)res, reg_start);
		}

		void ICollection<ParserFilterResolver>.CopyTo(ParserFilterResolver[] res, int reg_start)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001(res, reg_start);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		bool ICollection<ParserFilterResolver>.get_IsReadOnly()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0004(ParserFilterResolver key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((ConfigurationIssuer)this)._0001(key);
		}

		bool ICollection<ParserFilterResolver>.Remove(ParserFilterResolver key)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0004(key);
		}
	}
}
