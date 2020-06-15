using GDBD.Specifications;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	internal static class BridgeInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ResolveError(Type res, Guid cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FieldInfo[] fields = res.GetFields(BindingFlags.Static | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!fieldInfo.IsPublic || !fieldInfo.IsStatic || (object)fieldInfo.FieldType != typeof(Guid) || !((Guid)fieldInfo.GetValue(null) == cont))
				{
					continue;
				}
				object[] customAttributes = fieldInfo.GetCustomAttributes(inherit: false);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					FieldClassSpec fieldClassSpec = customAttributes[j] as FieldClassSpec;
					if (fieldClassSpec != null)
					{
						return fieldClassSpec._0001();
					}
				}
				return fieldInfo.Name;
			}
			return cont.ToString();
		}
	}
}
