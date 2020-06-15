using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Rules
{
	internal sealed class TestInstanceRule
	{
		[DllImport("ole32.dll", EntryPoint = "PropVariantClear")]
		internal static extern int CloneError(IntPtr init);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TestInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
