using GDBD.Workers;
using System.IO;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	internal sealed class ItemClassSpec : Stream
	{
		[CompilerGenerated]
		private Stream importerInstance;

		[CompilerGenerated]
		private bool _ReponseInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Stream _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return importerInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void _0001(Stream res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			importerInstance = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ReponseInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool nospec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ReponseInstance = nospec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemClassSpec(Stream task)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_0001(task);
			_0001(nospec: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().CanRead;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().CanSeek;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().CanWrite;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001().Flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Position;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long IDfirst)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001().Position = IDfirst;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0001(byte[] var1, int cont_min, int positionpool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Read(var1, cont_min, positionpool);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0001(long min_ident, SeekOrigin b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001().Seek(min_ident, b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(long min_ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001().SetLength(min_ident);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] task, int b_low, int utilend)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			this._0001().Write(task, b_low, utilend);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0002(bool isasset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!this._0001())
			{
				this._0001().Dispose();
				_0001(null);
			}
		}
	}
}
