using _0008;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[Serializable]
	[_0008._0012(0)]
	public class ListenerTestItem : Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ListenerTestItem()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ListenerTestItem(string reference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ListenerTestItem(string def, Exception cont)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(def, cont);
		}
	}
}
