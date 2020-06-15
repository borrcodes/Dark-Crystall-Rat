using _0008;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal sealed class ErrorEventConsumer : FieldIssuer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		private new XText _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (XText)base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ErrorEventConsumer(XText first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001().Value;
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
