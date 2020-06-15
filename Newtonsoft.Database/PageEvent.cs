using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Database
{
	internal sealed class PageEvent : EventArgs
	{
		private string _HelperEvent;

		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _HelperEvent;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PageEvent(string setup)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_HelperEvent = setup;
		}
	}
}
