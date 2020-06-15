using _0008;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Mocks
{
	[_0008._0012(0)]
	internal sealed class ServiceIssuerMock : ValPropertyStruct, CreatorIssuer, InfoRequestStrategy
	{
		private readonly XmlElement m_RuleIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ServiceIssuerMock(XmlElement instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(instance);
			m_RuleIssuer = instance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new void _0001(CreatorIssuer asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValPropertyStruct valPropertyStruct = (ValPropertyStruct)asset;
			m_RuleIssuer.SetAttributeNode((XmlAttribute)valPropertyStruct._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new string _0001(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RuleIssuer.GetPrefixOfNamespace(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RuleIssuer.IsEmpty;
		}
	}
}
