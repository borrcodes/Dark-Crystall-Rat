using _0008;
using GDBD.Bridges;
using GDBD.Workers;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	[_0008._0012(0)]
	internal sealed class ManagerComposer
	{
		private readonly char[] m_StateComposer;

		private readonly TextWriter _ResolverComposer;

		[_0008._0012(2)]
		private byte[] poolComposer;

		private int _ValComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerComposer(TextWriter key)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_StateComposer = new char[76];
			base._002Ector();
			ContextClientBridge.RunClient(key, "writer");
			_ResolverComposer = key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteTest(byte[] value, int rowmap, int start_pool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (value == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (rowmap < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (start_pool < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (start_pool > value.Length - rowmap)
			{
				throw new ArgumentOutOfRangeException("count");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestTest(byte[] reference, int no__second, int next_field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DeleteTest(reference, no__second, next_field);
			if (_ValComposer > 0)
			{
				if (InvokeTest(reference, no__second, ref next_field))
				{
					return;
				}
				int fieldhigh = Convert.ToBase64CharArray(poolComposer, 0, 3, m_StateComposer, 0);
				CountTest(m_StateComposer, 0, fieldhigh);
			}
			ConcatTest(reference, no__second, ref next_field);
			int num = no__second + next_field;
			int num2 = 57;
			while (no__second < num)
			{
				if (no__second + num2 > num)
				{
					num2 = num - no__second;
				}
				int fieldhigh2 = Convert.ToBase64CharArray(reference, no__second, num2, m_StateComposer, 0);
				CountTest(m_StateComposer, 0, fieldhigh2);
				no__second += num2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConcatTest(byte[] config, int attrPtr, ref int state)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = state % 3;
			if (num > 0)
			{
				state -= num;
				if (poolComposer == null)
				{
					poolComposer = new byte[3];
				}
				for (int i = 0; i < num; i++)
				{
					poolComposer[i] = config[attrPtr + state + i];
				}
			}
			_ValComposer = num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool InvokeTest(byte[] key, int idxcont, ref int c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int valComposer = _ValComposer;
			while (valComposer < 3 && c > 0)
			{
				poolComposer[valComposer++] = key[idxcont++];
				c--;
			}
			if (c == 0 && valComposer < 3)
			{
				_ValComposer = valComposer;
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ValComposer > 0)
			{
				int fieldhigh = Convert.ToBase64CharArray(poolComposer, 0, _ValComposer, m_StateComposer, 0);
				CountTest(m_StateComposer, 0, fieldhigh);
				_ValComposer = 0;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CountTest(char[] item, int next_cont, int fieldhigh)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ResolverComposer.Write(item, next_cont, fieldhigh);
		}
	}
}
