using _0008;
using GDBD.Workers;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	internal struct PoolErrorFilter
	{
		private char[] m_PoolTest;

		private int valTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return valTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(int res_count)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			valTest = res_count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PoolTest == null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolErrorFilter(GDBD.Workers.WrapperComposerWorker<char> key, int sizeb)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this = new PoolErrorFilter(ValueFilterResolver.RegisterIssuer(key, sizeb));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PoolErrorFilter(char[] ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_PoolTest = ident;
			valTest = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeReader(GDBD.Workers.WrapperComposerWorker<char> instance, char token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (valTest == m_PoolTest.Length)
			{
				RateReader(instance, 1);
			}
			m_PoolTest[valTest++] = token;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyReader(GDBD.Workers.WrapperComposerWorker<char> i, char[] reg, int c_counter, int key2_end)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (valTest + key2_end >= m_PoolTest.Length)
			{
				RateReader(i, key2_end);
			}
			Array.Copy(reg, c_counter, m_PoolTest, valTest, key2_end);
			valTest += key2_end;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReader(GDBD.Workers.WrapperComposerWorker<char> item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_PoolTest != null)
			{
				ValueFilterResolver.RestartIssuer(item, m_PoolTest);
				m_PoolTest = null;
			}
			valTest = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RateReader(GDBD.Workers.WrapperComposerWorker<char> value, int pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			char[] array = ValueFilterResolver.RegisterIssuer(value, (valTest + pred) * 2);
			if (m_PoolTest != null)
			{
				Array.Copy(m_PoolTest, array, valTest);
				ValueFilterResolver.RestartIssuer(value, m_PoolTest);
			}
			m_PoolTest = array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return RemoveReader(0, valTest);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string RemoveReader(int def_max, int selectionlow)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new string(m_PoolTest, def_max, selectionlow);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public char[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PoolTest;
		}
	}
}
