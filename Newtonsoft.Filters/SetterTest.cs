using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	internal static class SetterTest
	{
		[CompilerGenerated]
		private sealed class _0001<_0001>
		{
			[_0008._0012(new byte[]
			{
				0,
				0,
				1
			})]
			public Func<_0001, string> _0001;

			[_0008._0012(0)]
			public string _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(_0001 P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return string.Equals(this._0001(P_0), this._0002, StringComparison.OrdinalIgnoreCase);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0002(_0001 P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return string.Equals(this._0001(P_0), this._0002, StringComparison.Ordinal);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StartReader(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return string.IsNullOrEmpty(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ListReader(this string asset, IFormatProvider attr, object serv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return asset.ConcatReader(attr, new object[1]
			{
				serv
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SelectReader(this string spec, IFormatProvider caller, object state, object selection2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return spec.ConcatReader(caller, new object[2]
			{
				state,
				selection2
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string DeleteReader(this string asset, IFormatProvider visitor, object filter, object var12, object last3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return asset.ConcatReader(visitor, new object[3]
			{
				filter,
				var12,
				last3
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string TestReader(this string reference, IFormatProvider pred, object serv, object cfg2, object ord3, object first4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return reference.ConcatReader(pred, new object[4]
			{
				serv,
				cfg2,
				ord3,
				first4
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ConcatReader(this string v, IFormatProvider col, object[] state)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(v, "format");
			return string.Format(col, v, state);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StringWriter InvokeReader(int ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new StringWriter(new StringBuilder(ident), CultureInfo.InvariantCulture);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrintReader(char info, char[] ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ord[0] = '\\';
			ord[1] = 'u';
			ord[2] = IteratorComposerPool.SelectIssuer(((int)info >> 12) & 0xF);
			ord[3] = IteratorComposerPool.SelectIssuer(((int)info >> 8) & 0xF);
			ord[4] = IteratorComposerPool.SelectIssuer(((int)info >> 4) & 0xF);
			ord[5] = IteratorComposerPool.SelectIssuer(info & 0xF);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CountReader<[_0008._0012(2)] T>(this IEnumerable<T> def, Func<T, string> second, string filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == null)
			{
				throw new ArgumentNullException("source");
			}
			if (second == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<T> source = def.Where((T P_0) => string.Equals(second(P_0), filter, StringComparison.OrdinalIgnoreCase));
			if (source.Count() <= 1)
			{
				return source.SingleOrDefault();
			}
			return def.Where((T P_0) => string.Equals(second(P_0), filter, StringComparison.Ordinal)).SingleOrDefault();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string AssetReader(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (StartReader(key) || !char.IsUpper(key[0]))
			{
				return key;
			}
			char[] array = key.ToCharArray();
			for (int i = 0; i < array.Length && (i != 1 || char.IsUpper(array[i])); i++)
			{
				bool flag = i + 1 < array.Length;
				if (i > 0 && flag && !char.IsUpper(array[i + 1]))
				{
					if (char.IsSeparator(array[i + 1]))
					{
						array[i] = CustomizeReader(array[i]);
					}
					break;
				}
				array[i] = CustomizeReader(array[i]);
			}
			return new string(array);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static char CustomizeReader(char value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			value = char.ToLower(value, CultureInfo.InvariantCulture);
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueryReader(char res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return char.IsHighSurrogate(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CancelReader(char first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return char.IsLowSurrogate(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ExcludeReader(this string def, char reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def.Length > 0)
			{
				return def[0] == reg;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool SetupReader(this string param, char counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param.Length > 0)
			{
				return param[param.Length - 1] == counter;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ManageReader(this string config, int pollength, int version_comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config == null)
			{
				throw new ArgumentNullException();
			}
			if (pollength < 0)
			{
				throw new ArgumentOutOfRangeException("start");
			}
			if (version_comp < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			int num = pollength + version_comp - 1;
			if (num >= config.Length)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			while (pollength < num && char.IsWhiteSpace(config[pollength]))
			{
				pollength++;
			}
			while (num >= pollength && char.IsWhiteSpace(config[num]))
			{
				num--;
			}
			return config.Substring(pollength, num - pollength + 1);
		}
	}
}
