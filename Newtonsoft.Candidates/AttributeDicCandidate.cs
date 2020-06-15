using _0008;
using GDBD.Bridges;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Filters;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[_0008._0012(0)]
	internal sealed class AttributeDicCandidate : RoleTestItem
	{
		private readonly MemberInfo recordIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AttributeDicCandidate(MemberInfo first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(first, "memberInfo");
			recordIssuer = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(object v, object vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				ResolverErrorFilter.CloneReader(recordIssuer, v, vis);
			}
			catch (Exception second)
			{
				throw new StrategyError("Error setting value to '{0}' on '{1}'.".SelectReader(CultureInfo.InvariantCulture, recordIssuer.Name, v.GetType()), second);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001(object v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				PropertyInfo propertyInfo = recordIssuer as PropertyInfo;
				if ((object)propertyInfo != null && propertyInfo.PropertyType.IsByRef)
				{
					throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".ListReader(CultureInfo.InvariantCulture, propertyInfo));
				}
				return ResolverErrorFilter.StopReader(recordIssuer, v);
			}
			catch (Exception second)
			{
				throw new StrategyError("Error getting value from '{0}' on '{1}'.".SelectReader(CultureInfo.InvariantCulture, recordIssuer.Name, v.GetType()), second);
			}
		}
	}
}
