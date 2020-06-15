using _0008;
using GDBD.Dispatcher;
using GDBD.Mocks;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[_0008._0012(0)]
	internal static class HelperDicCandidate
	{
		internal enum ListViewColumns
		{

		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(new byte[]
			{
				0,
				2,
				2
			})]
			public Newtonsoft.Rules.ClientInstanceRule<object, object> _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object _0001(object P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001(null, new object[1]
				{
					P_0
				});
			}
		}

		private static readonly Dictionary<Type, SettingsSerializeAs> _PublisherComposer;

		private static readonly StateErrorFilter[] m_UtilsComposer;

		[_0008._0012(new byte[]
		{
			1,
			0,
			1,
			1,
			2,
			2,
			2
		})]
		private static readonly Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<Type, Type>, Func<object, object>> m_StrategyComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SettingsSerializeAs PatchProperty(Type var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool counter;
			return FindProperty(var1, out counter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SettingsSerializeAs FindProperty(Type ident, out bool counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_PublisherComposer.TryGetValue(ident, out SettingsSerializeAs value))
			{
				counter = false;
				return value;
			}
			if (ident.LoginClient())
			{
				counter = true;
				return PatchProperty(Enum.GetUnderlyingType(ident));
			}
			if (ResolverErrorFilter.PatchReader(ident))
			{
				Type underlyingType = Nullable.GetUnderlyingType(ident);
				if (underlyingType.LoginClient())
				{
					Type var = typeof(Nullable<>).MakeGenericType(Enum.GetUnderlyingType(underlyingType));
					counter = true;
					return PatchProperty(var);
				}
			}
			counter = false;
			return (SettingsSerializeAs)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StateErrorFilter ValidateProperty(IConvertible def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_UtilsComposer[(int)def.GetTypeCode()];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool OrderProperty(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(IConvertible).IsAssignableFrom(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TimeSpan ResolveProperty(string init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return TimeSpan.Parse(init, CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object, object> FillProperty(GDBD.Workers.TemplateComposerWorker<Type, Type> init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type workerTest = init.workerTest;
			Type advisorTest = init._AdvisorTest;
			MethodInfo methodInfo = advisorTest.GetMethod("op_Implicit", new Type[1]
			{
				workerTest
			}) ?? advisorTest.GetMethod("op_Explicit", new Type[1]
			{
				workerTest
			});
			if (methodInfo == null)
			{
				return null;
			}
			Newtonsoft.Rules.ClientInstanceRule<object, object> clientInstanceRule = ConfigProperty._0001()._0001<object>(methodInfo);
			return (object P_0) => clientInstanceRule(null, new object[1]
			{
				P_0
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BigInteger RunProperty(object def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def is BigInteger)
			{
				return (BigInteger)def;
			}
			string text = def as string;
			if (text != null)
			{
				return BigInteger.Parse(text, CultureInfo.InvariantCulture);
			}
			if (def is float)
			{
				float value = (float)def;
				return new BigInteger(value);
			}
			if (def is double)
			{
				double value2 = (double)def;
				return new BigInteger(value2);
			}
			if (def is decimal)
			{
				decimal value3 = (decimal)def;
				return new BigInteger(value3);
			}
			if (def is int)
			{
				int value4 = (int)def;
				return new BigInteger(value4);
			}
			if (def is long)
			{
				long value5 = (long)def;
				return new BigInteger(value5);
			}
			if (def is uint)
			{
				uint value6 = (uint)def;
				return new BigInteger(value6);
			}
			if (def is ulong)
			{
				ulong value7 = (ulong)def;
				return new BigInteger(value7);
			}
			byte[] array = def as byte[];
			if (array != null)
			{
				return new BigInteger(array);
			}
			throw new InvalidCastException("Cannot convert {0} to BigInteger.".ListReader(CultureInfo.InvariantCulture, def.GetType()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CompareProperty(BigInteger first, Type caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (caller == typeof(decimal))
			{
				return (decimal)first;
			}
			if (caller == typeof(double))
			{
				return (double)first;
			}
			if (caller == typeof(float))
			{
				return (float)first;
			}
			if (caller == typeof(ulong))
			{
				return (ulong)first;
			}
			if (caller == typeof(bool))
			{
				return first != 0L;
			}
			try
			{
				return Convert.ChangeType((long)first, caller, CultureInfo.InvariantCulture);
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException("Can not convert from BigInteger to {0}.".ListReader(CultureInfo.InvariantCulture, caller), innerException);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool AddProperty([_0008._0012(2)] object _0002, CultureInfo attr, Type filter, [_0008._0012(2)] out object _0005)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (EnableProperty(_0002, attr, filter, out _0005) == (ListViewColumns)0)
				{
					return true;
				}
				_0005 = null;
				return false;
			}
			catch
			{
				_0005 = null;
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ListViewColumns EnableProperty([_0008._0012(2)] object _0002, CultureInfo ivk, Type proc, [_0008._0012(2)] out object _0005)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_0002 == null)
			{
				throw new ArgumentNullException("initialValue");
			}
			if (ResolverErrorFilter.PatchReader(proc))
			{
				proc = Nullable.GetUnderlyingType(proc);
			}
			Type type = _0002.GetType();
			if (proc == type)
			{
				_0005 = _0002;
				return (ListViewColumns)0;
			}
			if (OrderProperty(_0002.GetType()) && OrderProperty(proc))
			{
				if (proc.LoginClient())
				{
					if (_0002 is string)
					{
						_0005 = Enum.Parse(proc, _0002.ToString(), ignoreCase: true);
						return (ListViewColumns)0;
					}
					if (CreateProperty(_0002))
					{
						_0005 = Enum.ToObject(proc, _0002);
						return (ListViewColumns)0;
					}
				}
				_0005 = Convert.ChangeType(_0002, proc, ivk);
				return (ListViewColumns)0;
			}
			if (_0002 is DateTime)
			{
				DateTime dateTime = (DateTime)_0002;
				if (proc == typeof(DateTimeOffset))
				{
					_0005 = new DateTimeOffset(dateTime);
					return (ListViewColumns)0;
				}
			}
			byte[] array = _0002 as byte[];
			if (array != null && proc == typeof(Guid))
			{
				_0005 = new Guid(array);
				return (ListViewColumns)0;
			}
			if (_0002 is Guid)
			{
				Guid guid = (Guid)_0002;
				if (proc == typeof(byte[]))
				{
					_0005 = guid.ToByteArray();
					return (ListViewColumns)0;
				}
			}
			string text = _0002 as string;
			if (text != null)
			{
				if (proc == typeof(Guid))
				{
					_0005 = new Guid(text);
					return (ListViewColumns)0;
				}
				if (proc == typeof(Uri))
				{
					_0005 = new Uri(text, UriKind.RelativeOrAbsolute);
					return (ListViewColumns)0;
				}
				if (proc == typeof(TimeSpan))
				{
					_0005 = ResolveProperty(text);
					return (ListViewColumns)0;
				}
				if (proc == typeof(byte[]))
				{
					_0005 = Convert.FromBase64String(text);
					return (ListViewColumns)0;
				}
				if (proc == typeof(Version))
				{
					if (FlushProperty(text, out Version _0003))
					{
						_0005 = _0003;
						return (ListViewColumns)0;
					}
					_0005 = null;
					return (ListViewColumns)3;
				}
				if (typeof(Type).IsAssignableFrom(proc))
				{
					_0005 = Type.GetType(text, throwOnError: true);
					return (ListViewColumns)0;
				}
			}
			if (proc == typeof(BigInteger))
			{
				_0005 = RunProperty(_0002);
				return (ListViewColumns)0;
			}
			if (_0002 is BigInteger)
			{
				BigInteger first = (BigInteger)_0002;
				_0005 = CompareProperty(first, proc);
				return (ListViewColumns)0;
			}
			TypeConverter converter = TypeDescriptor.GetConverter(type);
			if (converter != null && converter.CanConvertTo(proc))
			{
				_0005 = converter.ConvertTo(null, ivk, _0002, proc);
				return (ListViewColumns)0;
			}
			TypeConverter converter2 = TypeDescriptor.GetConverter(proc);
			if (converter2 != null && converter2.CanConvertFrom(type))
			{
				_0005 = converter2.ConvertFrom(null, ivk, _0002);
				return (ListViewColumns)0;
			}
			if (_0002 == DBNull.Value)
			{
				if (ResolverErrorFilter.VerifyReader(proc))
				{
					_0005 = InsertProperty(null, type, proc);
					return (ListViewColumns)0;
				}
				_0005 = null;
				return (ListViewColumns)1;
			}
			if (proc.SortReader() || proc.PublishReader() || proc.VerifyClient())
			{
				_0005 = null;
				return (ListViewColumns)2;
			}
			_0005 = null;
			return (ListViewColumns)3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object MapProperty(object res, CultureInfo selection, Type temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (temp == typeof(object))
			{
				return res;
			}
			if (res == null && ResolverErrorFilter.VerifyReader(temp))
			{
				return null;
			}
			if (AddProperty(res, selection, temp, out object _0005))
			{
				return _0005;
			}
			return InsertProperty(res, ResolverErrorFilter.CallIssuer(res), temp);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object InsertProperty(object param, Type result, Type tag)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param != null)
			{
				Type type = param.GetType();
				if (tag.IsAssignableFrom(type))
				{
					return param;
				}
				Func<object, object> func = m_StrategyComposer.InitReader(new GDBD.Workers.TemplateComposerWorker<Type, Type>(type, tag));
				if (func != null)
				{
					return func(param);
				}
			}
			else if (ResolverErrorFilter.VerifyReader(tag))
			{
				return null;
			}
			throw new ArgumentException("Could not cast or convert from {0} to {1}.".SelectReader(CultureInfo.InvariantCulture, result?.ToString() ?? "{null}", tag));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool FlushProperty(string ident, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out Version _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Version.TryParse(ident, out _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CreateProperty(object reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (PatchProperty(reference.GetType()))
			{
			case (SettingsSerializeAs)6:
			case (SettingsSerializeAs)8:
			case (SettingsSerializeAs)10:
			case (SettingsSerializeAs)12:
			case (SettingsSerializeAs)14:
			case (SettingsSerializeAs)16:
			case (SettingsSerializeAs)18:
			case (SettingsSerializeAs)20:
				return true;
			default:
				return false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TYMED StopProperty(char[] last, int colhigh, int filter, out int result2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			result2 = 0;
			if (filter == 0)
			{
				return (TYMED)3;
			}
			bool flag = last[colhigh] == '-';
			if (flag)
			{
				if (filter == 1)
				{
					return (TYMED)3;
				}
				colhigh++;
				filter--;
			}
			int num = colhigh + filter;
			if (filter > 10 || (filter == 10 && last[colhigh] - 48 > 2))
			{
				for (int i = colhigh; i < num; i++)
				{
					int num2 = last[i] - 48;
					if (num2 < 0 || num2 > 9)
					{
						return (TYMED)3;
					}
				}
				return (TYMED)2;
			}
			for (int j = colhigh; j < num; j++)
			{
				int num3 = last[j] - 48;
				if (num3 < 0 || num3 > 9)
				{
					return (TYMED)3;
				}
				int num4 = 10 * result2 - num3;
				if (num4 > result2)
				{
					for (j++; j < num; j++)
					{
						num3 = last[j] - 48;
						if (num3 < 0 || num3 > 9)
						{
							return (TYMED)3;
						}
					}
					return (TYMED)2;
				}
				result2 = num4;
			}
			if (!flag)
			{
				if (result2 == int.MinValue)
				{
					return (TYMED)2;
				}
				result2 = -result2;
			}
			return (TYMED)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TYMED CloneProperty(char[] res, int indexOfpol, int rule_X, out long caller2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			caller2 = 0L;
			if (rule_X == 0)
			{
				return (TYMED)3;
			}
			bool flag = res[indexOfpol] == '-';
			if (flag)
			{
				if (rule_X == 1)
				{
					return (TYMED)3;
				}
				indexOfpol++;
				rule_X--;
			}
			int num = indexOfpol + rule_X;
			if (rule_X > 19)
			{
				for (int i = indexOfpol; i < num; i++)
				{
					int num2 = res[i] - 48;
					if (num2 < 0 || num2 > 9)
					{
						return (TYMED)3;
					}
				}
				return (TYMED)2;
			}
			for (int j = indexOfpol; j < num; j++)
			{
				int num3 = res[j] - 48;
				if (num3 < 0 || num3 > 9)
				{
					return (TYMED)3;
				}
				long num4 = 10 * caller2 - num3;
				if (num4 > caller2)
				{
					for (j++; j < num; j++)
					{
						num3 = res[j] - 48;
						if (num3 < 0 || num3 > 9)
						{
							return (TYMED)3;
						}
					}
					return (TYMED)2;
				}
				caller2 = num4;
			}
			if (!flag)
			{
				if (caller2 == long.MinValue)
				{
					return (TYMED)2;
				}
				caller2 = -caller2;
			}
			return (TYMED)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TYMED LogoutProperty(char[] reference, int start_ivk, int util_amount, out decimal reference2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			reference2 = default(decimal);
			if (util_amount == 0)
			{
				return (TYMED)3;
			}
			bool flag = reference[start_ivk] == '-';
			if (flag)
			{
				if (util_amount == 1)
				{
					return (TYMED)3;
				}
				start_ivk++;
				util_amount--;
			}
			int i = start_ivk;
			int num = start_ivk + util_amount;
			int num2 = num;
			int num3 = num;
			int num4 = 0;
			ulong num5 = 0uL;
			ulong num6 = 0uL;
			int num7 = 0;
			int num8 = 0;
			char? c = null;
			bool? flag2 = null;
			for (; i < num; i++)
			{
				char c2 = reference[i];
				if (c2 == '.')
				{
					goto IL_008a;
				}
				if (c2 == 'E' || c2 == 'e')
				{
					goto IL_00b0;
				}
				if (c2 < '0' || c2 > '9')
				{
					return (TYMED)3;
				}
				if (i == start_ivk && c2 == '0')
				{
					i++;
					if (i != num)
					{
						c2 = reference[i];
						if (c2 == '.')
						{
							goto IL_008a;
						}
						if (c2 != 'e' && c2 != 'E')
						{
							return (TYMED)3;
						}
						goto IL_00b0;
					}
				}
				if (num7 < 29)
				{
					if (num7 == 28)
					{
						bool? flag3 = flag2;
						bool valueOrDefault;
						if (!flag3.HasValue)
						{
							flag2 = (num5 > 7922816251426433759L || (num5 == 7922816251426433759L && (num6 > 354395033 || (num6 == 354395033 && c2 > '5'))));
							bool? flag4 = flag2;
							valueOrDefault = flag4.GetValueOrDefault();
						}
						else
						{
							valueOrDefault = flag3.GetValueOrDefault();
						}
						if (valueOrDefault)
						{
							goto IL_027e;
						}
					}
					if (num7 < 19)
					{
						num5 = (ulong)((long)(num5 * 10) + (long)(c2 - 48));
					}
					else
					{
						num6 = (ulong)((long)(num6 * 10) + (long)(c2 - 48));
					}
					num7++;
					continue;
				}
				goto IL_027e;
				IL_008a:
				if (i == start_ivk)
				{
					return (TYMED)3;
				}
				if (i + 1 == num)
				{
					return (TYMED)3;
				}
				if (num2 != num)
				{
					return (TYMED)3;
				}
				num2 = i + 1;
				continue;
				IL_027e:
				if (!c.HasValue)
				{
					c = c2;
				}
				num8++;
				continue;
				IL_00b0:
				if (i == start_ivk)
				{
					return (TYMED)3;
				}
				if (i == num2)
				{
					return (TYMED)3;
				}
				i++;
				if (i == num)
				{
					return (TYMED)3;
				}
				if (num2 < num)
				{
					num3 = i - 1;
				}
				c2 = reference[i];
				bool flag5 = false;
				switch (c2)
				{
				case '-':
					flag5 = true;
					i++;
					break;
				case '+':
					i++;
					break;
				}
				for (; i < num; i++)
				{
					c2 = reference[i];
					if (c2 < '0' || c2 > '9')
					{
						return (TYMED)3;
					}
					int num9 = 10 * num4 + (c2 - 48);
					if (num4 < num9)
					{
						num4 = num9;
					}
				}
				if (flag5)
				{
					num4 = -num4;
				}
			}
			num4 += num8;
			num4 -= num3 - num2;
			if (num7 <= 19)
			{
				reference2 = num5;
			}
			else
			{
				reference2 = (decimal)num5 / new decimal(1, 0, 0, isNegative: false, (byte)(num7 - 19)) + (decimal)num6;
			}
			if (num4 > 0)
			{
				num7 += num4;
				if (num7 > 29)
				{
					return (TYMED)2;
				}
				if (num7 == 29)
				{
					if (num4 > 1)
					{
						reference2 /= new decimal(1, 0, 0, isNegative: false, (byte)(num4 - 1));
						if (reference2 > 7922816251426433759354395033m)
						{
							return (TYMED)2;
						}
					}
					else if (reference2 == 7922816251426433759354395033m && c > '5')
					{
						return (TYMED)2;
					}
					reference2 *= 10m;
				}
				else
				{
					reference2 /= new decimal(1, 0, 0, isNegative: false, (byte)num4);
				}
			}
			else
			{
				if (c >= '5' && num4 >= -28)
				{
					++reference2;
				}
				if (num4 < 0)
				{
					if (num7 + num4 + 28 <= 0)
					{
						reference2 = (flag ? 0m : 0m);
						return (TYMED)1;
					}
					if (num4 >= -28)
					{
						reference2 *= new decimal(1, 0, 0, isNegative: false, (byte)(-num4));
					}
					else
					{
						reference2 /= 10000000000000000000000000000m;
						reference2 *= new decimal(1, 0, 0, isNegative: false, (byte)(-num4 - 28));
					}
				}
			}
			if (flag)
			{
				reference2 = -reference2;
			}
			return (TYMED)1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool VisitProperty(string v, out Guid connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Guid.TryParseExact(v, "D", out connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ViewProperty(char[] key, int b_offset, int comp_offset, out int selection2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			selection2 = 0;
			for (int i = b_offset; i < comp_offset; i++)
			{
				char c = key[i];
				int num;
				if (c <= '9' && c >= '0')
				{
					num = c - 48;
				}
				else if (c <= 'F' && c >= 'A')
				{
					num = c - 55;
				}
				else
				{
					if (c > 'f' || c < 'a')
					{
						selection2 = 0;
						return false;
					}
					num = c - 87;
				}
				selection2 += num << (comp_offset - 1 - i) * 4;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HelperDicCandidate()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_PublisherComposer = new Dictionary<Type, SettingsSerializeAs>
			{
				{
					typeof(char),
					(SettingsSerializeAs)2
				},
				{
					typeof(char?),
					(SettingsSerializeAs)3
				},
				{
					typeof(bool),
					(SettingsSerializeAs)4
				},
				{
					typeof(bool?),
					(SettingsSerializeAs)5
				},
				{
					typeof(sbyte),
					(SettingsSerializeAs)6
				},
				{
					typeof(sbyte?),
					(SettingsSerializeAs)7
				},
				{
					typeof(short),
					(SettingsSerializeAs)8
				},
				{
					typeof(short?),
					(SettingsSerializeAs)9
				},
				{
					typeof(ushort),
					(SettingsSerializeAs)10
				},
				{
					typeof(ushort?),
					(SettingsSerializeAs)11
				},
				{
					typeof(int),
					(SettingsSerializeAs)12
				},
				{
					typeof(int?),
					(SettingsSerializeAs)13
				},
				{
					typeof(byte),
					(SettingsSerializeAs)14
				},
				{
					typeof(byte?),
					(SettingsSerializeAs)15
				},
				{
					typeof(uint),
					(SettingsSerializeAs)16
				},
				{
					typeof(uint?),
					(SettingsSerializeAs)17
				},
				{
					typeof(long),
					(SettingsSerializeAs)18
				},
				{
					typeof(long?),
					(SettingsSerializeAs)19
				},
				{
					typeof(ulong),
					(SettingsSerializeAs)20
				},
				{
					typeof(ulong?),
					(SettingsSerializeAs)21
				},
				{
					typeof(float),
					(SettingsSerializeAs)22
				},
				{
					typeof(float?),
					(SettingsSerializeAs)23
				},
				{
					typeof(double),
					(SettingsSerializeAs)24
				},
				{
					typeof(double?),
					(SettingsSerializeAs)25
				},
				{
					typeof(DateTime),
					(SettingsSerializeAs)26
				},
				{
					typeof(DateTime?),
					(SettingsSerializeAs)27
				},
				{
					typeof(DateTimeOffset),
					(SettingsSerializeAs)28
				},
				{
					typeof(DateTimeOffset?),
					(SettingsSerializeAs)29
				},
				{
					typeof(decimal),
					(SettingsSerializeAs)30
				},
				{
					typeof(decimal?),
					(SettingsSerializeAs)31
				},
				{
					typeof(Guid),
					(SettingsSerializeAs)32
				},
				{
					typeof(Guid?),
					(SettingsSerializeAs)33
				},
				{
					typeof(TimeSpan),
					(SettingsSerializeAs)34
				},
				{
					typeof(TimeSpan?),
					(SettingsSerializeAs)35
				},
				{
					typeof(BigInteger),
					(SettingsSerializeAs)36
				},
				{
					typeof(BigInteger?),
					(SettingsSerializeAs)37
				},
				{
					typeof(Uri),
					(SettingsSerializeAs)38
				},
				{
					typeof(string),
					(SettingsSerializeAs)39
				},
				{
					typeof(byte[]),
					(SettingsSerializeAs)40
				},
				{
					typeof(DBNull),
					(SettingsSerializeAs)41
				}
			};
			m_UtilsComposer = new StateErrorFilter[19]
			{
				new StateErrorFilter(typeof(object), (SettingsSerializeAs)0),
				new StateErrorFilter(typeof(object), (SettingsSerializeAs)1),
				new StateErrorFilter(typeof(object), (SettingsSerializeAs)41),
				new StateErrorFilter(typeof(bool), (SettingsSerializeAs)4),
				new StateErrorFilter(typeof(char), (SettingsSerializeAs)2),
				new StateErrorFilter(typeof(sbyte), (SettingsSerializeAs)6),
				new StateErrorFilter(typeof(byte), (SettingsSerializeAs)14),
				new StateErrorFilter(typeof(short), (SettingsSerializeAs)8),
				new StateErrorFilter(typeof(ushort), (SettingsSerializeAs)10),
				new StateErrorFilter(typeof(int), (SettingsSerializeAs)12),
				new StateErrorFilter(typeof(uint), (SettingsSerializeAs)16),
				new StateErrorFilter(typeof(long), (SettingsSerializeAs)18),
				new StateErrorFilter(typeof(ulong), (SettingsSerializeAs)20),
				new StateErrorFilter(typeof(float), (SettingsSerializeAs)22),
				new StateErrorFilter(typeof(double), (SettingsSerializeAs)24),
				new StateErrorFilter(typeof(decimal), (SettingsSerializeAs)30),
				new StateErrorFilter(typeof(DateTime), (SettingsSerializeAs)26),
				new StateErrorFilter(typeof(object), (SettingsSerializeAs)0),
				new StateErrorFilter(typeof(string), (SettingsSerializeAs)39)
			};
			m_StrategyComposer = new Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<Type, Type>, Func<object, object>>(FillProperty);
		}
	}
}
