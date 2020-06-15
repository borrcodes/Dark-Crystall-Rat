using _0008;
using GDBD.Mocks;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Database
{
	[_0008._0012(0)]
	internal static class TokenEventEntry
	{
		[_0008._0012(0)]
		internal static class GlobalComposer
		{
			[_0008._0012(2)]
			private static object _WrapperComposer;

			[_0008._0012(2)]
			private static object paramsComposer;

			[_0008._0012(2)]
			private static Newtonsoft.Rules.ClientInstanceRule<object, object> _TemplateComposer;

			[_0008._0012(2)]
			private static Newtonsoft.Rules.ClientInstanceRule<object, object> expressionComposer;

			private static bool _ConfigComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void FillIssuer()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (!_ConfigComposer)
				{
					if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: false) == null)
					{
						throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".ListReader(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
					}
					_WrapperComposer = RunIssuer(new int[1]);
					paramsComposer = RunIssuer(new int[2]
					{
						0,
						3
					});
					CompareIssuer();
					_ConfigComposer = true;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private static object RunIssuer(int[] ident)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Array array = Array.CreateInstance(type, ident.Length);
				for (int i = 0; i < ident.Length; i++)
				{
					object value = type.GetMethod("Create", new Type[2]
					{
						type2,
						typeof(string)
					}).Invoke(null, new object[2]
					{
						0,
						null
					});
					array.SetValue(value, i);
				}
				return array;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void CompareIssuer()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
				Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
				Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
				Type type4 = typeof(IEnumerable<>).MakeGenericType(type);
				MethodInfo method = type3.GetMethod("GetMember", new Type[4]
				{
					type2,
					typeof(string),
					typeof(Type),
					type4
				});
				_TemplateComposer = ConfigProperty._0001()._0001<object>(method);
				MethodInfo method2 = type3.GetMethod("SetMember", new Type[4]
				{
					type2,
					typeof(string),
					typeof(Type),
					type4
				});
				expressionComposer = ConfigProperty._0001()._0001<object>(method2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static CallSiteBinder AddIssuer(string i, Type vis)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				FillIssuer();
				return (CallSiteBinder)_TemplateComposer(null, new object[4]
				{
					0,
					i,
					vis,
					_WrapperComposer
				});
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static CallSiteBinder EnableIssuer(string info, Type second)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				FillIssuer();
				return (CallSiteBinder)expressionComposer(null, new object[4]
				{
					0,
					info,
					second,
					paramsComposer
				});
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<string> ResolveIssuer(this IDynamicMetaObjectProvider spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return spec.GetMetaObject(Expression.Constant(spec)).GetDynamicMemberNames();
		}
	}
}
