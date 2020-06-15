using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Database
{
	[ComVisible(false)]
	internal static class BaseEventEntry
	{
		public static readonly Guid _ContainerFilter;

		public static readonly Guid m_ProccesorFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BaseEventEntry()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ContainerFilter = new Guid(4218176129u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);
			m_ProccesorFilter = new Guid(4218176138u, 851, 4561, 144, 95, 0, 0, 192, 204, 22, 186);
		}
	}
}
