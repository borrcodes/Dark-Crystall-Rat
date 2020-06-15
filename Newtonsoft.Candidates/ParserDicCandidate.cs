using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	internal sealed class ParserDicCandidate
	{
		[CompilerGenerated]
		private ProgressReportingOption mappingInstance;

		[CompilerGenerated]
		private IntPtr _MockInstance;

		private ObjectList m_ObserverInstance;

		private ConnectionList _DescriptorInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ProgressReportingOption _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return mappingInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(ProgressReportingOption key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			mappingInstance = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public IntPtr _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _MockInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(IntPtr reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_MockInstance = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ParserDicCandidate SelectDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ParserDicCandidate((ProgressReportingOption)1, IntPtr.Zero);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParserDicCandidate(ProgressReportingOption ident, IntPtr col)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001(ident);
			_0001(col);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DeleteDic(QueueBroadcasterFilter.InstanceInstanceRule value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() == (ProgressReportingOption)1)
			{
				m_ObserverInstance = new ObjectList(value);
				m_ObserverInstance.CreateControl();
				_0001(m_ObserverInstance.Handle);
			}
			else if (this._0001() == (ProgressReportingOption)2)
			{
				_DescriptorInstance = new ConnectionList(value);
				_DescriptorInstance.AssignHandle(this._0001());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void TestDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ObserverInstance != null)
			{
				m_ObserverInstance.Close();
				m_ObserverInstance = null;
			}
			if (_DescriptorInstance != null)
			{
				_DescriptorInstance.ReleaseHandle();
				_DescriptorInstance = null;
			}
		}
	}
}
