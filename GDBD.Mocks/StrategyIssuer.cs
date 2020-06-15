using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace GDBD.Mocks
{
	[_0008._0012(0)]
	internal sealed class StrategyIssuer : BroadcasterError
	{
		[_0008._0012(2)]
		private static ModelInstanceExpression _InfoIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher config, object caller, PrototypeError comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (caller == null)
			{
				config._0008();
				return;
			}
			byte[] item = ReflectRequest(caller);
			config._0001(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] ReflectRequest(object def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def.GetType().FullName == "System.Data.Linq.Binary")
			{
				ResetRequest(def.GetType());
				return (byte[])_InfoIssuer.CancelIssuer(def, "ToArray");
			}
			if (def is SqlBinary)
			{
				return ((SqlBinary)def).Value;
			}
			throw new StrategyError("Unexpected value type when writing binary: {0}".ListReader(CultureInfo.InvariantCulture, def.GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ResetRequest(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_InfoIssuer == null)
			{
				_InfoIssuer = ModelInstanceExpression.InitIssuer(last, last.GetConstructor(new Type[1]
				{
					typeof(byte[])
				}), new string[1]
				{
					"ToArray"
				});
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem instance, Type pred, object res, PrototypeError reference2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance._0001() == WatcherComposer.Null)
			{
				if (!ResolverErrorFilter.VerifyReader(pred))
				{
					throw StrategyError.PatchComposer(instance, "Cannot convert null value to {0}.".ListReader(CultureInfo.InvariantCulture, pred));
				}
				return null;
			}
			byte[] array;
			if (instance._0001() == WatcherComposer.StartArray)
			{
				array = RegisterRequest(instance);
			}
			else
			{
				if (instance._0001() != WatcherComposer.String)
				{
					throw StrategyError.PatchComposer(instance, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".ListReader(CultureInfo.InvariantCulture, instance._0001()));
				}
				array = Convert.FromBase64String(instance._0001().ToString());
			}
			Type type = ResolverErrorFilter.PatchReader(pred) ? Nullable.GetUnderlyingType(pred) : pred;
			if (type.FullName == "System.Data.Linq.Binary")
			{
				ResetRequest(type);
				return _InfoIssuer._0001()(new object[1]
				{
					array
				});
			}
			if (type == typeof(SqlBinary))
			{
				return new SqlBinary(array);
			}
			throw StrategyError.PatchComposer(instance, "Unexpected object type when writing binary: {0}".ListReader(CultureInfo.InvariantCulture, pred));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] RegisterRequest(TagTestItem spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<byte> list = new List<byte>();
			while (spec._0001())
			{
				switch (spec._0001())
				{
				case WatcherComposer.Integer:
					list.Add(Convert.ToByte(spec._0001(), CultureInfo.InvariantCulture));
					break;
				case WatcherComposer.EndArray:
					return list.ToArray();
				default:
					throw StrategyError.PatchComposer(spec, "Unexpected token when reading bytes: {0}".ListReader(CultureInfo.InvariantCulture, spec._0001()));
				case WatcherComposer.Comment:
					break;
				}
			}
			throw StrategyError.PatchComposer(spec, "Unexpected end when reading bytes.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance.FullName == "System.Data.Linq.Binary")
			{
				return true;
			}
			if (instance == typeof(SqlBinary) || instance == typeof(SqlBinary?))
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StrategyIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
