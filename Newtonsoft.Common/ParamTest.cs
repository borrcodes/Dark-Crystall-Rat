using _0008;
using GDBD.Dispatcher;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	[_0008._0012(0)]
	internal static class ParamTest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MemberTypes DefineReader(this MemberInfo last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return last.MemberType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CollectReader(this Type spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return spec.ContainsGenericParameters;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SortReader(this Type spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return spec.IsInterface;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CallReader(this Type res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return res.IsGenericType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PublishReader(this Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return task.IsGenericTypeDefinition;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type WriteReader(this Type first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return first.BaseType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Assembly RevertReader(this Type asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return asset.Assembly;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LoginClient(this Type asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return asset.IsEnum;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckClient(this Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return info.IsClass;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DisableClient(this Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return reference.IsSealed;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool VerifyClient(this Type init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return init.IsAbstract;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PatchClient(this Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return info.IsVisible;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FindClient(this Type def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return def.IsValueType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ValidateClient(this Type first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return first.IsPrimitive;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool OrderClient(this Type setup, string counter, bool iscontrol, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out Type _0005)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = setup;
			while (type != null)
			{
				if (string.Equals(type.FullName, counter, StringComparison.Ordinal))
				{
					_0005 = type;
					return true;
				}
				type = type.WriteReader();
			}
			if (iscontrol)
			{
				Type[] interfaces = setup.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (string.Equals(interfaces[i].Name, counter, StringComparison.Ordinal))
					{
						_0005 = setup;
						return true;
					}
				}
			}
			_0005 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ResolveClient(this Type task, string caller, bool createhelper)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type _0005;
			return task.OrderClient(caller, createhelper, out _0005);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FillClient(this Type init, Type caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = init;
			while (type != null)
			{
				foreach (Type item in (IEnumerable<Type>)type.GetInterfaces())
				{
					if (item == caller || (item != null && item.FillClient(caller)))
					{
						return true;
					}
				}
				type = type.WriteReader();
			}
			return false;
		}
	}
}
