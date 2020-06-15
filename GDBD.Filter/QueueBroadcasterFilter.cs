using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Filter
{
	internal sealed class QueueBroadcasterFilter
	{
		[Flags]
		public enum EventAttributes
		{

		}

		public enum BufferLoadResult
		{

		}

		public delegate void InstanceInstanceRule(IntPtr, BufferLoadResult, IntPtr, ServerErrorFilter, IntPtr);

		[DllImport("winmm.dll", EntryPoint = "waveOutPrepareHeader")]
		public static extern MathOperator InterruptDic(IntPtr key, ServerErrorFilter connection, int no__role);

		[DllImport("winmm.dll", EntryPoint = "waveOutUnprepareHeader")]
		public static extern MathOperator CalcDic(IntPtr init, ServerErrorFilter cont, int indexcomp);

		[DllImport("winmm.dll", EntryPoint = "waveOutWrite")]
		public static extern MathOperator InstantiateDic(IntPtr task, ServerErrorFilter map, int column_helper);

		[DllImport("winmm.dll", EntryPoint = "waveOutOpen")]
		public static extern MathOperator ReflectDic(out IntPtr last, IntPtr result, RefList state, IntPtr param2, IntPtr ident3, EventAttributes pred4);

		[DllImport("winmm.dll", EntryPoint = "waveOutReset")]
		public static extern MathOperator ResetDic(IntPtr info);

		[DllImport("winmm.dll", EntryPoint = "waveOutClose")]
		public static extern MathOperator RegisterDic(IntPtr def);

		[DllImport("winmm.dll", EntryPoint = "waveOutRestart")]
		public static extern MathOperator RestartDic(IntPtr init);

		[DllImport("winmm.dll", EntryPoint = "waveInGetNumDevs")]
		public static extern int SearchDic();

		[DllImport("winmm.dll", CharSet = CharSet.Auto, EntryPoint = "waveInGetDevCaps")]
		public static extern MathOperator ComputeDic(IntPtr last, out FacadeErrorFilter vis, int indexhelper);

		[DllImport("winmm.dll", EntryPoint = "waveInAddBuffer")]
		public static extern MathOperator DestroyDic(IntPtr v, ServerErrorFilter caller, int state_Position);

		[DllImport("winmm.dll", EntryPoint = "waveInClose")]
		public static extern MathOperator SetDic(IntPtr item);

		[DllImport("winmm.dll", EntryPoint = "waveInOpen")]
		public static extern MathOperator RateDic(out IntPtr res, IntPtr caller, RefList state, IntPtr setup2, IntPtr config3, EventAttributes key4);

		[DllImport("winmm.dll", EntryPoint = "waveInPrepareHeader")]
		public static extern MathOperator RemoveDic(IntPtr param, ServerErrorFilter caller, int rowcontrol);

		[DllImport("winmm.dll", EntryPoint = "waveInUnprepareHeader")]
		public static extern MathOperator PostDic(IntPtr setup, ServerErrorFilter cont, int index_util);

		[DllImport("winmm.dll", EntryPoint = "waveInReset")]
		public static extern MathOperator ChangeDic(IntPtr last);

		[DllImport("winmm.dll", EntryPoint = "waveInStart")]
		public static extern MathOperator CalculateDic(IntPtr last);

		[DllImport("winmm.dll", EntryPoint = "waveInStop")]
		public static extern MathOperator GetDic(IntPtr ident);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueBroadcasterFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
