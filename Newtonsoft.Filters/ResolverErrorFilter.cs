using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	internal static class ResolverErrorFilter
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class RepositoryTest
		{
			[_0008._0012(0)]
			public static readonly RepositoryTest serverTest;

			[_0008._0012(0)]
			public static Func<ConstructorInfo, bool> facadeTest;

			[_0008._0012(0)]
			public static Func<MemberInfo, string> m_ManagerTest;

			[_0008._0012(0)]
			public static Func<ParameterInfo, Type> _StateTest;

			[_0008._0012(0)]
			public static Func<FieldInfo, bool> _ResolverTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RepositoryTest()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				serverTest = new RepositoryTest();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RepositoryTest()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ResetReader(ConstructorInfo ident)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return !ident.GetParameters().Any();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string RegisterReader(MemberInfo task)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return task.Name;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Type RestartReader(ParameterInfo def)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return def.ParameterType;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool SearchReader(FieldInfo var1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return var1.IsPrivate;
			}
		}

		[CompilerGenerated]
		private sealed class _0001
		{
			[_0008._0012(0)]
			public MemberInfo _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(MemberInfo P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0.DeclaringType == this._0001.DeclaringType;
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(0)]
			public PropertyInfo _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(PropertyInfo P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0.Name == this._0001.Name;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0002(PropertyInfo P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (P_0.Name == this._0001.Name)
				{
					return P_0.DeclaringType == this._0001.DeclaringType;
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			[_0008._0012(0)]
			public Type _0001;

			[_0008._0012(0)]
			public _0002 _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0003()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(PropertyInfo P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (P_0.Name == _0002._0001.Name && P_0.DefineIssuer())
				{
					return (P_0.CollectIssuer()?.DeclaringType ?? P_0.DeclaringType).IsAssignableFrom(this._0001);
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			[_0008._0012(0)]
			public string _0001;

			[_0008._0012(0)]
			public Type _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0004()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(MethodInfo P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (P_0.Name == this._0001 && P_0.DeclaringType != _0002)
				{
					return P_0.GetBaseDefinition().DeclaringType == _0002;
				}
				return false;
			}
		}

		public static readonly Type[] collectionTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ResolverErrorFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			collectionTest = Type.EmptyTypes;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DefineIssuer(this PropertyInfo v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(v, "propertyInfo");
			MethodInfo getMethod = v.GetGetMethod(nonPublic: true);
			if (getMethod != null && getMethod.IsVirtual)
			{
				return true;
			}
			getMethod = v.GetSetMethod(nonPublic: true);
			if (getMethod != null && getMethod.IsVirtual)
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MethodInfo CollectIssuer(this PropertyInfo reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(reference, "propertyInfo");
			MethodInfo getMethod = reference.GetGetMethod(nonPublic: true);
			if (getMethod != null)
			{
				return getMethod.GetBaseDefinition();
			}
			return reference.GetSetMethod(nonPublic: true)?.GetBaseDefinition();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SortIssuer(PropertyInfo config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo getMethod = config.GetGetMethod();
			if (getMethod != null && getMethod.IsPublic)
			{
				return true;
			}
			MethodInfo setMethod = config.GetSetMethod();
			if (setMethod != null && setMethod.IsPublic)
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type CallIssuer(object info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return info?.GetType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PublishIssuer(Type info, RollbackTransactionGrbit cont, UtilsRequestStrategy consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = WriteIssuer(info, consumer);
			switch (cont)
			{
			case (RollbackTransactionGrbit)0:
				return RevertIssuer(text);
			case (RollbackTransactionGrbit)1:
				return text;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string WriteIssuer(Type def, UtilsRequestStrategy caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (caller != null)
			{
				caller.BindToName(def, out string cont, out string tag);
				return tag + ((cont == null) ? "" : (", " + cont));
			}
			return def.AssemblyQualifiedName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string RevertIssuer(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			bool flag2 = false;
			foreach (char c in value)
			{
				switch (c)
				{
				case '[':
				case ']':
					flag = false;
					flag2 = false;
					stringBuilder.Append(c);
					break;
				case ',':
					if (!flag)
					{
						flag = true;
						stringBuilder.Append(c);
					}
					else
					{
						flag2 = true;
					}
					break;
				default:
					if (!flag2)
					{
						stringBuilder.Append(c);
					}
					break;
				}
			}
			return stringBuilder.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LoginReader(Type value, bool isconnection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(value, "t");
			if (value.FindClient())
			{
				return true;
			}
			return DisableReader(value, isconnection) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo CheckReader(Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return DisableReader(info, ismap: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo DisableReader(Type value, bool ismap)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
			if (ismap)
			{
				bindingFlags |= BindingFlags.NonPublic;
			}
			return value.GetConstructors(bindingFlags).SingleOrDefault((ConstructorInfo ident) => !ident.GetParameters().Any());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool VerifyReader(Type param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "t");
			if (param.FindClient())
			{
				return PatchReader(param);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PatchReader(Type spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(spec, "t");
			if (spec.CallReader())
			{
				return spec.GetGenericTypeDefinition() == typeof(Nullable<>);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type FindReader(Type var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!PatchReader(var1))
			{
				return var1;
			}
			return Nullable.GetUnderlyingType(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type ValidateReader(Type item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!item.IsByRef || !item.HasElementType)
			{
				return item;
			}
			return item.GetElementType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool OrderReader(Type i, Type map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!i.CallReader())
			{
				return false;
			}
			return i.GetGenericTypeDefinition() == map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ResolveReader(Type instance, Type caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type _0004;
			return FillReader(instance, caller, out _0004);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FillReader(Type ident, Type b, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out Type _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(ident, "type");
			ContextClientBridge.RunClient(b, "genericInterfaceDefinition");
			if (!b.SortReader() || !b.PublishReader())
			{
				throw new ArgumentNullException("'{0}' is not a generic interface definition.".ListReader(CultureInfo.InvariantCulture, b));
			}
			if (ident.SortReader() && ident.CallReader())
			{
				Type genericTypeDefinition = ident.GetGenericTypeDefinition();
				if (b == genericTypeDefinition)
				{
					_0004 = ident;
					return true;
				}
			}
			Type[] interfaces = ident.GetInterfaces();
			foreach (Type type in interfaces)
			{
				if (type.CallReader())
				{
					Type genericTypeDefinition2 = type.GetGenericTypeDefinition();
					if (b == genericTypeDefinition2)
					{
						_0004 = type;
						return true;
					}
				}
			}
			_0004 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RunReader(Type key, Type result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type _0004;
			return CompareReader(key, result, out _0004);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CompareReader(Type first, Type second, [_0008._0012(2)] out Type _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(first, "type");
			ContextClientBridge.RunClient(second, "genericClassDefinition");
			if (!second.CheckClient() || !second.PublishReader())
			{
				throw new ArgumentNullException("'{0}' is not a generic class definition.".ListReader(CultureInfo.InvariantCulture, second));
			}
			return AddReader(first, second, out _0004);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool AddReader(Type item, Type visitor, [_0008._0012(2)] out Type _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			do
			{
				if (item.CallReader() && visitor == item.GetGenericTypeDefinition())
				{
					_0004 = item;
					return true;
				}
				item = item.WriteReader();
			}
			while (item != null);
			_0004 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type EnableReader(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(last, "type");
			if (last.IsArray)
			{
				return last.GetElementType();
			}
			if (FillReader(last, typeof(IEnumerable<>), out Type _0004))
			{
				if (_0004.PublishReader())
				{
					throw new Exception("Type {0} is not a collection.".ListReader(CultureInfo.InvariantCulture, last));
				}
				return _0004.GetGenericArguments()[0];
			}
			if (typeof(IEnumerable).IsAssignableFrom(last))
			{
				return null;
			}
			throw new Exception("Type {0} is not a collection.".ListReader(CultureInfo.InvariantCulture, last));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MapReader([_0008._0012(1)] Type _0002, out Type second, out Type util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(_0002, "dictionaryType");
			if (FillReader(_0002, typeof(IDictionary<, >), out Type _0004))
			{
				if (_0004.PublishReader())
				{
					throw new Exception("Type {0} is not a dictionary.".ListReader(CultureInfo.InvariantCulture, _0002));
				}
				Type[] genericArguments = _0004.GetGenericArguments();
				second = genericArguments[0];
				util = genericArguments[1];
			}
			else
			{
				if (!typeof(IDictionary).IsAssignableFrom(_0002))
				{
					throw new Exception("Type {0} is not a dictionary.".ListReader(CultureInfo.InvariantCulture, _0002));
				}
				second = null;
				util = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type InsertReader(MemberInfo reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(reference, "member");
			switch (reference.DefineReader())
			{
			case MemberTypes.Field:
				return ((FieldInfo)reference).FieldType;
			case MemberTypes.Property:
				return ((PropertyInfo)reference).PropertyType;
			case MemberTypes.Event:
				return ((EventInfo)reference).EventHandlerType;
			case MemberTypes.Method:
				return ((MethodInfo)reference).ReturnType;
			default:
				throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "member");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FlushReader(Type value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!value.FindClient())
			{
				return false;
			}
			Attribute[] array = ForgotReader(value, null, controlopen: false);
			for (int i = 0; i < array.Length; i++)
			{
				if (string.Equals(array[i].GetType().FullName, "System.Runtime.CompilerServices.IsByRefLikeAttribute", StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CreateReader(PropertyInfo value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(value, "property");
			return value.GetIndexParameters().Length != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object StopReader(MemberInfo ident, object caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(ident, "member");
			ContextClientBridge.RunClient(caller, "target");
			switch (ident.DefineReader())
			{
			case MemberTypes.Field:
				return ((FieldInfo)ident).GetValue(caller);
			case MemberTypes.Property:
				try
				{
					return ((PropertyInfo)ident).GetValue(caller, null);
				}
				catch (TargetParameterCountException innerException)
				{
					throw new ArgumentException("MemberInfo '{0}' has index parameters".ListReader(CultureInfo.InvariantCulture, ident.Name), innerException);
				}
			default:
				throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".ListReader(CultureInfo.InvariantCulture, ident.Name), "member");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CloneReader(MemberInfo info, object col, object dic)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(info, "member");
			ContextClientBridge.RunClient(col, "target");
			switch (info.DefineReader())
			{
			case MemberTypes.Field:
				((FieldInfo)info).SetValue(col, dic);
				break;
			case MemberTypes.Property:
				((PropertyInfo)info).SetValue(col, dic, null);
				break;
			default:
				throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".ListReader(CultureInfo.InvariantCulture, info.Name), "member");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LogoutReader(MemberInfo info, bool updateb)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (info.DefineReader())
			{
			case MemberTypes.Field:
			{
				FieldInfo fieldInfo = (FieldInfo)info;
				if (updateb)
				{
					return true;
				}
				if (fieldInfo.IsPublic)
				{
					return true;
				}
				return false;
			}
			case MemberTypes.Property:
			{
				PropertyInfo propertyInfo = (PropertyInfo)info;
				if (!propertyInfo.CanRead)
				{
					return false;
				}
				if (updateb)
				{
					return true;
				}
				return propertyInfo.GetGetMethod(updateb) != null;
			}
			default:
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool VisitReader(MemberInfo value, bool calcconnection, bool addrule)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (value.DefineReader())
			{
			case MemberTypes.Field:
			{
				FieldInfo fieldInfo = (FieldInfo)value;
				if (fieldInfo.IsLiteral)
				{
					return false;
				}
				if (fieldInfo.IsInitOnly && !addrule)
				{
					return false;
				}
				if (calcconnection)
				{
					return true;
				}
				if (fieldInfo.IsPublic)
				{
					return true;
				}
				return false;
			}
			case MemberTypes.Property:
			{
				PropertyInfo propertyInfo = (PropertyInfo)value;
				if (!propertyInfo.CanWrite)
				{
					return false;
				}
				if (calcconnection)
				{
					return true;
				}
				return propertyInfo.GetSetMethod(calcconnection) != null;
			}
			default:
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<MemberInfo> ViewReader(Type res, BindingFlags vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<MemberInfo> list = new List<MemberInfo>();
			list.AddRange(AwakeReader(res, vis));
			list.AddRange(ReadReader(res, vis));
			List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
			foreach (IGrouping<string, MemberInfo> item in from task in list
				group task by task.Name)
			{
				if (item.Count() == 1)
				{
					list2.Add(item.First());
				}
				else
				{
					List<MemberInfo> list3 = new List<MemberInfo>();
					foreach (MemberInfo current2 in item)
					{
						if (list3.Count == 0)
						{
							list3.Add(current2);
						}
						else if ((!ConnectReader(current2, vis) || current2.Name == "Item") && !list3.Any((MemberInfo P_0) => P_0.DeclaringType == current2.DeclaringType))
						{
							list3.Add(current2);
						}
					}
					list2.AddRange(list3);
				}
			}
			return list2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ConnectReader(MemberInfo i, BindingFlags cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i.DefineReader() != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)i;
			if (!propertyInfo.DefineIssuer())
			{
				return false;
			}
			Type declaringType = propertyInfo.DeclaringType;
			if (!declaringType.CallReader())
			{
				return false;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, cont);
			if (member.Length == 0)
			{
				return false;
			}
			if (!InsertReader(member[0]).IsGenericParameter)
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T MoveReader<[_0008._0012(0)] T>(object init) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PopReader<T>(init, iscounter: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T PopReader<[_0008._0012(0)] T>(object i, bool iscounter) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			T[] array = NewReader<T>(i, iscounter);
			if (array == null)
			{
				return null;
			}
			return array.FirstOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] NewReader<[_0008._0012(0)] T>(object asset, bool removeresult) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Attribute[] array = ForgotReader(asset, typeof(T), removeresult);
			T[] array2 = array as T[];
			if (array2 != null)
			{
				return array2;
			}
			return array.Cast<T>().ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Attribute[] ForgotReader(object task, Type reg, bool controlopen)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(task, "attributeProvider");
			Type type = task as Type;
			if ((object)type == null)
			{
				Assembly assembly = task as Assembly;
				if ((object)assembly == null)
				{
					MemberInfo memberInfo = task as MemberInfo;
					if ((object)memberInfo == null)
					{
						Module module = task as Module;
						if ((object)module == null)
						{
							ParameterInfo parameterInfo = task as ParameterInfo;
							if (parameterInfo != null)
							{
								if (!(reg != null))
								{
									return Attribute.GetCustomAttributes(parameterInfo, controlopen);
								}
								return Attribute.GetCustomAttributes(parameterInfo, reg, controlopen);
							}
							ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)task;
							return (Attribute[])((reg != null) ? customAttributeProvider.GetCustomAttributes(reg, controlopen) : customAttributeProvider.GetCustomAttributes(controlopen));
						}
						if (!(reg != null))
						{
							return Attribute.GetCustomAttributes(module, controlopen);
						}
						return Attribute.GetCustomAttributes(module, reg, controlopen);
					}
					if (!(reg != null))
					{
						return Attribute.GetCustomAttributes(memberInfo, controlopen);
					}
					return Attribute.GetCustomAttributes(memberInfo, reg, controlopen);
				}
				if (!(reg != null))
				{
					return Attribute.GetCustomAttributes(assembly);
				}
				return Attribute.GetCustomAttributes(assembly, reg);
			}
			return ((reg != null) ? type.GetCustomAttributes(reg, controlopen) : type.GetCustomAttributes(controlopen)).Cast<Attribute>().ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GDBD.Workers.TemplateComposerWorker<string, string> IncludeReader(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int? num = PushReader(instance);
			string col;
			string i;
			if (num.HasValue)
			{
				col = instance.ManageReader(0, num.GetValueOrDefault());
				i = instance.ManageReader(num.GetValueOrDefault() + 1, instance.Length - num.GetValueOrDefault() - 1);
			}
			else
			{
				col = instance;
				i = null;
			}
			return new GDBD.Workers.TemplateComposerWorker<string, string>(i, col);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int? PushReader(string info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 0;
			for (int i = 0; i < info.Length; i++)
			{
				switch (info[i])
				{
				case '[':
					num++;
					break;
				case ']':
					num--;
					break;
				case ',':
					if (num == 0)
					{
						return i;
					}
					break;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MemberInfo PrepareReader(Type i, MemberInfo result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (result.DefineReader() == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)result;
				Type[] types = (from def in propertyInfo.GetIndexParameters()
					select def.ParameterType).ToArray();
				return i.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
			}
			return i.GetMember(result.Name, result.DefineReader(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<FieldInfo> AwakeReader(Type setup, BindingFlags ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(setup, "targetType");
			List<MemberInfo> list = new List<MemberInfo>(setup.GetFields(ord));
			UpdateReader(list, setup, ord);
			return list.Cast<FieldInfo>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void UpdateReader(IList<MemberInfo> i, Type ord, BindingFlags res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((res & BindingFlags.NonPublic) != 0)
			{
				BindingFlags bindingAttr = res.InterruptReader(BindingFlags.Public);
				while ((ord = ord.WriteReader()) != null)
				{
					IEnumerable<FieldInfo> caller = from var1 in ord.GetFields(bindingAttr)
						where var1.IsPrivate
						select var1;
					i.ExcludeTest(caller);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<PropertyInfo> ReadReader(Type param, BindingFlags pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "targetType");
			List<PropertyInfo> list = new List<PropertyInfo>(param.GetProperties(pred));
			if (param.SortReader())
			{
				Type[] interfaces = param.GetInterfaces();
				foreach (Type type in interfaces)
				{
					list.AddRange(type.GetProperties(pred));
				}
			}
			CalcReader(list, param, pred);
			for (int j = 0; j < list.Count; j++)
			{
				PropertyInfo propertyInfo = list[j];
				if (propertyInfo.DeclaringType != param)
				{
					PropertyInfo propertyInfo3 = list[j] = (PropertyInfo)PrepareReader(propertyInfo.DeclaringType, propertyInfo);
				}
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BindingFlags InterruptReader(this BindingFlags first, BindingFlags cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((first & cont) != cont)
			{
				return first;
			}
			return first ^ cont;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CalcReader(IList<PropertyInfo> value, Type ord, BindingFlags consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while ((ord = ord.WriteReader()) != null)
			{
				PropertyInfo[] properties = ord.GetProperties(consumer);
				foreach (PropertyInfo propertyInfo in properties)
				{
					PropertyInfo propertyInfo2 = propertyInfo;
					if (!propertyInfo2.DefineIssuer())
					{
						if (!SortIssuer(propertyInfo2))
						{
							int num = value.DefineTest((PropertyInfo P_0) => P_0.Name == propertyInfo2.Name);
							if (num == -1)
							{
								value.Add(propertyInfo2);
							}
							else if (!SortIssuer(value[num]))
							{
								value[num] = propertyInfo2;
							}
						}
						else if (value.DefineTest((PropertyInfo P_0) => P_0.Name == propertyInfo2.Name && P_0.DeclaringType == propertyInfo2.DeclaringType) == -1)
						{
							value.Add(propertyInfo2);
						}
					}
					else
					{
						Type c = propertyInfo2.CollectIssuer()?.DeclaringType ?? propertyInfo2.DeclaringType;
						if (value.DefineTest((PropertyInfo P_0) => P_0.Name == propertyInfo2.Name && P_0.DefineIssuer() && (P_0.CollectIssuer()?.DeclaringType ?? P_0.DeclaringType).IsAssignableFrom(c)) == -1)
						{
							value.Add(propertyInfo2);
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool InstantiateReader(Type asset, Type token, string filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return asset.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any((MethodInfo P_0) => P_0.Name == filter && P_0.DeclaringType != token && P_0.GetBaseDefinition().DeclaringType == token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object ReflectReader(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!reference.FindClient())
			{
				return null;
			}
			switch (HelperDicCandidate.PatchProperty(reference))
			{
			case (SettingsSerializeAs)4:
				return false;
			case (SettingsSerializeAs)2:
			case (SettingsSerializeAs)6:
			case (SettingsSerializeAs)8:
			case (SettingsSerializeAs)10:
			case (SettingsSerializeAs)12:
			case (SettingsSerializeAs)14:
			case (SettingsSerializeAs)16:
				return 0;
			case (SettingsSerializeAs)18:
			case (SettingsSerializeAs)20:
				return 0L;
			case (SettingsSerializeAs)22:
				return 0f;
			case (SettingsSerializeAs)24:
				return 0.0;
			case (SettingsSerializeAs)30:
				return 0m;
			case (SettingsSerializeAs)26:
				return default(DateTime);
			case (SettingsSerializeAs)36:
				return default(BigInteger);
			case (SettingsSerializeAs)32:
				return default(Guid);
			case (SettingsSerializeAs)28:
				return default(DateTimeOffset);
			default:
				if (VerifyReader(reference))
				{
					return null;
				}
				return Activator.CreateInstance(reference);
			}
		}
	}
}
