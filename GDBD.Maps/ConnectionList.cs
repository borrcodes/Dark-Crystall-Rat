using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GDBD.Maps
{
	internal sealed class ConnectionList : NativeWindow
	{
		private QueueBroadcasterFilter.InstanceInstanceRule initializerList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionList(QueueBroadcasterFilter.InstanceInstanceRule v)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			initializerList = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(ref Message key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueueBroadcasterFilter.BufferLoadResult msg = (QueueBroadcasterFilter.BufferLoadResult)key.Msg;
			switch (msg)
			{
			case (QueueBroadcasterFilter.BufferLoadResult)957:
			case (QueueBroadcasterFilter.BufferLoadResult)960:
			{
				IntPtr wParam = key.WParam;
				ServerErrorFilter serverErrorFilter = new ServerErrorFilter();
				Marshal.PtrToStructure(key.LParam, (object)serverErrorFilter);
				initializerList(wParam, msg, IntPtr.Zero, serverErrorFilter, IntPtr.Zero);
				break;
			}
			case (QueueBroadcasterFilter.BufferLoadResult)955:
			case (QueueBroadcasterFilter.BufferLoadResult)956:
			case (QueueBroadcasterFilter.BufferLoadResult)958:
			case (QueueBroadcasterFilter.BufferLoadResult)959:
				initializerList(key.WParam, msg, IntPtr.Zero, null, IntPtr.Zero);
				break;
			default:
				base.WndProc(ref key);
				break;
			}
		}
	}
}
