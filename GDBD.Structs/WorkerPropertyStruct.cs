using GDBD.Dispatcher;
using GDBD.Workers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Structs
{
	internal sealed class WorkerPropertyStruct
	{
		internal struct ClassReader
		{
			public string m_RequestReader;

			public Version iteratorReader;

			public string testsReader;

			public string _MethodReader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ReadIterator(bool isparam)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_00e8: Incompatible stack heights: 0 vs 1
				//IL_00f4: Incompatible stack heights: 0 vs 1
				//IL_00fa: Incompatible stack heights: 0 vs 1
				//IL_0104: Incompatible stack heights: 0 vs 1
				//IL_010a: Incompatible stack heights: 0 vs 1
				//IL_0110: Incompatible stack heights: 0 vs 1
				//IL_011a: Incompatible stack heights: 0 vs 1
				//IL_0120: Incompatible stack heights: 0 vs 1
				new StringBuilder();
				StringBuilder stringBuilder = (StringBuilder)/*Error near IL_00ee: Stack underflow*/;
				string requestReader = ((ClassReader)/*Error near IL_001d: Stack underflow*/).m_RequestReader;
				((StringBuilder)/*Error near IL_0104: Stack underflow*/).Append(requestReader);
				if (0 == 0)
				{
					while ((int)/*Error near IL_0033: Stack underflow*/ != 0)
					{
						_ = (((ClassReader)/*Error near IL_003d: Stack underflow*/).iteratorReader != null);
						if (4u != 0)
						{
							if ((int)/*Error near IL_004e: Stack underflow*/ != 0)
							{
								((StringBuilder)/*Error near IL_005e: Stack underflow*/).Append(", Version=");
								stringBuilder.Append(iteratorReader);
							}
							break;
						}
					}
					stringBuilder.Append(", Culture=");
				}
				if (8u != 0)
				{
					stringBuilder.Append((testsReader.Length == 0) ? "neutral" : testsReader);
					stringBuilder.Append(", PublicKeyToken=");
					stringBuilder.Append((_MethodReader.Length == 0) ? "null" : _MethodReader);
				}
				return stringBuilder.ToString();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ClassReader(string reference)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				iteratorReader = null;
				testsReader = string.Empty;
				_MethodReader = string.Empty;
				m_RequestReader = string.Empty;
				string[] array = reference.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (text.StartsWith("Version="))
					{
						iteratorReader = new Version(text.Substring(8));
					}
					else if (text.StartsWith("Culture="))
					{
						testsReader = text.Substring(8);
						if (testsReader == "neutral")
						{
							testsReader = string.Empty;
						}
					}
					else if (text.StartsWith("PublicKeyToken="))
					{
						_MethodReader = text.Substring(15);
						if (_MethodReader == "null")
						{
							_MethodReader = string.Empty;
						}
					}
					else
					{
						m_RequestReader = text;
					}
				}
			}
		}

		private static Dictionary<string, Assembly> m_BroadcasterReader;

		[DllImport("kernel32", EntryPoint = "MoveFileEx")]
		private static extern bool IncludeIterator(string init, string cust, int tag_count);

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AwakeIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_005a: Incompatible stack heights: 0 vs 1
			//IL_0075: Incompatible stack heights: 0 vs 1
			//IL_007f: Incompatible stack heights: 0 vs 1
			//IL_0089: Incompatible stack heights: 0 vs 1
			//IL_0093: Incompatible stack heights: 0 vs 1
			//IL_009f: Incompatible stack heights: 0 vs 1
			//IL_00a9: Incompatible stack heights: 0 vs 1
			//IL_00b5: Incompatible stack heights: 0 vs 1
			bool flag;
			try
			{
				Process.GetCurrentProcess();
				_ = ((Process)/*Error near IL_007f: Stack underflow*/).MainModule;
				_ = ((ProcessModule)/*Error near IL_0089: Stack underflow*/).ModuleName;
				((string)/*Error near IL_0093: Stack underflow*/).ToLower();
				string text = (string)/*Error near IL_0099: Stack underflow*/;
				if (0 == 0)
				{
					_ = ((string)/*Error near IL_00a9: Stack underflow*/ == "w3wp.exe");
					if (uint.MaxValue != 0)
					{
						if ((int)/*Error near IL_003e: Stack underflow*/ != 0)
						{
							if (0 == 0)
							{
								flag = true;
							}
							goto IL_00c2;
						}
						_ = ((string)/*Error near IL_005f: Stack underflow*/ == "aspnet_wp.exe");
					}
					if ((int)/*Error near IL_0064: Stack underflow*/ != 0)
					{
						flag = true;
						goto IL_00c2;
					}
				}
			}
			catch
			{
			}
			goto IL_00c0;
			IL_00c2:
			if (4 == 0)
			{
				goto IL_00c0;
			}
			int result = flag ? 1 : 0;
			if (0 == 0)
			{
				return (byte)result != 0;
			}
			goto IL_00c1;
			IL_00c0:
			result = 0;
			goto IL_00c1;
			IL_00c1:
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PushIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			try
			{
				_ = AppDomain.CurrentDomain;
				ResolveEventHandler value = PrepareIterator;
				((AppDomain)/*Error near IL_002e: Stack underflow*/).AssemblyResolve += value;
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static Assembly PrepareIterator(object def, ResolveEventArgs cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_02e0: Incompatible stack heights: 0 vs 2
			//IL_02ea: Incompatible stack heights: 0 vs 1
			//IL_02fe: Incompatible stack heights: 0 vs 1
			//IL_030e: Incompatible stack heights: 0 vs 1
			//IL_0314: Incompatible stack heights: 0 vs 1
			//IL_031e: Incompatible stack heights: 0 vs 1
			void* ptr = stackalloc byte[16];
			ClassReader classReader = default(ClassReader);
			_ = ref classReader;
			_ = ((ResolveEventArgs)/*Error near IL_02ea: Stack underflow*/).Name;
			*(ClassReader*)/*Error near IL_02f4: Stack underflow*/ = new ClassReader((string)/*Error near IL_02f4: Stack underflow*/);
			string text2;
			bool flag;
			bool flag2;
			while (true)
			{
				classReader.ReadIterator(isparam: false);
				string text = (string)/*Error near IL_0304: Stack underflow*/;
				_ = Encoding.UTF8;
				((Encoding)/*Error near IL_031e: Stack underflow*/).GetBytes((string)/*Error near IL_031e: Stack underflow*/);
				string b = Convert.ToBase64String((byte[])/*Error near IL_0040: Stack underflow*/);
				string[] array = "e2RiYTA4ZDg4LTkyM2YtNGQ1NS1iY2U4LTNmYWIyNzQwZThjN30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{f0ac8481-2a23-4c93-9d4b-c36e2fae6ec0},e2RiYTA4ZDg4LTkyM2YtNGQ1NS1iY2U4LTNmYWIyNzQwZThjN30=,[z]{f0ac8481-2a23-4c93-9d4b-c36e2fae6ec0}".Split(',');
				text2 = string.Empty;
				flag = false;
				flag2 = false;
				*(int*)ptr = 0;
				while (*(int*)ptr < array.Length - 1)
				{
					if (array[*(int*)ptr] == b)
					{
						text2 = array[*(int*)ptr + 1];
						break;
					}
					*(int*)ptr += 2;
				}
				if (text2.Length != 0 || classReader._MethodReader.Length != 0)
				{
					break;
				}
				b = Convert.ToBase64String(Encoding.UTF8.GetBytes(classReader.m_RequestReader));
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < array.Length - 1)
				{
					if (!(array[*(int*)((byte*)ptr + 4)] == b))
					{
						*(int*)((byte*)ptr + 4) += 2;
						continue;
					}
					goto IL_00ed;
				}
				break;
				IL_00ed:
				if (0 == 0)
				{
					text2 = array[*(int*)((byte*)ptr + 4) + 1];
					break;
				}
			}
			if (text2.Length > 0)
			{
				if (text2[0] == '[')
				{
					*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
					string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
					flag = (text3.IndexOf('z') >= 0);
					flag2 = (text3.IndexOf('t') >= 0);
					text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
				}
				lock (m_BroadcasterReader)
				{
					if (m_BroadcasterReader.ContainsKey(text2))
					{
						return m_BroadcasterReader[text2];
					}
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream != null)
					{
						*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
						byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
						manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
						if (flag)
						{
							array2 = PolicyReader.ComputeIterator(array2);
						}
						Assembly assembly = null;
						if (!flag2)
						{
							try
							{
								assembly = Assembly.Load(array2);
							}
							catch (FileLoadException)
							{
								flag2 = true;
							}
							catch (BadImageFormatException)
							{
								flag2 = true;
							}
						}
						if (flag2)
						{
							try
							{
								string text4 = $"{Path.GetTempPath()}{text2}\\";
								Directory.CreateDirectory(text4);
								string text5 = text4 + classReader.m_RequestReader + ".dll";
								if (!File.Exists(text5))
								{
									FileStream fileStream = File.OpenWrite(text5);
									fileStream.Write(array2, 0, array2.Length);
									fileStream.Close();
									IncludeIterator(text5, null, 4);
									IncludeIterator(text4, null, 4);
								}
								assembly = Assembly.LoadFile(text5);
							}
							catch
							{
							}
						}
						m_BroadcasterReader[text2] = assembly;
						return assembly;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorkerPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WorkerPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_001d: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			new Dictionary<string, Assembly>();
			m_BroadcasterReader = (Dictionary<string, Assembly>)/*Error near IL_0017: Stack underflow*/;
		}
	}
}
