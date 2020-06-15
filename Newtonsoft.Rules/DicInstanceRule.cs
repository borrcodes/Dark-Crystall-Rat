using GDBD.Filter;
using GDBD.Items;
using GDBD.Workers;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Rules
{
	internal sealed class DicInstanceRule : Stream
	{
		private Stream _ProducerInstance;

		private readonly BinaryWriter _StructInstance;

		private long m_StubInstance;

		private long _CodeInstance;

		private long taskInstance;

		private readonly RefList m_CustomerInstance;

		private readonly byte[] m_InterpreterInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DicInstanceRule(Stream last, RefList cust)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_InterpreterInstance = new byte[3];
			base._002Ector();
			_ProducerInstance = last;
			m_CustomerInstance = cust;
			_StructInstance = new BinaryWriter(last, Encoding.UTF8);
			_StructInstance.Write(Encoding.UTF8.GetBytes("RIFF"));
			_StructInstance.Write(0);
			_StructInstance.Write(Encoding.UTF8.GetBytes("WAVE"));
			_StructInstance.Write(Encoding.UTF8.GetBytes("fmt "));
			cust._0001(_StructInstance);
			InvokeDic();
			ConcatDic();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConcatDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_StructInstance.Write(Encoding.UTF8.GetBytes("data"));
			m_StubInstance = _ProducerInstance.Position;
			_StructInstance.Write(0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InvokeDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PrintDic())
			{
				_StructInstance.Write(Encoding.UTF8.GetBytes("fact"));
				_StructInstance.Write(4);
				_CodeInstance = _ProducerInstance.Position;
				_StructInstance.Write(0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PrintDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_CustomerInstance._0001() != ValidationType.Pcm)
			{
				return m_CustomerInstance._0006() != 0;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return taskInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0001(byte[] value, int cust_Position, int length_util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Cannot read from a WaveFileWriter");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0001(long def_size, SeekOrigin attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Cannot seek within a WaveFileWriter");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long nextinfo)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Cannot set length of a WaveFileWriter");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return taskInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(long IDi)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw new InvalidOperationException("Repositioning a WaveFileWriter is not supported");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] info, int reg_start, int comp_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ProducerInstance.Length + comp_start > uint.MaxValue)
			{
				throw new ArgumentException("WAV file too large", "count");
			}
			_ProducerInstance.Write(info, reg_start, comp_start);
			taskInstance += comp_start;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			long position = _StructInstance.BaseStream.Position;
			_0001(_StructInstance);
			_StructInstance.BaseStream.Position = position;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(bool isinfo)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (isinfo && _ProducerInstance != null)
			{
				try
				{
					_0001(_StructInstance);
				}
				finally
				{
					_ProducerInstance.Close();
					_ProducerInstance = null;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0001(BinaryWriter key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			key.Flush();
			AssetDic(key);
			CustomizeDic(key);
			CountDic(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CountDic(BinaryWriter res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			res.Seek((int)m_StubInstance, SeekOrigin.Begin);
			res.Write((uint)taskInstance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AssetDic(BinaryWriter res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			res.Seek(4, SeekOrigin.Begin);
			res.Write((uint)(_ProducerInstance.Length - 8));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CustomizeDic(BinaryWriter first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PrintDic())
			{
				int num = m_CustomerInstance._0006() * m_CustomerInstance._0002();
				if (num != 0)
				{
					first.Seek((int)_CodeInstance, SeekOrigin.Begin);
					first.Write((int)(taskInstance * 8 / num));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				Dispose(disposing: false);
			}
			finally
			{
				base.Finalize();
			}
		}
	}
}
