using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using Newtonsoft.Database;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal sealed class ComparatorProperty : AccountEventEntry
	{
		private readonly object _ProcProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ComparatorProperty(object first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(first, "attributeProvider");
			_ProcProperty = first;
		}
	}
}
