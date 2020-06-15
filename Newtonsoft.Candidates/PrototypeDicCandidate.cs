using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Candidates
{
	[StructLayout(LayoutKind.Sequential)]
	[ComVisible(false)]
	internal sealed class PrototypeDicCandidate : IDisposable
	{
		public Guid procEvent;

		public Guid m_RecordFilter;

		[MarshalAs(UnmanagedType.Bool)]
		public bool _EventFilter;

		[MarshalAs(UnmanagedType.Bool)]
		public bool _FilterFilter;

		public int instanceFilter;

		public Guid m_DicFilter;

		public IntPtr m_ErrorFilter;

		public int composerFilter;

		public IntPtr propertyFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				_0001(isfirst: false);
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
			_0001(isfirst: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(bool isfirst)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (composerFilter != 0 && propertyFilter != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(propertyFilter);
				composerFilter = 0;
			}
			if (m_ErrorFilter != IntPtr.Zero)
			{
				Marshal.Release(m_ErrorFilter);
				m_ErrorFilter = IntPtr.Zero;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrototypeDicCandidate()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_EventFilter = true;
			instanceFilter = 1;
			base._002Ector();
		}
	}
}
