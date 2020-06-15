using _0008;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Rules;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace GDBD.Mocks
{
	[_0008._0012(0)]
	internal static class ConfigProperty
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			[_0008._0012(0)]
			public Type _0001;

			[_0008._0012(new byte[]
			{
				0,
				1
			})]
			public Func<object> _0002;

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
			internal object _0001(object[] P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					if (P_0 != null)
					{
						Type[] types = P_0.Select(delegate(object res)
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							if (res == null)
							{
								throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
							}
							return res.GetType();
						}).ToArray();
						ConstructorInfo constructor = this._0001.GetConstructor(types);
						if (!(constructor != null))
						{
							throw new ListenerTestItem("No matching parameterized constructor found for '{0}'.".ListReader(CultureInfo.InvariantCulture, this._0001));
						}
						return ConfigProperty._0001()._0001(constructor)(P_0);
					}
					if (_0002 == null)
					{
						throw new ListenerTestItem("No parameterless constructor defined for '{0}'.".ListReader(CultureInfo.InvariantCulture, this._0001));
					}
					return _0002();
				}
				catch (Exception cont)
				{
					throw new ListenerTestItem("Error creating '{0}'.".ListReader(CultureInfo.InvariantCulture, this._0001), cont);
				}
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class AnnotationInstanceExpression
		{
			[_0008._0012(0)]
			public static readonly AnnotationInstanceExpression threadProperty;

			[_0008._0012(0)]
			public static Func<object, Type> _ConsumerProperty;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static AnnotationInstanceExpression()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				threadProperty = new AnnotationInstanceExpression();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnnotationInstanceExpression()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Type InterruptClass(object res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (res == null)
				{
					throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
				}
				return res.GetType();
			}
		}

		private static bool? m_ConnectionProperty;

		private static bool? initializerProperty;

		[_0008._0012(new byte[]
		{
			1,
			1,
			1,
			2,
			1,
			1
		})]
		private static readonly Newtonsoft.Database.DispatcherEventEntry<Type, Func<object[], object>> objectProperty;

		[_0008._0012(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly Newtonsoft.Database.DispatcherEventEntry<Type, Type> schemaProperty;

		[_0008._0012(2)]
		private static ModelInstanceExpression _RefProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateClass<[_0008._0012(0)] T>(object res) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return GDBD.Items.WriterTestItem<T>.CompareClient(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StopClass(Type key, out TypeConverter token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			token = TypeDescriptor.GetConverter(key);
			if (token != null)
			{
				Type type = token.GetType();
				if (!string.Equals(type.FullName, "System.ComponentModel.ComponentConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.ComponentModel.ReferenceConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.Windows.Forms.Design.DataSourceConverter", StringComparison.Ordinal) && type != typeof(TypeConverter))
				{
					return token.CanConvertTo(typeof(string));
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataContractAttribute CloneClass(Type v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = v;
			while (type != null)
			{
				DataContractAttribute dataContractAttribute = GDBD.Items.WriterTestItem<DataContractAttribute>.CompareClient(type);
				if (dataContractAttribute != null)
				{
					return dataContractAttribute;
				}
				type = type.WriteReader();
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static DataMemberAttribute LogoutClass(MemberInfo i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i.DefineReader() == MemberTypes.Field)
			{
				return GDBD.Items.WriterTestItem<DataMemberAttribute>.CompareClient(i);
			}
			PropertyInfo propertyInfo = (PropertyInfo)i;
			DataMemberAttribute dataMemberAttribute = GDBD.Items.WriterTestItem<DataMemberAttribute>.CompareClient(propertyInfo);
			if (dataMemberAttribute == null && propertyInfo.DefineIssuer())
			{
				Type type = propertyInfo.DeclaringType;
				while (dataMemberAttribute == null && type != null)
				{
					PropertyInfo propertyInfo2 = (PropertyInfo)ResolverErrorFilter.PrepareReader(type, propertyInfo);
					if (propertyInfo2 != null && propertyInfo2.DefineIssuer())
					{
						dataMemberAttribute = GDBD.Items.WriterTestItem<DataMemberAttribute>.CompareClient(propertyInfo2);
					}
					type = type.WriteReader();
				}
			}
			return dataMemberAttribute;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ServerComposer VisitClass(Type i, bool iscaller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ClassComposerPool classComposerPool = CreateClass<ClassComposerPool>(i);
			if (classComposerPool != null)
			{
				return classComposerPool._0001();
			}
			if (CloneClass(i) != null)
			{
				return (ServerComposer)1;
			}
			if (!iscaller && UpdateClass(i))
			{
				return (ServerComposer)2;
			}
			return (ServerComposer)0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BroadcasterError ViewClass(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RecordEventConsumer recordEventConsumer = CreateClass<RecordEventConsumer>(value);
			if (recordEventConsumer != null)
			{
				Func<object[], object> func = objectProperty.InitReader(recordEventConsumer._0001());
				if (func != null)
				{
					return (BroadcasterError)func(recordEventConsumer._0001());
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BroadcasterError ConnectClass(Type asset, object[] pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (BroadcasterError)objectProperty.InitReader(asset)(pred);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ProducerIteratorMapping MoveClass(Type spec, object[] cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ProducerIteratorMapping)objectProperty.InitReader(spec)(cust);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ProducerIteratorMapping PopClass(RefDic spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (spec._0001() == null)
			{
				if (spec._0002() == null)
				{
					return null;
				}
				spec._0001(MoveClass(spec._0002(), spec._0002()));
			}
			return spec._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object[], object> NewClass(Type item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Func<object> func = ResolverErrorFilter.LoginReader(item, isconnection: false) ? ConfigProperty._0001()._0001<object>(item) : null;
			return delegate(object[] P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					if (P_0 != null)
					{
						Type[] types = P_0.Select(delegate(object res)
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							if (res == null)
							{
								throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
							}
							return res.GetType();
						}).ToArray();
						ConstructorInfo constructor = item.GetConstructor(types);
						if (!(constructor != null))
						{
							throw new ListenerTestItem("No matching parameterized constructor found for '{0}'.".ListReader(CultureInfo.InvariantCulture, item));
						}
						return ConfigProperty._0001()._0001(constructor)(P_0);
					}
					if (func == null)
					{
						throw new ListenerTestItem("No parameterless constructor defined for '{0}'.".ListReader(CultureInfo.InvariantCulture, item));
					}
					return func();
				}
				catch (Exception cont)
				{
					throw new ListenerTestItem("Error creating '{0}'.".ListReader(CultureInfo.InvariantCulture, item), cont);
				}
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type ForgotClass(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return schemaProperty.InitReader(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type IncludeClass(Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Attribute[] array = ResolverErrorFilter.ForgotReader(info, null, controlopen: true);
			foreach (Attribute attribute in array)
			{
				Type type = attribute.GetType();
				if (string.Equals(type.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
				{
					if (_RefProperty == null)
					{
						_RefProperty = ModelInstanceExpression.ManageIssuer(type, new string[1]
						{
							"MetadataClassType"
						});
					}
					return (Type)_RefProperty.CancelIssuer(attribute, "MetadataClassType");
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T PushClass<[_0008._0012(0)] T>(Type first) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = ForgotClass(first);
			T val;
			if (type != null)
			{
				val = ResolverErrorFilter.PopReader<T>(type, iscounter: true);
				if (val != null)
				{
					return val;
				}
			}
			val = ResolverErrorFilter.PopReader<T>(first, iscounter: true);
			if (val != null)
			{
				return val;
			}
			Type[] interfaces = first.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				val = ResolverErrorFilter.PopReader<T>(interfaces[i], iscounter: true);
				if (val != null)
				{
					return val;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T PrepareClass<[_0008._0012(0)] T>(MemberInfo item) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = ForgotClass(item.DeclaringType);
			T val;
			if (type != null)
			{
				MemberInfo memberInfo = ResolverErrorFilter.PrepareReader(type, item);
				if (memberInfo != null)
				{
					val = ResolverErrorFilter.PopReader<T>(memberInfo, iscounter: true);
					if (val != null)
					{
						return val;
					}
				}
			}
			val = ResolverErrorFilter.PopReader<T>(item, iscounter: true);
			if (val != null)
			{
				return val;
			}
			if (item.DeclaringType != null)
			{
				Type[] interfaces = item.DeclaringType.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					MemberInfo memberInfo2 = ResolverErrorFilter.PrepareReader(interfaces[i], item);
					if (memberInfo2 != null)
					{
						val = ResolverErrorFilter.PopReader<T>(memberInfo2, iscounter: true);
						if (val != null)
						{
							return val;
						}
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AwakeClass(object ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolverErrorFilter.PopReader<NonSerializedAttribute>(ident, iscounter: false) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UpdateClass(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolverErrorFilter.PopReader<SerializableAttribute>(value, iscounter: false) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T ReadClass<[_0008._0012(0)] T>(object key) where T : Attribute
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = key as Type;
			if ((object)type != null)
			{
				return PushClass<T>(type);
			}
			MemberInfo memberInfo = key as MemberInfo;
			if ((object)memberInfo != null)
			{
				return PrepareClass<T>(memberInfo);
			}
			return ResolverErrorFilter.PopReader<T>(key, iscounter: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecuritySafeCritical]
		public static bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!m_ConnectionProperty.HasValue)
			{
				try
				{
					new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
					new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
					new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
					new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
					new SecurityPermission(PermissionState.Unrestricted).Demand();
					m_ConnectionProperty = true;
				}
				catch (Exception)
				{
					m_ConnectionProperty = false;
				}
			}
			return m_ConnectionProperty.GetValueOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!initializerProperty.HasValue)
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				initializerProperty = (currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
			}
			return initializerProperty.GetValueOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static VisitorComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ConfigProperty._0001())
			{
				return AnnotationComposer._0001();
			}
			return ReaderInstanceRule._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ConfigProperty()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			objectProperty = new Newtonsoft.Database.DispatcherEventEntry<Type, Func<object[], object>>(NewClass);
			schemaProperty = new Newtonsoft.Database.DispatcherEventEntry<Type, Type>(IncludeClass);
		}
	}
}
