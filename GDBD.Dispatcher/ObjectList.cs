using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GDBD.Dispatcher
{
	internal sealed class ObjectList : Form
	{
		private QueueBroadcasterFilter.InstanceInstanceRule m_SchemaList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectList(QueueBroadcasterFilter.InstanceInstanceRule key)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_SchemaList = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(ref Message i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueueBroadcasterFilter.BufferLoadResult msg = (QueueBroadcasterFilter.BufferLoadResult)i.Msg;
			switch (msg)
			{
			case (QueueBroadcasterFilter.BufferLoadResult)957:
			case (QueueBroadcasterFilter.BufferLoadResult)960:
			{
				IntPtr wParam = i.WParam;
				ServerErrorFilter serverErrorFilter = new ServerErrorFilter();
				Marshal.PtrToStructure(i.LParam, (object)serverErrorFilter);
				m_SchemaList(wParam, msg, IntPtr.Zero, serverErrorFilter, IntPtr.Zero);
				break;
			}
			case (QueueBroadcasterFilter.BufferLoadResult)955:
			case (QueueBroadcasterFilter.BufferLoadResult)956:
			case (QueueBroadcasterFilter.BufferLoadResult)958:
			case (QueueBroadcasterFilter.BufferLoadResult)959:
				m_SchemaList(i.WParam, msg, IntPtr.Zero, null, IntPtr.Zero);
				break;
			default:
				WndProc(ref i);
				break;
			}
		}
	}
}
