using GDBD.Filter;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace GDBD.Items
{
	internal sealed class DecoratorList : IDisposable
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public EventHandler<InstanceInstance> _0001;

			public DecoratorList _0002;

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

		private IntPtr m_FieldList;

		private volatile bool itemList;

		private PrototypeInstance[] _RegList;

		private readonly QueueBroadcasterFilter.InstanceInstanceRule _ProcessList;

		private ParserDicCandidate baseList;

		private readonly SynchronizationContext containerList;

		private int proccesorList;

		[CompilerGenerated]
		private EventHandler<TemplateList> adapterList;

		[CompilerGenerated]
		private EventHandler<InstanceInstance> m_TokenList;

		[CompilerGenerated]
		private int m_DispatcherList;

		[CompilerGenerated]
		private int accountList;

		[CompilerGenerated]
		private int m_SingletonList;

		[CompilerGenerated]
		private RefList modelList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoratorList()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(ParserDicCandidate.SelectDic());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoratorList(ParserDicCandidate init)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			containerList = SynchronizationContext.Current;
			if ((init._0001() == (ProgressReportingOption)1 || init._0001() == (ProgressReportingOption)2) && containerList == null)
			{
				throw new InvalidOperationException("Use WaveInEvent to record on a background thread");
			}
			_0003(0);
			_0001(new RefList(8000, 16, 1));
			_0001(100);
			_0002(3);
			_ProcessList = PrepareDic;
			baseList = init;
			init.DeleteDic(_ProcessList);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return QueueBroadcasterFilter.SearchDic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static FacadeErrorFilter PushDic(int last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FacadeErrorFilter vis = default(FacadeErrorFilter);
			int indexhelper = Marshal.SizeOf((object)vis);
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.ComputeDic((IntPtr)last, out vis, indexhelper), "waveInGetDevCaps");
			return vis;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(int info_Z)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_DispatcherList = info_Z;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(int remove_SETUPAt)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			accountList = remove_SETUPAt;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0003(int asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_SingletonList = asset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PrepareDic(IntPtr config, QueueBroadcasterFilter.BufferLoadResult selection, IntPtr serv, ServerErrorFilter connection2, IntPtr attr3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (selection == (QueueBroadcasterFilter.BufferLoadResult)960 && itemList)
			{
				PrototypeInstance prototypeInstance = (PrototypeInstance)((GCHandle)connection2._RuleList).Target;
				if (prototypeInstance != null)
				{
					proccesorList = Array.IndexOf(_RegList, prototypeInstance);
					AwakeDic(prototypeInstance);
					try
					{
						prototypeInstance.VerifyError();
					}
					catch (Exception asset)
					{
						itemList = false;
						UpdateDic(asset);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AwakeDic(PrototypeInstance setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			adapterList?.Invoke(this, new TemplateList(setup._0001(), setup._0001()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateDic(Exception asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			EventHandler<InstanceInstance> tokenList = m_TokenList;
			if (tokenList != null)
			{
				if (containerList == null)
				{
					tokenList(this, new InstanceInstance(asset));
				}
				else
				{
					containerList.Post(delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						tokenList(this, new InstanceInstance(asset));
					}, null);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!itemList)
			{
				return;
			}
			itemList = false;
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.GetDic(m_FieldList), "waveInStop");
			for (int i = 0; i < _RegList.Length; i++)
			{
				int num = (i + proccesorList + 1) % _RegList.Length;
				PrototypeInstance prototypeInstance = _RegList[num];
				if (prototypeInstance._0001())
				{
					AwakeDic(prototypeInstance);
				}
			}
			UpdateDic(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(RefList value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			modelList = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(bool isvalue)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (isvalue)
			{
				if (itemList)
				{
					_0002();
				}
				ReadDic();
				if (baseList != null)
				{
					baseList.TestDic();
					baseList = null;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_FieldList == IntPtr.Zero)
			{
				return;
			}
			QueueBroadcasterFilter.ChangeDic(m_FieldList);
			if (_RegList != null)
			{
				for (int i = 0; i < _RegList.Length; i++)
				{
					_RegList[i]._0003();
				}
				_RegList = null;
			}
			QueueBroadcasterFilter.SetDic(m_FieldList);
			m_FieldList = IntPtr.Zero;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001(isvalue: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0003();
		}
	}
}
