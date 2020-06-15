using _0008;
using GDBD.Bridges;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal abstract class ProcTest
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			[_0008._0012(0)]
			public MethodInfo _0001;

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
			internal void _0001(object P_0, StreamingContext P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.Invoke(P_0, new object[1]
				{
					P_1
				});
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(0)]
			public MethodInfo _0001;

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
			internal void _0001(object P_0, StreamingContext P_1, ValErrorFilter P_2)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.Invoke(P_0, new object[2]
				{
					P_1,
					P_2
				});
			}
		}

		internal bool recordProperty;

		internal bool m_EventProperty;

		internal bool _FilterProperty;

		internal Type _InstanceProperty;

		internal Docking dicProperty;

		internal ParameterFilterResolver _ErrorProperty;

		internal bool composerProperty;

		internal bool propertyProperty;

		internal bool _IssuerProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<MessageInstanceExpression> m_ReaderProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<MessageInstanceExpression> _ClientProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<MessageInstanceExpression> m_BroadcasterProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<MessageInstanceExpression> _ClassProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<SingletonEventEntry> m_RequestProperty;

		private Type m_IteratorProperty;

		[CompilerGenerated]
		private readonly Type _TestsProperty;

		[CompilerGenerated]
		private bool? _MethodProperty;

		[_0008._0012(2)]
		[CompilerGenerated]
		private BroadcasterError m_AuthenticationProperty;

		[CompilerGenerated]
		[_0008._0012(2)]
		private BroadcasterError mapperProperty;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private Func<object> _PredicateProperty;

		[CompilerGenerated]
		private bool _PolicyProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _TestsProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Type _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_IteratorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(Type init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(init, "value");
			m_IteratorProperty = init;
			propertyProperty = m_IteratorProperty.DisableClient();
			_IssuerProperty = (!m_IteratorProperty.SortReader() && !m_IteratorProperty.VerifyClient());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool? _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _MethodProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool? init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_MethodProperty = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public BroadcasterError _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_AuthenticationProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(BroadcasterError key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_AuthenticationProperty = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public BroadcasterError _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return mapperProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0003(BroadcasterError config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			mapperProperty = config;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IList<MessageInstanceExpression> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ReaderProperty == null)
			{
				m_ReaderProperty = new List<MessageInstanceExpression>();
			}
			return m_ReaderProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IList<MessageInstanceExpression> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ClientProperty == null)
			{
				_ClientProperty = new List<MessageInstanceExpression>();
			}
			return _ClientProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IList<MessageInstanceExpression> _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BroadcasterProperty == null)
			{
				m_BroadcasterProperty = new List<MessageInstanceExpression>();
			}
			return m_BroadcasterProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IList<MessageInstanceExpression> _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ClassProperty == null)
			{
				_ClassProperty = new List<MessageInstanceExpression>();
			}
			return _ClassProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IList<SingletonEventEntry> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RequestProperty == null)
			{
				m_RequestProperty = new List<SingletonEventEntry>();
			}
			return m_RequestProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Func<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _PredicateProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Func<object> reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_PredicateProperty = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _PolicyProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0003(bool isreference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_PolicyProperty = isreference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ProcTest(Type task)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(task, "underlyingType");
			_TestsProperty = task;
			task = ResolverErrorFilter.ValidateReader(task);
			recordProperty = ResolverErrorFilter.VerifyReader(task);
			_InstanceProperty = ((recordProperty && ResolverErrorFilter.PatchReader(task)) ? Nullable.GetUnderlyingType(task) : task);
			Type instanceProperty;
			_0002(instanceProperty = _InstanceProperty);
			m_IteratorProperty = instanceProperty;
			m_EventProperty = HelperDicCandidate.OrderProperty(_InstanceProperty);
			_FilterProperty = _InstanceProperty.LoginClient();
			dicProperty = (Docking)0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ListClient(object first, StreamingContext cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ClassProperty != null)
			{
				foreach (MessageInstanceExpression item in _ClassProperty)
				{
					item(first, cfg);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SelectClient(object config, StreamingContext cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_BroadcasterProperty != null)
			{
				foreach (MessageInstanceExpression item in m_BroadcasterProperty)
				{
					item(config, cont);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void DeleteClient(object def, StreamingContext cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ClientProperty != null)
			{
				foreach (MessageInstanceExpression item in _ClientProperty)
				{
					item(def, cfg);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void TestClient(object init, StreamingContext selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ReaderProperty != null)
			{
				foreach (MessageInstanceExpression item in m_ReaderProperty)
				{
					item(init, selection);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ConcatClient(object value, StreamingContext cfg, ValErrorFilter comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RequestProperty != null)
			{
				foreach (SingletonEventEntry item in m_RequestProperty)
				{
					item(value, cfg, comp);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MessageInstanceExpression InvokeClient(MethodInfo setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return delegate(object P_0, StreamingContext P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				setup.Invoke(P_0, new object[1]
				{
					P_1
				});
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SingletonEventEntry PrintClient(MethodInfo task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return delegate(object P_0, StreamingContext P_1, ValErrorFilter P_2)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				task.Invoke(P_0, new object[2]
				{
					P_1,
					P_2
				});
			};
		}
	}
}
