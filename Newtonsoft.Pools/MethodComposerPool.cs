using _0008;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Pools
{
	[_0008._0012(0)]
	internal sealed class MethodComposerPool : FieldIssuer, CreatorIssuer, DicEventConsumer
	{
		[CompilerGenerated]
		private readonly XDeclaration decoratorIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new XDeclaration _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return decoratorIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MethodComposerPool(XDeclaration i)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(null);
			decoratorIssuer = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override XmlNodeType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return XmlNodeType.XmlDeclaration;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Version;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Encoding;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Standalone;
		}
	}
}
