using GDBD.Workers;
using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace GDBD.Specifications
{
	internal static class ObserverEvent
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly string m_DescriptorEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static readonly string m_ProducerEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _StructEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool m_StubEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _CodeEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool m_TaskEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static readonly bool customerEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool interpreterEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _WatcherEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _CollectionEvent;

		public static string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObserverEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_StubEvent = (Environment.OSVersion.Platform == PlatformID.Win32NT);
			_CodeEvent = (ResolveList() && Environment.OSVersion.Version.Major >= 5);
			m_TaskEvent = (ResolveList() && Environment.OSVersion.Version.Major >= 6);
			customerEvent = (ResolveList() && Environment.OSVersion.Version >= new Version(6, 1));
			interpreterEvent = (ResolveList() && Environment.OSVersion.Version >= new Version(6, 2, 9200));
			_WatcherEvent = (ResolveList() && Environment.OSVersion.Version >= new Version(6, 3));
			_CollectionEvent = (ResolveList() && Environment.OSVersion.Version >= new Version(10, 0));
			m_ProducerEvent = "Unknown OS";
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator())
				{
					if (managementObjectEnumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
						m_ProducerEvent = managementObject["Caption"].ToString();
					}
				}
			}
			m_ProducerEvent = Regex.Replace(Name, "^.*(?=Windows)", "").Trim();
			_StructEvent = Environment.Is64BitOperatingSystem;
			m_DescriptorEvent = $"{Name} {(ValidateList() ? 64 : 32)} Bit";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static string VerifyList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_DescriptorEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool ValidateList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StructEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool ResolveList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_StubEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool RunList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _CodeEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool AddList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TaskEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool MapList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return customerEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool FlushList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return interpreterEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool StopList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _WatcherEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static bool LogoutList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _CollectionEvent;
		}
	}
}
