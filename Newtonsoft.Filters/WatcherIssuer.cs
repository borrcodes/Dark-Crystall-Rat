using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	public sealed class WatcherIssuer : ConfigurationIssuer
	{
		[_0008._0012(0)]
		private sealed class PublisherClientBridge : IEnumerable<ParserFilterResolver>, IList<ParserFilterResolver>, ICollection<ParserFilterResolver>, IEnumerable
		{
			[_0008._0012(2)]
			internal ParserFilterResolver m_ServerIssuer;

			public ParserFilterResolver this[int indexOf_instance]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					if (indexOf_instance != 0)
					{
						throw new IndexOutOfRangeException();
					}
					return m_ServerIssuer;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					if (setup != 0)
					{
						throw new IndexOutOfRangeException();
					}
					m_ServerIssuer = value;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public IEnumerator<ParserFilterResolver> _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return new _0001(0)
				{
					_0003 = this
				};
			}

			IEnumerator<ParserFilterResolver> IEnumerable<ParserFilterResolver>.GetEnumerator()
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
			public void Add(ParserFilterResolver first)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				m_ServerIssuer = first;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				m_ServerIssuer = null;
			}

			void ICollection<ParserFilterResolver>.Clear()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool _0001(ParserFilterResolver first)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return m_ServerIssuer == first;
			}

			bool ICollection<ParserFilterResolver>.Contains(ParserFilterResolver first)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001(first);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001(ParserFilterResolver[] setup, int visitor_end)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_ServerIssuer != null)
				{
					setup[visitor_end] = m_ServerIssuer;
				}
			}

			void ICollection<ParserFilterResolver>.CopyTo(ParserFilterResolver[] setup, int visitor_end)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001(setup, visitor_end);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool _0002(ParserFilterResolver def)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_ServerIssuer == def)
				{
					m_ServerIssuer = null;
					return true;
				}
				return false;
			}

			bool ICollection<ParserFilterResolver>.Remove(ParserFilterResolver def)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0002(def);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_ServerIssuer == null)
				{
					return 0;
				}
				return 1;
			}

			int ICollection<ParserFilterResolver>.get_Count()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return false;
			}

			bool ICollection<ParserFilterResolver>.get_IsReadOnly()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0001(ParserFilterResolver info)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_ServerIssuer != info)
				{
					return -1;
				}
				return 0;
			}

			int IList<ParserFilterResolver>.IndexOf(ParserFilterResolver info)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001(info);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001(int end_ident, ParserFilterResolver pred)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (end_ident == 0)
				{
					m_ServerIssuer = pred;
				}
			}

			void IList<ParserFilterResolver>.Insert(int end_ident, ParserFilterResolver pred)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001(end_ident, pred);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001(int rescounter)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (rescounter == 0)
				{
					m_ServerIssuer = null;
				}
			}

			void IList<ParserFilterResolver>.RemoveAt(int rescounter)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				this._0001(rescounter);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PublisherClientBridge()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		private readonly PublisherClientBridge collectionIssuer;

		private readonly string m_RepositoryIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IList<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return collectionIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RepositoryIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParserFilterResolver _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return collectionIssuer.m_ServerIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003(ParserFilterResolver param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CustomizeClass();
			ParserFilterResolver cust = param ?? PoolIssuer.VisitRequest();
			if (collectionIssuer.m_ServerIssuer == null)
			{
				_0001(0, cust, isconsumer: false);
			}
			else
			{
				_0001(0, cust);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WatcherIssuer(WatcherIssuer reference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			collectionIssuer = new PublisherClientBridge();
			base._002Ector(reference);
			m_RepositoryIssuer = reference._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001(int ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			return _0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(int endvalue, ParserFilterResolver pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (endvalue != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (!ConfigurationIssuer.ExcludeClass(_0004(), pol))
			{
				((DecoratorReaderMapper)base._0001())?.LoginRequest(this);
				base._0001(0, pol);
				((DecoratorReaderMapper)base._0001())?.RevertClass(this);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool _0001(ParserFilterResolver item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new ListenerTestItem("Cannot add or remove items from {0}.".ListReader(CultureInfo.InvariantCulture, typeof(WatcherIssuer)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(int instance_size)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new ListenerTestItem("Cannot add or remove items from {0}.".ListReader(CultureInfo.InvariantCulture, typeof(WatcherIssuer)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int _0001(ParserFilterResolver init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return -1;
			}
			return collectionIssuer._0001(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(int def, ParserFilterResolver attr, bool isconsumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr == null || attr._0001() != Newtonsoft.Rules.UnicodeCategory.Comment)
			{
				if (_0004() != null)
				{
					throw new ListenerTestItem("{0} cannot have multiple values.".ListReader(CultureInfo.InvariantCulture, typeof(WatcherIssuer)));
				}
				base._0001(0, attr, stripcomp: false);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool _0002(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0004() == spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new ListenerTestItem("Cannot add or remove items from {0}.".ListReader(CultureInfo.InvariantCulture, typeof(WatcherIssuer)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new WatcherIssuer(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.UnicodeCategory _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Newtonsoft.Rules.UnicodeCategory.Property;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WatcherIssuer(string first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			collectionIssuer = new PublisherClientBridge();
			base._002Ector();
			ContextClientBridge.RunClient(first, "name");
			m_RepositoryIssuer = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WatcherIssuer(string init, object ord)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			collectionIssuer = new PublisherClientBridge();
			base._002Ector();
			ContextClientBridge.RunClient(init, "name");
			m_RepositoryIssuer = init;
			_0003(QueryClass(ord) ? new InstanceClassDispatcher(ord) : ConfigurationIssuer.InitClass(ord));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher v, BroadcasterError[] counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			v._0002(m_RepositoryIssuer);
			ParserFilterResolver parserFilterResolver = _0004();
			if (parserFilterResolver != null)
			{
				parserFilterResolver._0001(v, counter);
			}
			else
			{
				v._0008();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static WatcherIssuer OrderRequest(TagTestItem info, CodeIteratorMapping selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info._0001() == WatcherComposer.None && !info._0001())
			{
				throw ContextError.CheckComposer(info, "Error reading JProperty from JsonReader.");
			}
			info.RevertError();
			if (info._0001() != WatcherComposer.PropertyName)
			{
				throw ContextError.CheckComposer(info, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".ListReader(CultureInfo.InvariantCulture, info._0001()));
			}
			WatcherIssuer watcherIssuer = new WatcherIssuer((string)info._0001());
			watcherIssuer.TestClass(info as IdentifierClientBridge, selection);
			watcherIssuer.CollectClass(info, selection);
			return watcherIssuer;
		}
	}
}
