using _0008;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Maps
{
	[_0008._0012(0)]
	internal static class DescriptorIteratorMapping
	{
		internal static readonly long _FieldComposer;

		private static readonly int[] _ItemComposer;

		private static readonly int[] _RegComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DescriptorIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_FieldComposer = 621355968000000000L;
			_ItemComposer = new int[13]
			{
				0,
				31,
				59,
				90,
				120,
				151,
				181,
				212,
				243,
				273,
				304,
				334,
				365
			};
			_RegComposer = new int[13]
			{
				0,
				31,
				60,
				91,
				121,
				152,
				182,
				213,
				244,
				274,
				305,
				335,
				366
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TimeSpan AwakeProperty(this DateTime reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return TimeZoneInfo.Local.GetUtcOffset(reference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlDateTimeSerializationMode UpdateProperty(DateTimeKind ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (ident)
			{
			case DateTimeKind.Local:
				return XmlDateTimeSerializationMode.Local;
			case DateTimeKind.Unspecified:
				return XmlDateTimeSerializationMode.Unspecified;
			case DateTimeKind.Utc:
				return XmlDateTimeSerializationMode.Utc;
			default:
				throw CustomerListAnnotation.ConcatIssuer("kind", ident, "Unexpected DateTimeKind value.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime ReadProperty(DateTime param, PsMaxLengths cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (cont)
			{
			case (PsMaxLengths)0:
				param = InterruptProperty(param);
				break;
			case (PsMaxLengths)1:
				param = CalcProperty(param);
				break;
			case (PsMaxLengths)2:
				param = new DateTime(param.Ticks, DateTimeKind.Unspecified);
				break;
			default:
				throw new ArgumentException("Invalid date time handling value.");
			case (PsMaxLengths)3:
				break;
			}
			return param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DateTime InterruptProperty(DateTime config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (config.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(config.Ticks, DateTimeKind.Local);
			case DateTimeKind.Utc:
				return config.ToLocalTime();
			case DateTimeKind.Local:
				return config;
			default:
				return config;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DateTime CalcProperty(DateTime v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (v.Kind)
			{
			case DateTimeKind.Unspecified:
				return new DateTime(v.Ticks, DateTimeKind.Utc);
			case DateTimeKind.Utc:
				return v;
			case DateTimeKind.Local:
				return v.ToUniversalTime();
			default:
				return v;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static long InstantiateProperty(DateTime ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident.Kind == DateTimeKind.Utc)
			{
				return ident.Ticks;
			}
			return ReflectProperty(ident, ident.AwakeProperty());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static long ReflectProperty(DateTime first, TimeSpan caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (first.Kind == DateTimeKind.Utc || first == DateTime.MaxValue || first == DateTime.MinValue)
			{
				return first.Ticks;
			}
			long num = first.Ticks - caller.Ticks;
			if (num > 3155378975999999999L)
			{
				return 3155378975999999999L;
			}
			if (num < 0)
			{
				return 0L;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long ResetProperty(DateTime instance, TimeSpan connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return RestartProperty(ReflectProperty(instance, connection));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long RegisterProperty(DateTime param, bool usecont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return RestartProperty(usecont ? InstantiateProperty(param) : param.Ticks);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static long RestartProperty(long def_Y)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (def_Y - _FieldComposer) / 10000;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DateTime SearchProperty(long min_spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new DateTime(min_spec * 10000 + _FieldComposer, DateTimeKind.Utc);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ComputeProperty(InvocationTest init, PsMaxLengths vis, out DateTime res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InfoComposer property = default(InfoComposer);
			if (!property.ConnectProperty(init._0001(), init._0001(), init._0002()))
			{
				res = default(DateTime);
				return false;
			}
			DateTime dateTime = SetProperty(property);
			switch (property.m_DatabaseComposer)
			{
			case (ExceptionDicCandidate)1:
				dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Utc);
				break;
			case (ExceptionDicCandidate)2:
			{
				TimeSpan timeSpan2 = new TimeSpan(property._ExceptionComposer, property.attributeComposer, 0);
				long num = dateTime.Ticks + timeSpan2.Ticks;
				if (num <= DateTime.MaxValue.Ticks)
				{
					dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
					break;
				}
				num += dateTime.AwakeProperty().Ticks;
				if (num > DateTime.MaxValue.Ticks)
				{
					num = DateTime.MaxValue.Ticks;
				}
				dateTime = new DateTime(num, DateTimeKind.Local);
				break;
			}
			case (ExceptionDicCandidate)3:
			{
				TimeSpan timeSpan = new TimeSpan(property._ExceptionComposer, property.attributeComposer, 0);
				long num = dateTime.Ticks - timeSpan.Ticks;
				if (num >= DateTime.MinValue.Ticks)
				{
					dateTime = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
					break;
				}
				num += dateTime.AwakeProperty().Ticks;
				if (num < DateTime.MinValue.Ticks)
				{
					num = DateTime.MinValue.Ticks;
				}
				dateTime = new DateTime(num, DateTimeKind.Local);
				break;
			}
			}
			res = ReadProperty(dateTime, vis);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DestroyProperty(InvocationTest info, out DateTimeOffset attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InfoComposer property = default(InfoComposer);
			if (!property.ConnectProperty(info._0001(), info._0001(), info._0002()))
			{
				attr = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime = SetProperty(property);
			TimeSpan offset;
			switch (property.m_DatabaseComposer)
			{
			case (ExceptionDicCandidate)1:
				offset = new TimeSpan(0L);
				break;
			case (ExceptionDicCandidate)2:
				offset = new TimeSpan(-property._ExceptionComposer, -property.attributeComposer, 0);
				break;
			case (ExceptionDicCandidate)3:
				offset = new TimeSpan(property._ExceptionComposer, property.attributeComposer, 0);
				break;
			default:
				offset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
				break;
			}
			long num = dateTime.Ticks - offset.Ticks;
			if (num < 0 || num > 3155378975999999999L)
			{
				attr = default(DateTimeOffset);
				return false;
			}
			attr = new DateTimeOffset(dateTime, offset);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DateTime SetProperty(InfoComposer value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool flag;
			if (value.m_ParserComposer == 24)
			{
				flag = true;
				value.m_ParserComposer = 0;
			}
			else
			{
				flag = false;
			}
			DateTime result = new DateTime(value.valueComposer, value.m_ParameterComposer, value.prototypeComposer, value.m_ParserComposer, value.m_StatusComposer, value._PageComposer).AddTicks(value._HelperComposer);
			if (flag)
			{
				result = result.AddDays(1.0);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RateProperty(InvocationTest task, PsMaxLengths map, [_0008._0012(2)] string _0004, CultureInfo item2, out DateTime attr3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task._0002() > 0)
			{
				int num = task._0001();
				if (task[num] == '/')
				{
					if (task._0002() >= 9 && task.CalculateReader("/Date(") && task.GetReader(")/") && GetProperty(task, map, out attr3))
					{
						return true;
					}
				}
				else if (task._0002() >= 19 && task._0002() <= 40 && char.IsDigit(task[num]) && task[num + 10] == 'T' && ComputeProperty(task, map, out attr3))
				{
					return true;
				}
				if (!SetterTest.StartReader(_0004) && StartProperty(task.ToString(), map, _0004, item2, out attr3))
				{
					return true;
				}
			}
			attr3 = default(DateTime);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RemoveProperty(string asset, PsMaxLengths connection, [_0008._0012(2)] string _0004, CultureInfo res2, out DateTime res3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (asset.Length > 0)
			{
				if (asset[0] == '/')
				{
					if (asset.Length >= 9 && asset.StartsWith("/Date(", StringComparison.Ordinal) && asset.EndsWith(")/", StringComparison.Ordinal) && GetProperty(new InvocationTest(asset.ToCharArray(), 0, asset.Length), connection, out res3))
					{
						return true;
					}
				}
				else if (asset.Length >= 19 && asset.Length <= 40 && char.IsDigit(asset[0]) && asset[10] == 'T' && DateTime.TryParseExact(asset, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out res3))
				{
					res3 = ReadProperty(res3, connection);
					return true;
				}
				if (!SetterTest.StartReader(_0004) && StartProperty(asset, connection, _0004, res2, out res3))
				{
					return true;
				}
			}
			res3 = default(DateTime);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PostProperty(InvocationTest setup, [_0008._0012(2)] string _0003, CultureInfo state, out DateTimeOffset res2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup._0002() > 0)
			{
				int num = setup._0001();
				if (setup[num] == '/')
				{
					if (setup._0002() >= 9 && setup.CalculateReader("/Date(") && setup.GetReader(")/") && ListProperty(setup, out res2))
					{
						return true;
					}
				}
				else if (setup._0002() >= 19 && setup._0002() <= 40 && char.IsDigit(setup[num]) && setup[num + 10] == 'T' && DestroyProperty(setup, out res2))
				{
					return true;
				}
				if (!SetterTest.StartReader(_0003) && SelectProperty(setup.ToString(), _0003, state, out res2))
				{
					return true;
				}
			}
			res2 = default(DateTimeOffset);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ChangeProperty(string value, [_0008._0012(2)] string _0003, CultureInfo filter, out DateTimeOffset connection2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (value.Length > 0)
			{
				if (value[0] == '/')
				{
					if (value.Length >= 9 && value.StartsWith("/Date(", StringComparison.Ordinal) && value.EndsWith(")/", StringComparison.Ordinal) && ListProperty(new InvocationTest(value.ToCharArray(), 0, value.Length), out connection2))
					{
						return true;
					}
				}
				else if (value.Length >= 19 && value.Length <= 40 && char.IsDigit(value[0]) && value[10] == 'T' && DateTimeOffset.TryParseExact(value, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out connection2) && DestroyProperty(new InvocationTest(value.ToCharArray(), 0, value.Length), out connection2))
				{
					return true;
				}
				if (!SetterTest.StartReader(_0003) && SelectProperty(value, _0003, filter, out connection2))
				{
					return true;
				}
			}
			connection2 = default(DateTimeOffset);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CalculateProperty(InvocationTest reference, out long second, out TimeSpan state, out DateTimeKind result2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			result2 = DateTimeKind.Utc;
			int num = reference.ChangeReader('+', 7, reference._0002() - 8);
			if (num == -1)
			{
				num = reference.ChangeReader('-', 7, reference._0002() - 8);
			}
			if (num != -1)
			{
				result2 = DateTimeKind.Local;
				if (!DeleteProperty(reference, num + reference._0001(), out state))
				{
					second = 0L;
					return false;
				}
			}
			else
			{
				state = TimeSpan.Zero;
				num = reference._0002() - 2;
			}
			return HelperDicCandidate.CloneProperty(reference._0001(), 6 + reference._0001(), num - 6, out second) == (TYMED)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool GetProperty(InvocationTest asset, PsMaxLengths visitor, out DateTime role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CalculateProperty(asset, out long second, out TimeSpan _, out DateTimeKind result))
			{
				role = default(DateTime);
				return false;
			}
			DateTime dateTime = SearchProperty(second);
			switch (result)
			{
			case DateTimeKind.Unspecified:
				role = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
				break;
			case DateTimeKind.Local:
				role = dateTime.ToLocalTime();
				break;
			default:
				role = dateTime;
				break;
			}
			role = ReadProperty(role, visitor);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool StartProperty(string def, PsMaxLengths pred, string rule, CultureInfo v2, out DateTime vis3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (DateTime.TryParseExact(def, rule, v2, DateTimeStyles.RoundtripKind, out DateTime result))
			{
				result = (vis3 = ReadProperty(result, pred));
				return true;
			}
			vis3 = default(DateTime);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ListProperty(InvocationTest def, out DateTimeOffset connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CalculateProperty(def, out long second, out TimeSpan state, out DateTimeKind _))
			{
				connection = default(DateTime);
				return false;
			}
			connection = new DateTimeOffset(SearchProperty(second).Add(state).Ticks, state);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool SelectProperty(string spec, string reg, CultureInfo third, out DateTimeOffset v2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (DateTimeOffset.TryParseExact(spec, reg, third, DateTimeStyles.RoundtripKind, out DateTimeOffset result))
			{
				v2 = result;
				return true;
			}
			v2 = default(DateTimeOffset);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool DeleteProperty(InvocationTest task, int ID_map, out TimeSpan pool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool flag = task[ID_map] == '-';
			if (HelperDicCandidate.StopProperty(task._0001(), ID_map + 1, 2, out int result) != (TYMED)1)
			{
				pool = default(TimeSpan);
				return false;
			}
			int result2 = 0;
			if (task._0002() - ID_map > 5 && HelperDicCandidate.StopProperty(task._0001(), ID_map + 3, 2, out result2) != (TYMED)1)
			{
				pool = default(TimeSpan);
				return false;
			}
			pool = TimeSpan.FromHours(result) + TimeSpan.FromMinutes(result2);
			if (flag)
			{
				pool = pool.Negate();
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void TestProperty(TextWriter info, DateTime token, FindDirection state, string init2, CultureInfo res3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(init2))
			{
				char[] array = new char[64];
				int count = ConcatProperty(array, 0, token, null, token.Kind, state);
				info.Write(array, 0, count);
			}
			else
			{
				info.Write(token.ToString(init2, res3));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int ConcatProperty(char[] value, int start_cust, DateTime c, TimeSpan? asset2, DateTimeKind setup3, FindDirection token4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = start_cust;
			if (token4 == (FindDirection)1)
			{
				TimeSpan timeSpan = asset2 ?? c.AwakeProperty();
				long num2 = ResetProperty(c, timeSpan);
				"\\/Date(".CopyTo(0, value, num, 7);
				num += 7;
				string text = num2.ToString(CultureInfo.InvariantCulture);
				text.CopyTo(0, value, num, text.Length);
				num += text.Length;
				switch (setup3)
				{
				case DateTimeKind.Unspecified:
					if (c != DateTime.MaxValue && c != DateTime.MinValue)
					{
						num = CountProperty(value, num, timeSpan, token4);
					}
					break;
				case DateTimeKind.Local:
					num = CountProperty(value, num, timeSpan, token4);
					break;
				}
				")\\/".CopyTo(0, value, num, 3);
				num += 3;
			}
			else
			{
				num = InvokeProperty(value, num, c);
				switch (setup3)
				{
				case DateTimeKind.Local:
					num = CountProperty(value, num, asset2 ?? c.AwakeProperty(), token4);
					break;
				case DateTimeKind.Utc:
					value[num++] = 'Z';
					break;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int InvokeProperty(char[] asset, int cfg, DateTime role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 19;
			CustomizeProperty(role, out int cust, out int template, out int reg);
			PrintProperty(asset, cfg, cust, 4);
			asset[cfg + 4] = '-';
			PrintProperty(asset, cfg + 5, template, 2);
			asset[cfg + 7] = '-';
			PrintProperty(asset, cfg + 8, reg, 2);
			asset[cfg + 10] = 'T';
			PrintProperty(asset, cfg + 11, role.Hour, 2);
			asset[cfg + 13] = ':';
			PrintProperty(asset, cfg + 14, role.Minute, 2);
			asset[cfg + 16] = ':';
			PrintProperty(asset, cfg + 17, role.Second, 2);
			int num2 = (int)(role.Ticks % 10000000);
			if (num2 != 0)
			{
				int num3 = 7;
				while (num2 % 10 == 0)
				{
					num3--;
					num2 /= 10;
				}
				asset[cfg + 19] = '.';
				PrintProperty(asset, cfg + 20, num2, num3);
				num += num3 + 1;
			}
			return cfg + num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void PrintProperty(char[] value, int connection_end, int flagsfield, int offsetitem2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (offsetitem2-- != 0)
			{
				value[connection_end + offsetitem2] = (char)(flagsfield % 10 + 48);
				flagsfield /= 10;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int CountProperty(char[] param, int insert_PREDAt, TimeSpan helper, FindDirection pred2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			param[insert_PREDAt++] = ((helper.Ticks >= 0) ? '+' : '-');
			int flagsfield = Math.Abs(helper.Hours);
			PrintProperty(param, insert_PREDAt, flagsfield, 2);
			insert_PREDAt += 2;
			if (pred2 == (FindDirection)0)
			{
				param[insert_PREDAt++] = ':';
			}
			int flagsfield2 = Math.Abs(helper.Minutes);
			PrintProperty(param, insert_PREDAt, flagsfield2, 2);
			insert_PREDAt += 2;
			return insert_PREDAt;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AssetProperty(TextWriter var1, DateTimeOffset caller, FindDirection role, string cfg2, CultureInfo cont3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(cfg2))
			{
				char[] array = new char[64];
				int count = ConcatProperty(array, 0, (role == (FindDirection)0) ? caller.DateTime : caller.UtcDateTime, caller.Offset, DateTimeKind.Local, role);
				var1.Write(array, 0, count);
			}
			else
			{
				var1.Write(caller.ToString(cfg2, cont3));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CustomizeProperty(DateTime config, out int cust, out int template, out int reg2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = (int)(config.Ticks / 864000000000L);
			int num2 = num / 146097;
			num -= num2 * 146097;
			int num3 = num / 36524;
			if (num3 == 4)
			{
				num3 = 3;
			}
			num -= num3 * 36524;
			int num4 = num / 1461;
			num -= num4 * 1461;
			int num5 = num / 365;
			if (num5 == 4)
			{
				num5 = 3;
			}
			cust = num2 * 400 + num3 * 100 + num4 * 4 + num5 + 1;
			num -= num5 * 365;
			int[] array = (num5 == 3 && (num4 != 24 || num3 == 3)) ? _RegComposer : _ItemComposer;
			int i;
			for (i = num >> 6; num >= array[i]; i++)
			{
			}
			template = i;
			reg2 = num - array[i - 1] + 1;
		}
	}
}
