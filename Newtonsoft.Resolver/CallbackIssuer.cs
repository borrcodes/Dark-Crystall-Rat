using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal sealed class CallbackIssuer : BroadcasterError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher spec, object selection, PrototypeError role)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem param, Type counter, object helper, PrototypeError config2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return RemoveRequest(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object RemoveRequest(TagTestItem spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!spec.RevertError())
			{
				throw StrategyError.PatchComposer(spec, "Unexpected end when reading ExpandoObject.");
			}
			switch (spec._0001())
			{
			case WatcherComposer.StartObject:
				return ChangeRequest(spec);
			case WatcherComposer.StartArray:
				return PostRequest(spec);
			default:
				if (RulesClientBridge.StartIssuer(spec._0001()))
				{
					return spec._0001();
				}
				throw StrategyError.PatchComposer(spec, "Unexpected token when converting ExpandoObject: {0}".ListReader(CultureInfo.InvariantCulture, spec._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object PostRequest(TagTestItem init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IList<object> list = new List<object>();
			while (init._0001())
			{
				switch (init._0001())
				{
				case WatcherComposer.EndArray:
					return list;
				case WatcherComposer.Comment:
					continue;
				}
				object item = RemoveRequest(init);
				list.Add(item);
			}
			throw StrategyError.PatchComposer(init, "Unexpected end when reading ExpandoObject.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ChangeRequest(TagTestItem reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IDictionary<string, object> dictionary = new ExpandoObject();
			while (reference._0001())
			{
				switch (reference._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string key = reference._0001().ToString();
					if (!reference._0001())
					{
						throw StrategyError.PatchComposer(reference, "Unexpected end when reading ExpandoObject.");
					}
					object obj2 = dictionary[key] = RemoveRequest(reference);
					break;
				}
				case WatcherComposer.EndObject:
					return dictionary;
				}
			}
			throw StrategyError.PatchComposer(reference, "Unexpected end when reading ExpandoObject.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return reference == typeof(ExpandoObject);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CallbackIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
