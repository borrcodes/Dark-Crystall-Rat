using _0008;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Consumers;
using Newtonsoft.Expressions;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	[_0008._0012(0)]
	internal sealed class ImporterTest : ListEventConsumer
	{
		private int _ReponseTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Newtonsoft.Consumers.EventEventConsumer<string, object> RateClient(object reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RuleTestItem ruleTestItem = reference as RuleTestItem;
			if (ruleTestItem == null)
			{
				AlgoInstanceExpression algoInstanceExpression = reference as AlgoInstanceExpression;
				if (algoInstanceExpression == null)
				{
					throw new ListenerTestItem("The DefaultReferenceResolver can only be used internally.");
				}
				ruleTestItem = algoInstanceExpression.FlushClass();
			}
			return ruleTestItem._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001(object reference, string cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RateClient(reference).CustomizeTest(cfg, out object counter);
			return counter;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001(object res, object result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Newtonsoft.Consumers.EventEventConsumer<string, object> eventEventConsumer = RateClient(res);
			if (!eventEventConsumer.QueryTest(result, out string pred))
			{
				_ReponseTest++;
				pred = _ReponseTest.ToString(CultureInfo.InvariantCulture);
				eventEventConsumer.AssetTest(pred, result);
			}
			return pred;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(object ident, string vis, object serv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RateClient(ident).AssetTest(vis, serv);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(object i, object ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string pred;
			return RateClient(i).QueryTest(ivk, out pred);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ImporterTest()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
