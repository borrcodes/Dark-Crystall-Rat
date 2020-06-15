using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Newtonsoft.Common
{
	internal sealed class RepositoryEvent
	{
		private static readonly RandomNumberGenerator serverEvent;

		[ThreadStatic]
		private static Random facadeEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Random ViewList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (facadeEvent == null)
			{
				byte[] array = new byte[4];
				serverEvent.GetBytes(array);
				facadeEvent = new Random(BitConverter.ToInt32(array, 0));
			}
			return facadeEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ConnectList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ViewList().Next();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int MoveList(int infohigh)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ViewList().Next(infohigh);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int PopList(int next_value, int token_counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ViewList().Next(next_value, token_counter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NewList(byte[] key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ViewList().NextBytes(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public double ForgotList()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ViewList().NextDouble();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RepositoryEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RepositoryEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			serverEvent = RandomNumberGenerator.Create();
		}
	}
}
