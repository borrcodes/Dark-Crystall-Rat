using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal sealed class TokenIssuer : BroadcasterError
	{
		internal static readonly List<CreatorIssuer> dispatcherIssuer;

		[_0008._0012(2)]
		[CompilerGenerated]
		private string _AccountIssuer;

		[CompilerGenerated]
		private bool singletonIssuer;

		[CompilerGenerated]
		private bool m_ModelIssuer;

		[CompilerGenerated]
		private bool messageIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _AccountIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return singletonIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ModelIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return messageIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher i, object visitor, PrototypeError third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (visitor == null)
			{
				i._0008();
				return;
			}
			CreatorIssuer creatorIssuer = CountRequest(visitor);
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
			AssetRequest(creatorIssuer, xmlNamespaceManager);
			if (!_0004())
			{
				i._0002();
			}
			InitRequest(i, creatorIssuer, xmlNamespaceManager, !_0004());
			if (!_0004())
			{
				i._0011();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private CreatorIssuer CountRequest(object asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			XObject xObject = asset as XObject;
			if (xObject != null)
			{
				return ItemReaderMapper.InvokeRequest(xObject);
			}
			XmlNode xmlNode = asset as XmlNode;
			if (xmlNode != null)
			{
				return ValPropertyStruct.ConcatRequest(xmlNode);
			}
			throw new ArgumentException("Value must be an XML object.", "value");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AssetRequest(CreatorIssuer var1, XmlNamespaceManager cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<CreatorIssuer> list = null;
			CreatorIssuer creatorIssuer = var1;
			while ((creatorIssuer = creatorIssuer._0001()) != null)
			{
				if (creatorIssuer._0001() == XmlNodeType.Element)
				{
					if (list == null)
					{
						list = new List<CreatorIssuer>();
					}
					list.Add(creatorIssuer);
				}
			}
			if (list != null)
			{
				list.Reverse();
				foreach (CreatorIssuer item in list)
				{
					cust.PushScope();
					foreach (CreatorIssuer item2 in item._0002())
					{
						if (item2._0003() == "http://www.w3.org/2000/xmlns/" && item2._0001() != "xmlns")
						{
							cust.AddNamespace(item2._0001(), item2._0002());
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string CustomizeRequest(CreatorIssuer key, XmlNamespaceManager cont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = (key._0003() == null || (key._0001() == "xmlns" && key._0003() == "http://www.w3.org/2000/xmlns/")) ? null : cont.LookupPrefix(key._0003());
			if (!SetterTest.StartReader(text))
			{
				return text + ":" + XmlConvert.DecodeName(key._0001());
			}
			return XmlConvert.DecodeName(key._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string QueryRequest(CreatorIssuer first, XmlNamespaceManager connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (first._0001())
			{
			case XmlNodeType.Attribute:
				if (first._0003() == "http://james.newtonking.com/projects/json")
				{
					return "$" + first._0001();
				}
				return "@" + CustomizeRequest(first, connection);
			case XmlNodeType.CDATA:
				return "#cdata-section";
			case XmlNodeType.Comment:
				return "#comment";
			case XmlNodeType.Element:
				if (first._0003() == "http://james.newtonking.com/projects/json")
				{
					return "$" + first._0001();
				}
				return CustomizeRequest(first, connection);
			case XmlNodeType.ProcessingInstruction:
				return "?" + CustomizeRequest(first, connection);
			case XmlNodeType.DocumentType:
				return "!" + CustomizeRequest(first, connection);
			case XmlNodeType.XmlDeclaration:
				return "?xml";
			case XmlNodeType.SignificantWhitespace:
				return "#significant-whitespace";
			case XmlNodeType.Text:
				return "#text";
			case XmlNodeType.Whitespace:
				return "#whitespace";
			default:
				throw new StrategyError("Unexpected XmlNodeType when getting node name: " + first._0001());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CancelRequest(CreatorIssuer spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			foreach (CreatorIssuer item in spec._0002())
			{
				if (item._0001() == "Array" && item._0003() == "http://james.newtonking.com/projects/json")
				{
					return XmlConvert.ToBoolean(item._0002());
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExcludeRequest(RecordClassDispatcher i, CreatorIssuer vis, XmlNamespaceManager third, bool hasattr2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (vis._0001().Count)
			{
			case 0:
				return;
			case 1:
			{
				string ident = QueryRequest(vis._0001()[0], third);
				SetupRequest(i, third, hasattr2, vis._0001(), ident);
				return;
			}
			}
			Dictionary<string, object> dictionary = null;
			string text = null;
			for (int j = 0; j < vis._0001().Count; j++)
			{
				CreatorIssuer creatorIssuer = vis._0001()[j];
				string text2 = QueryRequest(creatorIssuer, third);
				object value;
				if (dictionary == null)
				{
					if (text == null)
					{
						text = text2;
						continue;
					}
					if (text2 == text)
					{
						continue;
					}
					dictionary = new Dictionary<string, object>();
					if (j > 1)
					{
						List<CreatorIssuer> list = new List<CreatorIssuer>(j);
						for (int k = 0; k < j; k++)
						{
							list.Add(vis._0001()[k]);
						}
						dictionary.Add(text, list);
					}
					else
					{
						dictionary.Add(text, vis._0001()[0]);
					}
					dictionary.Add(text2, creatorIssuer);
				}
				else if (!dictionary.TryGetValue(text2, out value))
				{
					dictionary.Add(text2, creatorIssuer);
				}
				else
				{
					List<CreatorIssuer> list2 = value as List<CreatorIssuer>;
					if (list2 == null)
					{
						list2 = (List<CreatorIssuer>)(dictionary[text2] = new List<CreatorIssuer>
						{
							(CreatorIssuer)value
						});
					}
					list2.Add(creatorIssuer);
				}
			}
			if (dictionary == null)
			{
				SetupRequest(i, third, hasattr2, vis._0001(), text);
			}
			else
			{
				foreach (KeyValuePair<string, object> item in dictionary)
				{
					List<CreatorIssuer> list3 = item.Value as List<CreatorIssuer>;
					if (list3 != null)
					{
						SetupRequest(i, third, hasattr2, list3, item.Key);
					}
					else
					{
						ManageRequest(i, third, hasattr2, (CreatorIssuer)item.Value, item.Key);
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupRequest(RecordClassDispatcher reference, XmlNamespaceManager cont, bool addcomp, List<CreatorIssuer> vis2, string ident3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (vis2.Count == 1 && !CancelRequest(vis2[0]))
			{
				InitRequest(reference, vis2[0], cont, addcomp);
				return;
			}
			if (addcomp)
			{
				reference._0002(ident3);
			}
			reference._0003();
			for (int i = 0; i < vis2.Count; i++)
			{
				InitRequest(reference, vis2[i], cont, isresult2: false);
			}
			reference._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ManageRequest(RecordClassDispatcher task, XmlNamespaceManager result, bool skipres, CreatorIssuer cust2, string instance3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelRequest(cust2))
			{
				InitRequest(task, cust2, result, skipres);
				return;
			}
			if (skipres)
			{
				task._0002(instance3);
			}
			task._0003();
			InitRequest(task, cust2, result, isresult2: false);
			task._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitRequest(RecordClassDispatcher first, CreatorIssuer second, XmlNamespaceManager template, bool isresult2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (second._0001())
			{
			case XmlNodeType.Document:
			case XmlNodeType.DocumentFragment:
				ExcludeRequest(first, second, template, isresult2);
				break;
			case XmlNodeType.Element:
				if (CancelRequest(second) && DefineRequest(second) && second._0001().Count > 0)
				{
					ExcludeRequest(first, second, template, hasattr2: false);
					break;
				}
				template.PushScope();
				foreach (CreatorIssuer item in second._0002())
				{
					if (item._0003() == "http://www.w3.org/2000/xmlns/")
					{
						string prefix = (item._0001() != "xmlns") ? XmlConvert.DecodeName(item._0001()) : string.Empty;
						string text = item._0002();
						if (text == null)
						{
							throw new StrategyError("Namespace attribute must have a value.");
						}
						template.AddNamespace(prefix, text);
					}
				}
				if (isresult2)
				{
					first._0002(QueryRequest(second, template));
				}
				if (!ResolveIterator(second._0002()) && second._0001().Count == 1 && second._0001()[0]._0001() == XmlNodeType.Text)
				{
					first._0004(second._0001()[0]._0002());
				}
				else if (second._0001().Count == 0 && second._0002().Count == 0)
				{
					if (((InfoRequestStrategy)second)._0001())
					{
						first._0008();
					}
					else
					{
						first._0004(string.Empty);
					}
				}
				else
				{
					first._0002();
					for (int i = 0; i < second._0002().Count; i++)
					{
						InitRequest(first, second._0002()[i], template, isresult2: true);
					}
					ExcludeRequest(first, second, template, hasattr2: true);
					first._0011();
				}
				template.PopScope();
				break;
			case XmlNodeType.Comment:
				if (isresult2)
				{
					first._0005(second._0002());
				}
				break;
			case XmlNodeType.Attribute:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				if ((!(second._0003() == "http://www.w3.org/2000/xmlns/") || !(second._0002() == "http://james.newtonking.com/projects/json")) && (!(second._0003() == "http://james.newtonking.com/projects/json") || !(second._0001() == "Array")))
				{
					if (isresult2)
					{
						first._0002(QueryRequest(second, template));
					}
					first._0004(second._0002());
				}
				break;
			case XmlNodeType.XmlDeclaration:
			{
				DicEventConsumer dicEventConsumer = (DicEventConsumer)second;
				first._0002(QueryRequest(second, template));
				first._0002();
				if (!SetterTest.StartReader(dicEventConsumer._0004()))
				{
					first._0002("@version");
					first._0004(dicEventConsumer._0004());
				}
				if (!SetterTest.StartReader(dicEventConsumer._0005()))
				{
					first._0002("@encoding");
					first._0004(dicEventConsumer._0005());
				}
				if (!SetterTest.StartReader(dicEventConsumer._0006()))
				{
					first._0002("@standalone");
					first._0004(dicEventConsumer._0006());
				}
				first._0011();
				break;
			}
			case XmlNodeType.DocumentType:
			{
				IndexerIssuer indexerIssuer = (IndexerIssuer)second;
				first._0002(QueryRequest(second, template));
				first._0002();
				if (!SetterTest.StartReader(indexerIssuer._0004()))
				{
					first._0002("@name");
					first._0004(indexerIssuer._0004());
				}
				if (!SetterTest.StartReader(indexerIssuer._0006()))
				{
					first._0002("@public");
					first._0004(indexerIssuer._0006());
				}
				if (!SetterTest.StartReader(indexerIssuer._0005()))
				{
					first._0002("@system");
					first._0004(indexerIssuer._0005());
				}
				if (!SetterTest.StartReader(indexerIssuer._0007()))
				{
					first._0002("@internalSubset");
					first._0004(indexerIssuer._0007());
				}
				first._0011();
				break;
			}
			default:
				throw new StrategyError("Unexpected XmlNodeType when serializing nodes: " + second._0001());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool DefineRequest(CreatorIssuer init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			foreach (CreatorIssuer item in init._0001())
			{
				if (item._0001() != init._0001())
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem param, Type reg, object serv, PrototypeError first2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (param._0001())
			{
			case WatcherComposer.Null:
				return null;
			default:
				throw StrategyError.PatchComposer(param, "XmlNodeConverter can only convert JSON that begins with an object.");
			case WatcherComposer.StartObject:
			{
				XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
				AttrBroadcasterFilter attrBroadcasterFilter = null;
				CreatorIssuer creatorIssuer = null;
				if (typeof(XObject).IsAssignableFrom(reg))
				{
					if (reg != typeof(XContainer) && reg != typeof(XDocument) && reg != typeof(XElement) && reg != typeof(XNode) && reg != typeof(XObject))
					{
						throw StrategyError.PatchComposer(param, "XmlNodeConverter only supports deserializing XDocument, XElement, XContainer, XNode or XObject.");
					}
					attrBroadcasterFilter = new AuthenticationComposerPool(new XDocument());
					creatorIssuer = attrBroadcasterFilter;
				}
				if (typeof(XmlNode).IsAssignableFrom(reg))
				{
					if (reg != typeof(XmlDocument) && reg != typeof(XmlElement) && reg != typeof(XmlNode))
					{
						throw StrategyError.PatchComposer(param, "XmlNodeConverter only supports deserializing XmlDocument, XmlElement or XmlNode.");
					}
					attrBroadcasterFilter = new ConnectionComposerWorker(new XmlDocument
					{
						XmlResolver = null
					});
					creatorIssuer = attrBroadcasterFilter;
				}
				if (attrBroadcasterFilter == null || creatorIssuer == null)
				{
					throw StrategyError.PatchComposer(param, "Unexpected type when converting XML: " + reg);
				}
				if (!SetterTest.StartReader(_0001()))
				{
					SortRequest(param, attrBroadcasterFilter, creatorIssuer, _0001(), xmlNamespaceManager);
				}
				else
				{
					param.SortError();
					ValidateIterator(param, attrBroadcasterFilter, xmlNamespaceManager, creatorIssuer);
				}
				if (reg == typeof(XElement))
				{
					XElement obj = (XElement)((CreatorIssuer)attrBroadcasterFilter._0001())._0001();
					obj.Remove();
					return obj;
				}
				if (reg == typeof(XmlElement))
				{
					return ((CreatorIssuer)attrBroadcasterFilter._0001())._0001();
				}
				return ((CreatorIssuer)attrBroadcasterFilter)._0001();
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CollectRequest(TagTestItem def, AttrBroadcasterFilter cust, XmlNamespaceManager consumer, string reg2, CreatorIssuer second3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_0005())
			{
				switch (reg2)
				{
				case "#text":
					second3._0001(cust._0002(WriteRequest(def)));
					return;
				case "#cdata-section":
					second3._0001(cust._0003(WriteRequest(def)));
					return;
				case "#whitespace":
					second3._0001(cust._0004(WriteRequest(def)));
					return;
				case "#significant-whitespace":
					second3._0001(cust._0005(WriteRequest(def)));
					return;
				}
				if (!SetterTest.StartReader(reg2) && reg2[0] == '?')
				{
					VerifyIterator(def, cust, second3, reg2);
					return;
				}
				if (string.Equals(reg2, "!DOCTYPE", StringComparison.OrdinalIgnoreCase))
				{
					PatchIterator(def, cust, second3);
					return;
				}
			}
			if (def._0001() == WatcherComposer.StartArray)
			{
				RevertRequest(def, cust, reg2, second3, consumer);
			}
			else
			{
				SortRequest(def, cust, second3, reg2, consumer);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SortRequest(TagTestItem spec, AttrBroadcasterFilter connection, CreatorIssuer template, string pred2, XmlNamespaceManager connection3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(pred2))
			{
				throw StrategyError.PatchComposer(spec, "XmlNodeConverter cannot convert JSON with an empty property name to XML.");
			}
			Dictionary<string, string> token = null;
			string asset = null;
			if (!_0005())
			{
				token = (CheckIterator(spec) ? DisableIterator(spec, connection3) : null);
				asset = CustomerListAnnotation.CountIssuer(pred2);
				if (pred2.ExcludeReader('@'))
				{
					string text = pred2.Substring(1);
					string reference = CustomerListAnnotation.CountIssuer(text);
					PublishRequest(spec, connection, template, pred2, text, connection3, reference);
					return;
				}
				if (pred2.ExcludeReader('$'))
				{
					switch (pred2)
					{
					case "$values":
						pred2 = pred2.Substring(1);
						asset = connection3.LookupPrefix("http://james.newtonking.com/projects/json");
						CallRequest(spec, connection, template, pred2, connection3, asset, token);
						return;
					case "$id":
					case "$ref":
					case "$type":
					case "$value":
					{
						string v = pred2.Substring(1);
						string reference2 = connection3.LookupPrefix("http://james.newtonking.com/projects/json");
						PublishRequest(spec, connection, template, pred2, v, connection3, reference2);
						return;
					}
					}
				}
			}
			else if (CheckIterator(spec))
			{
				spec.SortError();
			}
			CallRequest(spec, connection, template, pred2, connection3, asset, token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallRequest(TagTestItem def, AttrBroadcasterFilter attr, CreatorIssuer state, string pred2, XmlNamespaceManager reference3, string asset4, Dictionary<string, string> token5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InfoRequestStrategy infoRequestStrategy = FindIterator(pred2, attr, asset4, reference3);
			state._0001(infoRequestStrategy);
			if (token5 != null)
			{
				foreach (KeyValuePair<string, string> item in token5)
				{
					string text = XmlConvert.EncodeName(item.Key);
					string text2 = CustomerListAnnotation.CountIssuer(item.Key);
					CreatorIssuer key = (!SetterTest.StartReader(text2)) ? attr._0002(text, reference3.LookupNamespace(text2) ?? string.Empty, item.Value) : attr._0002(text, item.Value);
					infoRequestStrategy._0001(key);
				}
			}
			switch (def._0001())
			{
			case WatcherComposer.Null:
				break;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
			{
				string text3 = WriteRequest(def);
				if (text3 != null)
				{
					((CreatorIssuer)infoRequestStrategy)._0001(attr._0002(text3));
				}
				break;
			}
			case WatcherComposer.EndObject:
				reference3.RemoveNamespace(string.Empty, reference3.DefaultNamespace);
				break;
			default:
				reference3.PushScope();
				ValidateIterator(def, attr, reference3, infoRequestStrategy);
				reference3.PopScope();
				reference3.RemoveNamespace(string.Empty, reference3.DefaultNamespace);
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void PublishRequest(TagTestItem def, AttrBroadcasterFilter cont, CreatorIssuer consumer, string res2, string v3, XmlNamespaceManager value4, string reference5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (consumer._0001() == XmlNodeType.Document)
			{
				throw StrategyError.PatchComposer(def, "JSON root object has property '{0}' that will be converted to an attribute. A root object cannot have any attribute properties. Consider specifying a DeserializeRootElementName.".ListReader(CultureInfo.InvariantCulture, res2));
			}
			string text = XmlConvert.EncodeName(v3);
			string text2 = WriteRequest(def);
			CreatorIssuer key = (!SetterTest.StartReader(reference5)) ? cont._0002(text, value4.LookupNamespace(reference5), text2) : cont._0002(text, text2);
			((InfoRequestStrategy)consumer)._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string WriteRequest(TagTestItem init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (init._0001())
			{
			case WatcherComposer.String:
				return init._0001()?.ToString();
			case WatcherComposer.Integer:
			{
				object obj = init._0001();
				if (obj is BigInteger)
				{
					return ((BigInteger)obj).ToString(CultureInfo.InvariantCulture);
				}
				return XmlConvert.ToString(Convert.ToInt64(init._0001(), CultureInfo.InvariantCulture));
			}
			case WatcherComposer.Float:
			{
				object obj = init._0001();
				if (obj is decimal)
				{
					decimal value3 = (decimal)obj;
					return XmlConvert.ToString(value3);
				}
				obj = init._0001();
				if (obj is float)
				{
					float value4 = (float)obj;
					return XmlConvert.ToString(value4);
				}
				return XmlConvert.ToString(Convert.ToDouble(init._0001(), CultureInfo.InvariantCulture));
			}
			case WatcherComposer.Boolean:
				return XmlConvert.ToString(Convert.ToBoolean(init._0001(), CultureInfo.InvariantCulture));
			case WatcherComposer.Date:
			{
				object obj = init._0001();
				if (obj is DateTimeOffset)
				{
					DateTimeOffset value = (DateTimeOffset)obj;
					return XmlConvert.ToString(value);
				}
				DateTime value2 = Convert.ToDateTime(init._0001(), CultureInfo.InvariantCulture);
				return XmlConvert.ToString(value2, DescriptorIteratorMapping.UpdateProperty(value2.Kind));
			}
			case WatcherComposer.Bytes:
				return Convert.ToBase64String((byte[])init._0001());
			case WatcherComposer.Null:
				return null;
			default:
				throw StrategyError.PatchComposer(init, "Cannot get an XML string value from token type '{0}'.".ListReader(CultureInfo.InvariantCulture, init._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevertRequest(TagTestItem instance, AttrBroadcasterFilter selection, string template, CreatorIssuer value2, XmlNamespaceManager item3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string dir = CustomerListAnnotation.CountIssuer(template);
			InfoRequestStrategy infoRequestStrategy = FindIterator(template, selection, dir, item3);
			value2._0001(infoRequestStrategy);
			int num = 0;
			while (instance._0001() && instance._0001() != WatcherComposer.EndArray)
			{
				CollectRequest(instance, selection, item3, template, infoRequestStrategy);
				num++;
			}
			if (_0003())
			{
				LoginIterator(infoRequestStrategy, selection);
			}
			if (num == 1 && _0003())
			{
				foreach (CreatorIssuer item4 in ((CreatorIssuer)infoRequestStrategy)._0001())
				{
					InfoRequestStrategy infoRequestStrategy2 = item4 as InfoRequestStrategy;
					if (infoRequestStrategy2 != null && ((CreatorIssuer)infoRequestStrategy2)._0001() == template)
					{
						LoginIterator(infoRequestStrategy2, selection);
						break;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoginIterator(InfoRequestStrategy var1, AttrBroadcasterFilter token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			var1._0001(token._0002("json:Array", "http://james.newtonking.com/projects/json", "true"));
			if (var1 is SerializerDicCandidate && var1._0001("http://james.newtonking.com/projects/json") == null)
			{
				var1._0001(token._0002("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckIterator(TagTestItem reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (reference._0001())
			{
			case WatcherComposer.StartConstructor:
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Null:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
				return false;
			default:
				return true;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Dictionary<string, string> DisableIterator(TagTestItem v, XmlNamespaceManager token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Dictionary<string, string> dictionary = null;
			bool flag = false;
			while (!flag && v._0001())
			{
				switch (v._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string text = v._0001().ToString();
					if (!SetterTest.StartReader(text))
					{
						switch (text[0])
						{
						case '@':
						{
							if (dictionary == null)
							{
								dictionary = new Dictionary<string, string>();
							}
							text = text.Substring(1);
							v.SortError();
							string value = WriteRequest(v);
							dictionary.Add(text, value);
							if (OrderIterator(text, out string _0003))
							{
								token.AddNamespace(_0003, value);
							}
							break;
						}
						case '$':
							switch (text)
							{
							case "$values":
							case "$id":
							case "$ref":
							case "$type":
							case "$value":
							{
								string text2 = token.LookupPrefix("http://james.newtonking.com/projects/json");
								if (text2 == null)
								{
									if (dictionary == null)
									{
										dictionary = new Dictionary<string, string>();
									}
									int? num = null;
									int? num2;
									while (true)
									{
										num2 = num;
										if (token.LookupNamespace("json" + num2) == null)
										{
											break;
										}
										num = num.GetValueOrDefault() + 1;
									}
									num2 = num;
									text2 = "json" + num2;
									dictionary.Add("xmlns:" + text2, "http://james.newtonking.com/projects/json");
									token.AddNamespace(text2, "http://james.newtonking.com/projects/json");
								}
								if (text == "$values")
								{
									flag = true;
									break;
								}
								text = text.Substring(1);
								v.SortError();
								if (!RulesClientBridge.StartIssuer(v._0001()))
								{
									throw StrategyError.PatchComposer(v, "Unexpected JsonToken: " + v._0001());
								}
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								string value = v._0001()?.ToString();
								dictionary.Add(text2 + ":" + text, value);
								break;
							}
							default:
								flag = true;
								break;
							}
							break;
						default:
							flag = true;
							break;
						}
					}
					else
					{
						flag = true;
					}
					break;
				}
				case WatcherComposer.Comment:
				case WatcherComposer.EndObject:
					flag = true;
					break;
				default:
					throw StrategyError.PatchComposer(v, "Unexpected JsonToken: " + v._0001());
				}
			}
			return dictionary;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VerifyIterator(TagTestItem setup, AttrBroadcasterFilter visitor, CreatorIssuer temp, string setup2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup2 == "?xml")
			{
				string instance = null;
				string caller = null;
				string tag = null;
				while (setup._0001() && setup._0001() != WatcherComposer.EndObject)
				{
					switch (setup._0001()?.ToString())
					{
					case "@version":
						setup.SortError();
						instance = WriteRequest(setup);
						break;
					case "@encoding":
						setup.SortError();
						caller = WriteRequest(setup);
						break;
					case "@standalone":
						setup.SortError();
						tag = WriteRequest(setup);
						break;
					default:
						throw StrategyError.PatchComposer(setup, "Unexpected property name encountered while deserializing XmlDeclaration: " + setup._0001());
					}
				}
				CreatorIssuer asset = visitor._0001(instance, caller, tag);
				temp._0001(asset);
			}
			else
			{
				CreatorIssuer asset2 = visitor._0001(setup2.Substring(1), WriteRequest(setup));
				temp._0001(asset2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PatchIterator(TagTestItem setup, AttrBroadcasterFilter selection, CreatorIssuer util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string spec = null;
			string caller = null;
			string state = null;
			string config = null;
			while (setup._0001() && setup._0001() != WatcherComposer.EndObject)
			{
				switch (setup._0001()?.ToString())
				{
				case "@name":
					setup.SortError();
					spec = WriteRequest(setup);
					break;
				case "@public":
					setup.SortError();
					caller = WriteRequest(setup);
					break;
				case "@system":
					setup.SortError();
					state = WriteRequest(setup);
					break;
				case "@internalSubset":
					setup.SortError();
					config = WriteRequest(setup);
					break;
				default:
					throw StrategyError.PatchComposer(setup, "Unexpected property name encountered while deserializing XmlDeclaration: " + setup._0001());
				}
			}
			CreatorIssuer asset = selection._0001(spec, caller, state, config);
			util._0001(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InfoRequestStrategy FindIterator(string setup, AttrBroadcasterFilter cust, string dir, XmlNamespaceManager pred2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = _0005() ? XmlConvert.EncodeLocalName(setup) : XmlConvert.EncodeName(setup);
			string text2 = SetterTest.StartReader(dir) ? pred2.DefaultNamespace : pred2.LookupNamespace(dir);
			if (SetterTest.StartReader(text2))
			{
				return cust._0001(text);
			}
			return cust._0001(text, text2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ValidateIterator(TagTestItem def, AttrBroadcasterFilter caller, XmlNamespaceManager tag, CreatorIssuer ord2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			do
			{
				switch (def._0001())
				{
				case WatcherComposer.EndObject:
				case WatcherComposer.EndArray:
					return;
				case WatcherComposer.PropertyName:
				{
					if (ord2._0001() == XmlNodeType.Document && caller._0001() != null)
					{
						throw StrategyError.PatchComposer(def, "JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifying a DeserializeRootElementName.");
					}
					string text = def._0001().ToString();
					def.SortError();
					if (def._0001() == WatcherComposer.StartArray)
					{
						int num = 0;
						while (def._0001() && def._0001() != WatcherComposer.EndArray)
						{
							CollectRequest(def, caller, tag, text, ord2);
							num++;
						}
						if (num == 1 && this._0003())
						{
							CustomerListAnnotation.CustomizeIssuer(text, out string _0003, out string role);
							string b = SetterTest.StartReader(_0003) ? tag.DefaultNamespace : tag.LookupNamespace(_0003);
							foreach (CreatorIssuer item in ord2._0001())
							{
								InfoRequestStrategy infoRequestStrategy = item as InfoRequestStrategy;
								if (infoRequestStrategy != null && ((CreatorIssuer)infoRequestStrategy)._0001() == role && infoRequestStrategy._0003() == b)
								{
									LoginIterator(infoRequestStrategy, caller);
									break;
								}
							}
						}
					}
					else
					{
						CollectRequest(def, caller, tag, text, ord2);
					}
					break;
				}
				case WatcherComposer.StartConstructor:
				{
					string reg = def._0001().ToString();
					while (def._0001() && def._0001() != WatcherComposer.EndConstructor)
					{
						CollectRequest(def, caller, tag, reg, ord2);
					}
					break;
				}
				case WatcherComposer.Comment:
					ord2._0001(caller._0001((string)def._0001()));
					break;
				default:
					throw StrategyError.PatchComposer(def, "Unexpected JsonToken when deserializing node: " + def._0001());
				}
			}
			while (def._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool OrderIterator(string info, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(2)] out string _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info.StartsWith("xmlns", StringComparison.Ordinal))
			{
				if (info.Length == 5)
				{
					_0003 = string.Empty;
					return true;
				}
				if (info[5] == ':')
				{
					_0003 = info.Substring(6, info.Length - 6);
					return true;
				}
			}
			_0003 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ResolveIterator(List<CreatorIssuer> key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			foreach (CreatorIssuer item in key)
			{
				if (!(item._0003() == "http://james.newtonking.com/projects/json") && (!(item._0003() == "http://www.w3.org/2000/xmlns/") || !(item._0002() == "http://james.newtonking.com/projects/json")))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v.ResolveClient("System.Xml.Linq.XObject", createhelper: false))
			{
				return FillIterator(v);
			}
			if (v.ResolveClient("System.Xml.XmlNode", createhelper: false))
			{
				return RunIterator(v);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool FillIterator(Type def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(XObject).IsAssignableFrom(def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool RunIterator(Type setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(XmlNode).IsAssignableFrom(setup);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TokenIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			dispatcherIssuer = new List<CreatorIssuer>();
		}
	}
}
