using _0008;
using GDBD.Importers;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace GDBD.Workers
{
	[_0008._0012(0)]
	internal sealed class InitializerComposer : SetMemberBinder
	{
		private readonly SetMemberBinder objectComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InitializerComposer(SetMemberBinder var1)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(var1.Name, var1.IgnoreCase);
			objectComposer = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(DynamicMetaObject key, DynamicMetaObject result, DynamicMetaObject template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMetaObject dynamicMetaObject = objectComposer.Bind(key, new DynamicMetaObject[1]
			{
				result
			});
			return new DynamicMetaObject(new SchemaComposer().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
		}
	}
}
