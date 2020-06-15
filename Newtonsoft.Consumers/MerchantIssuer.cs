using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal sealed class MerchantIssuer : BroadcasterError
	{
		private static readonly Newtonsoft.Database.DispatcherEventEntry<Type, ModelInstanceExpression> m_ListenerIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ModelInstanceExpression CalculateRequest(Type i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type[] genericArguments = i.GetGenericArguments();
			Type type = ((IList<Type>)genericArguments)[0];
			Type type2 = ((IList<Type>)genericArguments)[1];
			return ModelInstanceExpression.InitIssuer(i, i.GetConstructor(new Type[2]
			{
				type,
				type2
			}), new string[2]
			{
				"Key",
				"Value"
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher config, object col, PrototypeError dic)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (col == null)
			{
				config._0008();
				return;
			}
			ModelInstanceExpression modelInstanceExpression = m_ListenerIssuer.InitReader(col.GetType());
			PublisherRequestStrategy publisherRequestStrategy = dic._0001() as PublisherRequestStrategy;
			config._0002();
			config._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Key") : "Key");
			dic.InsertComposer(config, modelInstanceExpression.CancelIssuer(col, "Key"), modelInstanceExpression.SetupIssuer("Key"));
			config._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Value") : "Value");
			dic.InsertComposer(config, modelInstanceExpression.CancelIssuer(col, "Value"), modelInstanceExpression.SetupIssuer("Value"));
			config._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem config, Type ivk, object template, PrototypeError connection2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config._0001() == WatcherComposer.Null)
			{
				if (!ResolverErrorFilter.PatchReader(ivk))
				{
					throw StrategyError.PatchComposer(config, "Cannot convert null value to KeyValuePair.");
				}
				return null;
			}
			object obj = null;
			object obj2 = null;
			config.SortError();
			Type res = ResolverErrorFilter.PatchReader(ivk) ? Nullable.GetUnderlyingType(ivk) : ivk;
			ModelInstanceExpression modelInstanceExpression = m_ListenerIssuer.InitReader(res);
			ProcTest procTest = connection2._0001()._0001(modelInstanceExpression.SetupIssuer("Key"));
			ProcTest procTest2 = connection2._0001()._0001(modelInstanceExpression.SetupIssuer("Value"));
			while (config._0001() == WatcherComposer.PropertyName)
			{
				string a = config._0001().ToString();
				if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
				{
					config.CallError(procTest, iscaller: false);
					obj = connection2.AddComposer(config, procTest._0002());
				}
				else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
				{
					config.CallError(procTest2, iscaller: false);
					obj2 = connection2.AddComposer(config, procTest2._0002());
				}
				else
				{
					config.AssetError();
				}
				config.SortError();
			}
			return modelInstanceExpression._0001()(new object[2]
			{
				obj,
				obj2
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = ResolverErrorFilter.PatchReader(instance) ? Nullable.GetUnderlyingType(instance) : instance;
			if (type.FindClient() && type.CallReader())
			{
				return type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MerchantIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MerchantIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_ListenerIssuer = new Newtonsoft.Database.DispatcherEventEntry<Type, ModelInstanceExpression>(CalculateRequest);
		}
	}
}
