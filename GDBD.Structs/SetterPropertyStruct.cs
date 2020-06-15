using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	internal sealed class SetterPropertyStruct
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForgotIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				WorkerPropertyStruct.PushIterator();
			}
			catch (Exception)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetterPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
