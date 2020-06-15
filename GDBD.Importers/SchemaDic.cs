using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	internal sealed class SchemaDic : RefDic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SchemaDic()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
