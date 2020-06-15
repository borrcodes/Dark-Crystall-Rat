using GDBD.Workers;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace GDBD.Mocks
{
	internal sealed class IteratorIssuerMock : EventArgs
	{
		private Bitmap m_StatusEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IteratorIssuerMock(Bitmap info)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_StatusEvent = info;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bitmap DefineList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_StatusEvent;
		}
	}
}
