using _0008;
using GDBD.Bridges;
using GDBD.Filter;
using GDBD.Mocks;
using GDBD.Strategies;
using GDBD.Structs;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Workers
{
	[_0008._0012(0)]
	internal sealed class ConnectionComposerWorker : ValPropertyStruct, CreatorIssuer, AttrBroadcasterFilter
	{
		private readonly XmlDocument tagIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionComposerWorker(XmlDocument value)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(value);
			tagIssuer = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new CreatorIssuer _0001(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateComment(spec));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateTextNode(param));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0003(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateCDataSection(setup));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0004(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateWhitespace(key));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0005(string config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateSignificantWhitespace(config));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string config, string b, string field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new BridgeIssuer(tagIssuer.CreateXmlDeclaration(config, b, field));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string var1, string result, string template, string reference2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new InvocationPropertyStruct(tagIssuer.CreateDocumentType(var1, result, template, null));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string info, string visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ValPropertyStruct(tagIssuer.CreateProcessingInstruction(info, visitor));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new InfoRequestStrategy _0001(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ServiceIssuerMock(tagIssuer.CreateElement(setup));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRequestStrategy _0001(string res, string caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ServiceIssuerMock(tagIssuer.CreateElement(res, caller));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string reference, string token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValPropertyStruct valPropertyStruct = new ValPropertyStruct(tagIssuer.CreateAttribute(reference));
			valPropertyStruct._0001(token);
			return valPropertyStruct;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string info, string ivk, string field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValPropertyStruct valPropertyStruct = new ValPropertyStruct(tagIssuer.CreateAttribute(info, ivk));
			valPropertyStruct._0001(field);
			return valPropertyStruct;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new InfoRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (tagIssuer.DocumentElement == null)
			{
				return null;
			}
			return new ServiceIssuerMock(tagIssuer.DocumentElement);
		}
	}
}
