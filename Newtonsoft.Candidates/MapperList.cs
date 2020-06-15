using GDBD.Workers;
using Newtonsoft.Database;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	internal sealed class MapperList : AccountFilter
	{
		private readonly byte[] predicateList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapperList(byte[] first)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			if (first == null)
			{
				throw new ArgumentNullException("key");
			}
			predicateList = (byte[])first.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] AddDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (byte[])predicateList.Clone();
		}
	}
}
