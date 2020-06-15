using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Newtonsoft.Annotations
{
	internal sealed class RoleEvent : WriterReaderMapper
	{
		private sealed class WrapperEvent : DefinitionClientBridge
		{
			private RoleEvent _ParamsEvent;

			private bool templateEvent;

			private int expressionEvent;

			private int configEvent;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return expressionEvent;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0001(int var1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				expressionEvent = var1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return configEvent;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void _0002(int position_key)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				configEvent = position_key;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public WrapperEvent(RoleEvent reference, bool acceptivk)
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				_ParamsEvent = reference;
				templateEvent = acceptivk;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int _0001(double asset, IntPtr reg)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public unsafe int _0001(double item, IntPtr second, int tag)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (_ParamsEvent.m_AnnotationEvent != null)
				{
					Bitmap bitmap = new Bitmap(expressionEvent, configEvent, PixelFormat.Format24bppRgb);
					BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, expressionEvent, configEvent), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
					int stride = bitmapData.Stride;
					int stride2 = bitmapData.Stride;
					byte* ptr = (byte*)bitmapData.Scan0.ToPointer() + stride2 * (configEvent - 1);
					byte* ptr2 = (byte*)second.ToPointer();
					for (int i = 0; i < configEvent; i++)
					{
						AdvisorRequestStrategy.ManageInstance(ptr, ptr2, stride);
						ptr -= stride2;
						ptr2 += stride;
					}
					bitmap.UnlockBits(bitmapData);
					if (templateEvent)
					{
						_ParamsEvent.IncludeInstance(bitmap);
					}
					else
					{
						_ParamsEvent.ForgotInstance(bitmap);
					}
					bitmap.Dispose();
				}
				return 0;
			}
		}

		private string _CreatorEvent;

		private int _RuleEvent;

		private long m_BridgeEvent;

		private IndexerClassSpec importerEvent;

		private IndexerClassSpec _ReponseEvent;

		private bool indexerEvent;

		private Thread m_DecoratorEvent;

		private ManualResetEvent fieldEvent;

		private IndexerClassSpec[] itemEvent;

		private IndexerClassSpec[] _RegEvent;

		private bool m_ProcessEvent;

		private bool baseEvent;

		private bool containerEvent;

		private bool proccesorEvent;

		private IntPtr m_AdapterEvent;

		private object m_TokenEvent;

		private DateTime m_DispatcherEvent;

		private object _AccountEvent;

		private bool? singletonEvent;

		private ConnectionEvent[] m_ModelEvent;

		private ConnectionEvent m_MessageEvent;

		private static Dictionary<string, IndexerClassSpec[]> _ProductEvent;

		private static Dictionary<string, IndexerClassSpec[]> interceptorEvent;

		private static Dictionary<string, ConnectionEvent[]> _AlgoEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ParserEvent m_AnnotationEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ParserEvent exporterEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ObjectBroadcasterDispatcher m_VisitorEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RegEventEntry globalEvent;

		public virtual string Source
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _CreatorEvent;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_CreatorEvent = value;
				itemEvent = null;
				_RegEvent = null;
				m_ModelEvent = null;
				singletonEvent = null;
			}
		}

		public int FramesReceived
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				int ruleEvent = _RuleEvent;
				_RuleEvent = 0;
				return ruleEvent;
			}
		}

		public long BytesReceived
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				long bridgeEvent = m_BridgeEvent;
				m_BridgeEvent = 0L;
				return bridgeEvent;
			}
		}

		public bool IsRunning
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (m_DecoratorEvent != null)
				{
					if (!m_DecoratorEvent.Join(0))
					{
						return true;
					}
					CompareInstance();
				}
				return false;
			}
		}

		[Obsolete]
		public Size RegisterInstance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return Size.Empty;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1

		}

		[Obsolete]
		public Size ComputeInstance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return Size.Empty;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1

		}

		[Obsolete]
		public int RateInstance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1

		}

		public event ParserEvent NewFrame
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ParserEvent parserEvent = m_AnnotationEvent;
				ParserEvent parserEvent2;
				do
				{
					parserEvent2 = parserEvent;
					ParserEvent value2 = (ParserEvent)Delegate.Combine(parserEvent2, value);
					parserEvent = Interlocked.CompareExchange(ref m_AnnotationEvent, value2, parserEvent2);
				}
				while ((object)parserEvent != parserEvent2);
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ParserEvent parserEvent = m_AnnotationEvent;
				ParserEvent parserEvent2;
				do
				{
					parserEvent2 = parserEvent;
					ParserEvent value2 = (ParserEvent)Delegate.Remove(parserEvent2, value);
					parserEvent = Interlocked.CompareExchange(ref m_AnnotationEvent, value2, parserEvent2);
				}
				while ((object)parserEvent != parserEvent2);
			}
		}

		public event ObjectBroadcasterDispatcher VideoSourceError
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ObjectBroadcasterDispatcher objectBroadcasterDispatcher = m_VisitorEvent;
				ObjectBroadcasterDispatcher objectBroadcasterDispatcher2;
				do
				{
					objectBroadcasterDispatcher2 = objectBroadcasterDispatcher;
					ObjectBroadcasterDispatcher value2 = (ObjectBroadcasterDispatcher)Delegate.Combine(objectBroadcasterDispatcher2, value);
					objectBroadcasterDispatcher = Interlocked.CompareExchange(ref m_VisitorEvent, value2, objectBroadcasterDispatcher2);
				}
				while ((object)objectBroadcasterDispatcher != objectBroadcasterDispatcher2);
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ObjectBroadcasterDispatcher objectBroadcasterDispatcher = m_VisitorEvent;
				ObjectBroadcasterDispatcher objectBroadcasterDispatcher2;
				do
				{
					objectBroadcasterDispatcher2 = objectBroadcasterDispatcher;
					ObjectBroadcasterDispatcher value2 = (ObjectBroadcasterDispatcher)Delegate.Remove(objectBroadcasterDispatcher2, value);
					objectBroadcasterDispatcher = Interlocked.CompareExchange(ref m_VisitorEvent, value2, objectBroadcasterDispatcher2);
				}
				while ((object)objectBroadcasterDispatcher != objectBroadcasterDispatcher2);
			}
		}

		public event RegEventEntry PlayingFinished
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			add
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				RegEventEntry regEventEntry = globalEvent;
				RegEventEntry regEventEntry2;
				do
				{
					regEventEntry2 = regEventEntry;
					RegEventEntry value2 = (RegEventEntry)Delegate.Combine(regEventEntry2, value);
					regEventEntry = Interlocked.CompareExchange(ref globalEvent, value2, regEventEntry2);
				}
				while ((object)regEventEntry != regEventEntry2);
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			remove
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				RegEventEntry regEventEntry = globalEvent;
				RegEventEntry regEventEntry2;
				do
				{
					regEventEntry2 = regEventEntry;
					RegEventEntry value2 = (RegEventEntry)Delegate.Remove(regEventEntry2, value);
					regEventEntry = Interlocked.CompareExchange(ref globalEvent, value2, regEventEntry2);
				}
				while ((object)regEventEntry != regEventEntry2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionEvent PushInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_MessageEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrepareInstance(ConnectionEvent spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ProcessEvent = true;
			m_MessageEvent = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionEvent[] UpdateInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ModelEvent == null)
			{
				lock (_AlgoEvent)
				{
					if (!string.IsNullOrEmpty(_CreatorEvent) && _AlgoEvent.ContainsKey(_CreatorEvent))
					{
						m_ModelEvent = _AlgoEvent[_CreatorEvent];
					}
				}
				if (m_ModelEvent == null)
				{
					if (!IsRunning)
					{
						LogoutInstance(isvar1: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (m_ModelEvent != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			return (m_ModelEvent != null) ? m_ModelEvent : new ConnectionEvent[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool InterruptInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return indexerEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalcInstance(bool overrideres)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			indexerEvent = overrideres;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void PrintInstance(ParserEvent res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParserEvent parserEvent = exporterEvent;
			ParserEvent parserEvent2;
			do
			{
				parserEvent2 = parserEvent;
				ParserEvent value = (ParserEvent)Delegate.Combine(parserEvent2, res);
				parserEvent = Interlocked.CompareExchange(ref exporterEvent, value, parserEvent2);
			}
			while ((object)parserEvent != parserEvent2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void CountInstance(ParserEvent task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParserEvent parserEvent = exporterEvent;
			ParserEvent parserEvent2;
			do
			{
				parserEvent2 = parserEvent;
				ParserEvent value = (ParserEvent)Delegate.Remove(parserEvent2, task);
				parserEvent = Interlocked.CompareExchange(ref exporterEvent, value, parserEvent2);
			}
			while ((object)parserEvent != parserEvent2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerClassSpec RemoveInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PostInstance(IndexerClassSpec v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			importerEvent = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerClassSpec CalculateInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetInstance(IndexerClassSpec config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ReponseEvent = config;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerClassSpec[] ListInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (itemEvent == null)
			{
				lock (_ProductEvent)
				{
					if (!string.IsNullOrEmpty(_CreatorEvent) && _ProductEvent.ContainsKey(_CreatorEvent))
					{
						itemEvent = _ProductEvent[_CreatorEvent];
					}
				}
				if (itemEvent == null)
				{
					if (!IsRunning)
					{
						LogoutInstance(isvar1: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (itemEvent != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			return (itemEvent != null) ? itemEvent : new IndexerClassSpec[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerClassSpec[] DeleteInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_RegEvent == null)
			{
				lock (interceptorEvent)
				{
					if (!string.IsNullOrEmpty(_CreatorEvent) && interceptorEvent.ContainsKey(_CreatorEvent))
					{
						_RegEvent = interceptorEvent[_CreatorEvent];
					}
				}
				if (_RegEvent == null)
				{
					if (!IsRunning)
					{
						LogoutInstance(isvar1: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (_RegEvent != null)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
			}
			return (_RegEvent != null) ? _RegEvent : new IndexerClassSpec[0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ConcatInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TokenEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RoleEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			importerEvent = null;
			_ReponseEvent = null;
			indexerEvent = false;
			m_DecoratorEvent = null;
			fieldEvent = null;
			m_ProcessEvent = false;
			baseEvent = false;
			containerEvent = false;
			proccesorEvent = false;
			m_AdapterEvent = IntPtr.Zero;
			m_TokenEvent = null;
			m_DispatcherEvent = default(DateTime);
			_AccountEvent = new object();
			singletonEvent = null;
			m_ModelEvent = null;
			m_MessageEvent = ConnectionEvent.CustomizeInstance();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RoleEvent(string init)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			importerEvent = null;
			_ReponseEvent = null;
			indexerEvent = false;
			m_DecoratorEvent = null;
			fieldEvent = null;
			m_ProcessEvent = false;
			baseEvent = false;
			containerEvent = false;
			proccesorEvent = false;
			m_AdapterEvent = IntPtr.Zero;
			m_TokenEvent = null;
			m_DispatcherEvent = default(DateTime);
			_AccountEvent = new object();
			singletonEvent = null;
			m_ModelEvent = null;
			m_MessageEvent = ConnectionEvent.CustomizeInstance();
			base._002Ector();
			_CreatorEvent = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!IsRunning)
			{
				if (string.IsNullOrEmpty(_CreatorEvent))
				{
					throw new ArgumentException("Video source is not specified.");
				}
				_RuleEvent = 0;
				m_BridgeEvent = 0L;
				singletonEvent = null;
				m_ProcessEvent = true;
				fieldEvent = new ManualResetEvent(initialState: false);
				lock (_AccountEvent)
				{
					m_DecoratorEvent = new Thread(CloneInstance);
					m_DecoratorEvent.Name = _CreatorEvent;
					m_DecoratorEvent.Start();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_DecoratorEvent != null)
			{
				fieldEvent.Set();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_DecoratorEvent != null)
			{
				m_DecoratorEvent.Join();
				CompareInstance();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (IsRunning)
			{
				m_DecoratorEvent.Abort();
				_0003();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompareInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_DecoratorEvent = null;
			fieldEvent.Close();
			fieldEvent = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddInstance(IntPtr instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_CreatorEvent == null || _CreatorEvent == string.Empty)
			{
				throw new ArgumentException("Video source is not specified.");
			}
			lock (_AccountEvent)
			{
				if (IsRunning)
				{
					m_AdapterEvent = instance;
					containerEvent = true;
				}
				else
				{
					object obj = null;
					try
					{
						obj = ExceptionEvent.CallList(_CreatorEvent);
					}
					catch
					{
						throw new ApplicationException("Failed creating device object for moniker.");
					}
					if (!(obj is PropertyComposerPool))
					{
						throw new NotSupportedException("The video source does not support configuration property page.");
					}
					ConnectInstance(instance, obj);
					Marshal.ReleaseComObject(obj);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableInstance(IntPtr spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			lock (_AccountEvent)
			{
				for (int i = 0; i < 500; i++)
				{
					if (singletonEvent.HasValue)
					{
						break;
					}
					if (!IsRunning)
					{
						break;
					}
					Thread.Sleep(10);
				}
				if (!IsRunning || !singletonEvent.HasValue)
				{
					throw new ApplicationException("The video source must be running in order to display crossbar property page.");
				}
				if (!singletonEvent.Value)
				{
					throw new NotSupportedException("Crossbar configuration is not supported by currently running video source.");
				}
				m_AdapterEvent = spec;
				proccesorEvent = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MapInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			lock (_AccountEvent)
			{
				if (!singletonEvent.HasValue)
				{
					if (!IsRunning)
					{
						LogoutInstance(isvar1: false);
					}
					else
					{
						for (int i = 0; i < 500; i++)
						{
							if (singletonEvent.HasValue)
							{
								break;
							}
							Thread.Sleep(10);
						}
					}
				}
				return singletonEvent.HasValue && singletonEvent.Value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			baseEvent = true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FlushInstance(PipelinePublishProjectCfgTargets i, int meanpol, WatsonLoggingFlags filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool result = true;
			if (_CreatorEvent == null || string.IsNullOrEmpty(_CreatorEvent))
			{
				throw new ArgumentException("Video source is not specified.");
			}
			lock (_AccountEvent)
			{
				object obj = null;
				try
				{
					obj = ExceptionEvent.CallList(_CreatorEvent);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is SchemaEvent))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				SchemaEvent schemaEvent = (SchemaEvent)obj;
				int num = schemaEvent._0001(i, meanpol, filter);
				result = (num >= 0);
				Marshal.ReleaseComObject(obj);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CreateInstance(PipelinePublishProjectCfgTargets def, out int cust, out WatsonLoggingFlags third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool result = true;
			if (_CreatorEvent == null || string.IsNullOrEmpty(_CreatorEvent))
			{
				throw new ArgumentException("Video source is not specified.");
			}
			lock (_AccountEvent)
			{
				object obj = null;
				try
				{
					obj = ExceptionEvent.CallList(_CreatorEvent);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is SchemaEvent))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				SchemaEvent schemaEvent = (SchemaEvent)obj;
				int num = schemaEvent._0001(def, out cust, out third);
				result = (num >= 0);
				Marshal.ReleaseComObject(obj);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool StopInstance(PipelinePublishProjectCfgTargets key, out int selection, out int template, out int selection2, out int last3, out WatsonLoggingFlags t4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool result = true;
			if (_CreatorEvent == null || string.IsNullOrEmpty(_CreatorEvent))
			{
				throw new ArgumentException("Video source is not specified.");
			}
			lock (_AccountEvent)
			{
				object obj = null;
				try
				{
					obj = ExceptionEvent.CallList(_CreatorEvent);
				}
				catch
				{
					throw new ApplicationException("Failed creating device object for moniker.");
				}
				if (!(obj is SchemaEvent))
				{
					throw new NotSupportedException("The video source does not support camera control.");
				}
				SchemaEvent schemaEvent = (SchemaEvent)obj;
				int num = schemaEvent._0001(key, out selection, out template, out selection2, out last3, out t4);
				result = (num >= 0);
				Marshal.ReleaseComObject(obj);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloneInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			LogoutInstance(isvar1: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LogoutInstance(bool isvar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Directories reason = (Directories)1;
			bool flag = false;
			WrapperEvent wrapperEvent = new WrapperEvent(this, acceptivk: false);
			WrapperEvent wrapperEvent2 = new WrapperEvent(this, acceptivk: true);
			object obj = null;
			object obj2 = null;
			object obj3 = null;
			object obj4 = null;
			object map = null;
			ThreadEvent threadEvent = null;
			MethodIssuerMock methodIssuerMock = null;
			SerializerTestItem serializerTestItem = null;
			SerializerTestItem serializerTestItem2 = null;
			SerializerTestItem serializerTestItem3 = null;
			ComparatorEvent comparatorEvent = null;
			ComparatorEvent comparatorEvent2 = null;
			CustomerErrorFilter customerErrorFilter = null;
			TestsIssuerMock testsIssuerMock = null;
			InterpreterErrorFilter interpreterErrorFilter = null;
			RefBroadcasterDispatcher counter = null;
			DecoratorClassSpec decoratorClassSpec = null;
			try
			{
				Type typeFromCLSID = Type.GetTypeFromCLSID(AlgoComposerWorker.m_AttributeFilter);
				if (typeFromCLSID == null)
				{
					throw new ApplicationException("Failed creating capture graph builder");
				}
				obj = Activator.CreateInstance(typeFromCLSID);
				threadEvent = (ThreadEvent)obj;
				typeFromCLSID = Type.GetTypeFromCLSID(AlgoComposerWorker.m_HelperFilter);
				if (typeFromCLSID == null)
				{
					throw new ApplicationException("Failed creating filter graph");
				}
				obj2 = Activator.CreateInstance(typeFromCLSID);
				methodIssuerMock = (MethodIssuerMock)obj2;
				threadEvent._0001((PolicyBroadcasterFilter)methodIssuerMock);
				m_TokenEvent = ExceptionEvent.CallList(_CreatorEvent);
				if (m_TokenEvent == null)
				{
					throw new ApplicationException("Failed creating device object for moniker");
				}
				serializerTestItem = (SerializerTestItem)m_TokenEvent;
				try
				{
					testsIssuerMock = (TestsIssuerMock)m_TokenEvent;
				}
				catch
				{
				}
				typeFromCLSID = Type.GetTypeFromCLSID(AlgoComposerWorker.m_ExceptionFilter);
				if (typeFromCLSID == null)
				{
					throw new ApplicationException("Failed creating sample grabber");
				}
				obj3 = Activator.CreateInstance(typeFromCLSID);
				comparatorEvent = (ComparatorEvent)obj3;
				serializerTestItem2 = (SerializerTestItem)obj3;
				obj4 = Activator.CreateInstance(typeFromCLSID);
				comparatorEvent2 = (ComparatorEvent)obj4;
				serializerTestItem3 = (SerializerTestItem)obj4;
				methodIssuerMock._0001(serializerTestItem, "source");
				methodIssuerMock._0001(serializerTestItem2, "grabber_video");
				methodIssuerMock._0001(serializerTestItem3, "grabber_snapshot");
				PrototypeDicCandidate prototypeDicCandidate = new PrototypeDicCandidate();
				prototypeDicCandidate.procEvent = ThreadConsumer._MerchantFilter;
				prototypeDicCandidate.m_RecordFilter = RoleFilter._ItemFilter;
				comparatorEvent._0001(prototypeDicCandidate);
				comparatorEvent2._0001(prototypeDicCandidate);
				threadEvent._0001(PrinterIteratorMapping.m_AdapterFilter, Guid.Empty, serializerTestItem, typeof(DecoratorClassSpec).GUID, out map);
				if (map != null)
				{
					decoratorClassSpec = (DecoratorClassSpec)map;
				}
				singletonEvent = (decoratorClassSpec != null);
				m_ModelEvent = MoveInstance(decoratorClassSpec);
				if (testsIssuerMock != null)
				{
					threadEvent._0001(m_TokenEvent, (ChildType)1, BaseEventEntry.m_ProccesorFilter, ThreadConsumer._MerchantFilter, containscont3: false, 0, out counter);
					if (counter != null)
					{
						testsIssuerMock._0001(counter, out TargetEntryState pol);
						flag = ((pol & (TargetEntryState)4) != 0);
					}
				}
				comparatorEvent._0002(isparam: false);
				comparatorEvent._0001(explicitparam: false);
				comparatorEvent._0001(wrapperEvent, 1);
				comparatorEvent2._0002(isparam: true);
				comparatorEvent2._0001(explicitparam: false);
				comparatorEvent2._0001(wrapperEvent2, 1);
				ViewInstance(threadEvent, serializerTestItem, BaseEventEntry._ContainerFilter, importerEvent, ref itemEvent);
				if (flag)
				{
					ViewInstance(threadEvent, serializerTestItem, BaseEventEntry.m_ProccesorFilter, _ReponseEvent, ref _RegEvent);
				}
				else
				{
					_RegEvent = new IndexerClassSpec[0];
				}
				lock (_ProductEvent)
				{
					if (itemEvent != null && !_ProductEvent.ContainsKey(_CreatorEvent))
					{
						_ProductEvent.Add(_CreatorEvent, itemEvent);
					}
				}
				lock (interceptorEvent)
				{
					if (_RegEvent != null && !interceptorEvent.ContainsKey(_CreatorEvent))
					{
						interceptorEvent.Add(_CreatorEvent, _RegEvent);
					}
				}
				if (isvar1)
				{
					threadEvent._0001(BaseEventEntry._ContainerFilter, ThreadConsumer._MerchantFilter, serializerTestItem, null, serializerTestItem2);
					if (comparatorEvent._0002(prototypeDicCandidate) == 0)
					{
						ObserverListAnnotation observerListAnnotation = (ObserverListAnnotation)Marshal.PtrToStructure(prototypeDicCandidate.propertyFilter, typeof(ObserverListAnnotation));
						wrapperEvent._0001(observerListAnnotation.predicateFilter._DescriptorFilter);
						wrapperEvent._0002(observerListAnnotation.predicateFilter.m_ProducerFilter);
						prototypeDicCandidate._0002();
					}
					if (flag && indexerEvent)
					{
						threadEvent._0001(BaseEventEntry.m_ProccesorFilter, ThreadConsumer._MerchantFilter, serializerTestItem, null, serializerTestItem3);
						if (comparatorEvent2._0002(prototypeDicCandidate) == 0)
						{
							ObserverListAnnotation observerListAnnotation2 = (ObserverListAnnotation)Marshal.PtrToStructure(prototypeDicCandidate.propertyFilter, typeof(ObserverListAnnotation));
							wrapperEvent2._0001(observerListAnnotation2.predicateFilter._DescriptorFilter);
							wrapperEvent2._0002(observerListAnnotation2.predicateFilter.m_ProducerFilter);
							prototypeDicCandidate._0002();
						}
					}
					customerErrorFilter = (CustomerErrorFilter)obj2;
					interpreterErrorFilter = (InterpreterErrorFilter)obj2;
					customerErrorFilter._0001();
					if (flag && indexerEvent)
					{
						m_DispatcherEvent = DateTime.Now;
						testsIssuerMock._0001(counter, (TargetEntryState)4);
					}
					do
					{
						if (interpreterErrorFilter != null && interpreterErrorFilter._0001(out dateorder reference, out IntPtr cont, out IntPtr field, 0) >= 0)
						{
							interpreterErrorFilter._0001(reference, cont, field);
							if (reference == (dateorder)31)
							{
								reason = (Directories)2;
								break;
							}
						}
						if (m_ProcessEvent)
						{
							m_ProcessEvent = false;
							if (singletonEvent.Value)
							{
								NewInstance(decoratorClassSpec, m_MessageEvent);
								m_MessageEvent = PopInstance(decoratorClassSpec);
							}
						}
						if (baseEvent)
						{
							baseEvent = false;
							if (flag && indexerEvent)
							{
								testsIssuerMock._0001(counter, (TargetEntryState)8);
							}
						}
						if (containerEvent)
						{
							containerEvent = false;
							ConnectInstance(m_AdapterEvent, m_TokenEvent);
							if (decoratorClassSpec != null)
							{
								m_MessageEvent = PopInstance(decoratorClassSpec);
							}
						}
						if (proccesorEvent)
						{
							proccesorEvent = false;
							if (decoratorClassSpec != null)
							{
								ConnectInstance(m_AdapterEvent, decoratorClassSpec);
								m_MessageEvent = PopInstance(decoratorClassSpec);
							}
						}
					}
					while (!fieldEvent.WaitOne(100, exitContext: false));
					customerErrorFilter._0003();
				}
			}
			catch (Exception ex)
			{
				if (m_VisitorEvent != null)
				{
					m_VisitorEvent(this, new PageEvent(ex.Message));
				}
			}
			finally
			{
				threadEvent = null;
				methodIssuerMock = null;
				serializerTestItem = null;
				customerErrorFilter = null;
				testsIssuerMock = null;
				interpreterErrorFilter = null;
				counter = null;
				decoratorClassSpec = null;
				serializerTestItem2 = null;
				serializerTestItem3 = null;
				comparatorEvent = null;
				comparatorEvent2 = null;
				if (obj2 != null)
				{
					Marshal.ReleaseComObject(obj2);
					obj2 = null;
				}
				if (m_TokenEvent != null)
				{
					Marshal.ReleaseComObject(m_TokenEvent);
					m_TokenEvent = null;
				}
				if (obj3 != null)
				{
					Marshal.ReleaseComObject(obj3);
					obj3 = null;
				}
				if (obj4 != null)
				{
					Marshal.ReleaseComObject(obj4);
					obj4 = null;
				}
				if (obj != null)
				{
					Marshal.ReleaseComObject(obj);
					obj = null;
				}
				if (map != null)
				{
					Marshal.ReleaseComObject(map);
					map = null;
				}
			}
			if (globalEvent != null)
			{
				globalEvent(this, reason);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VisitInstance(RefEvent init, IndexerClassSpec visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!IndexerClassSpec._0001(visitor, null))
			{
				int def = 0;
				int token = 0;
				PrototypeDicCandidate result = null;
				TokenizerIteratorMapping filter = new TokenizerIteratorMapping();
				init._0001(out def, out token);
				for (int i = 0; i < def; i++)
				{
					try
					{
						IndexerClassSpec token2 = new IndexerClassSpec(init, i);
						if (IndexerClassSpec._0001(visitor, token2) && init._0001(i, out result, filter) == 0)
						{
							break;
						}
					}
					catch
					{
					}
				}
				if (result != null)
				{
					init._0001(result);
					result._0002();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewInstance(ThreadEvent res, SerializerTestItem selection, Guid control, IndexerClassSpec instance2, ref IndexerClassSpec[] cust3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			res._0001(control, ThreadConsumer._MerchantFilter, selection, typeof(RefEvent).GUID, out object map);
			if (map != null)
			{
				RefEvent refEvent = null;
				try
				{
					refEvent = (RefEvent)map;
				}
				catch (InvalidCastException)
				{
				}
				if (refEvent != null)
				{
					if (cust3 == null)
					{
						try
						{
							cust3 = IndexerClassSpec.OrderInstance(refEvent);
						}
						catch
						{
						}
					}
					if (IndexerClassSpec._0002(instance2, null))
					{
						VisitInstance(refEvent, instance2);
					}
				}
			}
			if (cust3 == null)
			{
				cust3 = new IndexerClassSpec[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectInstance(IntPtr first, object selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				PropertyComposerPool propertyComposerPool = (PropertyComposerPool)selection;
				propertyComposerPool._0001(out StateFilter setup);
				ExceptionEvent exceptionEvent = new ExceptionEvent(_CreatorEvent);
				AdvisorRequestStrategy.InitInstance(first, 0, 0, exceptionEvent.Name, 1, ref selection, setup.resolverFilter, setup._PoolFilter, 0, 0, IntPtr.Zero);
				Marshal.FreeCoTaskMem(setup._PoolFilter);
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConnectionEvent[] MoveInstance(DecoratorClassSpec first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			lock (_AlgoEvent)
			{
				if (_AlgoEvent.ContainsKey(_CreatorEvent))
				{
					return _AlgoEvent[_CreatorEvent];
				}
				List<ConnectionEvent> list = new List<ConnectionEvent>();
				if (first != null && first._0001(out int _, out int counter) == 0)
				{
					for (int i = 0; i < counter; i++)
					{
						if (first._0001(applyinstance: true, i, out int _, out BreakpointType col) == 0 && col < (BreakpointType)4096)
						{
							list.Add(new ConnectionEvent(i, col));
						}
					}
				}
				ConnectionEvent[] array = new ConnectionEvent[list.Count];
				list.CopyTo(array);
				_AlgoEvent.Add(_CreatorEvent, array);
				return array;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConnectionEvent PopInstance(DecoratorClassSpec config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ConnectionEvent result = ConnectionEvent.CustomizeInstance();
			if (config._0001(out int key, out int _) == 0)
			{
				int num = -1;
				int temp;
				for (int i = 0; i < key; i++)
				{
					if (config._0001(applyinstance: false, i, out temp, out BreakpointType col) == 0 && col == (BreakpointType)12)
					{
						num = i;
						break;
					}
				}
				if (num != -1 && config._0001(num, out int attr) == 0)
				{
					config._0001(applyinstance: true, attr, out temp, out BreakpointType col2);
					result = new ConnectionEvent(attr, col2);
				}
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NewInstance(DecoratorClassSpec ident, ConnectionEvent attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr.m_ObjectEvent == (BreakpointType)0 || ident._0001(out int key, out int counter) != 0)
			{
				return;
			}
			int num = -1;
			int num2 = -1;
			int temp;
			BreakpointType col;
			for (int i = 0; i < key; i++)
			{
				if (ident._0001(applyinstance: false, i, out temp, out col) == 0 && col == (BreakpointType)12)
				{
					num = i;
					break;
				}
			}
			for (int j = 0; j < counter; j++)
			{
				if (ident._0001(applyinstance: true, j, out temp, out col) == 0 && col == attr.m_ObjectEvent && j == attr.m_InitializerEvent)
				{
					num2 = j;
					break;
				}
			}
			if (num2 != -1 && num != -1 && ident._0001(num, num2) == 0)
			{
				ident._0002(num, num2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ForgotInstance(Bitmap info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RuleEvent++;
			m_BridgeEvent += info.Width * info.Height * (Image.GetPixelFormatSize(info.PixelFormat) >> 3);
			if (!fieldEvent.WaitOne(0, exitContext: false) && m_AnnotationEvent != null)
			{
				m_AnnotationEvent(this, new IteratorIssuerMock(info));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IncludeInstance(Bitmap init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((DateTime.Now - m_DispatcherEvent).TotalSeconds >= 4.0 && !fieldEvent.WaitOne(0, exitContext: false) && exporterEvent != null)
			{
				exporterEvent(this, new IteratorIssuerMock(init));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RoleEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ProductEvent = new Dictionary<string, IndexerClassSpec[]>();
			interceptorEvent = new Dictionary<string, IndexerClassSpec[]>();
			_AlgoEvent = new Dictionary<string, ConnectionEvent[]>();
		}
	}
}
