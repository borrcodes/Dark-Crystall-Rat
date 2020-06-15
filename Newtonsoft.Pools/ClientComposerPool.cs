using GDBD.Mappers;
using GDBD.Workers;
using Newtonsoft.Rules;

namespace Newtonsoft.Pools
{
	internal struct ClientComposerPool
	{
		public int contextDic;

		public DefinitionDic m_ParamDic;

		public InteractiveOperation m_PublisherDic;

		public ErrorInstanceRule utilsDic;
	}
}
