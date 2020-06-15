using GDBD.Items;
using GDBD.Workers;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Filter
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal sealed class RefList
	{
		protected ValidationType m_ThreadList;

		protected short _ConsumerList;

		protected int comparatorList;

		protected int m_ProcList;

		protected short m_RecordInstance;

		protected short m_EventInstance;

		protected short _FilterInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefList()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(44100, 16, 2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefList(int asset_end, int position_connection)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(asset_end, 16, position_connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int StartDic(int ID_first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = (int)((double)_0004() / 1000.0 * (double)ID_first);
			if (num % _0005() != 0)
			{
				num = num + _0005() - num % _0005();
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefList(int sizetask, int attr_end, int column_template)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			if (column_template < 1)
			{
				throw new ArgumentOutOfRangeException("channels", "Channels must be 1 or greater");
			}
			m_ThreadList = ValidationType.Pcm;
			_ConsumerList = (short)column_template;
			comparatorList = sizetask;
			m_EventInstance = (short)attr_end;
			_FilterInstance = 0;
			m_RecordInstance = (short)(column_template * (attr_end / 8));
			m_ProcList = comparatorList * m_RecordInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RefList ListDic(int init_Low, int counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RefList refList = new RefList();
			refList.m_ThreadList = ValidationType.IeeeFloat;
			refList._ConsumerList = (short)counter;
			refList.m_EventInstance = 32;
			refList.comparatorList = init_Low;
			refList.m_RecordInstance = (short)(4 * counter);
			refList.m_ProcList = init_Low * refList.m_RecordInstance;
			refList._FilterInstance = 0;
			return refList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValidationType threadList = m_ThreadList;
			if (threadList == ValidationType.Pcm || threadList == ValidationType.Extensible)
			{
				return $"{m_EventInstance} bit PCM: {comparatorList / 1000}kHz {_ConsumerList} channels";
			}
			return m_ThreadList.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(object param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RefList refList = param as RefList;
			if (refList != null)
			{
				if (m_ThreadList == refList.m_ThreadList && _ConsumerList == refList._ConsumerList && comparatorList == refList.comparatorList && m_ProcList == refList.m_ProcList && m_RecordInstance == refList.m_RecordInstance)
				{
					return m_EventInstance == refList.m_EventInstance;
				}
				return false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (int)m_ThreadList ^ (int)_ConsumerList ^ comparatorList ^ m_ProcList ^ m_RecordInstance ^ m_EventInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValidationType _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ThreadList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(BinaryWriter item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			item.Write(18 + _FilterInstance);
			item.Write((short)this._0001());
			item.Write((short)_0002());
			item.Write(_0003());
			item.Write(_0004());
			item.Write((short)_0005());
			item.Write((short)_0006());
			item.Write(_FilterInstance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ConsumerList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return comparatorList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ProcList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RecordInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_EventInstance;
		}
	}
}
