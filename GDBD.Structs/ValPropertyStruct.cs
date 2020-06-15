using _0008;
using GDBD.Bridges;
using GDBD.Mocks;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Rules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Structs
{
	[_0008._0012(0)]
	internal class ValPropertyStruct : CreatorIssuer
	{
		[_0008._0012(1)]
		private readonly XmlNode m_SpecificationIssuer;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<CreatorIssuer> _WriterIssuer;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<CreatorIssuer> m_RoleIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValPropertyStruct(XmlNode value)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_SpecificationIssuer = value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_SpecificationIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlNodeType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_SpecificationIssuer.NodeType;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_SpecificationIssuer.LocalName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<CreatorIssuer> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_WriterIssuer == null)
			{
				if (!m_SpecificationIssuer.HasChildNodes)
				{
					_WriterIssuer = TokenIssuer.dispatcherIssuer;
				}
				else
				{
					_WriterIssuer = new List<CreatorIssuer>(m_SpecificationIssuer.ChildNodes.Count);
					foreach (XmlNode childNode in m_SpecificationIssuer.ChildNodes)
					{
						_WriterIssuer.Add(ConcatRequest(childNode));
					}
				}
			}
			return _WriterIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CreatorIssuer ConcatRequest(XmlNode ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (ident.NodeType)
			{
			case XmlNodeType.Element:
				return new ServiceIssuerMock((XmlElement)ident);
			case XmlNodeType.XmlDeclaration:
				return new BridgeIssuer((XmlDeclaration)ident);
			case XmlNodeType.DocumentType:
				return new InvocationPropertyStruct((XmlDocumentType)ident);
			default:
				return new ValPropertyStruct(ident);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<CreatorIssuer> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RoleIssuer == null)
			{
				if (!this._0002())
				{
					m_RoleIssuer = TokenIssuer.dispatcherIssuer;
				}
				else
				{
					m_RoleIssuer = new List<CreatorIssuer>(m_SpecificationIssuer.Attributes.Count);
					foreach (XmlAttribute attribute in m_SpecificationIssuer.Attributes)
					{
						m_RoleIssuer.Add(ConcatRequest(attribute));
					}
				}
			}
			return m_RoleIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			XmlElement xmlElement = m_SpecificationIssuer as XmlElement;
			if (xmlElement != null)
			{
				return xmlElement.HasAttributes;
			}
			XmlAttributeCollection attributes = m_SpecificationIssuer.Attributes;
			if (attributes == null)
			{
				return false;
			}
			return attributes.Count > 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			XmlAttribute xmlAttribute = m_SpecificationIssuer as XmlAttribute;
			XmlNode xmlNode = (xmlAttribute != null) ? xmlAttribute.OwnerElement : m_SpecificationIssuer.ParentNode;
			if (xmlNode == null)
			{
				return null;
			}
			return ConcatRequest(xmlNode);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_SpecificationIssuer.Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_SpecificationIssuer.Value = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatorIssuer _0001(CreatorIssuer i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValPropertyStruct valPropertyStruct = (ValPropertyStruct)i;
			m_SpecificationIssuer.AppendChild(valPropertyStruct.m_SpecificationIssuer);
			_WriterIssuer = null;
			m_RoleIssuer = null;
			return i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_SpecificationIssuer.NamespaceURI;
		}
	}
}
