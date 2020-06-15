using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Annotations
{
	internal static class StructListAnnotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int CompareError(this COMException item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return item.ErrorCode;
		}
	}
}
