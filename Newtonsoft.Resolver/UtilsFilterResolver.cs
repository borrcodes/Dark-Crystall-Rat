using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Database;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	internal abstract class UtilsFilterResolver : Stream, ProccesorEventEntry
	{
		public abstract RefList _0001();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool get_CanRead()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool get_CanSeek()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool get_CanWrite()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long Seek(long indexOf_param, SeekOrigin pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (pol)
			{
			case SeekOrigin.Begin:
				Position = indexOf_param;
				break;
			case SeekOrigin.Current:
				Position += indexOf_param;
				break;
			default:
				Position = Length + indexOf_param;
				break;
			}
			return Position;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLength(long starttask)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotSupportedException("Can't set length of a WaveFormatString");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(byte[] var1, int map, int index_template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new NotSupportedException("Can't write to a WaveFormatString");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UtilsFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
