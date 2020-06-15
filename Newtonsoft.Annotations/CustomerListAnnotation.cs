using _0008;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Newtonsoft.Annotations
{
	[_0008._0012(0)]
	internal static class CustomerListAnnotation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TestIssuer(object init, object cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == cust)
			{
				return true;
			}
			if (init == null || cust == null)
			{
				return false;
			}
			if (init.GetType() != cust.GetType())
			{
				if (HelperDicCandidate.CreateProperty(init) && HelperDicCandidate.CreateProperty(cust))
				{
					return Convert.ToDecimal(init, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(cust, CultureInfo.CurrentCulture));
				}
				if ((init is double || init is float || init is decimal) && (cust is double || cust is float || cust is decimal))
				{
					return IteratorComposerPool.DeleteIssuer(Convert.ToDouble(init, CultureInfo.CurrentCulture), Convert.ToDouble(cust, CultureInfo.CurrentCulture));
				}
				return false;
			}
			return init.Equals(cust);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ArgumentOutOfRangeException ConcatIssuer(string setup, object caller, string serv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string message = serv + Environment.NewLine + "Actual value was {0}.".ListReader(CultureInfo.InvariantCulture, caller);
			return new ArgumentOutOfRangeException(setup, message);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InvokeIssuer(object setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup == null)
			{
				return "{null}";
			}
			string text = setup as string;
			if (text == null)
			{
				return setup.ToString();
			}
			return "\"" + text + "\"";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int PrintIssuer(byte[] task, byte[] connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = task.Length.CompareTo(connection.Length);
			if (num != 0)
			{
				return num;
			}
			for (int i = 0; i < task.Length; i++)
			{
				int num2 = task[i].CompareTo(connection[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CountIssuer(string item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CustomizeIssuer(item, out string _0003, out string _);
			return _0003;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string AssetIssuer(string reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CustomizeIssuer(reference, out string _, out string role);
			return role;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CustomizeIssuer(string key, [_0008._0012(2)] out string _0003, out string role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = key.IndexOf(':');
			if (num == -1 || num == 0 || key.Length - 1 == num)
			{
				_0003 = null;
				role = key;
			}
			else
			{
				_0003 = key.Substring(0, num);
				role = key.Substring(num + 1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RegexOptions QueryIssuer(string init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RegexOptions regexOptions = RegexOptions.None;
			for (int i = 0; i < init.Length; i++)
			{
				switch (init[i])
				{
				case 'i':
					regexOptions |= RegexOptions.IgnoreCase;
					break;
				case 'm':
					regexOptions |= RegexOptions.Multiline;
					break;
				case 's':
					regexOptions |= RegexOptions.Singleline;
					break;
				case 'x':
					regexOptions |= RegexOptions.ExplicitCapture;
					break;
				}
			}
			return regexOptions;
		}
	}
}
