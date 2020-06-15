using _0008;
using GDBD.Importers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[_0008._0012(0)]
	internal sealed class ParamClientBridge : InitializerTest
	{
		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private Func<string, string> _ServiceProperty;

		[CompilerGenerated]
		private readonly Type queueProperty;

		[CompilerGenerated]
		private readonly Type m_ProxyProperty;

		[CompilerGenerated]
		private ProcTest registryProperty;

		private readonly Type m_AttrProperty;

		private Type m_ConfigurationProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> candidateProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private Func<object> _TokenizerProperty;

		[CompilerGenerated]
		private readonly bool printerProperty;

		private readonly ConstructorInfo m_MappingProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> _MockProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> _ObserverProperty;

		[CompilerGenerated]
		private bool m_DescriptorProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Func<string, string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ServiceProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Func<string, string> first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ServiceProperty = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return queueProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Type _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ProxyProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new ProcTest _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return registryProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0002(ProcTest last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			registryProperty = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return printerProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new GDBD.Specifications.AdapterClassSpec<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ObserverProperty == null && m_MappingProperty != null)
			{
				_ObserverProperty = ConfigProperty._0001()._0001(m_MappingProperty);
			}
			return _ObserverProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new GDBD.Specifications.AdapterClassSpec<object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _MockProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(GDBD.Specifications.AdapterClassSpec<object> init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_MockProperty = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_DescriptorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool usetask)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_DescriptorProperty = usetask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!this._0002() && _ObserverProperty == null)
			{
				return m_MappingProperty != null;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParamClientBridge(Type asset)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(asset);
			_ErrorProperty = (ParameterFilterResolver)5;
			Type second;
			Type util;
			if (ResolverErrorFilter.FillReader(asset, typeof(IDictionary<, >), out m_AttrProperty))
			{
				second = m_AttrProperty.GetGenericArguments()[0];
				util = m_AttrProperty.GetGenericArguments()[1];
				if (ResolverErrorFilter.OrderReader(base._0002(), typeof(IDictionary<, >)))
				{
					_0002(typeof(Dictionary<, >).MakeGenericType(second, util));
				}
				else if (asset.CallReader() && asset.GetGenericTypeDefinition().FullName == "System.Collections.Concurrent.ConcurrentDictionary`2")
				{
					printerProperty = true;
				}
			}
			else
			{
				ResolverErrorFilter.MapReader(base._0002(), out second, out util);
				if (base._0002() == typeof(IDictionary))
				{
					_0002(typeof(Dictionary<object, object>));
				}
			}
			if (second != null && util != null)
			{
				m_MappingProperty = ObserverIteratorMapping.InitTest(base._0003(), typeof(KeyValuePair<, >).MakeGenericType(second, util), typeof(IDictionary<, >).MakeGenericType(second, util));
				if (!this._0003() && asset.Name == "FSharpMap`2")
				{
					PropertyTest.MoveIssuer(asset.RevertReader());
					_ObserverProperty = PropertyTest._0001().IncludeIssuer(second, util);
				}
			}
			if (!typeof(IDictionary).IsAssignableFrom(base._0003()))
			{
				printerProperty = true;
			}
			queueProperty = second;
			m_ProxyProperty = util;
			if (this._0001() != null && _0004() != null && ParamRequestStrategy.InstantiateIssuer(asset, this._0001(), _0004(), out Type _0005, out GDBD.Specifications.AdapterClassSpec<object> _0006))
			{
				_0002(_0005);
				_ObserverProperty = _0006;
				composerProperty = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ProcessComposer CountClient(object key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (candidateProperty == null)
			{
				m_ConfigurationProperty = typeof(IssuerInstanceRule<, >).MakeGenericType(this._0001(), _0004());
				ConstructorInfo constructor = m_ConfigurationProperty.GetConstructor(new Type[1]
				{
					m_AttrProperty
				});
				candidateProperty = ConfigProperty._0001()._0001(constructor);
			}
			return (ProcessComposer)candidateProperty(new object[1]
			{
				key
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IDictionary AssetClient()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_TokenizerProperty == null)
			{
				Type task = typeof(Dictionary<, >).MakeGenericType(this._0001() ?? typeof(object), _0004() ?? typeof(object));
				_TokenizerProperty = ConfigProperty._0001()._0001<object>(task);
			}
			return (IDictionary)_TokenizerProperty();
		}
	}
}
