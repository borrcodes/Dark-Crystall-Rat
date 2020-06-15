using System;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	internal static class AttributeTestItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CompareEvent<T>(this object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (T)Convert.ChangeType(value, typeof(T));
		}
	}
}
