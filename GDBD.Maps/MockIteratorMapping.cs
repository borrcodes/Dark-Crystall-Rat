using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Maps
{
	internal static class MockIteratorMapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int FillError<T>()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Marshal.SizeOf(typeof(T));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T RunError<T>(IntPtr task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (T)Marshal.PtrToStructure(task, typeof(T));
		}
	}
}
