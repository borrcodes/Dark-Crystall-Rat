using _0008;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Database
{
	[_0008._0012(0)]
	internal sealed class ProccesorIssuer : FieldIssuer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XAttribute _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XAttribute)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProccesorIssuer(XAttribute param)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Name.LocalName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Name.NamespaceName;
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
			return ItemReaderMapper.InvokeRequest(_0001().Parent);
		}
	}
}
