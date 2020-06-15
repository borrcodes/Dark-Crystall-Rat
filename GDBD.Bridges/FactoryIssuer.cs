using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[_0008._0012(0)]
	internal sealed class FactoryIssuer : BroadcasterError
	{
		[_0008._0012(2)]
		private static ModelInstanceExpression m_SerializerIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher v, object col, PrototypeError role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (col == null)
			{
				v._0008();
				return;
			}
			RateRequest(col.GetType());
			PublisherRequestStrategy publisherRequestStrategy = role._0001() as PublisherRequestStrategy;
			string init = (string)m_SerializerIssuer.CancelIssuer(col, "Key");
			object obj = m_SerializerIssuer.CancelIssuer(col, "Value");
			Type type = obj?.GetType();
			v._0002();
			v._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Key") : "Key");
			v._0004(init);
			v._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Type") : "Type");
			v._0004(type?.FullName);
			v._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Value") : "Value");
			if (type != null)
			{
				if (InterceptorInstanceExpression.ExcludeBroadcaster(obj, type, out string _0004))
				{
					v._0004(_0004);
				}
				else
				{
					v._0001(obj);
				}
			}
			else
			{
				v._0008();
			}
			v._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SetRequest(TagTestItem param, string ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			param.SortError();
			if (param._0001() != WatcherComposer.PropertyName || !string.Equals(param._0001()?.ToString(), ord, StringComparison.OrdinalIgnoreCase))
			{
				throw new StrategyError("Expected JSON property '{0}'.".ListReader(CultureInfo.InvariantCulture, ord));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem item, Type attr, object util, PrototypeError var12)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RateRequest(attr);
			object obj = m_SerializerIssuer._0001()(new object[0]);
			SetRequest(item, "Key");
			item.SortError();
			m_SerializerIssuer.ExcludeIssuer(obj, "Key", item._0001()?.ToString());
			SetRequest(item, "Type");
			item.SortError();
			Type type = Type.GetType(item._0001()?.ToString());
			SetRequest(item, "Value");
			item.SortError();
			m_SerializerIssuer.ExcludeIssuer(obj, "Value", var12.AddComposer(item, type));
			item.SortError();
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RateRequest(Type item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_SerializerIssuer == null)
			{
				m_SerializerIssuer = ModelInstanceExpression.ManageIssuer(item, new string[2]
				{
					"Key",
					"Value"
				});
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return reference.ResolveClient("System.Data.EntityKeyMember", createhelper: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FactoryIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
