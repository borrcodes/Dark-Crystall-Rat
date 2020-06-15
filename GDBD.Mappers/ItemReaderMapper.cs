using _0008;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace GDBD.Mappers
{
	[_0008._0012(0)]
	internal class ItemReaderMapper : FieldIssuer
	{
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<CreatorIssuer> m_ProcessIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XContainer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XContainer)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemReaderMapper(XContainer var1)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<CreatorIssuer> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProcessIssuer == null)
			{
				if (!_0002())
				{
					m_ProcessIssuer = TokenIssuer.dispatcherIssuer;
				}
				else
				{
					m_ProcessIssuer = new List<CreatorIssuer>();
					foreach (XNode item in _0001().Nodes())
					{
						m_ProcessIssuer.Add(InvokeRequest(item));
					}
				}
			}
			return m_ProcessIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected new virtual bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().LastNode != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CreatorIssuer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_0001().Parent == null)
			{
				return null;
			}
			return InvokeRequest(_0001().Parent);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CreatorIssuer InvokeRequest(XObject init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			XDocument xDocument = init as XDocument;
			if (xDocument != null)
			{
				return new AuthenticationComposerPool(xDocument);
			}
			XElement xElement = init as XElement;
			if (xElement != null)
			{
				return new SerializerDicCandidate(xElement);
			}
			XContainer xContainer = init as XContainer;
			if (xContainer != null)
			{
				return new ItemReaderMapper(xContainer);
			}
			XProcessingInstruction xProcessingInstruction = init as XProcessingInstruction;
			if (xProcessingInstruction != null)
			{
				return new ContainerIssuer(xProcessingInstruction);
			}
			XText xText = init as XText;
			if (xText != null)
			{
				return new ErrorEventConsumer(xText);
			}
			XComment xComment = init as XComment;
			if (xComment != null)
			{
				return new BaseIssuer(xComment);
			}
			XAttribute xAttribute = init as XAttribute;
			if (xAttribute != null)
			{
				return new ProccesorIssuer(xAttribute);
			}
			XDocumentType xDocumentType = init as XDocumentType;
			if (xDocumentType != null)
			{
				return new StatusFilterResolver(xDocumentType);
			}
			return new FieldIssuer(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CreatorIssuer _0001(CreatorIssuer reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0001().Add(reference._0001());
			m_ProcessIssuer = null;
			return reference;
		}
	}
}
