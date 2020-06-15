using _0008;
using GDBD.Maps;
using GDBD.Workers;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace GDBD.Strategies
{
	[_0008._0012(0)]
	internal sealed class ContainerIssuer : FieldIssuer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XProcessingInstruction _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XProcessingInstruction)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContainerIssuer(XProcessingInstruction asset)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Target;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Data;
		}
	}
}
