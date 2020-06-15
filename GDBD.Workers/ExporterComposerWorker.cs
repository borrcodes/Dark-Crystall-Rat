using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Structs;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Workers
{
	internal sealed class ExporterComposerWorker : IDisposable
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public EventHandler<InstanceInstance> _0001;

			public ExporterComposerWorker _0002;

			public Exception _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001(_0002, new InstanceInstance(_0003));
			}
		}

		private readonly object m_WatcherInstance;

		private readonly SynchronizationContext m_CollectionInstance;

		private IntPtr m_RepositoryInstance;

		private FactoryInstance[] _ServerInstance;

		private ProccesorEventEntry facadeInstance;

		private volatile SourceMode m_ManagerInstance;

		private AutoResetEvent stateInstance;

		private float resolverInstance;

		[CompilerGenerated]
		private EventHandler<InstanceInstance> m_PoolInstance;

		[CompilerGenerated]
		private int valInstance;

		[CompilerGenerated]
		private int m_InvocationInstance;

		[CompilerGenerated]
		private int _DefinitionInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return valInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(int num_ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			valInstance = num_ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InvocationInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(int spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_InvocationInstance = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DefinitionInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExporterComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			resolverInstance = 1f;
			_DefinitionInstance = -1;
			base._002Ector();
			m_CollectionInstance = SynchronizationContext.Current;
			if (m_CollectionInstance != null && (m_CollectionInstance.GetType().Name == "LegacyAspNetSynchronizationContext" || m_CollectionInstance.GetType().Name == "AspNetSynchronizationContext"))
			{
				m_CollectionInstance = null;
			}
			_0001(300);
			_0002(2);
			m_WatcherInstance = new object();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(ProccesorEventEntry item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ManagerInstance != 0)
			{
				throw new InvalidOperationException("Can't re-initialize during playback");
			}
			if (m_RepositoryInstance != IntPtr.Zero)
			{
				InitDic();
				ManageDic();
			}
			stateInstance = new AutoResetEvent(initialState: false);
			facadeInstance = item;
			int selection = item._0001().StartDic((this._0001() + this._0002() - 1) / this._0002());
			MathOperator key;
			lock (m_WatcherInstance)
			{
				key = QueueBroadcasterFilter.ReflectDic(out m_RepositoryInstance, (IntPtr)_0003(), facadeInstance._0001(), stateInstance.SafeWaitHandle.DangerousGetHandle(), IntPtr.Zero, (QueueBroadcasterFilter.EventAttributes)327680);
			}
			FacadePropertyStruct.VisitDic(key, "waveOutOpen");
			_ServerInstance = new FactoryInstance[this._0002()];
			m_ManagerInstance = (SourceMode)0;
			for (int i = 0; i < this._0002(); i++)
			{
				_ServerInstance[i] = new FactoryInstance(m_RepositoryInstance, selection, facadeInstance, m_WatcherInstance);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ServerInstance == null || facadeInstance == null)
			{
				throw new InvalidOperationException("Must call Init first");
			}
			if (m_ManagerInstance == (SourceMode)0)
			{
				m_ManagerInstance = (SourceMode)1;
				stateInstance.Set();
				ThreadPool.QueueUserWorkItem(delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					QueryDic();
				}, null);
			}
			else if (m_ManagerInstance == (SourceMode)2)
			{
				ExcludeDic();
				stateInstance.Set();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QueryDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Exception key = null;
			try
			{
				CancelDic();
			}
			catch (Exception ex)
			{
				key = ex;
			}
			finally
			{
				m_ManagerInstance = (SourceMode)0;
				DefineDic(key);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (m_ManagerInstance != 0)
			{
				if (!stateInstance.WaitOne(this._0001()))
				{
					_ = m_ManagerInstance;
					_ = 1;
				}
				if (m_ManagerInstance != (SourceMode)1)
				{
					continue;
				}
				int num = 0;
				FactoryInstance[] serverInstance = _ServerInstance;
				foreach (FactoryInstance factoryInstance in serverInstance)
				{
					if (factoryInstance._0002() || factoryInstance.ValidateError())
					{
						num++;
					}
				}
				if (num == 0)
				{
					m_ManagerInstance = (SourceMode)0;
					stateInstance.Set();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExcludeDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ManagerInstance == (SourceMode)2)
			{
				MathOperator mathOperator;
				lock (m_WatcherInstance)
				{
					mathOperator = QueueBroadcasterFilter.RestartDic(m_RepositoryInstance);
				}
				if (mathOperator != 0)
				{
					throw new FacadePropertyStruct(mathOperator, "waveOutRestart");
				}
				m_ManagerInstance = (SourceMode)1;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ManagerInstance != 0)
			{
				m_ManagerInstance = (SourceMode)0;
				MathOperator mathOperator;
				lock (m_WatcherInstance)
				{
					mathOperator = QueueBroadcasterFilter.ResetDic(m_RepositoryInstance);
				}
				if (mathOperator != 0)
				{
					throw new FacadePropertyStruct(mathOperator, "waveOutReset");
				}
				stateInstance.Set();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SourceMode _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ManagerInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GC.SuppressFinalize(this);
			SetupDic(createi: true);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0006();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetupDic(bool createi)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0002();
			if (createi)
			{
				InitDic();
			}
			ManageDic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ManageDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (stateInstance != null)
			{
				stateInstance.Close();
				stateInstance = null;
			}
			lock (m_WatcherInstance)
			{
				if (m_RepositoryInstance != IntPtr.Zero)
				{
					QueueBroadcasterFilter.RegisterDic(m_RepositoryInstance);
					m_RepositoryInstance = IntPtr.Zero;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ServerInstance != null)
			{
				FactoryInstance[] serverInstance = _ServerInstance;
				for (int i = 0; i < serverInstance.Length; i++)
				{
					serverInstance[i]._0002();
				}
				_ServerInstance = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				SetupDic(createi: false);
			}
			finally
			{
				base.Finalize();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DefineDic(Exception key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			EventHandler<InstanceInstance> poolInstance = m_PoolInstance;
			if (poolInstance != null)
			{
				if (m_CollectionInstance == null)
				{
					poolInstance(this, new InstanceInstance(key));
				}
				else
				{
					m_CollectionInstance.Post(delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						poolInstance(this, new InstanceInstance(key));
					}, null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void CollectDic(object v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueryDic();
		}
	}
}
