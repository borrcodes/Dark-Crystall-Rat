using GDBD.Workers;
using Microsoft.VisualBasic;
using Newtonsoft.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace GDBD.Specifications
{
	internal sealed class ReponseClassSpec
	{
		private static readonly string[] _PrinterEvent;

		private static Mutex mappingEvent;

		private static readonly RepositoryEvent m_MockEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PublishFilter(int info_end)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StringBuilder stringBuilder = new StringBuilder(info_end);
			for (int i = 0; i < info_end; i++)
			{
				stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[m_MockEvent.MoveList("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
			}
			return stringBuilder.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string WriteFilter(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Strings.StrReverse(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] RevertFilter(byte[] v, int counter, int idx_field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[v.Length - idx_field];
			Array.Copy(v, 0, array, 0, counter);
			Array.Copy(v, counter + idx_field, array, counter, v.Length - counter - idx_field);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool LoginList(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				Mutex.OpenExisting(spec);
			}
			catch
			{
				mappingEvent = new Mutex(initiallyOwned: true, spec);
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<string> CheckList(string res, int connectionLow)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<string> list = new List<string>();
			if (connectionLow > res.Length)
			{
				list.Add(res);
				return list;
			}
			int num = 0;
			bool flag = false;
			do
			{
				list.Add(res.Substring(num, connectionLow));
				num += connectionLow;
				if (connectionLow > res.Length - num)
				{
					flag = true;
				}
			}
			while (!flag);
			list.Add(res.Substring(num, res.Length - num));
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string DisableList(long max_i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			double num = max_i;
			int num2 = 0;
			while (num >= 1024.0 && num2 + 1 < _PrinterEvent.Length)
			{
				num2++;
				num /= 1024.0;
			}
			return $"{num:0.##} {_PrinterEvent[num2]}";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReponseClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReponseClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_PrinterEvent = new string[6]
			{
				"B",
				"KB",
				"MB",
				"GB",
				"TB",
				"PB"
			};
			m_MockEvent = new RepositoryEvent();
		}
	}
}
