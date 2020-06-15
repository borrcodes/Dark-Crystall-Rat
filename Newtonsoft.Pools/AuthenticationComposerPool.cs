using _0008;
using GDBD.Filter;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Resolver;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Pools
{
	[_0008._0012(0)]
	internal sealed class AuthenticationComposerPool : ItemReaderMapper, CreatorIssuer, AttrBroadcasterFilter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XDocument _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XDocument)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AuthenticationComposerPool(XDocument ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(ident);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<CreatorIssuer> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<CreatorIssuer> list = base._0001();
			if (this._0001().Declaration != null && (list.Count == 0 || list[0]._0001() != XmlNodeType.XmlDeclaration))
			{
				list.Insert(0, new MethodComposerPool(this._0001().Declaration));
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0002())
			{
				return true;
			}
			return this._0001().Declaration != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new FieldIssuer(new XComment(value));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new FieldIssuer(new XText(v));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0003(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new FieldIssuer(new XCData(key));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0004(string info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new FieldIssuer(new XText(info));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0005(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new FieldIssuer(new XText(i));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string asset, string map, string role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new MethodComposerPool(new XDeclaration(asset, map, role));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string res, string reg, string c, string setup2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new StatusFilterResolver(new XDocumentType(res, reg, c, setup2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(string res, string ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ContainerIssuer(new XProcessingInstruction(res, ivk));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRequestStrategy _0001(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new SerializerDicCandidate(new XElement(i));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoRequestStrategy _0001(string reference, string cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new SerializerDicCandidate(new XElement(XName.Get(CustomerListAnnotation.AssetIssuer(reference), cfg)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string res, string reg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ProccesorIssuer(new XAttribute(res, reg));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0002(string param, string col, string tag)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new ProccesorIssuer(new XAttribute(XName.Get(CustomerListAnnotation.AssetIssuer(param), col), tag));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new InfoRequestStrategy _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001().Root == null)
			{
				return null;
			}
			return new SerializerDicCandidate(this._0001().Root);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CreatorIssuer _0001(CreatorIssuer config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MethodComposerPool methodComposerPool = config as MethodComposerPool;
			if (methodComposerPool != null)
			{
				this._0001().Declaration = methodComposerPool._0001();
				return methodComposerPool;
			}
			return base._0001(config);
		}
	}
}
