using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace GDBD.Strategies
{
	[global::_0008._0012(0)]
	public sealed class PublisherRequestStrategy : BridgeTest
	{
		internal sealed class CallbackTest<[global::_0008._0012(2)] T, [global::_0008._0012(2)] TT> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			[global::_0008._0012(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			private readonly IEnumerable<KeyValuePair<T, TT>> m_MerchantTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public IEnumerator<KeyValuePair<object, object>> _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return new _0001(0)
				{
					_0003 = this
				};
			}

			IEnumerator<KeyValuePair<object, object>> IEnumerable<KeyValuePair<object, object>>.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private IEnumerator _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001();
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class ContainerClassSpec
		{
			[global::_0008._0012(0)]
			public static readonly ContainerClassSpec _ListenerTest;

			[global::_0008._0012(0)]
			public static Func<MemberInfo, bool> tagTest;

			[global::_0008._0012(0)]
			public static Func<MemberInfo, bool> _SpecificationTest;

			[global::_0008._0012(0)]
			public static Func<Type, IEnumerable<MemberInfo>> writerTest;

			[global::_0008._0012(0)]
			public static Func<MemberInfo, bool> m_RoleTest;

			[global::_0008._0012(0)]
			public static Func<ConstructorInfo, bool> m_CreatorTest;

			[global::_0008._0012(0)]
			public static Func<ProductInstanceExpression, int> m_RuleTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ContainerClassSpec()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_ListenerTest = new ContainerClassSpec();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ContainerClassSpec()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool RegisterClient(MemberInfo def)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				PropertyInfo propertyInfo = def as PropertyInfo;
				if ((object)propertyInfo == null)
				{
					return true;
				}
				return !ResolverErrorFilter.CreateReader(propertyInfo);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool RestartClient(MemberInfo setup)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return !string.Equals(setup.Name, "TargetSite", StringComparison.Ordinal);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<MemberInfo> SearchClient(Type res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				List<MemberInfo> list = new List<MemberInfo>();
				list.ExcludeTest(res.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				list.ExcludeTest(res.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				return list;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ComputeClient(MemberInfo item)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				MemberTypes memberTypes = item.DefineReader();
				if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
				{
					return false;
				}
				if (!item.IsDefined(typeof(IteratorError), inherit: false))
				{
					return false;
				}
				if (!ResolverErrorFilter.LogoutReader(item, updateb: true))
				{
					throw new ListenerTestItem("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".SelectReader(CultureInfo.InvariantCulture, InterruptClient(item.DeclaringType), item.Name));
				}
				if (ResolverErrorFilter.FillReader(ResolverErrorFilter.InsertReader(item), typeof(IDictionary<, >), out Type _0004))
				{
					Type obj = _0004.GetGenericArguments()[0];
					Type type = _0004.GetGenericArguments()[1];
					if (obj.IsAssignableFrom(typeof(string)) && type.IsAssignableFrom(typeof(ParserFilterResolver)))
					{
						return true;
					}
				}
				throw new ListenerTestItem("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".SelectReader(CultureInfo.InvariantCulture, InterruptClient(item.DeclaringType), item.Name));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool DestroyClient(ConstructorInfo v)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return v.IsDefined(typeof(BroadcasterComposerPool), inherit: true);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int SetClient(ProductInstanceExpression reference)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return reference._0001() ?? (-1);
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[global::_0008._0012(0)]
			public ProducerIteratorMapping _0001;

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
			internal string _0001(string P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001._0003(P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			[global::_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Func<object, object> _0001;

			[global::_0008._0012(0)]
			public MemberInfo _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0003()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			[global::_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Action<object, object> _0001;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public Func<object> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0003;

			[global::_0008._0012(0)]
			public _0003 _0004;

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
			internal void _0001(object P_0, string P_1, object P_2)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				object obj = _0004._0001(P_0);
				if (obj == null)
				{
					if (this._0001 == null)
					{
						throw new StrategyError("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".ListReader(CultureInfo.InvariantCulture, _0004._0002.Name));
					}
					obj = _0002();
					this._0001(P_0, obj);
				}
				_0003(obj, new object[2]
				{
					P_1,
					P_2
				});
			}
		}

		[CompilerGenerated]
		private sealed class _0005
		{
			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public GDBD.Specifications.AdapterClassSpec<object> _0001;

			[global::_0008._0012(0)]
			public _0003 _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0005()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<KeyValuePair<object, object>> _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				object obj = _0002._0001(P_0);
				if (obj == null)
				{
					return null;
				}
				return (IEnumerable<KeyValuePair<object, object>>)this._0001(new object[1]
				{
					obj
				});
			}
		}

		[CompilerGenerated]
		private sealed class _0006
		{
			[global::_0008._0012(0)]
			public ProducerIteratorMapping _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0006()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string _0001(string P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001._0003(P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0007
		{
			[global::_0008._0012(0)]
			public ProducerIteratorMapping _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0007()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string _0001(string P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001._0003(P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0008
		{
			[global::_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0008()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (bool)this._0001(P_0, new object[0]);
			}
		}

		[CompilerGenerated]
		private sealed class _000E
		{
			[global::_0008._0012(new byte[]
			{
				0,
				1,
				1
			})]
			public Func<object, object> _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _000E()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (bool)this._0001(P_0);
			}
		}

		private static readonly BridgeTest m_ValueTest;

		private static readonly string[] parameterTest;

		private static readonly BroadcasterError[] prototypeTest;

		private readonly ContextRequestStrategy parserTest;

		private readonly Newtonsoft.Database.DispatcherEventEntry<Type, ProcTest> statusTest;

		[CompilerGenerated]
		private BindingFlags _PageTest;

		[CompilerGenerated]
		private bool _HelperTest;

		[CompilerGenerated]
		private bool m_ExceptionTest;

		[CompilerGenerated]
		private bool _AttributeTest;

		[CompilerGenerated]
		private bool databaseTest;

		[CompilerGenerated]
		private bool m_FactoryTest;

		[CompilerGenerated]
		[global::_0008._0012(2)]
		private ProducerIteratorMapping serializerTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BridgeTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ValueTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ConfigProperty._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public BindingFlags _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _PageTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(BindingFlags reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_PageTest = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _HelperTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ExceptionTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _AttributeTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool validateasset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_AttributeTest = validateasset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return databaseTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_FactoryTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public ProducerIteratorMapping _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return serializerTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PublisherRequestStrategy()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			parserTest = new ContextRequestStrategy();
			base._002Ector();
			_0001(validateasset: true);
			_0001(BindingFlags.Instance | BindingFlags.Public);
			statusTest = new Newtonsoft.Database.DispatcherEventEntry<Type, ProcTest>(_0002);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual ProcTest _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(reference, "type");
			return statusTest.InitReader(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool EnableClient(MemberInfo config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyInfo propertyInfo = config as PropertyInfo;
			if ((object)propertyInfo != null)
			{
				if (ResolverErrorFilter.CreateReader(propertyInfo))
				{
					return false;
				}
				return !ResolverErrorFilter.FlushReader(propertyInfo.PropertyType);
			}
			FieldInfo fieldInfo = config as FieldInfo;
			if ((object)fieldInfo != null)
			{
				return !ResolverErrorFilter.FlushReader(fieldInfo.FieldType);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual List<MemberInfo> _0001(Type spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool iscaller = _0004();
			ServerComposer serverComposer = ConfigProperty.VisitClass(spec, iscaller);
			IEnumerable<MemberInfo> enumerable = ResolverErrorFilter.ViewReader(spec, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(delegate(MemberInfo def)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				PropertyInfo propertyInfo = def as PropertyInfo;
				return (object)propertyInfo == null || !ResolverErrorFilter.CreateReader(propertyInfo);
			});
			List<MemberInfo> list = new List<MemberInfo>();
			if (serverComposer != (ServerComposer)2)
			{
				DataContractAttribute dataContractAttribute = ConfigProperty.CloneClass(spec);
				List<MemberInfo> list2 = ResolverErrorFilter.ViewReader(spec, this._0001()).Where(EnableClient).ToList();
				foreach (MemberInfo item in enumerable)
				{
					if (_0002() || !item.IsDefined(typeof(CompilerGeneratedAttribute), inherit: true))
					{
						if (list2.Contains(item))
						{
							list.Add(item);
						}
						else if (ConfigProperty.ReadClass<TokenizerError>(item) != null)
						{
							list.Add(item);
						}
						else if (ConfigProperty.ReadClass<ProcBroadcasterDispatcher>(item) != null)
						{
							list.Add(item);
						}
						else if (dataContractAttribute != null && ConfigProperty.ReadClass<DataMemberAttribute>(item) != null)
						{
							list.Add(item);
						}
						else if (serverComposer == (ServerComposer)2 && item.DefineReader() == MemberTypes.Field)
						{
							list.Add(item);
						}
					}
				}
				if (spec.OrderClient("System.Data.Objects.DataClasses.EntityObject", iscontrol: false, out Type _))
				{
					list = list.Where(MapClient).ToList();
				}
				if (typeof(Exception).IsAssignableFrom(spec))
				{
					list = list.Where((MemberInfo setup) => !string.Equals(setup.Name, "TargetSite", StringComparison.Ordinal)).ToList();
				}
				return list;
			}
			foreach (MemberInfo item2 in enumerable)
			{
				FieldInfo fieldInfo = item2 as FieldInfo;
				if ((object)fieldInfo != null && !fieldInfo.IsStatic)
				{
					list.Add(item2);
				}
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MapClient(MemberInfo reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyInfo propertyInfo = reference as PropertyInfo;
			if ((object)propertyInfo != null && propertyInfo.PropertyType.CallReader() && propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1")
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual PrototypeFilterResolver _0001(Type res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PrototypeFilterResolver prototypeFilterResolver = new PrototypeFilterResolver(res);
			ConnectClient(prototypeFilterResolver);
			bool iscaller = _0004();
			prototypeFilterResolver._0001(ConfigProperty.VisitClass(prototypeFilterResolver._InstanceProperty, iscaller));
			prototypeFilterResolver._0001().ExcludeTest(_0001(prototypeFilterResolver._InstanceProperty, prototypeFilterResolver._0001()));
			Func<string, string> func = null;
			ClassComposerPool classComposerPool = ConfigProperty.CreateClass<ClassComposerPool>(prototypeFilterResolver._InstanceProperty);
			if (classComposerPool != null)
			{
				prototypeFilterResolver._0001(classComposerPool.m_PolicyError);
				prototypeFilterResolver._0001(classComposerPool.serviceError);
				prototypeFilterResolver._0001(classComposerPool.predicateError);
				if (((RefDic)classComposerPool)._0002() != null)
				{
					ProducerIteratorMapping producerIteratorMapping = ConfigProperty.PopClass(classComposerPool);
					func = ((string P_0) => producerIteratorMapping._0003(P_0));
				}
			}
			if (func == null)
			{
				func = _0002;
			}
			prototypeFilterResolver._0001(func);
			if (prototypeFilterResolver._IssuerProperty)
			{
				ConstructorInfo constructorInfo = StopClient(prototypeFilterResolver._InstanceProperty);
				if (constructorInfo != null)
				{
					prototypeFilterResolver._0001(ConfigProperty._0001()._0001(constructorInfo));
					prototypeFilterResolver._0002().ExcludeTest(_0001(constructorInfo, prototypeFilterResolver._0001()));
				}
				else if (prototypeFilterResolver._0001() == (ServerComposer)2)
				{
					if (ConfigProperty._0002())
					{
						prototypeFilterResolver._0001(prototypeFilterResolver.ManageClient);
					}
				}
				else if (((ProcTest)prototypeFilterResolver)._0001() == null || prototypeFilterResolver._0007())
				{
					ConstructorInfo constructorInfo2 = LogoutClient(prototypeFilterResolver._InstanceProperty);
					if (constructorInfo2 != null)
					{
						prototypeFilterResolver._0002(ConfigProperty._0001()._0001(constructorInfo2));
						prototypeFilterResolver._0002().ExcludeTest(_0001(constructorInfo2, prototypeFilterResolver._0001()));
					}
				}
				else if (prototypeFilterResolver._InstanceProperty.FindClient())
				{
					ConstructorInfo constructorInfo3 = CloneClient(prototypeFilterResolver._InstanceProperty, prototypeFilterResolver._0001());
					if (constructorInfo3 != null)
					{
						prototypeFilterResolver._0001(ConfigProperty._0001()._0001(constructorInfo3));
						prototypeFilterResolver._0002().ExcludeTest(_0001(constructorInfo3, prototypeFilterResolver._0001()));
					}
				}
			}
			MemberInfo memberInfo = FlushClient(prototypeFilterResolver._InstanceProperty);
			if (memberInfo != null)
			{
				CreateClient(prototypeFilterResolver, memberInfo);
			}
			if (Array.IndexOf(parameterTest, res.FullName) != -1)
			{
				prototypeFilterResolver._0004().Add(InsertClient);
			}
			return prototypeFilterResolver;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void InsertClient(object def, StreamingContext attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new StrategyError("Unable to serialize instance of '{0}'.".ListReader(CultureInfo.InvariantCulture, def.GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private MemberInfo FlushClient(Type v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PushClient(v).SelectMany(delegate(Type res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				List<MemberInfo> list = new List<MemberInfo>();
				list.ExcludeTest(res.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				list.ExcludeTest(res.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
				return list;
			}).LastOrDefault(delegate(MemberInfo item)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				MemberTypes memberTypes = item.DefineReader();
				if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
				{
					return false;
				}
				if (!item.IsDefined(typeof(IteratorError), inherit: false))
				{
					return false;
				}
				if (!ResolverErrorFilter.LogoutReader(item, updateb: true))
				{
					throw new ListenerTestItem("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".SelectReader(CultureInfo.InvariantCulture, InterruptClient(item.DeclaringType), item.Name));
				}
				if (ResolverErrorFilter.FillReader(ResolverErrorFilter.InsertReader(item), typeof(IDictionary<, >), out Type _0004))
				{
					Type obj = _0004.GetGenericArguments()[0];
					Type type = _0004.GetGenericArguments()[1];
					if (obj.IsAssignableFrom(typeof(string)) && type.IsAssignableFrom(typeof(ParserFilterResolver)))
					{
						return true;
					}
				}
				throw new ListenerTestItem("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".SelectReader(CultureInfo.InvariantCulture, InterruptClient(item.DeclaringType), item.Name));
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CreateClient(PrototypeFilterResolver var1, MemberInfo cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IteratorError iteratorError = ResolverErrorFilter.MoveReader<IteratorError>(cust);
			if (iteratorError == null)
			{
				return;
			}
			Type type = ResolverErrorFilter.InsertReader(cust);
			ResolverErrorFilter.FillReader(type, typeof(IDictionary<, >), out Type _0004);
			Type type2 = _0004.GetGenericArguments()[0];
			Type type3 = _0004.GetGenericArguments()[1];
			Type task = (!ResolverErrorFilter.OrderReader(type, typeof(IDictionary<, >))) ? type : typeof(Dictionary<, >).MakeGenericType(type2, type3);
			Func<object, object> func = ConfigProperty._0001().ValidateIssuer<object>(cust);
			if (iteratorError._0002())
			{
				Action<object, object> action = ResolverErrorFilter.VisitReader(cust, calcconnection: true, addrule: false) ? ConfigProperty._0001().OrderIssuer<object>(cust) : null;
				Func<object> func2 = ConfigProperty._0001()._0001<object>(task);
				MethodInfo methodInfo = type.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[1]
				{
					type2
				}, null)?.GetSetMethod();
				if (methodInfo == null)
				{
					methodInfo = _0004.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[1]
					{
						type2
					}, null)?.GetSetMethod();
				}
				Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule = ConfigProperty._0001()._0001<object>(methodInfo);
				StrategyRequestStrategy var2 = delegate(object P_0, string P_1, object P_2)
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					object obj2 = func(P_0);
					if (obj2 == null)
					{
						if (action == null)
						{
							throw new StrategyError("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".ListReader(CultureInfo.InvariantCulture, cust.Name));
						}
						obj2 = func2();
						action(P_0, obj2);
					}
					clientInstanceRule(obj2, new object[2]
					{
						P_1,
						P_2
					});
				};
				var1._0001(var2);
			}
			if (iteratorError._0001())
			{
				ConstructorInfo v = typeof(CallbackTest<, >).MakeGenericType(type2, type3).GetConstructors().First();
				GDBD.Specifications.AdapterClassSpec<object> adapterClassSpec = ConfigProperty._0001()._0001(v);
				PolicyIssuerMock res = delegate(object P_0)
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					object obj = func(P_0);
					return (obj == null) ? null : ((IEnumerable<KeyValuePair<object, object>>)adapterClassSpec(new object[1]
					{
						obj
					}));
				};
				var1._0001(res);
			}
			var1._0001(type3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo StopClient(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IEnumerator<ConstructorInfo> enumerator = (from v in reference.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where v.IsDefined(typeof(BroadcasterComposerPool), inherit: true)
				select v).GetEnumerator();
			if (enumerator.MoveNext())
			{
				ConstructorInfo current = enumerator.Current;
				if (enumerator.MoveNext())
				{
					throw new ListenerTestItem("Multiple constructors with the JsonConstructorAttribute.");
				}
				return current;
			}
			if (reference == typeof(Version))
			{
				return reference.GetConstructor(new Type[4]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				});
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo CloneClient(Type ident, CreatorTestItem result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IEnumerator<ConstructorInfo> enumerator = ((IEnumerable<ConstructorInfo>)ident.GetConstructors()).GetEnumerator();
			if (enumerator.MoveNext())
			{
				ConstructorInfo current = enumerator.Current;
				if (!enumerator.MoveNext())
				{
					ParameterInfo[] parameters = current.GetParameters();
					if (parameters.Length != 0)
					{
						ParameterInfo[] array = parameters;
						foreach (ParameterInfo parameterInfo in array)
						{
							ProductInstanceExpression productInstanceExpression = VisitClient(result, parameterInfo.Name, parameterInfo.ParameterType);
							if (productInstanceExpression == null || productInstanceExpression._0003())
							{
								return null;
							}
						}
						return current;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo LogoutClient(Type config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ConstructorInfo[] constructors = config.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors.Length == 1)
			{
				return constructors[0];
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IList<ProductInstanceExpression> _0001(ConstructorInfo def, CreatorTestItem token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParameterInfo[] parameters = def.GetParameters();
			CreatorTestItem creatorTestItem = new CreatorTestItem(def.DeclaringType);
			ParameterInfo[] array = parameters;
			foreach (ParameterInfo parameterInfo in array)
			{
				if (parameterInfo.Name == null)
				{
					continue;
				}
				ProductInstanceExpression productInstanceExpression = VisitClient(token, parameterInfo.Name, parameterInfo.ParameterType);
				if (productInstanceExpression != null || parameterInfo.Name != null)
				{
					ProductInstanceExpression productInstanceExpression2 = _0001(productInstanceExpression, parameterInfo);
					if (productInstanceExpression2 != null)
					{
						creatorTestItem.CollectClient(productInstanceExpression2);
					}
				}
			}
			return creatorTestItem;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ProductInstanceExpression VisitClient(CreatorTestItem config, string cfg, Type comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (cfg == null)
			{
				return null;
			}
			ProductInstanceExpression productInstanceExpression = config.SortClient(cfg);
			if (productInstanceExpression == null || productInstanceExpression._0002() != comp)
			{
				return null;
			}
			return productInstanceExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ProductInstanceExpression _0001(ProductInstanceExpression def, ParameterInfo second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProductInstanceExpression productInstanceExpression = new ProductInstanceExpression();
			productInstanceExpression._0002(second.ParameterType);
			productInstanceExpression._0001(new ComparatorProperty(second));
			CalcClient(productInstanceExpression, second, second.Name, second.Member.DeclaringType, (ServerComposer)0, out bool _);
			productInstanceExpression._0002(isres: false);
			productInstanceExpression._0003(islast: true);
			if (def != null)
			{
				productInstanceExpression._0001((productInstanceExpression._0001() != second.Name) ? productInstanceExpression._0001() : def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				if (!productInstanceExpression.m_ParamProperty && def.m_ParamProperty)
				{
					productInstanceExpression._0001(def._0001());
				}
				productInstanceExpression.contextProperty = (productInstanceExpression.contextProperty ?? def.contextProperty);
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
				productInstanceExpression._0001(productInstanceExpression._0001() ?? def._0001());
			}
			return productInstanceExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual BroadcasterError _0001(Type setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ConfigProperty.ViewClass(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Func<object> ViewClient(Type var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ConfigProperty._0001()._0001<object>(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectClient(ProcTest def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RefDic refDic = ConfigProperty.CreateClass<RefDic>(def._InstanceProperty);
			if (refDic != null)
			{
				def._0002(refDic.procDic);
			}
			else
			{
				DataContractAttribute dataContractAttribute = ConfigProperty.CloneClass(def._InstanceProperty);
				if (dataContractAttribute != null && dataContractAttribute.IsReference)
				{
					def._0002(true);
				}
			}
			def._0002(this._0001(def._InstanceProperty));
			def._0003(PrototypeError.LogoutComposer(prototypeTest, def._InstanceProperty));
			if (def._IssuerProperty && (ResolverErrorFilter.LoginReader(def._0003(), isconnection: true) || def._0003().FindClient()))
			{
				def._0001(ViewClient(def._0003()));
				def._0003(!def._0003().FindClient() && ResolverErrorFilter.CheckReader(def._0003()) == null);
			}
			MoveClient(def, def._InstanceProperty);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveClient(ProcTest value, Type caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PopClient(caller, out List<MessageInstanceExpression> _0003, out List<MessageInstanceExpression> _0004, out List<MessageInstanceExpression> _0005, out List<MessageInstanceExpression> _0006, out List<SingletonEventEntry> _0007);
			if (_0003 != null)
			{
				value._0004().ExcludeTest(_0003);
			}
			if (_0004 != null)
			{
				value._0003().ExcludeTest(_0004);
			}
			if (_0005 != null)
			{
				value._0002().ExcludeTest(_0005);
			}
			if (_0006 != null)
			{
				value._0001().ExcludeTest(_0006);
			}
			if (_0007 != null)
			{
				value._0001().ExcludeTest(_0007);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopClient(Type init, [global::_0008._0012(new byte[]
		{
			2,
			1
		})] out List<MessageInstanceExpression> _0003, [global::_0008._0012(new byte[]
		{
			2,
			1
		})] out List<MessageInstanceExpression> _0004, [global::_0008._0012(new byte[]
		{
			2,
			1
		})] out List<MessageInstanceExpression> _0005, [global::_0008._0012(new byte[]
		{
			2,
			1
		})] out List<MessageInstanceExpression> _0006, [global::_0008._0012(new byte[]
		{
			2,
			1
		})] out List<SingletonEventEntry> _0007)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0003 = null;
			_0004 = null;
			_0005 = null;
			_0006 = null;
			_0007 = null;
			foreach (Type item in PushClient(init))
			{
				MethodInfo first = null;
				MethodInfo first2 = null;
				MethodInfo first3 = null;
				MethodInfo first4 = null;
				MethodInfo first5 = null;
				bool flag = IncludeClient(item);
				bool flag2 = ForgotClient(item);
				MethodInfo[] methods = item.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodInfo methodInfo in methods)
				{
					if (!methodInfo.ContainsGenericParameters)
					{
						Type def = null;
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (!flag && ReadClient(methodInfo, parameters, typeof(OnSerializingAttribute), first, ref def))
						{
							_0003 = (_0003 ?? new List<MessageInstanceExpression>());
							_0003.Add(ProcTest.InvokeClient(methodInfo));
							first = methodInfo;
						}
						if (ReadClient(methodInfo, parameters, typeof(OnSerializedAttribute), first2, ref def))
						{
							_0004 = (_0004 ?? new List<MessageInstanceExpression>());
							_0004.Add(ProcTest.InvokeClient(methodInfo));
							first2 = methodInfo;
						}
						if (ReadClient(methodInfo, parameters, typeof(OnDeserializingAttribute), first3, ref def))
						{
							_0005 = (_0005 ?? new List<MessageInstanceExpression>());
							_0005.Add(ProcTest.InvokeClient(methodInfo));
							first3 = methodInfo;
						}
						if (!flag2 && ReadClient(methodInfo, parameters, typeof(OnDeserializedAttribute), first4, ref def))
						{
							_0006 = (_0006 ?? new List<MessageInstanceExpression>());
							_0006.Add(ProcTest.InvokeClient(methodInfo));
							first4 = methodInfo;
						}
						if (ReadClient(methodInfo, parameters, typeof(ListClassDispatcher), first5, ref def))
						{
							_0007 = (_0007 ?? new List<SingletonEventEntry>());
							_0007.Add(ProcTest.PrintClient(methodInfo));
							first5 = methodInfo;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool NewClient(Type ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident.CallReader())
			{
				switch (ident.GetGenericTypeDefinition().FullName)
				{
				case "System.Collections.Concurrent.ConcurrentQueue`1":
				case "System.Collections.Concurrent.ConcurrentStack`1":
				case "System.Collections.Concurrent.ConcurrentBag`1":
				case "System.Collections.Concurrent.ConcurrentDictionary`2":
				case "System.Collections.ObjectModel.ObservableCollection`1":
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ForgotClient(Type var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (NewClient(var1))
			{
				return true;
			}
			if (var1.Name == "FSharpSet`1" || var1.Name == "FSharpMap`2")
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool IncludeClient(Type value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (NewClient(value))
			{
				return true;
			}
			if (value.Name == "FSharpSet`1" || value.Name == "FSharpMap`2")
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Type> PushClient(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<Type> list = new List<Type>();
			Type type = task;
			while (type != null && type != typeof(object))
			{
				list.Add(type);
				type = type.WriteReader();
			}
			list.Reverse();
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ParamClientBridge _0001(Type res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParamClientBridge paramClientBridge = new ParamClientBridge(res);
			ConnectClient(paramClientBridge);
			RefDic refDic = ConfigProperty.ReadClass<RefDic>(res);
			if (refDic?._0002() != null)
			{
				ProducerIteratorMapping producerIteratorMapping = ConfigProperty.PopClass(refDic);
				paramClientBridge._0001((string P_0) => producerIteratorMapping._0003(P_0));
			}
			else
			{
				paramClientBridge._0001(_0003);
			}
			ConstructorInfo constructorInfo = StopClient(paramClientBridge._InstanceProperty);
			if (constructorInfo != null)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				Type type = (paramClientBridge._0001() != null && paramClientBridge._0004() != null) ? typeof(IEnumerable<>).MakeGenericType(typeof(KeyValuePair<, >).MakeGenericType(paramClientBridge._0001(), paramClientBridge._0004())) : typeof(IDictionary);
				if (parameters.Length == 0)
				{
					paramClientBridge._0001(usetask: false);
				}
				else
				{
					if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
					{
						throw new ListenerTestItem("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".SelectReader(CultureInfo.InvariantCulture, ((ProcTest)paramClientBridge)._0002(), type));
					}
					paramClientBridge._0001(usetask: true);
				}
				paramClientBridge._0001(ConfigProperty._0001()._0001(constructorInfo));
			}
			return paramClientBridge;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual MessageTest _0001(Type init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MessageTest messageTest = new MessageTest(init);
			ConnectClient(messageTest);
			ConstructorInfo constructorInfo = StopClient(messageTest._InstanceProperty);
			if (constructorInfo != null)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				Type type = (messageTest._0001() != null) ? typeof(IEnumerable<>).MakeGenericType(messageTest._0001()) : typeof(IEnumerable);
				if (parameters.Length == 0)
				{
					messageTest._0002(isasset: false);
				}
				else
				{
					if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
					{
						throw new ListenerTestItem("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".SelectReader(CultureInfo.InvariantCulture, ((ProcTest)messageTest)._0002(), type));
					}
					messageTest._0002(isasset: true);
				}
				messageTest._0001(ConfigProperty._0001()._0001(constructorInfo));
			}
			return messageTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ProccesorClassSpec _0001(Type init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProccesorClassSpec proccesorClassSpec = new ProccesorClassSpec(init);
			ConnectClient(proccesorClassSpec);
			return proccesorClassSpec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual MapInstanceExpression _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MapInstanceExpression mapInstanceExpression = new MapInstanceExpression(reference);
			ConnectClient(mapInstanceExpression);
			return mapInstanceExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual CollectionProperty _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CollectionProperty collectionProperty = new CollectionProperty(reference);
			ConnectClient(collectionProperty);
			if (collectionProperty._IssuerProperty)
			{
				ConstructorInfo constructor = collectionProperty._InstanceProperty.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[2]
				{
					typeof(SerializationInfo),
					typeof(StreamingContext)
				}, null);
				if (constructor != null)
				{
					GDBD.Specifications.AdapterClassSpec<object> ident = ConfigProperty._0001()._0001(constructor);
					collectionProperty._0001(ident);
				}
			}
			return collectionProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ProducerProperty _0001(Type spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProducerProperty producerProperty = new ProducerProperty(spec);
			ConnectClient(producerProperty);
			RefDic refDic = ConfigProperty.ReadClass<RefDic>(spec);
			if (refDic?._0002() != null)
			{
				ProducerIteratorMapping producerIteratorMapping = ConfigProperty.PopClass(refDic);
				producerProperty._0001((string P_0) => producerIteratorMapping._0003(P_0));
			}
			else
			{
				producerProperty._0001(_0003);
			}
			producerProperty._0001().ExcludeTest(_0001(spec, (ServerComposer)0));
			return producerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual StubIteratorMapping _0001(Type param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StubIteratorMapping stubIteratorMapping = new StubIteratorMapping(param);
			ConnectClient(stubIteratorMapping);
			return stubIteratorMapping;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ProcTest _0002(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = ResolverErrorFilter.ValidateReader(last);
			if (PrepareClient(type))
			{
				return this._0001(last);
			}
			type = ResolverErrorFilter.FindReader(type);
			RefDic refDic = ConfigProperty.CreateClass<RefDic>(type);
			if (refDic is ClassComposerPool)
			{
				return this._0001(last);
			}
			if (refDic is SchemaDic)
			{
				return this._0001(last);
			}
			if (refDic is ComparatorBroadcasterDispatcher)
			{
				return this._0001(last);
			}
			if (type == typeof(ParserFilterResolver) || type.IsSubclassOf(typeof(ParserFilterResolver)))
			{
				return this._0001(last);
			}
			if (ObserverIteratorMapping.SetupTest(type))
			{
				return this._0001(last);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type))
			{
				return this._0001(last);
			}
			if (UpdateClient(type))
			{
				return this._0001(last);
			}
			if (!_0003() && typeof(ISerializable).IsAssignableFrom(type) && ConfigProperty.UpdateClass(type))
			{
				return this._0001(last);
			}
			if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
			{
				return this._0001(last);
			}
			if (AwakeClient(type))
			{
				return this._0001(type);
			}
			return this._0001(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PrepareClient(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			SettingsSerializeAs settingsSerializeAs = HelperDicCandidate.PatchProperty(last);
			if (settingsSerializeAs != 0)
			{
				return settingsSerializeAs != (SettingsSerializeAs)1;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AwakeClient(Type first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (typeof(IConvertible).IsAssignableFrom(first) || (ResolverErrorFilter.PatchReader(first) && typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(first))))
			{
				return !typeof(ParserFilterResolver).IsAssignableFrom(first);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UpdateClient(Type setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ConfigProperty.StopClass(setup, out TypeConverter _))
			{
				return true;
			}
			if (setup == typeof(Type) || setup.IsSubclassOf(typeof(Type)))
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ReadClient(MethodInfo asset, ParameterInfo[] ivk, Type third, MethodInfo first2, ref Type def3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!asset.IsDefined(third, inherit: false))
			{
				return false;
			}
			if (first2 != null)
			{
				throw new ListenerTestItem("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".TestReader(CultureInfo.InvariantCulture, asset, first2, InterruptClient(asset.DeclaringType), third));
			}
			if (def3 != null)
			{
				throw new ListenerTestItem("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".TestReader(CultureInfo.InvariantCulture, def3, third, InterruptClient(asset.DeclaringType), asset));
			}
			if (asset.IsVirtual)
			{
				throw new ListenerTestItem("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".DeleteReader(CultureInfo.InvariantCulture, asset, InterruptClient(asset.DeclaringType), third));
			}
			if (asset.ReturnType != typeof(void))
			{
				throw new ListenerTestItem("Serialization Callback '{1}' in type '{0}' must return void.".SelectReader(CultureInfo.InvariantCulture, InterruptClient(asset.DeclaringType), asset));
			}
			if (third == typeof(ListClassDispatcher))
			{
				if (ivk == null || ivk.Length != 2 || ivk[0].ParameterType != typeof(StreamingContext) || ivk[1].ParameterType != typeof(ValErrorFilter))
				{
					throw new ListenerTestItem("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".TestReader(CultureInfo.InvariantCulture, InterruptClient(asset.DeclaringType), asset, typeof(StreamingContext), typeof(ValErrorFilter)));
				}
			}
			else if (ivk == null || ivk.Length != 1 || ivk[0].ParameterType != typeof(StreamingContext))
			{
				throw new ListenerTestItem("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".DeleteReader(CultureInfo.InvariantCulture, InterruptClient(asset.DeclaringType), asset, typeof(StreamingContext)));
			}
			def3 = third;
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string InterruptClient(Type first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first.PublishReader() || !first.CollectReader())
			{
				return first.FullName;
			}
			return "{0}.{1}".SelectReader(CultureInfo.InvariantCulture, first.Namespace, first.Name);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IList<ProductInstanceExpression> _0001(Type setup, ServerComposer ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<MemberInfo> obj = this._0001(setup) ?? throw new StrategyError("Null collection of serializable members returned.");
			ContextRequestStrategy contextRequestStrategy = this._0001();
			CreatorTestItem creatorTestItem = new CreatorTestItem(setup);
			foreach (MemberInfo item in obj)
			{
				ProductInstanceExpression productInstanceExpression = _0001(item, ivk);
				if (productInstanceExpression != null)
				{
					lock (contextRequestStrategy)
					{
						productInstanceExpression._0001(contextRequestStrategy.ConnectError(productInstanceExpression._0001()));
					}
					creatorTestItem.CollectClient(productInstanceExpression);
				}
			}
			return creatorTestItem.OrderBy((ProductInstanceExpression reference) => reference._0001() ?? (-1)).ToList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual ContextRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return parserTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual RoleTestItem _0001(MemberInfo item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001())
			{
				return new StructIteratorMapping(item);
			}
			return new AttributeDicCandidate(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual ProductInstanceExpression _0001(MemberInfo reference, ServerComposer connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProductInstanceExpression productInstanceExpression = new ProductInstanceExpression();
			productInstanceExpression._0002(ResolverErrorFilter.InsertReader(reference));
			productInstanceExpression._0001(reference.DeclaringType);
			productInstanceExpression._0001(_0001(reference));
			productInstanceExpression._0001(new ComparatorProperty(reference));
			CalcClient(productInstanceExpression, reference, reference.Name, reference.DeclaringType, connection, out bool value);
			if (connection != (ServerComposer)2)
			{
				productInstanceExpression._0002(ResolverErrorFilter.LogoutReader(reference, value));
				productInstanceExpression._0003(ResolverErrorFilter.VisitReader(reference, value, productInstanceExpression._0004()));
			}
			else
			{
				productInstanceExpression._0002(isres: true);
				productInstanceExpression._0003(islast: true);
			}
			if (!_0006())
			{
				productInstanceExpression._0001(InstantiateClient(reference));
			}
			if (!_0005())
			{
				ReflectClient(productInstanceExpression, reference, value);
			}
			return productInstanceExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CalcClient(ProductInstanceExpression last, object counter, string pool, Type cont2, ServerComposer cont3, out bool value4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DataContractAttribute dataContractAttribute = ConfigProperty.CloneClass(cont2);
			MemberInfo memberInfo = counter as MemberInfo;
			DataMemberAttribute dataMemberAttribute = (dataContractAttribute == null || !(memberInfo != null)) ? null : ConfigProperty.LogoutClass(memberInfo);
			TokenizerError tokenizerError = ConfigProperty.ReadClass<TokenizerError>(counter);
			ProcBroadcasterDispatcher procBroadcasterDispatcher = ConfigProperty.ReadClass<ProcBroadcasterDispatcher>(counter);
			string text;
			bool setattr;
			if (tokenizerError != null && tokenizerError._0001() != null)
			{
				text = tokenizerError._0001();
				setattr = true;
			}
			else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
			{
				text = dataMemberAttribute.Name;
				setattr = true;
			}
			else
			{
				text = pool;
				setattr = false;
			}
			RefDic refDic = ConfigProperty.ReadClass<RefDic>(cont2);
			ProducerIteratorMapping producerIteratorMapping = (tokenizerError?._0002() != null) ? ConfigProperty.MoveClass(tokenizerError._0002(), tokenizerError._0002()) : ((!(refDic?._0002() != null)) ? this._0001() : ConfigProperty.PopClass(refDic));
			if (producerIteratorMapping != null)
			{
				last._0001(producerIteratorMapping._0001(text, setattr));
			}
			else
			{
				last._0001(_0001(text));
			}
			last._0002(pool);
			bool flag = false;
			if (tokenizerError != null)
			{
				last.contextProperty = tokenizerError.m_StubError;
				last._0001(tokenizerError.m_StructError);
				last._0001(tokenizerError._MappingError);
				flag = true;
				last._0001(tokenizerError.printerError);
				last._0001(tokenizerError.mockError);
				last._0001(tokenizerError.observerError);
				last._0001(tokenizerError._DescriptorError);
				last._0001(tokenizerError.m_ProducerError);
				last._0002(tokenizerError.m_CodeError);
				last._0002((tokenizerError._0001() != null) ? ConfigProperty.ConnectClass(tokenizerError._0001(), tokenizerError._0001()) : null);
				last._0002(tokenizerError._TaskError);
				last._0002(tokenizerError.customerError);
			}
			else
			{
				last._0001((ApplicationState?)null);
				last._0001((FacadeComposer?)null);
				last._0001((PageDicCandidate?)null);
				last._0001((SparklineAxisMinMaxValues?)null);
				last._0001((bool?)null);
				last._0002((bool?)null);
				last._0002((BroadcasterError)null);
				last._0002((FacadeComposer?)null);
				last._0002((SparklineAxisMinMaxValues?)null);
				if (dataMemberAttribute != null)
				{
					last.contextProperty = (dataMemberAttribute.IsRequired ? ((SpecificationTestItem)1) : ((SpecificationTestItem)0));
					last._0001((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
					last._0001((!dataMemberAttribute.EmitDefaultValue) ? new ConnectActionCursor?((ConnectActionCursor)1) : null);
					flag = true;
				}
			}
			if (procBroadcasterDispatcher != null)
			{
				last.contextProperty = (SpecificationTestItem)2;
				flag = true;
			}
			last._0004(flag);
			bool flag2 = ConfigProperty.ReadClass<AuthenticationError>(counter) != null || ConfigProperty.ReadClass<IteratorError>(counter) != null || ConfigProperty.AwakeClass(counter);
			if (cont3 != (ServerComposer)1)
			{
				bool flag3 = false;
				flag3 = (ConfigProperty.ReadClass<IgnoreDataMemberAttribute>(counter) != null);
				last._0001(flag2 || flag3);
			}
			else
			{
				last._0001(flag2 || !flag);
			}
			last._0001(ConfigProperty.ViewClass(counter));
			DefaultValueAttribute defaultValueAttribute = ConfigProperty.ReadClass<DefaultValueAttribute>(counter);
			if (defaultValueAttribute != null)
			{
				last._0001(defaultValueAttribute.Value);
			}
			value4 = false;
			if ((this._0001() & BindingFlags.NonPublic) == BindingFlags.NonPublic)
			{
				value4 = true;
			}
			if (flag)
			{
				value4 = true;
			}
			if (cont3 == (ServerComposer)2)
			{
				value4 = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Predicate<object> InstantiateClient(MemberInfo spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo method = spec.DeclaringType.GetMethod("ShouldSerialize" + spec.Name, ResolverErrorFilter.collectionTest);
			if (method == null || method.ReturnType != typeof(bool))
			{
				return null;
			}
			Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule = ConfigProperty._0001()._0001<object>(method);
			return (object P_0) => (bool)clientInstanceRule(P_0, new object[0]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReflectClient(ProductInstanceExpression key, MemberInfo pol, bool helperopen)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MemberInfo memberInfo = pol.DeclaringType.GetProperty(pol.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (memberInfo == null)
			{
				memberInfo = pol.DeclaringType.GetField(pol.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			if (!(memberInfo == null) && !(ResolverErrorFilter.InsertReader(memberInfo) != typeof(bool)))
			{
				Func<object, object> func = ConfigProperty._0001().ValidateIssuer<object>(memberInfo);
				key._0002((object P_0) => (bool)func(P_0));
				if (ResolverErrorFilter.VisitReader(memberInfo, helperopen, addrule: false))
				{
					key._0001(ConfigProperty._0001().OrderIssuer<object>(memberInfo));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string _0001(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() != null)
			{
				return this._0001()._0001(res, setattr: false);
			}
			return res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string _0002(string v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() != null)
			{
				return this._0001()._0002(v);
			}
			return v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string _0003(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() != null)
			{
				return this._0001()._0003(key);
			}
			return _0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ResetClient(string v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PublisherRequestStrategy()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_ValueTest = new PublisherRequestStrategy();
			parameterTest = new string[3]
			{
				"System.IO.DriveInfo",
				"System.IO.FileInfo",
				"System.IO.DirectoryInfo"
			};
			prototypeTest = new BroadcasterError[10]
			{
				new FactoryIssuer(),
				new CallbackIssuer(),
				new TokenIssuer(),
				new StrategyIssuer(),
				new RepositoryListAnnotation(),
				new FieldReaderMapper(),
				new ValueIssuer(),
				new MerchantIssuer(),
				new CollectionListAnnotation(),
				new ConfigComposerWorker()
			};
		}
	}
}
