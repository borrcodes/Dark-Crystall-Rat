using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	internal sealed class CodeIteratorMapping
	{
		private XlOLEVerb _SystemIssuer;

		private ResourceDictionaryLocation identifierIssuer;

		private ColorMatrixFlag getterIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CodeIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			identifierIssuer = (ResourceDictionaryLocation)1;
			_SystemIssuer = (XlOLEVerb)0;
			getterIssuer = (ColorMatrixFlag)0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public XlOLEVerb _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SystemIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ResourceDictionaryLocation _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return identifierIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorMatrixFlag _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return getterIssuer;
		}
	}
}
