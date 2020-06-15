using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[Serializable]
	[_0008._0012(0)]
	public sealed class ContextError : ListenerTestItem
	{
		[CompilerGenerated]
		private readonly int m_ParamError;

		[CompilerGenerated]
		private readonly int _PublisherError;

		[_0008._0012(2)]
		[CompilerGenerated]
		private readonly string m_UtilsError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextError()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextError(string key, string connection, int helper_High, int spec2_min, Exception task3)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(key, task3);
			m_UtilsError = connection;
			m_ParamError = helper_High;
			_PublisherError = spec2_min;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextError CheckComposer(TagTestItem ident, string pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return DisableComposer(ident, pred, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextError DisableComposer(TagTestItem reference, string vis, Exception field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return VerifyComposer(reference as IdentifierClientBridge, reference._0002(), vis, field);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ContextError VerifyComposer(IdentifierClientBridge task, string token, string util, Exception first2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			util = QueueError.ComputeError(task, token, util);
			int helper_High;
			int spec2_min;
			if (task != null && task._0002())
			{
				helper_High = task._0001();
				spec2_min = task._0002();
			}
			else
			{
				helper_High = 0;
				spec2_min = 0;
			}
			return new ContextError(util, token, helper_High, spec2_min, first2);
		}
	}
}
