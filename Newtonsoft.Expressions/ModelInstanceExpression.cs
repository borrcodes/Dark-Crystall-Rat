using _0008;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	[_0008._0012(0)]
	internal sealed class ModelInstanceExpression
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			[_0008._0012(new byte[]
			{
				0,
				1
			})]
			public Func<object> _0001;

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
				return this._0001();
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001;

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
			internal object _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001(P_0, new object[0]);
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			[_0008._0012(new byte[]
			{
				0,
				1,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001;

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
			internal void _0001(object P_0, object P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001(P_0, new object[1]
				{
					P_1
				});
			}
		}

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private readonly GDBD.Specifications.AdapterClassSpec<object> _InterpreterTest;

		[CompilerGenerated]
		private readonly IDictionary<string, StubTest> m_WatcherTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public GDBD.Specifications.AdapterClassSpec<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InterpreterTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public IDictionary<string, StubTest> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_WatcherTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ModelInstanceExpression(GDBD.Specifications.AdapterClassSpec<object> last)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_WatcherTest = new Dictionary<string, StubTest>();
			_InterpreterTest = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object CancelIssuer(object instance, string b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001()[b]._0001()(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExcludeIssuer(object value, string map, object util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001()[map]._0001()(value, util);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Type SetupIssuer(string reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001()[reference]._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ModelInstanceExpression ManageIssuer(Type task, string[] token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return InitIssuer(task, null, token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ModelInstanceExpression InitIssuer(Type var1, MethodBase cfg, string[] field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			VisitorComposer visitorComposer = ConfigProperty._0001();
			GDBD.Specifications.AdapterClassSpec<object> last = null;
			if (cfg != null)
			{
				last = visitorComposer._0001(cfg);
			}
			else if (ResolverErrorFilter.LoginReader(var1, isconnection: false))
			{
				Func<object> func = visitorComposer._0001<object>(var1);
				last = ((object[] P_0) => func());
			}
			ModelInstanceExpression modelInstanceExpression = new ModelInstanceExpression(last);
			Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule;
			Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule2;
			foreach (string text in field)
			{
				MemberInfo[] member = var1.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
				if (member.Length != 1)
				{
					throw new ArgumentException("Expected a single member with the name '{0}'.".ListReader(CultureInfo.InvariantCulture, text));
				}
				MemberInfo memberInfo = member.Single();
				StubTest stubTest = new StubTest();
				switch (memberInfo.DefineReader())
				{
				case MemberTypes.Field:
				case MemberTypes.Property:
					if (ResolverErrorFilter.LogoutReader(memberInfo, updateb: false))
					{
						stubTest._0001(visitorComposer.ValidateIssuer<object>(memberInfo));
					}
					if (ResolverErrorFilter.VisitReader(memberInfo, calcconnection: false, addrule: false))
					{
						stubTest._0001(visitorComposer.OrderIssuer<object>(memberInfo));
					}
					break;
				case MemberTypes.Method:
				{
					MethodInfo methodInfo = (MethodInfo)memberInfo;
					if (methodInfo.IsPublic)
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
						{
							clientInstanceRule = visitorComposer._0001<object>(methodInfo);
							stubTest._0001((object P_0) => clientInstanceRule(P_0, new object[0]));
						}
						else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
						{
							clientInstanceRule2 = visitorComposer._0001<object>(methodInfo);
							stubTest._0001(delegate(object P_0, object P_1)
							{
								//Discarded unreachable code: IL_0002
								//IL_0003: Incompatible stack heights: 0 vs 1
								clientInstanceRule2(P_0, new object[1]
								{
									P_1
								});
							});
						}
					}
					break;
				}
				default:
					throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".SelectReader(CultureInfo.InvariantCulture, memberInfo.DefineReader(), memberInfo.Name));
				}
				stubTest._0001(ResolverErrorFilter.InsertReader(memberInfo));
				modelInstanceExpression._0001()[text] = stubTest;
			}
			return modelInstanceExpression;
		}
	}
}
