using _0008;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	[_0008._0012(0)]
	internal abstract class ProducerIteratorMapping
	{
		[CompilerGenerated]
		private bool m_UtilsTest;

		[CompilerGenerated]
		private bool strategyTest;

		[CompilerGenerated]
		private bool _InfoTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_UtilsTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return strategyTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InfoTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0001(string info, bool setattr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setattr && !_0003())
			{
				return info;
			}
			return _0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0002(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_0002())
			{
				return spec;
			}
			return _0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0003(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!_0001())
			{
				return instance;
			}
			return _0001(instance);
		}

		protected abstract string _0001(string first);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (((((GetType().GetHashCode() * 397) ^ _0001().GetHashCode()) * 397) ^ _0002().GetHashCode()) * 397) ^ _0003().GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return AddClient(setup as ProducerIteratorMapping);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool AddClient(ProducerIteratorMapping ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident == null)
			{
				return false;
			}
			if (GetType() == ident.GetType() && _0001() == ident._0001() && _0002() == ident._0002())
			{
				return _0003() == ident._0003();
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ProducerIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
