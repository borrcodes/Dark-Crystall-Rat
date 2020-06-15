using System;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	internal static class ContextClientBridge
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RunClient(object ident, string selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident == null)
			{
				throw new ArgumentNullException(selection);
			}
		}
	}
}
