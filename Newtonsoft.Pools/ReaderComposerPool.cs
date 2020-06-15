using GDBD.Workers;
using Newtonsoft.Filters;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal sealed class ReaderComposerPool : WatcherErrorFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReaderComposerPool()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReaderComposerPool(string first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(first);
		}
	}
}
