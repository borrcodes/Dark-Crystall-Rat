using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal static class InfoFilterResolver
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class ReponseReaderMapper
		{
			[_0008._0012(0)]
			public static readonly ReponseReaderMapper instanceTest;

			[_0008._0012(0)]
			public static Func<EnumMemberAttribute, string> dicTest;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ReponseReaderMapper()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				instanceTest = new ReponseReaderMapper();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ReponseReaderMapper()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string ViewIssuer(EnumMemberAttribute reference)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return reference.Value;
			}
		}

		[_0008._0012(new byte[]
		{
			1,
			0,
			1,
			2,
			1
		})]
		private static readonly Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping>, ThreadComposer> _EventTest;

		private static TestsComposerPool _FilterTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ThreadComposer MapIssuer(GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping> v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type workerTest = v.workerTest;
			string[] names = Enum.GetNames(workerTest);
			string[] array = new string[names.Length];
			ulong[] array2 = new ulong[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				FieldInfo field = workerTest.GetField(text, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				array2[i] = StopIssuer(field.GetValue(null));
				string text2 = (from EnumMemberAttribute reference in field.GetCustomAttributes(typeof(EnumMemberAttribute), inherit: true)
					select reference.Value).SingleOrDefault();
				bool setattr = text2 != null;
				if (text2 == null)
				{
					text2 = text;
				}
				string text3 = text2;
				if (Array.IndexOf(array, text3, 0, i) != -1)
				{
					throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".SelectReader(CultureInfo.InvariantCulture, text3, workerTest.Name));
				}
				array[i] = ((v._AdvisorTest != null) ? v._AdvisorTest._0001(text3, setattr) : text3);
			}
			return new ThreadComposer(workerTest.IsDefined(typeof(FlagsAttribute), inherit: false), array2, names, array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool InsertIssuer(Type spec, object vis, [_0008._0012(2)] ProducerIteratorMapping _0004, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(2)] out string _0005)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ThreadComposer threadComposer = _EventTest.InitReader(new GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping>(spec, _0004));
			ulong num = StopIssuer(vis);
			if (!threadComposer._ConsumerComposer)
			{
				int num2 = Array.BinarySearch(threadComposer.comparatorComposer, num);
				if (num2 >= 0)
				{
					_0005 = threadComposer._RecordTest[num2];
					return true;
				}
				_0005 = null;
				return false;
			}
			_0005 = FlushIssuer(threadComposer, num);
			return _0005 != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string FlushIssuer(ThreadComposer i, ulong attramount)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string[] recordTest = i._RecordTest;
			ulong[] comparatorComposer = i.comparatorComposer;
			int num = comparatorComposer.Length - 1;
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			ulong num2 = attramount;
			while (num >= 0 && (num != 0 || comparatorComposer[num] != 0L))
			{
				if ((attramount & comparatorComposer[num]) == comparatorComposer[num])
				{
					attramount -= comparatorComposer[num];
					if (!flag)
					{
						stringBuilder.Insert(0, ", ");
					}
					string value = recordTest[num];
					stringBuilder.Insert(0, value);
					flag = false;
				}
				num--;
			}
			if (attramount != 0L)
			{
				return null;
			}
			if (num2 == 0L)
			{
				if (comparatorComposer.Length != 0 && comparatorComposer[0] == 0L)
				{
					return recordTest[0];
				}
				return null;
			}
			return stringBuilder.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ThreadComposer CreateIssuer(Type ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventTest.InitReader(new GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping>(ident, null));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ulong StopIssuer(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool counter;
			switch (HelperDicCandidate.FindProperty(value.GetType(), out counter))
			{
			case (SettingsSerializeAs)6:
				return (ulong)(sbyte)value;
			case (SettingsSerializeAs)14:
				return (byte)value;
			case (SettingsSerializeAs)4:
				return Convert.ToByte((bool)value);
			case (SettingsSerializeAs)8:
				return (ulong)(short)value;
			case (SettingsSerializeAs)10:
				return (ushort)value;
			case (SettingsSerializeAs)2:
				return (char)value;
			case (SettingsSerializeAs)16:
				return (uint)value;
			case (SettingsSerializeAs)12:
				return (ulong)(int)value;
			case (SettingsSerializeAs)20:
				return (ulong)value;
			case (SettingsSerializeAs)18:
				return (ulong)(long)value;
			default:
				throw new InvalidOperationException("Unknown enum type.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CloneIssuer(Type param, ProducerIteratorMapping cfg, string role, bool isvalue2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(param, "enumType");
			ContextClientBridge.RunClient(role, "value");
			if (!param.LoginClient())
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			ThreadComposer threadComposer = _EventTest.InitReader(new GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping>(param, cfg));
			string[] procComposer = threadComposer.procComposer;
			string[] recordTest = threadComposer._RecordTest;
			ulong[] comparatorComposer = threadComposer.comparatorComposer;
			int? num = VisitIssuer(recordTest, role, 0, role.Length, StringComparison.Ordinal);
			if (num.HasValue)
			{
				return Enum.ToObject(param, comparatorComposer[num.Value]);
			}
			int num2 = -1;
			for (int i = 0; i < role.Length; i++)
			{
				if (!char.IsWhiteSpace(role[i]))
				{
					num2 = i;
					break;
				}
			}
			if (num2 == -1)
			{
				throw new ArgumentException("Must specify valid information for parsing in the string.");
			}
			char c = role[num2];
			if (char.IsDigit(c) || c == '-' || c == '+')
			{
				Type underlyingType = Enum.GetUnderlyingType(param);
				role = role.Trim();
				object obj = null;
				try
				{
					obj = Convert.ChangeType(role, underlyingType, CultureInfo.InvariantCulture);
				}
				catch (FormatException)
				{
				}
				if (obj != null)
				{
					if (isvalue2)
					{
						throw new FormatException("Integer string '{0}' is not allowed.".ListReader(CultureInfo.InvariantCulture, role));
					}
					return Enum.ToObject(param, obj);
				}
			}
			ulong num3 = 0uL;
			int j = num2;
			while (j <= role.Length)
			{
				int num4 = role.IndexOf(',', j);
				if (num4 == -1)
				{
					num4 = role.Length;
				}
				int num5 = num4;
				for (; j < num4 && char.IsWhiteSpace(role[j]); j++)
				{
				}
				while (num5 > j && char.IsWhiteSpace(role[num5 - 1]))
				{
					num5--;
				}
				int instance3_offset = num5 - j;
				num = LogoutIssuer(role, procComposer, recordTest, j, instance3_offset, StringComparison.Ordinal);
				if (!num.HasValue)
				{
					num = LogoutIssuer(role, procComposer, recordTest, j, instance3_offset, StringComparison.OrdinalIgnoreCase);
				}
				if (!num.HasValue)
				{
					num = VisitIssuer(recordTest, role, 0, role.Length, StringComparison.OrdinalIgnoreCase);
					if (num.HasValue)
					{
						return Enum.ToObject(param, comparatorComposer[num.Value]);
					}
					throw new ArgumentException("Requested value '{0}' was not found.".ListReader(CultureInfo.InvariantCulture, role));
				}
				num3 |= comparatorComposer[num.Value];
				j = num4 + 1;
			}
			return Enum.ToObject(param, num3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int? LogoutIssuer(string def, string[] connection, string[] third, int mean_param2, int instance3_offset, StringComparison token4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int? result = VisitIssuer(third, def, mean_param2, instance3_offset, token4);
			if (!result.HasValue)
			{
				result = VisitIssuer(connection, def, mean_param2, instance3_offset, token4);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int? VisitIssuer(string[] def, string cfg, int mean_helper, int var12length, StringComparison token3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			for (int i = 0; i < def.Length; i++)
			{
				if (def[i].Length == var12length && string.Compare(def[i], 0, cfg, mean_helper, var12length, token3) == 0)
				{
					return i;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_EventTest = new Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<Type, ProducerIteratorMapping>, ThreadComposer>(MapIssuer);
			_FilterTest = new TestsComposerPool();
		}
	}
}
