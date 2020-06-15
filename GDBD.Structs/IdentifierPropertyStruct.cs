using GDBD.Strategies;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	internal sealed class IdentifierPropertyStruct : ValueRequestStrategy
	{
		public static readonly IdentifierPropertyStruct comparatorIssuer;

		public static readonly IdentifierPropertyStruct _ProcIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IdentifierPropertyStruct(bool isitem)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(isitem, (ChildRunStatus)8);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IdentifierPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			comparatorIssuer = new IdentifierPropertyStruct(isitem: false);
			_ProcIssuer = new IdentifierPropertyStruct(isitem: true);
		}
	}
}
