using _0008;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Pools;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GDBD.Structs
{
	[_0008._0012(0)]
	internal sealed class InvocationPropertyStruct : ValPropertyStruct, CreatorIssuer, IndexerIssuer
	{
		private readonly XmlDocumentType _ReponseIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InvocationPropertyStruct(XmlDocumentType v)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(v);
			_ReponseIssuer = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseIssuer.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseIssuer.SystemId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseIssuer.PublicId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseIssuer.InternalSubset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return "DOCTYPE";
		}
	}
}
