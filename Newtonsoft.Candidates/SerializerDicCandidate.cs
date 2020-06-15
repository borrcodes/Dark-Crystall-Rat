using _0008;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Candidates
{
	[_0008._0012(0)]
	internal sealed class SerializerDicCandidate : ItemReaderMapper, CreatorIssuer, InfoRequestStrategy
	{
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private List<CreatorIssuer> m_AdapterIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XElement _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XElement)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializerDicCandidate(XElement value)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void _0001(CreatorIssuer i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FieldIssuer fieldIssuer = (FieldIssuer)i;
			this._0001().Add(fieldIssuer._0001());
			m_AdapterIssuer = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<CreatorIssuer> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_AdapterIssuer == null)
			{
				if (!this._0001().HasAttributes && !PrintRequest(_0003()))
				{
					m_AdapterIssuer = TokenIssuer.dispatcherIssuer;
				}
				else
				{
					m_AdapterIssuer = new List<CreatorIssuer>();
					foreach (XAttribute item in this._0001().Attributes())
					{
						m_AdapterIssuer.Add(new ProccesorIssuer(item));
					}
					string text = _0003();
					if (PrintRequest(text))
					{
						m_AdapterIssuer.Insert(0, new ProccesorIssuer(new XAttribute("xmlns", text)));
					}
				}
			}
			return m_AdapterIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PrintRequest(string last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!SetterTest.StartReader(last) && last != ((FieldIssuer)this)._0001()?._0003() && SetterTest.StartReader(_0001(last)))
			{
				bool flag = false;
				if (this._0001().HasAttributes)
				{
					foreach (XAttribute item in this._0001().Attributes())
					{
						if (item.Name.LocalName == "xmlns" && SetterTest.StartReader(item.Name.NamespaceName) && item.Value == last)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CreatorIssuer _0001(CreatorIssuer setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CreatorIssuer result = base._0001(setup);
			m_AdapterIssuer = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Name.LocalName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Name.NamespaceName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0001(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().GetPrefixOfNamespace(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().IsEmpty;
		}
	}
}
