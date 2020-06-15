using _0008;
using GDBD.Items;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal sealed class PrototypeFilterResolver : InitializerTest
	{
		[CompilerGenerated]
		private ServerComposer serverProperty;

		[CompilerGenerated]
		private InternalArrayTypeE? _FacadeProperty;

		[CompilerGenerated]
		private SpecificationTestItem? managerProperty;

		[CompilerGenerated]
		private ApplicationState? stateProperty;

		[CompilerGenerated]
		[_0008._0012(1)]
		private readonly CreatorTestItem resolverProperty;

		[CompilerGenerated]
		private StrategyRequestStrategy poolProperty;

		[CompilerGenerated]
		private PolicyIssuerMock m_ValProperty;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private Func<string, string> invocationProperty;

		internal bool m_DefinitionProperty;

		private bool? systemProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> identifierProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> getterProperty;

		private CreatorTestItem _SetterProperty;

		private Type m_WorkerProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new ServerComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return serverProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ServerComposer item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			serverProperty = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new InternalArrayTypeE? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _FacadeProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(InternalArrayTypeE? key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_FacadeProperty = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new SpecificationTestItem? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return managerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(SpecificationTestItem? res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			managerProperty = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new ApplicationState? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return stateProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ApplicationState? spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			stateProperty = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new CreatorTestItem _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return resolverProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new CreatorTestItem _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_SetterProperty == null)
			{
				_SetterProperty = new CreatorTestItem(base._0002());
			}
			return _SetterProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new GDBD.Specifications.AdapterClassSpec<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return identifierProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(GDBD.Specifications.AdapterClassSpec<object> spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			identifierProperty = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new GDBD.Specifications.AdapterClassSpec<object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return getterProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0002(GDBD.Specifications.AdapterClassSpec<object> res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			getterProperty = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new StrategyRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return poolProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(StrategyRequestStrategy var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			poolProperty = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new PolicyIssuerMock _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ValProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(PolicyIssuerMock res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ValProperty = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(Type first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_WorkerProperty = first;
			m_DefinitionProperty = (first != null && typeof(ParserFilterResolver).IsAssignableFrom(first));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Func<string, string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return invocationProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Func<string, string> spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			invocationProperty = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!systemProperty.HasValue)
			{
				systemProperty = false;
				if (this._0001().GetValueOrDefault((SpecificationTestItem)0) != 0)
				{
					systemProperty = true;
				}
				else
				{
					foreach (ProductInstanceExpression item in this._0001())
					{
						if (item._0001() != 0 || ((int?)item._0001() & 2) == 2)
						{
							systemProperty = true;
							break;
						}
					}
				}
			}
			return systemProperty.GetValueOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrototypeFilterResolver(Type res)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(res);
			_ErrorProperty = (ParameterFilterResolver)1;
			resolverProperty = new CreatorTestItem(base._0002());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecuritySafeCritical]
		internal object ManageClient()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ConfigProperty._0002())
			{
				throw new ListenerTestItem("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.".ListReader(CultureInfo.InvariantCulture, _InstanceProperty));
			}
			return FormatterServices.GetUninitializedObject(_InstanceProperty);
		}
	}
}
