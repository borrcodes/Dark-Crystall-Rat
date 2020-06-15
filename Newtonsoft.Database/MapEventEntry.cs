using GDBD.Workers;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Database
{
	internal sealed class MapEventEntry
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CalcIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				HelperFilterResolver.InstantiateIterator();
			}
			catch (Exception)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapEventEntry()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
