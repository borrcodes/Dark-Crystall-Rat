using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _0012
{
	[CompilerGenerated]
	internal sealed class _0003
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
		private struct DispatcherFilter
		{
		}

		internal static readonly DispatcherFilter _0001/* Not supported: data(00 01 02 03 04 06 08 08 00 00) */;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static uint _0001(string _0002)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint num = default(uint);
			if (_0002 != null)
			{
				num = 2166136261u;
				for (int i = 0; i < _0002.Length; i++)
				{
					num = (_0002[i] ^ num) * 16777619;
				}
			}
			return num;
		}
	}
}
namespace _0008
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class _0012 : Attribute
	{
		public readonly byte[] _0001;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _0012(byte P_0)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001 = new byte[1]
			{
				P_0
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _0012(byte[] P_0)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001 = P_0;
		}
	}
}
namespace _0014
{
	[CompilerGenerated]
	internal sealed class _001E
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
		private struct QueueIssuerMock
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
		private struct ClientReader
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
		private struct GetterPropertyStruct
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
		private struct ClassInstanceRule
		{
		}

		internal static readonly ClientReader _0001/* Not supported: data(FF FF FF FF 0A 00 00 00 64 00 00 00 E8 03 00 00 10 27 00 00 A0 86 01 00 40 42 0F 00) */;

		internal static readonly QueueIssuerMock _0002/* Not supported: data(22 00 27 00 3C 00 3E 00 26 00) */;

		internal static readonly ClassInstanceRule _0003/* Not supported: data(00 00 00 00 1F 00 00 00 3C 00 00 00 5B 00 00 00 79 00 00 00 98 00 00 00 B6 00 00 00 D5 00 00 00 F4 00 00 00 12 01 00 00 31 01 00 00 4F 01 00 00 6E 01 00 00) */;

		internal static readonly GetterPropertyStruct _0004/* Not supported: data(2E 00 20 00 27 00 2F 00 22 00 5B 00 5D 00 28 00 29 00 09 00 0A 00 0D 00 0C 00 08 00 5C 00 85 00 28 20 29 20) */;

		internal static readonly ClassInstanceRule _0005/* Not supported: data(00 00 00 00 1F 00 00 00 3B 00 00 00 5A 00 00 00 78 00 00 00 97 00 00 00 B5 00 00 00 D4 00 00 00 F3 00 00 00 11 01 00 00 30 01 00 00 4E 01 00 00 6D 01 00 00) */;
	}
}
namespace _000E
{
	[CompilerGenerated]
	internal sealed class _0011
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		private struct DispatcherClassSpec
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct ComposerClassDispatcher
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 76)]
		private struct ParserReader
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 116)]
		private struct ThreadIssuerImporter
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 120)]
		private struct StatusReader
		{
		}

		internal static readonly long _0001/* Not supported: data(4C 76 C5 17 0B F5 06 4B) */;

		internal static readonly long _0002/* Not supported: data(49 68 87 04 8D 68 72 2D) */;

		internal static readonly ComposerClassDispatcher _0003/* Not supported: data(02 02 02 02 02 02 02 02 02 02 02 02 02 02 02 02) */;

		internal static readonly ThreadIssuerImporter _0004/* Not supported: data(03 00 00 00 04 00 00 00 05 00 00 00 06 00 00 00 07 00 00 00 08 00 00 00 09 00 00 00 0A 00 00 00 0B 00 00 00 0D 00 00 00 0F 00 00 00 11 00 00 00 13 00 00 00 17 00 00 00 1B 00 00 00 1F 00 00 00 23 00 00 00 2B 00 00 00 33 00 00 00 3B 00 00 00 43 00 00 00 53 00 00 00 63 00 00 00 73 00 00 00 83 00 00 00 A3 00 00 00 C3 00 00 00 E3 00 00 00 02 01 00 00) */;

		internal static readonly DispatcherClassSpec _0005/* Not supported: data(02 00 00 00 03 00 00 00 07 00 00 00) */;

		internal static readonly ComposerClassDispatcher _0006/* Not supported: data(00 08 04 0C 02 0A 06 0E 01 09 05 0D 03 0B 07 0F) */;

		internal static readonly StatusReader _0007/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 06 00 00 00 06 00 00 00 07 00 00 00 07 00 00 00 08 00 00 00 08 00 00 00 09 00 00 00 09 00 00 00 0A 00 00 00 0A 00 00 00 0B 00 00 00 0B 00 00 00 0C 00 00 00 0C 00 00 00 0D 00 00 00 0D 00 00 00) */;

		internal static readonly ParserReader _0008/* Not supported: data(10 00 00 00 11 00 00 00 12 00 00 00 00 00 00 00 08 00 00 00 07 00 00 00 09 00 00 00 06 00 00 00 0A 00 00 00 05 00 00 00 0B 00 00 00 04 00 00 00 0C 00 00 00 03 00 00 00 0D 00 00 00 02 00 00 00 0E 00 00 00 01 00 00 00 0F 00 00 00) */;

		internal static readonly ComposerClassDispatcher _000E/* Not supported: data(01 01 01 01 01 01 01 01 01 01 01 01 01 01 01 01) */;

		internal static readonly DispatcherClassSpec _000F/* Not supported: data(03 00 00 00 03 00 00 00 0B 00 00 00) */;

		internal static readonly ThreadIssuerImporter _0010/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 01 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 02 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 03 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 04 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 05 00 00 00 00 00 00 00) */;

		internal static readonly StatusReader _0011/* Not supported: data(01 00 00 00 02 00 00 00 03 00 00 00 04 00 00 00 05 00 00 00 07 00 00 00 09 00 00 00 0D 00 00 00 11 00 00 00 19 00 00 00 21 00 00 00 31 00 00 00 41 00 00 00 61 00 00 00 81 00 00 00 C1 00 00 00 01 01 00 00 81 01 00 00 01 02 00 00 01 03 00 00 01 04 00 00 01 06 00 00 01 08 00 00 01 0C 00 00 01 10 00 00 01 18 00 00 01 20 00 00 01 30 00 00 01 40 00 00 01 60 00 00) */;
	}
}
