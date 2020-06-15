using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Structs
{
	internal sealed class PrototypeInstance : IDisposable
	{
		private readonly ServerErrorFilter parserInstance;

		private readonly int statusInstance;

		private readonly byte[] m_PageInstance;

		private GCHandle m_HelperInstance;

		private IntPtr m_ExceptionInstance;

		private GCHandle m_AttributeInstance;

		private GCHandle m_DatabaseInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrototypeInstance(IntPtr task, int attrsize)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			statusInstance = attrsize;
			m_PageInstance = new byte[attrsize];
			m_HelperInstance = GCHandle.Alloc(m_PageInstance, GCHandleType.Pinned);
			m_ExceptionInstance = task;
			parserInstance = new ServerErrorFilter();
			m_AttributeInstance = GCHandle.Alloc(parserInstance, GCHandleType.Pinned);
			parserInstance.m_WriterList = m_HelperInstance.AddrOfPinnedObject();
			parserInstance._RoleList = attrsize;
			parserInstance._ImporterList = 1;
			m_DatabaseInstance = GCHandle.Alloc(this);
			parserInstance._RuleList = (IntPtr)m_DatabaseInstance;
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.RemoveDic(task, parserInstance, Marshal.SizeOf((object)parserInstance)), "waveInPrepareHeader");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VerifyError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.PostDic(m_ExceptionInstance, parserInstance, Marshal.SizeOf((object)parserInstance)), "waveUnprepareHeader");
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.RemoveDic(m_ExceptionInstance, parserInstance, Marshal.SizeOf((object)parserInstance)), "waveInPrepareHeader");
			FacadePropertyStruct.VisitDic(QueueBroadcasterFilter.DestroyDic(m_ExceptionInstance, parserInstance, Marshal.SizeOf((object)parserInstance)), "waveInAddBuffer");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				PatchError(noi: false);
			}
			finally
			{
				base.Finalize();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GC.SuppressFinalize(this);
			PatchError(noi: true);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PatchError(bool noi)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ExceptionInstance != IntPtr.Zero)
			{
				QueueBroadcasterFilter.PostDic(m_ExceptionInstance, parserInstance, Marshal.SizeOf((object)parserInstance));
				m_ExceptionInstance = IntPtr.Zero;
			}
			if (m_AttributeInstance.IsAllocated)
			{
				m_AttributeInstance.Free();
			}
			if (m_HelperInstance.IsAllocated)
			{
				m_HelperInstance.Free();
			}
			if (m_DatabaseInstance.IsAllocated)
			{
				m_DatabaseInstance.Free();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PageInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (parserInstance._BridgeList & (TextPaddingOptions)1) == (TextPaddingOptions)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (parserInstance._BridgeList & (TextPaddingOptions)16) == (TextPaddingOptions)16;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return parserInstance._CreatorList;
		}
	}
}
