using _0008;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Bridges
{
	[_0008._0012(0)]
	internal sealed class BridgeIssuer : ValPropertyStruct, CreatorIssuer, DicEventConsumer
	{
		private readonly XmlDeclaration importerIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BridgeIssuer(XmlDeclaration last)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(last);
			importerIssuer = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerIssuer.Version;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerIssuer.Encoding;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerIssuer.Standalone;
		}
	}
}
