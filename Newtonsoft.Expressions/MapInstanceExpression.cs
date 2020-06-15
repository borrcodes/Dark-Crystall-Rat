using GDBD.Workers;
using Newtonsoft.Consumers;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	internal sealed class MapInstanceExpression : ProcTest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapInstanceExpression(Type info)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(info);
			_ErrorProperty = (ParameterFilterResolver)8;
		}
	}
}
