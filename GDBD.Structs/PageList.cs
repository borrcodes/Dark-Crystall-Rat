using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Expressions;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Structs
{
	internal sealed class PageList : IDisposable
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public EventHandler<InstanceInstance> _0001;

			public PageList _0002;

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

		private readonly AutoResetEvent m_HelperList;

		private readonly SynchronizationContext exceptionList;

		private IntPtr m_AttributeList;

		private volatile ComposerInstanceRule databaseList;

		private PrototypeInstance[] _FactoryList;

		[CompilerGenerated]
		private EventHandler<TemplateList> serializerList;

		[CompilerGenerated]
		private EventHandler<InstanceInstance> _CallbackList;

		[CompilerGenerated]
		private int m_MerchantList;

		[CompilerGenerated]
		private int _ListenerList;

		[CompilerGenerated]
		private int tagList;

		[CompilerGenerated]
		private RefList _SpecificationList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(EventHandler<TemplateList> last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			EventHandler<TemplateList> eventHandler = serializerList;
			EventHandler<TemplateList> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TemplateList> value = (EventHandler<TemplateList>)Delegate.Combine(eventHandler2, last);
				eventHandler = Interlocked.CompareExchange(ref serializerList, value, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PageList()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_HelperList = new AutoResetEvent(initialState: false);
			exceptionList = SynchronizationContext.Current;
			_0003(0);
			_0001(new RefList(8000, 16, 1));
			_0001(100);
			_0002(3);
			databaseList = (ComposerInstanceRule)0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_MerchantList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(int i_amount)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MerchantList = i_amount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ListenerList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(int task_offset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ListenerList = task_offset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return tagList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0003(int maxv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tagList = maxv;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = this._0001() * this._0001()._0004() / 1000;
			if (num % this._0001()._0005() != 0)
			{
				num -= num % this._0001()._0005();
			}
			_FactoryList = new PrototypeInstance[this._0002()];
			for (int i = 0; i < _FactoryList.Length; i++)
			{
				_FactoryList[i] = new PrototypeInstance(m_AttributeList, num);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ForgotDic();
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.RateDic(out m_AttributeList, (IntPtr)_0003(), this._0001(), m_HelperList.SafeWaitHandle.DangerousGetHandle(), IntPtr.Zero, (QueueBroadcasterFilter.EventAttributes)327680), "waveInOpen");
			ViewDic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (databaseList != 0)
			{
				throw new InvalidOperationException("Already recording");
			}
			ConnectDic();
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.CalculateDic(m_AttributeList), "waveInStart");
			databaseList = (ComposerInstanceRule)1;
			ThreadPool.QueueUserWorkItem(delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				MoveDic();
			}, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Exception item = null;
			try
			{
				PopDic();
			}
			catch (Exception ex)
			{
				item = ex;
			}
			finally
			{
				databaseList = (ComposerInstanceRule)0;
				NewDic(item);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			databaseList = (ComposerInstanceRule)2;
			PrototypeInstance[] factoryList = _FactoryList;
			foreach (PrototypeInstance prototypeInstance in factoryList)
			{
				if (!prototypeInstance._0002())
				{
					prototypeInstance.VerifyError();
				}
			}
			while (databaseList == (ComposerInstanceRule)2)
			{
				if (!m_HelperList.WaitOne())
				{
					continue;
				}
				factoryList = _FactoryList;
				foreach (PrototypeInstance prototypeInstance2 in factoryList)
				{
					if (prototypeInstance2._0001())
					{
						serializerList?.Invoke(this, new TemplateList(prototypeInstance2._0001(), prototypeInstance2._0001()));
						if (databaseList == (ComposerInstanceRule)2)
						{
							prototypeInstance2.VerifyError();
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NewDic(Exception item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			EventHandler<InstanceInstance> callbackList = _CallbackList;
			if (callbackList != null)
			{
				if (exceptionList == null)
				{
					callbackList(this, new InstanceInstance(item));
				}
				else
				{
					exceptionList.Post(delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						callbackList(this, new InstanceInstance(item));
					}, null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (databaseList != 0)
			{
				databaseList = (ComposerInstanceRule)3;
				m_HelperList.Set();
				FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.GetDic(m_AttributeList), "waveInStop");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public RefList _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SpecificationList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(RefList i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_SpecificationList = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(bool isitem)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (isitem)
			{
				if (databaseList != 0)
				{
					this._0002();
				}
				ForgotDic();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ForgotDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueueBroadcasterFilter.ChangeDic(m_AttributeList);
			if (_FactoryList != null)
			{
				for (int i = 0; i < _FactoryList.Length; i++)
				{
					_FactoryList[i]._0003();
				}
				_FactoryList = null;
			}
			QueueBroadcasterFilter.SetDic(m_AttributeList);
			m_AttributeList = IntPtr.Zero;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(isitem: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0008();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void IncludeDic(object i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveDic();
		}
	}
}
