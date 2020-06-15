using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Resolver;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	internal sealed class TemplateIssuer : SystemPropertyStruct, IEnumerable, IEnumerable<PageFilterResolver>
	{
		private readonly List<PageFilterResolver> m_ExpressionIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloneIterator(string first, SystemPropertyStruct token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<PageFilterResolver> expressionIssuer = m_ExpressionIssuer;
			PageFilterResolver pageFilterResolver = new PageFilterResolver();
			pageFilterResolver._0001(new ParameterRequestStrategy(first, haveb: false));
			pageFilterResolver._0001(token);
			expressionIssuer.Add(pageFilterResolver);
			token._0001(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ChildRunStatus _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ChildRunStatus)3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new IEnumerator<PageFilterResolver> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ExpressionIssuer.GetEnumerator();
		}

		IEnumerator<PageFilterResolver> IEnumerable<PageFilterResolver>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new IEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_ExpressionIssuer = new List<PageFilterResolver>();
			base._002Ector();
		}
	}
}
