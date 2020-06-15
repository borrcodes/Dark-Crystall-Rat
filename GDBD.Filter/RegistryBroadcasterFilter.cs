using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GDBD.Filter
{
	[_0008._0012(0)]
	internal static class RegistryBroadcasterFilter
	{
		internal static readonly bool[] _ObserverTest;

		internal static readonly bool[] m_DescriptorTest;

		internal static readonly bool[] _ProducerTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RegistryBroadcasterFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ObserverTest = new bool[128];
			m_DescriptorTest = new bool[128];
			_ProducerTest = new bool[128];
			IList<char> list = new List<char>
			{
				'\n',
				'\r',
				'\t',
				'\\',
				'\f',
				'\b'
			};
			for (int i = 0; i < 32; i++)
			{
				list.Add((char)i);
			}
			foreach (char item in list.Union(new char[1]
			{
				'\''
			}))
			{
				_ObserverTest[item] = true;
			}
			foreach (char item2 in list.Union(new char[1]
			{
				'"'
			}))
			{
				m_DescriptorTest[item2] = true;
			}
			foreach (char item3 in list.Union(new char[5]
			{
				'"',
				'\'',
				'<',
				'>',
				'&'
			}))
			{
				_ProducerTest[item3] = true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool[] ComputeIssuer(GraphGroupStyle def, char visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == (GraphGroupStyle)2)
			{
				return _ProducerTest;
			}
			if (visitor == '"')
			{
				return m_DescriptorTest;
			}
			return _ObserverTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DestroyIssuer(string reference, bool[] token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference == null)
			{
				return false;
			}
			foreach (char c in reference)
			{
				if (c >= token.Length || token[c])
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetIssuer(TextWriter reference, string col, char control, bool wantord2, bool[] ord3, GraphGroupStyle attr4, GDBD.Workers.WrapperComposerWorker<char> instance5, ref char[] result6)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (wantord2)
			{
				reference.Write(control);
			}
			if (!SetterTest.StartReader(col))
			{
				int num = RemoveIssuer(col, ord3, attr4);
				if (num == -1)
				{
					reference.Write(col);
				}
				else
				{
					if (num != 0)
					{
						if (result6 == null || result6.Length < num)
						{
							result6 = ValueFilterResolver.SearchIssuer(instance5, num, result6);
						}
						col.CopyTo(0, result6, 0, num);
						reference.Write(result6, 0, num);
					}
					int num2;
					for (int i = num; i < col.Length; i++)
					{
						char c = col[i];
						if (c < ord3.Length && !ord3[c])
						{
							continue;
						}
						string text;
						switch (c)
						{
						case '\t':
							text = "\\t";
							break;
						case '\n':
							text = "\\n";
							break;
						case '\r':
							text = "\\r";
							break;
						case '\f':
							text = "\\f";
							break;
						case '\b':
							text = "\\b";
							break;
						case '\\':
							text = "\\\\";
							break;
						case '\u0085':
							text = "\\u0085";
							break;
						case '\u2028':
							text = "\\u2028";
							break;
						case '\u2029':
							text = "\\u2029";
							break;
						default:
							if (c < ord3.Length || attr4 == (GraphGroupStyle)1)
							{
								if (c == '\'' && attr4 != (GraphGroupStyle)2)
								{
									text = "\\'";
									break;
								}
								if (c == '"' && attr4 != (GraphGroupStyle)2)
								{
									text = "\\\"";
									break;
								}
								if (result6 == null || result6.Length < 6)
								{
									result6 = ValueFilterResolver.SearchIssuer(instance5, 6, result6);
								}
								SetterTest.PrintReader(c, result6);
								text = "!";
							}
							else
							{
								text = null;
							}
							break;
						}
						if (text == null)
						{
							continue;
						}
						bool flag = string.Equals(text, "!", StringComparison.Ordinal);
						if (i > num)
						{
							num2 = i - num + (flag ? 6 : 0);
							int num3 = flag ? 6 : 0;
							if (result6 == null || result6.Length < num2)
							{
								char[] array = ValueFilterResolver.RegisterIssuer(instance5, num2);
								if (flag)
								{
									Array.Copy(result6, array, 6);
								}
								ValueFilterResolver.RestartIssuer(instance5, result6);
								result6 = array;
							}
							col.CopyTo(num, result6, num3, num2 - num3);
							reference.Write(result6, num3, num2 - num3);
						}
						num = i + 1;
						if (!flag)
						{
							reference.Write(text);
						}
						else
						{
							reference.Write(result6, 0, 6);
						}
					}
					num2 = col.Length - num;
					if (num2 > 0)
					{
						if (result6 == null || result6.Length < num2)
						{
							result6 = ValueFilterResolver.SearchIssuer(instance5, num2, result6);
						}
						col.CopyTo(num, result6, 0, num2);
						reference.Write(result6, 0, num2);
					}
				}
			}
			if (wantord2)
			{
				reference.Write(control);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RateIssuer(string var1, char cfg, bool appendtemplate, GraphGroupStyle vis2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool[] ord = ComputeIssuer(vis2, cfg);
			using (StringWriter stringWriter = SetterTest.InvokeReader(var1?.Length ?? 16))
			{
				char[] result = null;
				SetIssuer(stringWriter, var1, cfg, appendtemplate, ord, vis2, null, ref result);
				return stringWriter.ToString();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int RemoveIssuer(string v, bool[] vis, GraphGroupStyle consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			for (int i = 0; i != v.Length; i++)
			{
				char c = v[i];
				if (c < vis.Length)
				{
					if (vis[c])
					{
						return i;
					}
					continue;
				}
				if (consumer == (GraphGroupStyle)1)
				{
					return i;
				}
				if (c == '\u0085' || c == '\u2028' || c == '\u2029')
				{
					return i;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool PostIssuer(TagTestItem res, out DateTime reg, [ConsumerBroadcasterDispatcher(false)] [_0008._0012(2)] out string _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			reg = default(DateTime);
			_0004 = null;
			if (!ChangeIssuer(res, out long? counter, out _0004) || !counter.HasValue)
			{
				_0004 = (_0004 ?? "Date constructor has no arguments.");
				return false;
			}
			if (!ChangeIssuer(res, out long? counter2, out _0004))
			{
				return false;
			}
			if (counter2.HasValue)
			{
				List<long> list = new List<long>
				{
					counter.Value,
					counter2.Value
				};
				while (true)
				{
					if (!ChangeIssuer(res, out long? counter3, out _0004))
					{
						return false;
					}
					if (!counter3.HasValue)
					{
						break;
					}
					list.Add(counter3.Value);
				}
				if (list.Count > 7)
				{
					_0004 = "Unexpected number of arguments when reading date constructor.";
					return false;
				}
				while (list.Count < 7)
				{
					list.Add(0L);
				}
				reg = new DateTime((int)list[0], (int)list[1] + 1, (int)((list[2] == 0L) ? 1 : list[2]), (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
			}
			else
			{
				reg = DescriptorIteratorMapping.SearchProperty(counter.Value);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ChangeIssuer(TagTestItem i, out long? counter, [_0008._0012(2)] out string _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			counter = null;
			_0004 = null;
			if (!i._0001())
			{
				_0004 = "Unexpected end when reading date constructor.";
				return false;
			}
			if (i._0001() == WatcherComposer.EndConstructor)
			{
				return true;
			}
			if (i._0001() != WatcherComposer.Integer)
			{
				_0004 = "Unexpected token when reading date constructor. Expected Integer, got " + i._0001();
				return false;
			}
			counter = (long)i._0001();
			return true;
		}
	}
}
