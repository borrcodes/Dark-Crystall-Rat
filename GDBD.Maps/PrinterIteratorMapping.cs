using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Maps
{
	[ComVisible(false)]
	internal static class PrinterIteratorMapping
	{
		public static readonly Guid m_AdapterFilter;

		public static readonly Guid _TokenFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrinterIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_AdapterFilter = new Guid(2893646816u, 39139, 4561, 179, 241, 0, 170, 0, 55, 97, 197);
			_TokenFilter = new Guid(2893646817u, 39139, 4561, 179, 241, 0, 170, 0, 55, 97, 197);
		}
	}
}
