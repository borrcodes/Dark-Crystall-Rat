using GDBD.Bridges;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	internal sealed class TokenClassSpec
	{
		[CompilerGenerated]
		private readonly byte[] globalIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return globalIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenClassSpec(byte[] init)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(init, "value");
			if (init.Length != 12)
			{
				throw new ArgumentException("An ObjectId must be 12 bytes", "value");
			}
			globalIssuer = init;
		}
	}
}
