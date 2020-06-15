using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[_0008._0012(new byte[]
	{
		0,
		1,
		1
	})]
	internal sealed class CreatorTestItem : KeyedCollection<string, ProductInstanceExpression>
	{
		private readonly Type fieldProperty;

		private readonly List<ProductInstanceExpression> itemProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorTestItem(Type reference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector((IEqualityComparer<string>)StringComparer.Ordinal);
			ContextClientBridge.RunClient(reference, "type");
			fieldProperty = reference;
			itemProperty = (List<ProductInstanceExpression>)base.Items;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override string _0001(ProductInstanceExpression info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return info._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CollectClient(ProductInstanceExpression last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (Contains(last._0001()))
			{
				if (last._0001())
				{
					return;
				}
				ProductInstanceExpression productInstanceExpression = base[last._0001()];
				bool flag = true;
				if (productInstanceExpression._0001())
				{
					Remove(productInstanceExpression);
					flag = false;
				}
				else if (last._0001() != null && productInstanceExpression._0001() != null)
				{
					if (last._0001().IsSubclassOf(productInstanceExpression._0001()) || (productInstanceExpression._0001().SortReader() && last._0001().FillClient(productInstanceExpression._0001())))
					{
						Remove(productInstanceExpression);
						flag = false;
					}
					if (productInstanceExpression._0001().IsSubclassOf(last._0001()) || (last._0001().SortReader() && productInstanceExpression._0001().FillClient(last._0001())) || (fieldProperty.FillClient(productInstanceExpression._0001()) && fieldProperty.FillClient(last._0001())))
					{
						return;
					}
				}
				if (flag)
				{
					throw new StrategyError("A member with the name '{0}' already exists on '{1}'. Use the JsonPropertyAttribute to specify another name.".SelectReader(CultureInfo.InvariantCulture, last._0001(), fieldProperty));
				}
			}
			Add(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProductInstanceExpression SortClient(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProductInstanceExpression productInstanceExpression = PublishClient(res, StringComparison.Ordinal);
			if (productInstanceExpression == null)
			{
				productInstanceExpression = PublishClient(res, StringComparison.OrdinalIgnoreCase);
			}
			return productInstanceExpression;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CallClient(string last, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out ProductInstanceExpression _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base.Dictionary == null)
			{
				_0003 = null;
				return false;
			}
			return base.Dictionary.TryGetValue(last, out _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProductInstanceExpression PublishClient(string item, StringComparison selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (selection == StringComparison.Ordinal)
			{
				if (CallClient(item, out ProductInstanceExpression _0003))
				{
					return _0003;
				}
				return null;
			}
			for (int i = 0; i < itemProperty.Count; i++)
			{
				ProductInstanceExpression productInstanceExpression = itemProperty[i];
				if (string.Equals(item, productInstanceExpression._0001(), selection))
				{
					return productInstanceExpression;
				}
			}
			return null;
		}
	}
}
