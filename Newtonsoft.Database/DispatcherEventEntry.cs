using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Database
{
	[_0008._0012(0)]
	internal sealed class DispatcherEventEntry<[_0008._0012(2)] T, [_0008._0012(2)] TT>
	{
		private readonly ConcurrentDictionary<T, TT> rulesTest;

		private readonly Func<T, TT> contextTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DispatcherEventEntry(Func<T, TT> config)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(config, "creator");
			contextTest = config;
			rulesTest = new ConcurrentDictionary<T, TT>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TT InitReader(T res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return rulesTest.GetOrAdd(res, contextTest);
		}
	}
}
