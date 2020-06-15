using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	internal sealed class CollectionListAnnotation : BroadcasterError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher config, object caller, PrototypeError template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			TokenClassSpec tokenClassSpec = (TokenClassSpec)caller;
			TaskIteratorMapping taskIteratorMapping = config as TaskIteratorMapping;
			if (taskIteratorMapping != null)
			{
				taskIteratorMapping.PopIterator(tokenClassSpec._0001());
			}
			else
			{
				config._0001(tokenClassSpec._0001());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem setup, Type pol, object tag, PrototypeError def2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup._0001() != WatcherComposer.Bytes)
			{
				throw new StrategyError("Expected Bytes but got {0}.".ListReader(CultureInfo.InvariantCulture, setup._0001()));
			}
			return new TokenClassSpec((byte[])setup._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return item == typeof(TokenClassSpec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionListAnnotation()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
