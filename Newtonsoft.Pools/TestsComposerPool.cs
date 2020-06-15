using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Filters;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal sealed class TestsComposerPool : ProducerIteratorMapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TestsComposerPool()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string _0001(string task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SetterTest.AssetReader(task);
		}
	}
}
