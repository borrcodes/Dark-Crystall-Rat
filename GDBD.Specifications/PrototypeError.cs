using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace GDBD.Specifications
{
	[_0008._0012(0)]
	internal class PrototypeError
	{
		internal SparklineAxisMinMaxValues m_ParserError;

		internal RollbackTransactionGrbit _StatusError;

		internal TaskListAnnotation m_PageError;

		internal FacadeComposer helperError;

		internal InternalArrayTypeE _ExceptionError;

		internal PageDicCandidate _AttributeError;

		internal ApplicationState m_DatabaseError;

		internal ConnectActionCursor _FactoryError;

		internal AttributeStyle _SerializerError;

		internal CacheActions _CallbackError;

		[_0008._0012(2)]
		internal GetterClientBridge _MerchantError;

		internal BridgeTest listenerError;

		[_0008._0012(2)]
		internal ModelTest tagError;

		[_0008._0012(2)]
		internal IEqualityComparer m_SpecificationError;

		internal UtilsRequestStrategy writerError;

		internal StreamingContext roleError;

		[_0008._0012(2)]
		private ListEventConsumer _CreatorError;

		private TimeState? _RuleError;

		private FindDirection? m_BridgeError;

		private PsMaxLengths? importerError;

		private StubListAnnotation? _ReponseError;

		private ApplicationPartitionType? m_IndexerError;

		private SudsUse? _DecoratorError;

		private GraphGroupStyle? _FieldError;

		private CultureInfo m_ItemError;

		private int? _RegError;

		private bool processError;

		private bool? _BaseError;

		[_0008._0012(2)]
		private string containerError;

		private bool proccesorError;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private EventHandler<FilterClassDispatcher> _AdapterError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public virtual void _0001(EventHandler<FilterClassDispatcher> value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			EventHandler<FilterClassDispatcher> eventHandler = _AdapterError;
			EventHandler<FilterClassDispatcher> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FilterClassDispatcher> value2 = (EventHandler<FilterClassDispatcher>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref _AdapterError, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(ListEventConsumer i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i == null)
			{
				throw new ArgumentNullException("value", "Reference resolver cannot be null.");
			}
			_CreatorError = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(UtilsRequestStrategy setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup == null)
			{
				throw new ArgumentNullException("value", "Serialization binder cannot be null.");
			}
			writerError = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ModelTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return tagError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(ModelTest asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tagError = asset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(IEqualityComparer asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_SpecificationError = asset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(SparklineAxisMinMaxValues task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task < (SparklineAxisMinMaxValues)0 || task > (SparklineAxisMinMaxValues)4)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_ParserError = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(RollbackTransactionGrbit ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident < (RollbackTransactionGrbit)0 || ident > (RollbackTransactionGrbit)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_StatusError = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(TaskListAnnotation task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task < (TaskListAnnotation)0 || task > (TaskListAnnotation)3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_PageError = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(FacadeComposer param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param < (FacadeComposer)0 || param > (FacadeComposer)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			helperError = param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(InternalArrayTypeE instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance < (InternalArrayTypeE)0 || instance > (InternalArrayTypeE)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_ExceptionError = instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ApplicationState _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_DatabaseError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(ApplicationState reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference < (ApplicationState)0 || reference > (ApplicationState)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_DatabaseError = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(ConnectActionCursor first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first < (ConnectActionCursor)0 || first > (ConnectActionCursor)3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_FactoryError = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(PageDicCandidate ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident < (PageDicCandidate)0 || ident > (PageDicCandidate)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_AttributeError = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(AttributeStyle v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v < (AttributeStyle)0 || v > (AttributeStyle)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_SerializerError = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual CacheActions _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _CallbackError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(CacheActions reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference < (CacheActions)0 || reference > (CacheActions)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_CallbackError = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GetterClientBridge _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_MerchantError == null)
			{
				_MerchantError = new GetterClientBridge();
			}
			return _MerchantError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual BridgeTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return listenerError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(BridgeTest item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			listenerError = (item ?? PublisherRequestStrategy._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual StreamingContext _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return roleError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(StreamingContext last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			roleError = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _BaseError.GetValueOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrototypeError()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			helperError = (FacadeComposer)0;
			_ExceptionError = (InternalArrayTypeE)0;
			m_DatabaseError = (ApplicationState)0;
			_FactoryError = (ConnectActionCursor)0;
			_AttributeError = (PageDicCandidate)0;
			m_PageError = (TaskListAnnotation)0;
			_SerializerError = (AttributeStyle)0;
			m_ParserError = (SparklineAxisMinMaxValues)0;
			_CallbackError = (CacheActions)0;
			roleError = CodeListAnnotation.m_TokenError;
			writerError = IndexerTest.m_DecoratorTest;
			m_ItemError = CodeListAnnotation.m_DispatcherError;
			listenerError = PublisherRequestStrategy._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PrototypeError OrderComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new PrototypeError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PrototypeError ResolveComposer(CodeListAnnotation config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PrototypeError prototypeError = OrderComposer();
			if (config != null)
			{
				RunComposer(prototypeError, config);
			}
			return prototypeError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PrototypeError FillComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolveComposer(ProcConsumer._0001()?.Invoke());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RunComposer(PrototypeError last, CodeListAnnotation cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ObserverIteratorMapping.CancelTest(cfg._0001()))
			{
				for (int i = 0; i < cfg._0001().Count; i++)
				{
					last._0001().Insert(i, cfg._0001()[i]);
				}
			}
			if (cfg.m_ConsumerError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.m_ComparatorError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.templateError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.configError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.schemaError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.objectError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.initializerError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.connectionError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.m_ExpressionError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.threadError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.m_RefError.HasValue)
			{
				last._0001(cfg._0001());
			}
			if (cfg.m_ExporterError.HasValue)
			{
				last._BaseError = cfg.m_ExporterError;
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001());
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001());
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001()());
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001());
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001());
			}
			if (cfg._0001() != null)
			{
				last._0001(cfg._0001());
			}
			if (cfg.accountError.HasValue)
			{
				last._RuleError = cfg.accountError;
			}
			if (cfg.m_SingletonError.HasValue)
			{
				last.m_BridgeError = cfg.m_SingletonError;
			}
			if (cfg._ModelError.HasValue)
			{
				last.importerError = cfg._ModelError;
			}
			if (cfg._MessageError.HasValue)
			{
				last._ReponseError = cfg._MessageError;
			}
			if (cfg._ParamsError)
			{
				last.containerError = cfg.m_WrapperError;
				last.proccesorError = cfg._ParamsError;
			}
			if (cfg.productError.HasValue)
			{
				last.m_IndexerError = cfg.productError;
			}
			if (cfg.m_InterceptorError.HasValue)
			{
				last._DecoratorError = cfg.m_InterceptorError;
			}
			if (cfg.m_AlgoError.HasValue)
			{
				last._FieldError = cfg.m_AlgoError;
			}
			if (cfg._AnnotationError != null)
			{
				last.m_ItemError = cfg._AnnotationError;
			}
			if (cfg._GlobalError)
			{
				last._RegError = cfg._VisitorError;
				last.processError = cfg._GlobalError;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T CompareComposer<[_0008._0012(2)] T>(TagTestItem ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (T)AddComposer(ident, typeof(T));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object AddComposer(TagTestItem asset, Type selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001(asset, selection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual object _0001(TagTestItem setup, Type vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(setup, "reader");
			EnableComposer(setup, out CultureInfo selection, out PsMaxLengths? serv, out StubListAnnotation? visitor, out SudsUse? ident, out int? pred, out string attr);
			ObjectIssuerImporter objectIssuerImporter = (this._0001() != null && this._0001()._0001() >= TraceLevel.Verbose) ? CreateComposer(setup) : null;
			object result = new BroadcasterInstanceRule(this).PatchBroadcaster(objectIssuerImporter ?? setup, vis, this._0001());
			if (objectIssuerImporter != null)
			{
				this._0001()._0001(TraceLevel.Verbose, objectIssuerImporter.CalcClass(), null);
			}
			MapComposer(setup, selection, serv, visitor, ident, pred, attr);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnableComposer([_0008._0012(1)] TagTestItem _0002, out CultureInfo selection, out PsMaxLengths? serv, out StubListAnnotation? visitor2, out SudsUse? ident3, out int? pred4, out string attr5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ItemError != null && !m_ItemError.Equals(_0002._0001()))
			{
				selection = _0002._0001();
				_0002._0001(m_ItemError);
			}
			else
			{
				selection = null;
			}
			if (importerError.HasValue && _0002._0001() != importerError)
			{
				serv = _0002._0001();
				_0002._0001(importerError.GetValueOrDefault());
			}
			else
			{
				serv = null;
			}
			if (_ReponseError.HasValue && _0002._0001() != _ReponseError)
			{
				visitor2 = _0002._0001();
				_0002._0001(_ReponseError.GetValueOrDefault());
			}
			else
			{
				visitor2 = null;
			}
			if (_DecoratorError.HasValue && _0002._0001() != _DecoratorError)
			{
				ident3 = _0002._0001();
				_0002._0001(_DecoratorError.GetValueOrDefault());
			}
			else
			{
				ident3 = null;
			}
			if (processError && _0002._0002() != _RegError)
			{
				pred4 = _0002._0002();
				_0002._0001(_RegError);
			}
			else
			{
				pred4 = null;
			}
			if (proccesorError && _0002._0003() != containerError)
			{
				attr5 = _0002._0003();
				_0002._0001(containerError);
			}
			else
			{
				attr5 = null;
			}
			RequestComposerPool requestComposerPool = _0002 as RequestComposerPool;
			if (requestComposerPool != null && requestComposerPool._0001() == null)
			{
				PublisherRequestStrategy publisherRequestStrategy = listenerError as PublisherRequestStrategy;
				if (publisherRequestStrategy != null)
				{
					requestComposerPool._0001(publisherRequestStrategy._0001());
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MapComposer(TagTestItem spec, CultureInfo pred, PsMaxLengths? template, StubListAnnotation? config2, SudsUse? connection3, int? map4, string last5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (pred != null)
			{
				spec._0001(pred);
			}
			if (template.HasValue)
			{
				spec._0001(template.GetValueOrDefault());
			}
			if (config2.HasValue)
			{
				spec._0001(config2.GetValueOrDefault());
			}
			if (connection3.HasValue)
			{
				spec._0001(connection3.GetValueOrDefault());
			}
			if (processError)
			{
				spec._0001(map4);
			}
			if (proccesorError)
			{
				spec._0001(last5);
			}
			RequestComposerPool requestComposerPool = spec as RequestComposerPool;
			if (requestComposerPool != null && requestComposerPool._0001() != null)
			{
				PublisherRequestStrategy publisherRequestStrategy = listenerError as PublisherRequestStrategy;
				if (publisherRequestStrategy != null && requestComposerPool._0001() == publisherRequestStrategy._0001())
				{
					requestComposerPool._0001(null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertComposer(RecordClassDispatcher res, object map, Type state)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(res, map, state);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FlushComposer(RecordClassDispatcher ident, object reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(ident, reg, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ObjectIssuerImporter CreateComposer(TagTestItem key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ObjectIssuerImporter objectIssuerImporter = new ObjectIssuerImporter(key);
			if (key._0001() != 0)
			{
				objectIssuerImporter.InstantiateClass();
			}
			return objectIssuerImporter;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void _0001(RecordClassDispatcher param, object cont, Type c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "jsonWriter");
			TimeState? timeState = null;
			if (_RuleError.HasValue && param._0001() != _RuleError)
			{
				timeState = param._0001();
				param._0001(_RuleError.GetValueOrDefault());
			}
			FindDirection? findDirection = null;
			if (m_BridgeError.HasValue && param._0001() != m_BridgeError)
			{
				findDirection = param._0001();
				param._0001(m_BridgeError.GetValueOrDefault());
			}
			PsMaxLengths? psMaxLengths = null;
			if (importerError.HasValue && param._0001() != importerError)
			{
				psMaxLengths = param._0001();
				param._0001(importerError.GetValueOrDefault());
			}
			ApplicationPartitionType? applicationPartitionType = null;
			if (m_IndexerError.HasValue && param._0001() != m_IndexerError)
			{
				applicationPartitionType = param._0001();
				param._0001(m_IndexerError.GetValueOrDefault());
			}
			GraphGroupStyle? graphGroupStyle = null;
			if (_FieldError.HasValue && param._0001() != _FieldError)
			{
				graphGroupStyle = param._0001();
				param._0001(_FieldError.GetValueOrDefault());
			}
			CultureInfo cultureInfo = null;
			if (m_ItemError != null && !m_ItemError.Equals(param._0001()))
			{
				cultureInfo = param._0001();
				param._0001(m_ItemError);
			}
			string var = null;
			if (proccesorError && param._0003() != containerError)
			{
				var = param._0003();
				param._0007(containerError);
			}
			DicIssuer dicIssuer = (this._0001() != null && this._0001()._0001() >= TraceLevel.Verbose) ? new DicIssuer(param) : null;
			new InterceptorInstanceExpression(this).ListBroadcaster(dicIssuer ?? param, cont, c);
			if (dicIssuer != null)
			{
				this._0001()._0001(TraceLevel.Verbose, dicIssuer.ReflectClass(), null);
			}
			if (timeState.HasValue)
			{
				param._0001(timeState.GetValueOrDefault());
			}
			if (findDirection.HasValue)
			{
				param._0001(findDirection.GetValueOrDefault());
			}
			if (psMaxLengths.HasValue)
			{
				param._0001(psMaxLengths.GetValueOrDefault());
			}
			if (applicationPartitionType.HasValue)
			{
				param._0001(applicationPartitionType.GetValueOrDefault());
			}
			if (graphGroupStyle.HasValue)
			{
				param._0001(graphGroupStyle.GetValueOrDefault());
			}
			if (proccesorError)
			{
				param._0007(var);
			}
			if (cultureInfo != null)
			{
				param._0001(cultureInfo);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ListEventConsumer StopComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_CreatorError == null)
			{
				_CreatorError = new ImporterTest();
			}
			return _CreatorError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BroadcasterError CloneComposer(Type def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return LogoutComposer(_MerchantError, def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BroadcasterError LogoutComposer(IList<BroadcasterError> config, Type reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config != null)
			{
				for (int i = 0; i < config.Count; i++)
				{
					BroadcasterError broadcasterError = config[i];
					if (broadcasterError._0001(reg))
					{
						return broadcasterError;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void VisitComposer(FilterClassDispatcher key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_AdapterError?.Invoke(this, key);
		}
	}
}
