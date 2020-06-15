using _0008;
using GDBD.Bridges;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	[_0008._0012(0)]
	internal sealed class AnnotationComposer : VisitorComposer
	{
		[CompilerGenerated]
		private new sealed class _0001<_0001>
		{
			[_0008._0012(0)]
			public object _0001;

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
			internal object _0001(_0001 P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001;
			}
		}

		[CompilerGenerated]
		private static readonly AnnotationComposer exporterComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal static AnnotationComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return exporterComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DynamicMethod RevertProperty(string item, Type ivk, Type[] proc, Type t2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (t2.SortReader())
			{
				return new DynamicMethod(item, ivk, proc, t2.Module, skipVisibility: true);
			}
			return new DynamicMethod(item, ivk, proc, t2, skipVisibility: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GDBD.Specifications.AdapterClassSpec<object> _0001(MethodBase setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty(setup.ToString(), typeof(object), new Type[1]
			{
				typeof(object[])
			}, setup.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			LoginIssuer(setup, iLGenerator, 0);
			return (GDBD.Specifications.AdapterClassSpec<object>)dynamicMethod.CreateDelegate(typeof(GDBD.Specifications.AdapterClassSpec<object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.ClientInstanceRule<T, object> _0001<[_0008._0012(2)] T>(MethodBase v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty(v.ToString(), typeof(object), new Type[2]
			{
				typeof(object),
				typeof(object[])
			}, v.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			LoginIssuer(v, iLGenerator, 1);
			return (Newtonsoft.Rules.ClientInstanceRule<T, object>)dynamicMethod.CreateDelegate(typeof(Newtonsoft.Rules.ClientInstanceRule<T, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoginIssuer(MethodBase param, ILGenerator reg, int nextproc)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParameterInfo[] parameters = param.GetParameters();
			Label label = reg.DefineLabel();
			reg.Emit(OpCodes.Ldarg, nextproc);
			reg.Emit(OpCodes.Ldlen);
			reg.Emit(OpCodes.Ldc_I4, parameters.Length);
			reg.Emit(OpCodes.Beq, label);
			reg.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(ResolverErrorFilter.collectionTest));
			reg.Emit(OpCodes.Throw);
			reg.MarkLabel(label);
			if (!param.IsConstructor && !param.IsStatic)
			{
				reg.PushIssuer(param.DeclaringType);
			}
			LocalBuilder local = reg.DeclareLocal(typeof(IConvertible));
			LocalBuilder local2 = reg.DeclareLocal(typeof(object));
			OpCode opcode = (parameters.Length < 256) ? OpCodes.Ldloca_S : OpCodes.Ldloca;
			OpCode opcode2 = (parameters.Length < 256) ? OpCodes.Ldloc_S : OpCodes.Ldloc;
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type parameterType = parameterInfo.ParameterType;
				if (parameterType.IsByRef)
				{
					parameterType = parameterType.GetElementType();
					LocalBuilder local3 = reg.DeclareLocal(parameterType);
					if (!parameterInfo.IsOut)
					{
						reg.PrepareIssuer(nextproc, i);
						if (parameterType.FindClient())
						{
							Label label2 = reg.DefineLabel();
							Label label3 = reg.DefineLabel();
							reg.Emit(OpCodes.Brtrue_S, label2);
							reg.Emit(opcode, local3);
							reg.Emit(OpCodes.Initobj, parameterType);
							reg.Emit(OpCodes.Br_S, label3);
							reg.MarkLabel(label2);
							reg.PrepareIssuer(nextproc, i);
							reg.UpdateIssuer(parameterType);
							reg.Emit(OpCodes.Stloc_S, local3);
							reg.MarkLabel(label3);
						}
						else
						{
							reg.UpdateIssuer(parameterType);
							reg.Emit(OpCodes.Stloc_S, local3);
						}
					}
					reg.Emit(opcode, local3);
				}
				else if (parameterType.FindClient())
				{
					reg.PrepareIssuer(nextproc, i);
					reg.Emit(OpCodes.Stloc_S, local2);
					Label label4 = reg.DefineLabel();
					Label label5 = reg.DefineLabel();
					reg.Emit(OpCodes.Ldloc_S, local2);
					reg.Emit(OpCodes.Brtrue_S, label4);
					LocalBuilder local4 = reg.DeclareLocal(parameterType);
					reg.Emit(opcode, local4);
					reg.Emit(OpCodes.Initobj, parameterType);
					reg.Emit(opcode2, local4);
					reg.Emit(OpCodes.Br_S, label5);
					reg.MarkLabel(label4);
					if (parameterType.ValidateClient())
					{
						MethodInfo method = typeof(IConvertible).GetMethod("To" + parameterType.Name, new Type[1]
						{
							typeof(IFormatProvider)
						});
						if (method != null)
						{
							Label label6 = reg.DefineLabel();
							reg.Emit(OpCodes.Ldloc_S, local2);
							reg.Emit(OpCodes.Isinst, parameterType);
							reg.Emit(OpCodes.Brtrue_S, label6);
							reg.Emit(OpCodes.Ldloc_S, local2);
							reg.Emit(OpCodes.Isinst, typeof(IConvertible));
							reg.Emit(OpCodes.Stloc_S, local);
							reg.Emit(OpCodes.Ldloc_S, local);
							reg.Emit(OpCodes.Brfalse_S, label6);
							reg.Emit(OpCodes.Ldloc_S, local);
							reg.Emit(OpCodes.Ldnull);
							reg.Emit(OpCodes.Callvirt, method);
							reg.Emit(OpCodes.Br_S, label5);
							reg.MarkLabel(label6);
						}
					}
					reg.Emit(OpCodes.Ldloc_S, local2);
					reg.UpdateIssuer(parameterType);
					reg.MarkLabel(label5);
				}
				else
				{
					reg.PrepareIssuer(nextproc, i);
					reg.UpdateIssuer(parameterType);
				}
			}
			if (param.IsConstructor)
			{
				reg.Emit(OpCodes.Newobj, (ConstructorInfo)param);
			}
			else
			{
				reg.ReadIssuer((MethodInfo)param);
			}
			Type type = param.IsConstructor ? param.DeclaringType : ((MethodInfo)param).ReturnType;
			if (type != typeof(void))
			{
				reg.AwakeIssuer(type);
			}
			else
			{
				reg.Emit(OpCodes.Ldnull);
			}
			reg.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T> _0001<[_0008._0012(2)] T>(Type info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty("Create" + info.FullName, typeof(T), ResolverErrorFilter.collectionTest, info);
			dynamicMethod.InitLocals = true;
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			CheckIssuer(info, iLGenerator, typeof(T));
			return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckIssuer(Type asset, ILGenerator caller, Type c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (asset.FindClient())
			{
				caller.DeclareLocal(asset);
				caller.Emit(OpCodes.Ldloc_0);
				if (asset != c)
				{
					caller.Emit(OpCodes.Box, asset);
				}
			}
			else
			{
				ConstructorInfo constructor = asset.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ResolverErrorFilter.collectionTest, null);
				if (constructor == null)
				{
					throw new ArgumentException("Could not get constructor for {0}.".ListReader(CultureInfo.InvariantCulture, asset));
				}
				caller.Emit(OpCodes.Newobj, constructor);
			}
			caller.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty("Get" + reference.Name, typeof(object), new Type[1]
			{
				typeof(T)
			}, reference.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			DisableIssuer(reference, iLGenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisableIssuer(PropertyInfo v, ILGenerator cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo getMethod = v.GetGetMethod(nonPublic: true);
			if (getMethod == null)
			{
				throw new ArgumentException("Property '{0}' does not have a getter.".ListReader(CultureInfo.InvariantCulture, v.Name));
			}
			if (!getMethod.IsStatic)
			{
				cfg.PushIssuer(v.DeclaringType);
			}
			cfg.ReadIssuer(getMethod);
			cfg.AwakeIssuer(v.PropertyType);
			cfg.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T, object> _0001<[_0008._0012(2)] T>(FieldInfo i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (i.IsLiteral)
			{
				object value = i.GetValue(null);
				return (T P_0) => value;
			}
			DynamicMethod dynamicMethod = RevertProperty("Get" + i.Name, typeof(T), new Type[1]
			{
				typeof(object)
			}, i.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			VerifyIssuer(i, iLGenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VerifyIssuer(FieldInfo res, ILGenerator attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!res.IsStatic)
			{
				attr.PushIssuer(res.DeclaringType);
				attr.Emit(OpCodes.Ldfld, res);
			}
			else
			{
				attr.Emit(OpCodes.Ldsfld, res);
			}
			attr.AwakeIssuer(res.FieldType);
			attr.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action<T, object> _0001<[_0008._0012(2)] T>(FieldInfo value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty("Set" + value.Name, null, new Type[2]
			{
				typeof(T),
				typeof(object)
			}, value.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			PatchIssuer(value, iLGenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PatchIssuer(FieldInfo res, ILGenerator col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!res.IsStatic)
			{
				col.PushIssuer(res.DeclaringType);
			}
			col.Emit(OpCodes.Ldarg_1);
			col.UpdateIssuer(res.FieldType);
			if (!res.IsStatic)
			{
				col.Emit(OpCodes.Stfld, res);
			}
			else
			{
				col.Emit(OpCodes.Stsfld, res);
			}
			col.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMethod dynamicMethod = RevertProperty("Set" + ident.Name, null, new Type[2]
			{
				typeof(T),
				typeof(object)
			}, ident.DeclaringType);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			FindIssuer(ident, iLGenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void FindIssuer(PropertyInfo param, ILGenerator visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodInfo setMethod = param.GetSetMethod(nonPublic: true);
			if (!setMethod.IsStatic)
			{
				visitor.PushIssuer(param.DeclaringType);
			}
			visitor.Emit(OpCodes.Ldarg_1);
			visitor.UpdateIssuer(param.PropertyType);
			visitor.ReadIssuer(setMethod);
			visitor.InterruptIssuer();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnnotationComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnnotationComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			exporterComposer = new AnnotationComposer();
		}
	}
}
