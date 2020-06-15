using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	[_0008._0012(0)]
	internal static class ObserverIteratorMapping
	{
		private static class EventClassDispatcher<[_0008._0012(2)] T>
		{
			[_0008._0012(1)]
			public static readonly T[] _GetterComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static EventClassDispatcher()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_GetterComposer = new T[0];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CancelTest<[_0008._0012(2)] T>(ICollection<T> info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info != null)
			{
				return info.Count == 0;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ExcludeTest<[_0008._0012(2)] T>(this IList<T> spec, IEnumerable<T> caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (spec == null)
			{
				throw new ArgumentNullException("initial");
			}
			if (caller != null)
			{
				foreach (T item in caller)
				{
					spec.Add(item);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetupTest(Type value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(value, "type");
			if (typeof(IDictionary).IsAssignableFrom(value))
			{
				return true;
			}
			if (ResolverErrorFilter.ResolveReader(value, typeof(IDictionary<, >)))
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo ManageTest(Type first, Type caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type filter = typeof(IList<>).MakeGenericType(caller);
			return InitTest(first, caller, filter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo InitTest(Type v, Type vis, Type filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type left = typeof(IEnumerable<>).MakeGenericType(vis);
			ConstructorInfo constructorInfo = null;
			ConstructorInfo[] constructors = v.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			foreach (ConstructorInfo constructorInfo2 in constructors)
			{
				IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
				if (parameters.Count == 1)
				{
					Type parameterType = parameters[0].ParameterType;
					if (left == parameterType)
					{
						constructorInfo = constructorInfo2;
						break;
					}
					if (constructorInfo == null && parameterType.IsAssignableFrom(filter))
					{
						constructorInfo = constructorInfo2;
					}
				}
			}
			return constructorInfo;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int DefineTest<[_0008._0012(2)] T>(this IEnumerable<T> res, Func<T, bool> connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 0;
			foreach (T re in res)
			{
				if (connection(re))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CollectTest<[_0008._0012(2)] T>(this List<T> v, T attr, IEqualityComparer control)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			for (int i = 0; i < v.Count; i++)
			{
				if (control.Equals(attr, v[i]))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int SortTest<[_0008._0012(2)] T>(this List<T> reference, T visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			for (int i = 0; i < reference.Count; i++)
			{
				if ((object)visitor == (object)reference[i])
				{
					return i;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CallTest<[_0008._0012(2)] T>(this List<T> first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 0;
			int num2 = first.Count - 1;
			while (num < num2)
			{
				T value = first[num];
				first[num] = first[num2];
				first[num2] = value;
				num++;
				num2--;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IList<int> PublishTest(IList first, int flags_cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<int> list = new List<int>();
			IList list2 = first;
			while (true)
			{
				list.Add(list2.Count);
				if (list.Count == flags_cust || list2.Count == 0)
				{
					break;
				}
				IList list3 = list2[0] as IList;
				if (list3 == null)
				{
					break;
				}
				list2 = list3;
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WriteTest(IList setup, Array vis, int[] temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = temp.Length;
			if (num == vis.Rank)
			{
				vis.SetValue(RevertTest(setup, temp), temp);
				return;
			}
			int length = vis.GetLength(num);
			if (((IList)RevertTest(setup, temp)).Count != length)
			{
				throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
			}
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = temp[i];
			}
			for (int j = 0; j < vis.GetLength(num); j++)
			{
				array[num] = j;
				WriteTest(setup, vis, array);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object RevertTest(IList item, int[] vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList list = item;
			for (int i = 0; i < vis.Length; i++)
			{
				int index = vis[i];
				if (i == vis.Length - 1)
				{
					return list[index];
				}
				list = (IList)list[index];
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Array LoginProperty(IList task, Type second, int temp_length)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<int> list = PublishTest(task, temp_length);
			while (list.Count < temp_length)
			{
				list.Add(0);
			}
			Array array = Array.CreateInstance(second, list.ToArray());
			WriteTest(task, array, CheckProperty<int>());
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] CheckProperty<[_0008._0012(2)] T>()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return EventClassDispatcher<T>._GetterComposer;
		}
	}
}
