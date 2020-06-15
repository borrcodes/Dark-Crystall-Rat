using _0008;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace GDBD.Maps
{
	[_0008._0012(0)]
	internal class FieldIssuer : CreatorIssuer
	{
		private readonly XObject m_ItemIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FieldIssuer(XObject i)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_ItemIssuer = i;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ItemIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual XmlNodeType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ItemIssuer?.NodeType ?? XmlNodeType.None;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual List<CreatorIssuer> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return TokenIssuer.dispatcherIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual List<CreatorIssuer> _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return TokenIssuer.dispatcherIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual CreatorIssuer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual CreatorIssuer _0001(CreatorIssuer ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}
	}
}
