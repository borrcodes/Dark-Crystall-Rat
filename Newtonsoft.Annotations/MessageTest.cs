using _0008;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	[_0008._0012(0)]
	internal sealed class MessageTest : InitializerTest
	{
		[CompilerGenerated]
		private readonly Type _ProductTest;

		[CompilerGenerated]
		private readonly bool m_InterceptorTest;

		private readonly Type _AlgoTest;

		private Type annotationTest;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> m_ExporterTest;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private Func<object> _VisitorTest;

		[CompilerGenerated]
		private readonly bool m_GlobalTest;

		[CompilerGenerated]
		private readonly bool _WrapperTest;

		[CompilerGenerated]
		private bool m_ParamsTest;

		private readonly ConstructorInfo _TemplateTest;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> m_ExpressionTest;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private GDBD.Specifications.AdapterClassSpec<object> m_ConfigTest;

		[CompilerGenerated]
		private bool m_ConnectionTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ProductTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InterceptorTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_GlobalTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _WrapperTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ParamsTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(bool forcedef)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ParamsTest = forcedef;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new GDBD.Specifications.AdapterClassSpec<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ExpressionTest == null && _TemplateTest != null)
			{
				m_ExpressionTest = ConfigProperty._0001()._0001(_TemplateTest);
			}
			return m_ExpressionTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new GDBD.Specifications.AdapterClassSpec<object> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ConfigTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(GDBD.Specifications.AdapterClassSpec<object> task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ConfigTest = task;
			_0001(forcedef: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ConnectionTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool isasset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ConnectionTest = isasset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_0005() && m_ExpressionTest == null)
			{
				return _TemplateTest != null;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MessageTest(Type instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(instance);
			_ErrorProperty = (ParameterFilterResolver)2;
			m_GlobalTest = (base._0003().IsArray || (_InstanceProperty.CallReader() && _InstanceProperty.GetGenericTypeDefinition().FullName == "System.Linq.EmptyPartition`1"));
			bool forcedef;
			Type _0004;
			if (this._0002())
			{
				_ProductTest = ResolverErrorFilter.EnableReader(base._0002());
				composerProperty = true;
				_AlgoTest = typeof(List<>).MakeGenericType(this._0001());
				forcedef = true;
				m_InterceptorTest = (base._0003().IsArray && base._0002().GetArrayRank() > 1);
			}
			else if (typeof(IList).IsAssignableFrom(_InstanceProperty))
			{
				if (ResolverErrorFilter.FillReader(_InstanceProperty, typeof(ICollection<>), out _AlgoTest))
				{
					_ProductTest = _AlgoTest.GetGenericArguments()[0];
				}
				else
				{
					_ProductTest = ResolverErrorFilter.EnableReader(_InstanceProperty);
				}
				if (_InstanceProperty == typeof(IList))
				{
					_0002(typeof(List<object>));
				}
				if (this._0001() != null)
				{
					_TemplateTest = ObserverIteratorMapping.ManageTest(_InstanceProperty, this._0001());
				}
				composerProperty = ResolverErrorFilter.RunReader(_InstanceProperty, typeof(ReadOnlyCollection<>));
				forcedef = true;
			}
			else if (ResolverErrorFilter.FillReader(_InstanceProperty, typeof(ICollection<>), out _AlgoTest))
			{
				_ProductTest = _AlgoTest.GetGenericArguments()[0];
				if (ResolverErrorFilter.OrderReader(_InstanceProperty, typeof(ICollection<>)) || ResolverErrorFilter.OrderReader(_InstanceProperty, typeof(IList<>)))
				{
					_0002(typeof(List<>).MakeGenericType(this._0001()));
				}
				if (ResolverErrorFilter.OrderReader(_InstanceProperty, typeof(ISet<>)))
				{
					_0002(typeof(HashSet<>).MakeGenericType(this._0001()));
				}
				_TemplateTest = ObserverIteratorMapping.ManageTest(_InstanceProperty, this._0001());
				forcedef = true;
				_WrapperTest = true;
			}
			else if (ResolverErrorFilter.FillReader(_InstanceProperty, typeof(IEnumerable<>), out _0004))
			{
				_ProductTest = _0004.GetGenericArguments()[0];
				if (ResolverErrorFilter.OrderReader(base._0002(), typeof(IEnumerable<>)))
				{
					_0002(typeof(List<>).MakeGenericType(this._0001()));
				}
				_TemplateTest = ObserverIteratorMapping.ManageTest(_InstanceProperty, this._0001());
				StartClient(_InstanceProperty);
				if (_InstanceProperty.CallReader() && _InstanceProperty.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					_AlgoTest = _0004;
					composerProperty = false;
					_WrapperTest = false;
					forcedef = true;
				}
				else
				{
					_AlgoTest = typeof(List<>).MakeGenericType(this._0001());
					composerProperty = true;
					_WrapperTest = true;
					forcedef = _0006();
				}
			}
			else
			{
				forcedef = false;
				_WrapperTest = true;
			}
			_0001(forcedef);
			if (this._0001() != null && ParamRequestStrategy.CalcIssuer(_InstanceProperty, this._0001(), out Type _00042, out GDBD.Specifications.AdapterClassSpec<object> _0005))
			{
				_0002(_00042);
				m_ExpressionTest = _0005;
				composerProperty = true;
				_0001(forcedef: true);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ManagerErrorFilter CalculateClient(object def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ExporterTest == null)
			{
				annotationTest = typeof(GDBD.Dispatcher.SetterComposer<>).MakeGenericType(this._0001());
				Type type = (!ResolverErrorFilter.RunReader(_AlgoTest, typeof(List<>)) && !(_AlgoTest.GetGenericTypeDefinition() == typeof(IEnumerable<>))) ? _AlgoTest : typeof(ICollection<>).MakeGenericType(this._0001());
				ConstructorInfo constructor = annotationTest.GetConstructor(new Type[1]
				{
					type
				});
				m_ExporterTest = ConfigProperty._0001()._0001(constructor);
			}
			return (ManagerErrorFilter)m_ExporterTest(new object[1]
			{
				def
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IList GetClient()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_VisitorTest == null)
			{
				Type type = (this._0001() || this._0001() == null) ? typeof(object) : this._0001();
				Type task = typeof(List<>).MakeGenericType(type);
				_VisitorTest = ConfigProperty._0001()._0001<object>(task);
			}
			return (IList)_VisitorTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartClient(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_0006() && last.Name == "FSharpList`1")
			{
				PropertyTest.MoveIssuer(last.RevertReader());
				m_ExpressionTest = PropertyTest._0001().ForgotIssuer(this._0001());
			}
		}
	}
}
