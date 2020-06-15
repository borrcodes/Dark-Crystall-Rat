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
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Mappers
{
	[_0008._0012(0)]
	internal sealed class IndexerReaderMapper : ConfigurationIssuer
	{
		[_0008._0012(2)]
		private string m_ObserverIssuer;

		private readonly List<ParserFilterResolver> m_DescriptorIssuer;

		[_0008._0012(2)]
		public override ParserFilterResolver this[object def]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(def, "key");
				if (def is int)
				{
					int lengthinit = (int)def;
					return ((ConfigurationIssuer)this)._0001(lengthinit);
				}
				throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(def)));
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ContextClientBridge.RunClient(v, "key");
				if (v is int)
				{
					int lastY = (int)v;
					_0001(lastY, value);
					return;
				}
				throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".ListReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(v)));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IList<ParserFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_DescriptorIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int _0001(ParserFilterResolver param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param == null)
			{
				return -1;
			}
			return m_DescriptorIssuer.SortTest(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ObserverIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.UnicodeCategory _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Newtonsoft.Rules.UnicodeCategory.Constructor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerReaderMapper()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_DescriptorIssuer = new List<ParserFilterResolver>();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerReaderMapper(IndexerReaderMapper setup)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_DescriptorIssuer = new List<ParserFilterResolver>();
			base._002Ector(setup);
			m_ObserverIssuer = setup._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerReaderMapper(string spec)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_DescriptorIssuer = new List<ParserFilterResolver>();
			base._002Ector();
			if (spec == null)
			{
				throw new ArgumentNullException("name");
			}
			if (spec.Length == 0)
			{
				throw new ArgumentException("Constructor name cannot be empty.", "name");
			}
			m_ObserverIssuer = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new IndexerReaderMapper(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher setup, BroadcasterError[] b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			setup._0001(m_ObserverIssuer);
			int count = m_DescriptorIssuer.Count;
			for (int i = 0; i < count; i++)
			{
				m_DescriptorIssuer[i]._0001(setup, b);
			}
			setup._0010();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IndexerReaderMapper WriteClass(TagTestItem setup, CodeIteratorMapping reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup._0001() == WatcherComposer.None && !setup._0001())
			{
				throw ContextError.CheckComposer(setup, "Error reading JConstructor from JsonReader.");
			}
			setup.RevertError();
			if (setup._0001() != WatcherComposer.StartConstructor)
			{
				throw ContextError.CheckComposer(setup, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".ListReader(CultureInfo.InvariantCulture, setup._0001()));
			}
			IndexerReaderMapper indexerReaderMapper = new IndexerReaderMapper((string)setup._0001());
			indexerReaderMapper.TestClass(setup as IdentifierClientBridge, reg);
			indexerReaderMapper.CollectClass(setup, reg);
			return indexerReaderMapper;
		}
	}
}
