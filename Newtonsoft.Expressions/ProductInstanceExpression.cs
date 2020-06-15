using _0008;
using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	[_0008._0012(0)]
	public sealed class ProductInstanceExpression
	{
		internal SpecificationTestItem? contextProperty;

		internal bool m_ParamProperty;

		private object publisherProperty;

		private bool utilsProperty;

		private string _StrategyProperty;

		internal bool _InfoProperty;

		private Type m_ValueProperty;

		[CompilerGenerated]
		private ProcTest _ParameterProperty;

		[CompilerGenerated]
		private Type m_PrototypeProperty;

		[CompilerGenerated]
		private int? parserProperty;

		[CompilerGenerated]
		private string _StatusProperty;

		[CompilerGenerated]
		private RoleTestItem pageProperty;

		[CompilerGenerated]
		private AccountEventEntry helperProperty;

		[CompilerGenerated]
		private BroadcasterError exceptionProperty;

		[CompilerGenerated]
		private bool attributeProperty;

		[CompilerGenerated]
		private bool m_DatabaseProperty;

		[CompilerGenerated]
		private bool m_FactoryProperty;

		[CompilerGenerated]
		private bool _SerializerProperty;

		[CompilerGenerated]
		private bool? callbackProperty;

		[CompilerGenerated]
		private ApplicationState? m_MerchantProperty;

		[CompilerGenerated]
		private ConnectActionCursor? m_ListenerProperty;

		[CompilerGenerated]
		private FacadeComposer? m_TagProperty;

		[CompilerGenerated]
		private PageDicCandidate? _SpecificationProperty;

		[CompilerGenerated]
		private SparklineAxisMinMaxValues? m_WriterProperty;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private Predicate<object> _RoleProperty;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private Predicate<object> m_CreatorProperty;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private Predicate<object> _RuleProperty;

		[_0008._0012(new byte[]
		{
			2,
			1,
			2
		})]
		[CompilerGenerated]
		private Action<object, object> bridgeProperty;

		[CompilerGenerated]
		private BroadcasterError importerProperty;

		[CompilerGenerated]
		private bool? _ReponseProperty;

		[CompilerGenerated]
		private SparklineAxisMinMaxValues? indexerProperty;

		[CompilerGenerated]
		private FacadeComposer? decoratorProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal ProcTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ParameterProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0001(ProcTest first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ParameterProperty = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StrategyProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_StrategyProperty = i;
			_InfoProperty = !RegistryBroadcasterFilter.DestroyIssuer(_StrategyProperty, RegistryBroadcasterFilter._ProducerTest);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PrototypeProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_PrototypeProperty = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return parserProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(int? task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			parserProperty = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StatusProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(string config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_StatusProperty = config;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public RoleTestItem _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return pageProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(RoleTestItem item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			pageProperty = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(AccountEventEntry param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			helperProperty = param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Type _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ValueProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(Type instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ValueProperty != instance)
			{
				m_ValueProperty = instance;
				utilsProperty = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public BroadcasterError _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return exceptionProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(BroadcasterError setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			exceptionProperty = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return attributeProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool movetask)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			attributeProperty = movetask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_DatabaseProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool isres)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_DatabaseProperty = isres;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_FactoryProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0003(bool islast)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_FactoryProperty = islast;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SerializerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0004(bool writevar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_SerializerProperty = writevar1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!m_ParamProperty)
			{
				return null;
			}
			return publisherProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(object task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ParamProperty = true;
			publisherProperty = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object InitClient()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ValueProperty == null)
			{
				return null;
			}
			if (!m_ParamProperty && !utilsProperty)
			{
				publisherProperty = ResolverErrorFilter.ReflectReader(m_ValueProperty);
				utilsProperty = true;
			}
			return publisherProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpecificationTestItem _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return contextProperty.GetValueOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return callbackProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool? setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			callbackProperty = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ApplicationState? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_MerchantProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ApplicationState? last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MerchantProperty = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ConnectActionCursor? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ListenerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ConnectActionCursor? task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ListenerProperty = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public FacadeComposer? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TagProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(FacadeComposer? res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_TagProperty = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public PageDicCandidate? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SpecificationProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(PageDicCandidate? task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_SpecificationProperty = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public SparklineAxisMinMaxValues? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_WriterProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(SparklineAxisMinMaxValues? spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_WriterProperty = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Predicate<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RoleProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Predicate<object> value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RoleProperty = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Predicate<object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_CreatorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Predicate<object> _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RuleProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(Predicate<object> param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RuleProperty = param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Action<object, object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return bridgeProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Action<object, object> key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bridgeProperty = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001() ?? string.Empty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public BroadcasterError _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(BroadcasterError config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			importerProperty = config;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool? _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool? value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ReponseProperty = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public SparklineAxisMinMaxValues? _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return indexerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(SparklineAxisMinMaxValues? asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			indexerProperty = asset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public FacadeComposer? _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return decoratorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(FacadeComposer? i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			decoratorProperty = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DefineClient(RecordClassDispatcher res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = this._0001();
			if (_InfoProperty)
			{
				res._0001(text, injectcust: false);
			}
			else
			{
				res._0002(text);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProductInstanceExpression()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
