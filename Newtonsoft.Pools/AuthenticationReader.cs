using GDBD.Structs;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal sealed class AuthenticationReader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InterruptIterator(AppDomain param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_001c: Incompatible stack heights: 0 vs 1
			ResolveEventHandler value = WorkerPropertyStruct.PrepareIterator;
			((AppDomain)/*Error near IL_0026: Stack underflow*/).AssemblyResolve += value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationReader()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
