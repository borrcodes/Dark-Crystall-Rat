using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	internal sealed class InstanceInstance : EventArgs
	{
		private readonly Exception _DicInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InstanceInstance(Exception init = null)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_DicInstance = init;
		}
	}
}
