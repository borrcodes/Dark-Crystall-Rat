using GDBD.Filter;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Dispatcher
{
	internal sealed class FactoryInstance : IDisposable
	{
		private readonly ServerErrorFilter m_SerializerInstance;

		private readonly int callbackInstance;

		private readonly byte[] _MerchantInstance;

		private readonly ProccesorEventEntry listenerInstance;

		private readonly object m_TagInstance;

		private GCHandle specificationInstance;

		private IntPtr m_WriterInstance;

		private GCHandle m_RoleInstance;

		private GCHandle _CreatorInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryInstance(IntPtr param, int selection, ProccesorEventEntry pool, object item2)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			callbackInstance = selection;
			_MerchantInstance = new byte[selection];
			specificationInstance = GCHandle.Alloc(_MerchantInstance, GCHandleType.Pinned);
			m_WriterInstance = param;
			listenerInstance = pool;
			m_TagInstance = item2;
			m_SerializerInstance = new ServerErrorFilter();
			m_RoleInstance = GCHandle.Alloc(m_SerializerInstance, GCHandleType.Pinned);
			m_SerializerInstance.m_WriterList = specificationInstance.AddrOfPinnedObject();
			m_SerializerInstance._RoleList = selection;
			m_SerializerInstance._ImporterList = 1;
			_CreatorInstance = GCHandle.Alloc(this);
			m_SerializerInstance._RuleList = (IntPtr)_CreatorInstance;
			lock (item2)
			{
				FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.InterruptDic(param, m_SerializerInstance, Marshal.SizeOf((object)m_SerializerInstance)), "waveOutPrepareHeader");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				FindError(getdef: false);
			}
			finally
			{
				base.Finalize();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GC.SuppressFinalize(this);
			FindError(getdef: true);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FindError(bool getdef)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RoleInstance.IsAllocated)
			{
				m_RoleInstance.Free();
			}
			if (specificationInstance.IsAllocated)
			{
				specificationInstance.Free();
			}
			if (_CreatorInstance.IsAllocated)
			{
				_CreatorInstance.Free();
			}
			if (m_WriterInstance != IntPtr.Zero)
			{
				lock (m_TagInstance)
				{
					QueueBroadcasterFilter.CalcDic(m_WriterInstance, m_SerializerInstance, Marshal.SizeOf((object)m_SerializerInstance));
				}
				m_WriterInstance = IntPtr.Zero;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ValidateError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num;
			lock (listenerInstance)
			{
				num = listenerInstance.Read(_MerchantInstance, 0, _MerchantInstance.Length);
			}
			if (num == 0)
			{
				return false;
			}
			for (int i = num; i < _MerchantInstance.Length; i++)
			{
				_MerchantInstance[i] = 0;
			}
			OrderError();
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (m_SerializerInstance._BridgeList & (TextPaddingOptions)16) == (TextPaddingOptions)16;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OrderError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MathOperator mathOperator;
			lock (m_TagInstance)
			{
				mathOperator = QueueBroadcasterFilter.InstantiateDic(m_WriterInstance, m_SerializerInstance, Marshal.SizeOf((object)m_SerializerInstance));
			}
			if (mathOperator != 0)
			{
				throw new FacadePropertyStruct(mathOperator, "waveOutWrite");
			}
			GC.KeepAlive(this);
		}
	}
}
