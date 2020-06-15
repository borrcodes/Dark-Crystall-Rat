using _0008;
using GDBD.Workers;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal sealed class SchemaComposer : ExpressionVisitor
	{
		internal static readonly object refComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Expression _0001(ConditionalExpression task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task.IfFalse.NodeType == ExpressionType.Throw)
			{
				return Expression.Condition(task.Test, task.IfTrue, Expression.Constant(refComposer));
			}
			return base.VisitConditional(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SchemaComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SchemaComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			refComposer = new object();
		}
	}
}
