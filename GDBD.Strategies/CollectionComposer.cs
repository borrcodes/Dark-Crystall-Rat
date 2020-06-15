using _0008;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	[Serializable]
	[_0008._0012(0)]
	public sealed class CollectionComposer : ListenerTestItem
	{
		[CompilerGenerated]
		[_0008._0012(2)]
		private readonly string _RepositoryComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionComposer(string info, string second, Exception control)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(info, control);
			_RepositoryComposer = second;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CollectionComposer ListTest(RecordClassDispatcher res, string attr, Exception template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SelectTest(res._0001(), attr, template);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CollectionComposer SelectTest(string first, string connection, Exception third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			connection = QueueError.ComputeError(null, first, connection);
			return new CollectionComposer(connection, first, third);
		}
	}
}
