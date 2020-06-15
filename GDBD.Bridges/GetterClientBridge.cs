using _0008;
using GDBD.Specifications;
using GDBD.Workers;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[_0008._0012(new byte[]
	{
		0,
		1
	})]
	internal sealed class GetterClientBridge : Collection<BroadcasterError>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GetterClientBridge()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
