using GDBD.Structs;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	internal sealed class DefinitionErrorFilter : SystemPropertyStruct
	{
		public static readonly SystemPropertyStruct m_ObjectIssuer;

		public static readonly SystemPropertyStruct m_SchemaIssuer;

		[CompilerGenerated]
		private readonly ChildRunStatus _RefIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DefinitionErrorFilter(ChildRunStatus item)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_RefIssuer = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public override ChildRunStatus _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RefIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefinitionErrorFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_ObjectIssuer = new DefinitionErrorFilter((ChildRunStatus)10);
			m_SchemaIssuer = new DefinitionErrorFilter((ChildRunStatus)6);
		}
	}
}
