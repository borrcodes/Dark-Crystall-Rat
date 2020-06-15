using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Rules
{
	[ComVisible(false)]
	internal struct StateFilter
	{
		public int resolverFilter;

		public IntPtr _PoolFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Guid[] CancelInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Guid[] array = new Guid[resolverFilter];
			for (int i = 0; i < resolverFilter; i++)
			{
				IntPtr ptr = new IntPtr(_PoolFilter.ToInt64() + i * Marshal.SizeOf(typeof(Guid)));
				array[i] = (Guid)Marshal.PtrToStructure(ptr, typeof(Guid));
			}
			return array;
		}
	}
}
