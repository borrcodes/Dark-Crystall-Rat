using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Expressions
{
	internal sealed class TemplateList : EventArgs
	{
		private byte[] expressionList;

		private int m_ConfigList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateList(byte[] setup, int mapX)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			expressionList = setup;
			m_ConfigList = mapX;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return expressionList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ConfigList;
		}
	}
}
