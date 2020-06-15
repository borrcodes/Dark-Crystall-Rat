using _0008;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Dispatcher
{
	[_0008._0012(0)]
	internal sealed class FilterClassDispatcher : EventArgs
	{
		[CompilerGenerated]
		[_0008._0012(2)]
		private readonly object m_AccountTest;

		[CompilerGenerated]
		private readonly ValErrorFilter singletonTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilterClassDispatcher(object first, ValErrorFilter col)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_AccountTest = first;
			singletonTest = col;
		}
	}
}
