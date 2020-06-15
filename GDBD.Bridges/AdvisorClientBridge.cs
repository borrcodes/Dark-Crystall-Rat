using _0008;
using Newtonsoft.Common;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[_0008._0012(0)]
	internal static class AdvisorClientBridge
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PushIssuer(this ILGenerator spec, Type pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			spec.Emit(OpCodes.Ldarg_0);
			if (pred.FindClient())
			{
				spec.Emit(OpCodes.Unbox, pred);
			}
			else
			{
				spec.Emit(OpCodes.Castclass, pred);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrepareIssuer(this ILGenerator init, int num_second, int dic_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			init.Emit(OpCodes.Ldarg, num_second);
			init.Emit(OpCodes.Ldc_I4, dic_start);
			init.Emit(OpCodes.Ldelem_Ref);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AwakeIssuer(this ILGenerator last, Type reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reg.FindClient())
			{
				last.Emit(OpCodes.Box, reg);
			}
			else
			{
				last.Emit(OpCodes.Castclass, reg);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateIssuer(this ILGenerator res, Type ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ivk.FindClient())
			{
				res.Emit(OpCodes.Unbox_Any, ivk);
			}
			else
			{
				res.Emit(OpCodes.Castclass, ivk);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReadIssuer(this ILGenerator asset, MethodInfo col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (col.IsFinal || !col.IsVirtual)
			{
				asset.Emit(OpCodes.Call, col);
			}
			else
			{
				asset.Emit(OpCodes.Callvirt, col);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InterruptIssuer(this ILGenerator spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			spec.Emit(OpCodes.Ret);
		}
	}
}
