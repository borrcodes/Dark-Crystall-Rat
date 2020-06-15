using _0008;
using GDBD.Maps;
using GDBD.Workers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[_0008._0012(0)]
	internal class SetterClientBridge<[_0008._0012(2)] T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerable<string> _0001(T asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ObserverIteratorMapping.CheckProperty<string>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetterClientBridge()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
