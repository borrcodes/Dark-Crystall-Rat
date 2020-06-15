using _0008;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Rules;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal sealed class PropertyTest
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			[_0008._0012(new byte[]
			{
				0,
				2,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001;

			[_0008._0012(new byte[]
			{
				0,
				2,
				1
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0002;

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
			internal object _0001(object P_0, object[] P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return new ParamsComposerWorker(this._0001(P_0, P_1), _0002);
			}
		}

		private static readonly object issuerTest;

		[_0008._0012(2)]
		private static PropertyTest m_ReaderTest;

		private MethodInfo clientTest;

		private Type _BroadcasterTest;

		[CompilerGenerated]
		private Assembly _ClassTest;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> requestTest;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> _IteratorTest;

		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		[CompilerGenerated]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> m_TestsTest;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> m_MethodTest;

		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		[CompilerGenerated]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> m_AuthenticationTest;

		[CompilerGenerated]
		private Func<object, object> m_MapperTest;

		[CompilerGenerated]
		private Func<object, object> m_PredicateTest;

		[CompilerGenerated]
		private Func<object, object> policyTest;

		[_0008._0012(new byte[]
		{
			1,
			1,
			2
		})]
		[CompilerGenerated]
		private Newtonsoft.Rules.ClientInstanceRule<object, object> serviceTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PropertyTest(Assembly asset)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001(asset);
			Type type = asset.GetType("Microsoft.FSharp.Reflection.FSharpType");
			MethodInfo v = PopIssuer(type, "IsUnion", BindingFlags.Static | BindingFlags.Public);
			_0001(ConfigProperty._0001()._0001<object>(v));
			MethodInfo v2 = PopIssuer(type, "GetUnionCases", BindingFlags.Static | BindingFlags.Public);
			_0002(ConfigProperty._0001()._0001<object>(v2));
			Type type2 = asset.GetType("Microsoft.FSharp.Reflection.FSharpValue");
			_0003(NewIssuer(type2, "PreComputeUnionTagReader"));
			_0004(NewIssuer(type2, "PreComputeUnionReader"));
			_0005(NewIssuer(type2, "PreComputeUnionConstructor"));
			Type type3 = asset.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
			_0002(ConfigProperty._0001()._0001<object>(type3.GetProperty("Name")));
			_0003(ConfigProperty._0001()._0001<object>(type3.GetProperty("Tag")));
			_0001(ConfigProperty._0001()._0001<object>(type3.GetProperty("DeclaringType")));
			_0006(ConfigProperty._0001()._0001<object>(type3.GetMethod("GetFields")));
			Type type4 = asset.GetType("Microsoft.FSharp.Collections.ListModule");
			clientTest = type4.GetMethod("OfSeq");
			_BroadcasterTest = asset.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PropertyTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ReaderTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(Assembly res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ClassTest = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return requestTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(Newtonsoft.Rules.ClientInstanceRule<object, object> reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			requestTest = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IteratorTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0002(Newtonsoft.Rules.ClientInstanceRule<object, object> v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IteratorTest = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TestsTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0003(Newtonsoft.Rules.ClientInstanceRule<object, object> item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_TestsTest = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_MethodTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0004(Newtonsoft.Rules.ClientInstanceRule<object, object> i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MethodTest = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_AuthenticationTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0005(Newtonsoft.Rules.ClientInstanceRule<object, object> init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_AuthenticationTest = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Func<object, object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_MapperTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(Func<object, object> info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MapperTest = info;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Func<object, object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PredicateTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0002(Func<object, object> v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_PredicateTest = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Func<object, object> _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return policyTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0003(Func<object, object> setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			policyTest = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Newtonsoft.Rules.ClientInstanceRule<object, object> _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return serviceTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0006(Newtonsoft.Rules.ClientInstanceRule<object, object> item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			serviceTest = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveIssuer(Assembly ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ReaderTest == null)
			{
				lock (issuerTest)
				{
					if (m_ReaderTest == null)
					{
						m_ReaderTest = new PropertyTest(ident);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MethodInfo PopIssuer(Type asset, string selection, BindingFlags tag)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo method = asset.GetMethod(selection, tag);
			if (method == null && (tag & BindingFlags.NonPublic) != BindingFlags.NonPublic)
			{
				method = asset.GetMethod(selection, tag | BindingFlags.NonPublic);
			}
			return method;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Newtonsoft.Rules.ClientInstanceRule<object, object> NewIssuer(Type task, string pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo methodInfo = PopIssuer(task, pol, BindingFlags.Static | BindingFlags.Public);
			MethodInfo method = methodInfo.ReturnType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public);
			Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule = ConfigProperty._0001()._0001<object>(methodInfo);
			Newtonsoft.Rules.ClientInstanceRule<object, object> col = ConfigProperty._0001()._0001<object>(method);
			return (object P_0, object[] P_1) => new ParamsComposerWorker(clientInstanceRule(P_0, P_1), col);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GDBD.Specifications.AdapterClassSpec<object> ForgotIssuer(Type param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo v = clientTest.MakeGenericMethod(param);
			return ConfigProperty._0001()._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GDBD.Specifications.AdapterClassSpec<object> IncludeIssuer(Type first, Type visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (GDBD.Specifications.AdapterClassSpec<object>)typeof(PropertyTest).GetMethod("BuildMapCreator").MakeGenericMethod(first, visitor).Invoke(this, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PropertyTest()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			issuerTest = new object();
		}
	}
}
