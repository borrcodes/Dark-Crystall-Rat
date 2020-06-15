using _0008;
using GDBD.Dispatcher;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	[_0008._0012(0)]
	internal static class ParamRequestStrategy
	{
		[_0008._0012(0)]
		internal sealed class RegistryTest
		{
			[CompilerGenerated]
			private string _AttrTest;

			[CompilerGenerated]
			private string m_ConfigurationTest;

			[CompilerGenerated]
			private string _CandidateTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RegistryTest(string key, string cfg, string temp)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				_0001(key);
				_0002(cfg);
				_0003(temp);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public string _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _AttrTest;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0001(string i)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_AttrTest = i;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public string _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return m_ConfigurationTest;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0002(string i)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				m_ConfigurationTest = i;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public string _0003()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _CandidateTest;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0003(string key)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_CandidateTest = key;
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(0)]
			public string _0001;

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
			internal bool _0001(RegistryTest P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0._0001() == this._0001;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class TokenizerTest
		{
			[_0008._0012(0)]
			public static readonly TokenizerTest printerTest;

			[_0008._0012(0)]
			public static Func<MethodInfo, bool> _MappingTest;

			[_0008._0012(0)]
			public static Func<MethodInfo, bool> mockTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static TokenizerTest()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				printerTest = new TokenizerTest();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TokenizerTest()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ReflectIssuer(MethodInfo spec)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (spec.Name == "CreateRange")
				{
					return spec.GetParameters().Length == 1;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ResetIssuer(MethodInfo v)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ParameterInfo[] parameters = v.GetParameters();
				if (v.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.CallReader())
				{
					return parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			[_0008._0012(0)]
			public string _0001;

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
			internal bool _0001(RegistryTest P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0._0001() == this._0001;
			}
		}

		private static readonly IList<RegistryTest> _QueueTest;

		private static readonly IList<RegistryTest> proxyTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CalcIssuer(Type i, Type b, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(2)] out Type _0004, [_0008._0012(new byte[]
		{
			2,
			1
		})] [ConsumerBroadcasterDispatcher(true)] out GDBD.Specifications.AdapterClassSpec<object> _0005)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i.CallReader())
			{
				Type genericTypeDefinition = i.GetGenericTypeDefinition();
				string fullName = genericTypeDefinition.FullName;
				RegistryTest registryTest = _QueueTest.FirstOrDefault((RegistryTest P_0) => P_0._0001() == fullName);
				if (registryTest != null)
				{
					Type type = genericTypeDefinition.RevertReader().GetType(registryTest._0002());
					Type type2 = genericTypeDefinition.RevertReader().GetType(registryTest._0003());
					if (type != null && type2 != null)
					{
						MethodInfo methodInfo = type2.GetMethods().FirstOrDefault((MethodInfo spec) => spec.Name == "CreateRange" && spec.GetParameters().Length == 1);
						if (methodInfo != null)
						{
							_0004 = type.MakeGenericType(b);
							MethodInfo v = methodInfo.MakeGenericMethod(b);
							_0005 = ConfigProperty._0001()._0001(v);
							return true;
						}
					}
				}
			}
			_0004 = null;
			_0005 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool InstantiateIssuer(Type setup, Type result, Type consumer, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(2)] out Type _0005, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(new byte[]
		{
			2,
			1
		})] out GDBD.Specifications.AdapterClassSpec<object> _0006)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup.CallReader())
			{
				Type genericTypeDefinition = setup.GetGenericTypeDefinition();
				string fullName = genericTypeDefinition.FullName;
				RegistryTest registryTest = proxyTest.FirstOrDefault((RegistryTest P_0) => P_0._0001() == fullName);
				if (registryTest != null)
				{
					Type type = genericTypeDefinition.RevertReader().GetType(registryTest._0002());
					Type type2 = genericTypeDefinition.RevertReader().GetType(registryTest._0003());
					if (type != null && type2 != null)
					{
						MethodInfo methodInfo = type2.GetMethods().FirstOrDefault(delegate(MethodInfo v)
						{
							//Discarded unreachable code: IL_0002
							//IL_0003: Incompatible stack heights: 0 vs 1
							ParameterInfo[] parameters = v.GetParameters();
							return v.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.CallReader() && parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
						});
						if (methodInfo != null)
						{
							_0005 = type.MakeGenericType(result, consumer);
							MethodInfo v2 = methodInfo.MakeGenericMethod(result, consumer);
							_0006 = ConfigProperty._0001()._0001(v2);
							return true;
						}
					}
				}
			}
			_0005 = null;
			_0006 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParamRequestStrategy()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_QueueTest = new List<RegistryTest>
			{
				new RegistryTest("System.Collections.Immutable.IImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
				new RegistryTest("System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
				new RegistryTest("System.Collections.Immutable.IImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
				new RegistryTest("System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
				new RegistryTest("System.Collections.Immutable.IImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
				new RegistryTest("System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
				new RegistryTest("System.Collections.Immutable.IImmutableSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
				new RegistryTest("System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
				new RegistryTest("System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
				new RegistryTest("System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray")
			};
			proxyTest = new List<RegistryTest>
			{
				new RegistryTest("System.Collections.Immutable.IImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary"),
				new RegistryTest("System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
				new RegistryTest("System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary")
			};
		}
	}
}
