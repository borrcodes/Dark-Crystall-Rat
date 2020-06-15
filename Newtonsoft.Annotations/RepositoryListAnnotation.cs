using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Candidates;
using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	[_0008._0012(0)]
	internal sealed class RepositoryListAnnotation : BroadcasterError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher res, object connection, PrototypeError third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (connection == null)
			{
				res._0008();
				return;
			}
			DataSet obj = (DataSet)connection;
			PublisherRequestStrategy publisherRequestStrategy = third._0001() as PublisherRequestStrategy;
			FieldReaderMapper fieldReaderMapper = new FieldReaderMapper();
			res._0002();
			foreach (DataTable table in obj.Tables)
			{
				res._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient(table.TableName) : table.TableName);
				fieldReaderMapper._0001(res, table, third);
			}
			res._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem def, Type ord, object dir, PrototypeError reg2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def._0001() == WatcherComposer.Null)
			{
				return null;
			}
			DataSet dataSet = (ord == typeof(DataSet)) ? new DataSet() : ((DataSet)Activator.CreateInstance(ord));
			FieldReaderMapper fieldReaderMapper = new FieldReaderMapper();
			def.SortError();
			while (def._0001() == WatcherComposer.PropertyName)
			{
				DataTable dataTable = dataSet.Tables[(string)def._0001()];
				bool num = dataTable != null;
				dataTable = (DataTable)fieldReaderMapper._0001(def, typeof(DataTable), dataTable, reg2);
				if (!num)
				{
					dataSet.Tables.Add(dataTable);
				}
				def.SortError();
			}
			return dataSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(DataSet).IsAssignableFrom(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RepositoryListAnnotation()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
