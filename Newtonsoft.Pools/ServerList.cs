using Newtonsoft.Expressions;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Pools
{
	internal sealed class ServerList : IDisposable, ResolverList
	{
		private IntPtr facadeList;

		private int _ManagerList;

		private readonly int _StateList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (facadeList != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(facadeList);
				facadeList = IntPtr.Zero;
				GC.SuppressFinalize(this);
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				_0001();
			}
			finally
			{
				base.Finalize();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(int instancePtr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instancePtr > _StateList)
			{
				return -2147483645;
			}
			_ManagerList = instancePtr;
			return 0;
		}

		int ResolverList._0002(int instancePtr)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(instancePtr);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(out int value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			value = _StateList;
			return 0;
		}

		int ResolverList._0002(out int value)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(out value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0001(IntPtr res, IntPtr cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (res != IntPtr.Zero)
			{
				Marshal.WriteIntPtr(res, facadeList);
			}
			if (cfg != IntPtr.Zero)
			{
				Marshal.WriteInt32(cfg, _ManagerList);
			}
			return 0;
		}

		int ResolverList._0002(IntPtr res, IntPtr cfg)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(res, cfg);
		}
	}
}
