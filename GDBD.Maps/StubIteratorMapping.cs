using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	internal sealed class StubIteratorMapping : ProccesorClassSpec
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StubIteratorMapping(Type key)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(key);
			_ErrorProperty = (ParameterFilterResolver)4;
		}
	}
}
