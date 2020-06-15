using _0008;
using GDBD.Bridges;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal static class SchemaIssuerImporter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T ResetClass<[_0008._0012(2)] T>(this IEnumerable<ParserFilterResolver> instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return instance.RegisterClass<ParserFilterResolver, T>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TT RegisterClass<[_0008._0012(0)] T, [_0008._0012(2)] TT>(this IEnumerable<T> spec) where T : ParserFilterResolver
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(spec, "value");
			return ((spec as ParserFilterResolver) ?? throw new ArgumentException("Source value must be a JToken.")).SearchClass<ParserFilterResolver, TT>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<TT> RestartClass<[_0008._0012(0)] T, [_0008._0012(2)] TT>(this IEnumerable<T> task, object visitor) where T : ParserFilterResolver
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new _0001<T, TT>(-2)
			{
				_0005 = task,
				_0007 = visitor
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TT SearchClass<[_0008._0012(0)] T, [_0008._0012(2)] TT>(this T init) where T : ParserFilterResolver
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return default(TT);
			}
			if (init is TT)
			{
				TT result = init as TT;
				if (typeof(TT) != typeof(IComparable) && typeof(TT) != typeof(IFormattable))
				{
					return result;
				}
			}
			PoolIssuer poolIssuer = init as PoolIssuer;
			if (poolIssuer == null)
			{
				throw new InvalidCastException("Cannot cast {0} to {1}.".SelectReader(CultureInfo.InvariantCulture, init.GetType(), typeof(T)));
			}
			object obj = poolIssuer._0001();
			if (obj is TT)
			{
				return (TT)obj;
			}
			Type type = typeof(TT);
			if (ResolverErrorFilter.PatchReader(type))
			{
				if (poolIssuer._0001() == null)
				{
					return default(TT);
				}
				type = Nullable.GetUnderlyingType(type);
			}
			return (TT)Convert.ChangeType(poolIssuer._0001(), type, CultureInfo.InvariantCulture);
		}
	}
}
