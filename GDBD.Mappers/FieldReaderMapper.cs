using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Mappers
{
	[_0008._0012(0)]
	internal sealed class FieldReaderMapper : BroadcasterError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher item, object cfg, PrototypeError filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (cfg == null)
			{
				item._0008();
				return;
			}
			DataTable obj = (DataTable)cfg;
			PublisherRequestStrategy publisherRequestStrategy = filter._0001() as PublisherRequestStrategy;
			item._0003();
			foreach (DataRow row in obj.Rows)
			{
				item._0002();
				foreach (DataColumn column in row.Table.Columns)
				{
					object obj2 = row[column];
					if (filter._0001() != (ApplicationState)1 || (obj2 != null && obj2 != DBNull.Value))
					{
						item._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient(column.ColumnName) : column.ColumnName);
						filter.FlushComposer(item, obj2);
					}
				}
				item._0011();
			}
			item._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem info, Type b, object c, PrototypeError asset2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info._0001() == WatcherComposer.Null)
			{
				return null;
			}
			DataTable dataTable = c as DataTable;
			if (dataTable == null)
			{
				dataTable = ((b == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(b)));
			}
			if (info._0001() == WatcherComposer.PropertyName)
			{
				dataTable.TableName = (string)info._0001();
				info.SortError();
				if (info._0001() == WatcherComposer.Null)
				{
					return dataTable;
				}
			}
			if (info._0001() != WatcherComposer.StartArray)
			{
				throw StrategyError.PatchComposer(info, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".ListReader(CultureInfo.InvariantCulture, info._0001()));
			}
			info.SortError();
			while (info._0001() != WatcherComposer.EndArray)
			{
				RestartRequest(info, dataTable, asset2);
				info.SortError();
			}
			return dataTable;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RestartRequest(TagTestItem instance, DataTable cont, PrototypeError template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DataRow dataRow = cont.NewRow();
			instance.SortError();
			while (instance._0001() == WatcherComposer.PropertyName)
			{
				string text = (string)instance._0001();
				instance.SortError();
				DataColumn dataColumn = cont.Columns[text];
				if (dataColumn == null)
				{
					Type dataType = SearchRequest(instance);
					dataColumn = new DataColumn(text, dataType);
					cont.Columns.Add(dataColumn);
				}
				if (dataColumn.DataType == typeof(DataTable))
				{
					if (instance._0001() == WatcherComposer.StartArray)
					{
						instance.SortError();
					}
					DataTable dataTable = new DataTable();
					while (instance._0001() != WatcherComposer.EndArray)
					{
						RestartRequest(instance, dataTable, template);
						instance.SortError();
					}
					dataRow[text] = dataTable;
				}
				else if (!dataColumn.DataType.IsArray || !(dataColumn.DataType != typeof(byte[])))
				{
					object obj2 = dataRow[text] = ((instance._0001() != null) ? (template.AddComposer(instance, dataColumn.DataType) ?? DBNull.Value) : DBNull.Value);
				}
				else
				{
					if (instance._0001() == WatcherComposer.StartArray)
					{
						instance.SortError();
					}
					List<object> list = new List<object>();
					while (instance._0001() != WatcherComposer.EndArray)
					{
						list.Add(instance._0001());
						instance.SortError();
					}
					Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
					((ICollection)list).CopyTo(array, 0);
					dataRow[text] = array;
				}
				instance.SortError();
			}
			dataRow.EndEdit();
			cont.Rows.Add(dataRow);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type SearchRequest(TagTestItem key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = key._0001();
			switch (watcherComposer)
			{
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
				return key._0001();
			case WatcherComposer.Null:
			case WatcherComposer.Undefined:
			case WatcherComposer.EndArray:
				return typeof(string);
			case WatcherComposer.StartArray:
				key.SortError();
				if (key._0001() == WatcherComposer.StartObject)
				{
					return typeof(DataTable);
				}
				return SearchRequest(key).MakeArrayType();
			default:
				throw StrategyError.PatchComposer(key, "Unexpected JSON token when reading DataTable: {0}".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(DataTable).IsAssignableFrom(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FieldReaderMapper()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
