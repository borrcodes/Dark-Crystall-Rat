using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	internal class WatcherErrorFilter : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WatcherErrorFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WatcherErrorFilter(string param)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(param);
		}
	}
}
