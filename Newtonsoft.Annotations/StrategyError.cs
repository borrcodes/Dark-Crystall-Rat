using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	[Serializable]
	[_0008._0012(0)]
	public sealed class StrategyError : ListenerTestItem
	{
		[CompilerGenerated]
		private readonly int infoError;

		[CompilerGenerated]
		private readonly int _ValueError;

		[CompilerGenerated]
		[_0008._0012(2)]
		private readonly string _ParameterError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyError()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyError(string v)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyError(string config, Exception second)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(config, second);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyError(string var1, string pred, int sum_serv, int v2_max, Exception config3)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(var1, config3);
			_ParameterError = pred;
			infoError = sum_serv;
			_ValueError = v2_max;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StrategyError PatchComposer(TagTestItem first, string attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return FindComposer(first, attr, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StrategyError FindComposer(TagTestItem first, string result, Exception field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ValidateComposer(first as IdentifierClientBridge, first._0002(), result, field);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static StrategyError ValidateComposer(IdentifierClientBridge task, string counter, string res, Exception setup2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			res = QueueError.ComputeError(task, counter, res);
			int sum_serv;
			int v2_max;
			if (task != null && task._0002())
			{
				sum_serv = task._0001();
				v2_max = task._0002();
			}
			else
			{
				sum_serv = 0;
				v2_max = 0;
			}
			return new StrategyError(res, counter, sum_serv, v2_max, setup2);
		}
	}
}
