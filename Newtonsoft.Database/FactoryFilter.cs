using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Database
{
	[ComVisible(false)]
	internal static class FactoryFilter
	{
		public static readonly Guid serializerFilter;

		public static readonly Guid m_CallbackFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FactoryFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			serializerFilter = new Guid(89694080u, 50006, 4558, 191, 1, 0, 170, 0, 85, 89, 90);
			m_CallbackFilter = new Guid(4146755232u, 60170, 4560, 172, 228, 0, 0, 192, 204, 22, 186);
		}
	}
}
