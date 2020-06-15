using GDBD.Importers;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Rules
{
	internal sealed class FilterInstanceRule
	{
		private static readonly byte[] _ConsumerFilter;

		private readonly ParamsIssuerImporter _ComparatorFilter;

		private readonly SchemaFilter procFilter;

		private bool recordList;

		private int m_EventList;

		private byte[] m_FilterList;

		private byte[] m_InstanceList;

		private MapperList _DicList;

		private byte[] _ErrorList;

		private byte[] _ComposerList;

		private byte[] _PropertyList;

		private byte[] m_IssuerList;

		private byte[] m_ReaderList;

		private byte[] m_ClientList;

		private byte[] broadcasterList;

		private int m_ClassList;

		private ulong requestList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilterInstanceRule(ParamsIssuerImporter instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(instance, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilterInstanceRule(ParamsIssuerImporter asset, SchemaFilter vis)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			if (asset._0001() != 16)
			{
				throw new ArgumentException("cipher required with a block size of " + 16 + ".");
			}
			if (vis == null)
			{
				vis = new RefFilter();
			}
			_ComparatorFilter = asset;
			procFilter = vis;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001(bool isinit, AccountFilter cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			recordList = isinit;
			m_ReaderList = null;
			DescriptorListAnnotation descriptorListAnnotation = default(DescriptorListAnnotation);
			if (cfg is DescriptorListAnnotation)
			{
				DescriptorListAnnotation obj = (DescriptorListAnnotation)cfg;
				if (3u != 0)
				{
					descriptorListAnnotation = obj;
				}
			}
			else
			{
				if (!(cfg is TemplateIssuerImporter))
				{
					throw new ArgumentException("invalid parameters passed to GCM");
				}
				TemplateIssuerImporter obj2 = (TemplateIssuerImporter)cfg;
				TemplateIssuerImporter templateIssuerImporter;
				if (uint.MaxValue != 0)
				{
					templateIssuerImporter = obj2;
				}
				m_FilterList = templateIssuerImporter.EnableDic();
				m_InstanceList = null;
				if (0 == 0)
				{
					m_EventList = 16;
					_DicList = (MapperList)templateIssuerImporter._0001();
					goto IL_00f6;
				}
			}
			m_FilterList = descriptorListAnnotation._0002();
			m_InstanceList = descriptorListAnnotation._0001();
			int num = descriptorListAnnotation._0001();
			goto IL_0048;
			IL_00f6:
			num = (isinit ? 16 : (16 + m_EventList));
			while (5u != 0)
			{
				int num2;
				if (2u != 0)
				{
					num2 = num;
				}
				m_IssuerList = new byte[num2];
				if (m_FilterList != null)
				{
					int num3 = m_FilterList.Length;
					int num4 = 1;
					while (num3 >= num4)
					{
						if (m_InstanceList == null)
						{
							m_InstanceList = new byte[0];
						}
						ParamsIssuerImporter comparatorFilter = _ComparatorFilter;
						MapperList dicList = _DicList;
						if (8u != 0)
						{
							comparatorFilter._0001(isv: true, dicList);
						}
						_ErrorList = new byte[16];
						num = _ComparatorFilter._0001(_ErrorList, 0, _ErrorList, 0);
						if (4 == 0)
						{
							goto IL_010c;
						}
						SchemaFilter schemaFilter = procFilter;
						byte[] errorList = _ErrorList;
						if (0 == 0)
						{
							schemaFilter._0001(errorList);
						}
						_ComposerList = RunDic(m_InstanceList);
						if (0 == 0)
						{
							num3 = m_FilterList.Length;
							num4 = 12;
							if (num4 == 0)
							{
								continue;
							}
							if (num3 != num4)
							{
								_PropertyList = RunDic(m_FilterList);
								byte[] array = new byte[16];
								CompareDic((ulong)((long)m_FilterList.Length * 8L), array, 8);
								MappingIteratorMapping.ValidateDic(_PropertyList, array);
								procFilter._0002(_PropertyList);
								goto IL_0269;
							}
							_PropertyList = new byte[16];
						}
						Array.Copy(m_FilterList, 0, _PropertyList, 0, m_FilterList.Length);
						_PropertyList[15] = 1;
						goto IL_0269;
						IL_0269:
						m_ClientList = RegistryList.CloneDic(_ComposerList);
						broadcasterList = RegistryList.CloneDic(_PropertyList);
						m_ClassList = 0;
						requestList = 0uL;
						return;
					}
				}
				throw new ArgumentException("IV must be at least 1 byte");
				IL_010c:;
			}
			goto IL_0048;
			IL_0048:
			int num5 = default(int);
			if (0 == 0)
			{
				num5 = num;
			}
			if (num5 < 96 || num5 > 128 || num5 % 8 != 0)
			{
				throw new ArgumentException("Invalid value for MAC size: " + num5);
			}
			m_EventList = num5 / 8;
			_DicList = descriptorListAnnotation._0001();
			goto IL_00f6;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0001(int asset_min)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num;
			int num2;
			if (recordList)
			{
				num = asset_min;
				num2 = m_ClassList;
			}
			else
			{
				num = asset_min;
				if (false)
				{
					goto IL_001d;
				}
				num2 = m_ClassList;
				if (0 == 0)
				{
					return num + num2 - m_EventList;
				}
			}
			if (0 == 0)
			{
				num += num2;
				goto IL_001d;
			}
			goto IL_0023;
			IL_001d:
			num2 = m_EventList;
			goto IL_0023;
			IL_0023:
			return num + num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0001(byte[] key, int cfg, int rule_ID, byte[] asset2, int remove_FIRST3At)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num2 = default(int);
			while (true)
			{
				int num;
				if (2u != 0)
				{
					num = 0;
				}
				if (0 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					int num3;
					if (num2 != rule_ID)
					{
						m_IssuerList[m_ClassList++] = key[cfg + num2];
						if (m_ClassList == m_IssuerList.Length)
						{
							byte[] issuerList = m_IssuerList;
							int var12_amount = remove_FIRST3At + num;
							if (0 == 0)
							{
								FillDic(issuerList, 16, asset2, var12_amount);
							}
							num3 = (recordList ? 1 : 0);
							goto IL_0069;
						}
						goto IL_00bc;
					}
					return num;
					IL_006e:
					byte[] issuerList2 = m_IssuerList;
					byte[] issuerList3 = m_IssuerList;
					int eventList = m_EventList;
					if (0 == 0)
					{
						Array.Copy(issuerList2, 16, issuerList3, 0, eventList);
					}
					goto IL_008e;
					IL_00bc:
					num3 = num2;
					if (0 == 0)
					{
						int num4 = num3 + 1;
						if (true)
						{
							num2 = num4;
						}
						continue;
					}
					goto IL_0069;
					IL_008e:
					if (4 == 0 || 7 == 0)
					{
						break;
					}
					m_ClassList = m_IssuerList.Length - 16;
					if (false)
					{
						goto IL_006e;
					}
					int num5 = num + 16;
					if (2u != 0)
					{
						num = num5;
					}
					goto IL_00bc;
					IL_0069:
					if (num3 == 0)
					{
						goto IL_006e;
					}
					goto IL_008e;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public unsafe int _0001(byte[] v, int visZ)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int classList = m_ClassList;
			int num;
			if (5u != 0)
			{
				num = classList;
			}
			if (!recordList)
			{
				if (num < m_EventList)
				{
					throw new ProxyList("data too short");
				}
				int num2 = num - m_EventList;
				if (0 == 0)
				{
					num = num2;
				}
			}
			if (num > 0)
			{
				byte[] array = new byte[16];
				byte[] array2 = default(byte[]);
				if (0 == 0)
				{
					array2 = array;
				}
				byte[] issuerList = m_IssuerList;
				byte[] destinationArray = array2;
				int length = num;
				if (true)
				{
					Array.Copy(issuerList, destinationArray, length);
				}
				byte[] config = array2;
				int num_cust = num;
				if (0 == 0)
				{
					FillDic(config, num_cust, v, visZ);
				}
			}
			byte[] array3 = new byte[16];
			byte[] array4;
			if (5u != 0)
			{
				array4 = array3;
			}
			IntPtr intPtr = (IntPtr)(void*)m_InstanceList.LongLength;
			int num3;
			int num4;
			if (0 == 0)
			{
				num3 = (int)(long)intPtr;
				if (false)
				{
					goto IL_01a7;
				}
				CompareDic((ulong)((long)num3 * 8L), array4, 0);
				CompareDic(requestList * 8, array4, 8);
				do
				{
					MappingIteratorMapping.ValidateDic(m_ClientList, array4);
				}
				while (5 == 0);
				procFilter._0002(m_ClientList);
				byte[] array5 = new byte[16];
				_ComparatorFilter._0001(_PropertyList, 0, array5, 0);
				MappingIteratorMapping.ValidateDic(array5, m_ClientList);
				num4 = num;
				m_ReaderList = new byte[m_EventList];
				Array.Copy(array5, m_ReaderList, m_EventList);
				if (recordList)
				{
					Array.Copy(m_ReaderList, 0, v, visZ + m_ClassList, m_EventList);
					num4 += m_EventList;
					goto IL_019e;
				}
				byte[] array6 = new byte[m_EventList];
				Array.Copy(m_IssuerList, num, array6, 0, m_EventList);
				intPtr = (IntPtr)(RegistryList.StopDic(m_ReaderList, array6) ? 1 : 0);
			}
			if (intPtr == (IntPtr)0)
			{
				throw new ProxyList("mac check in GCM failed");
			}
			goto IL_019e;
			IL_01a7:
			return num3;
			IL_019e:
			ResolveDic(useident: false);
			num3 = num4;
			goto IL_01a7;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResolveDic(bool useident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ClientList = RegistryList.CloneDic(_ComposerList);
			broadcasterList = RegistryList.CloneDic(_PropertyList);
			m_ClassList = 0;
			requestList = 0uL;
			if (m_IssuerList != null)
			{
				byte[] issuerList = m_IssuerList;
				int length = m_IssuerList.Length;
				if (0 == 0)
				{
					Array.Clear(issuerList, 0, length);
				}
			}
			if (useident)
			{
				m_ReaderList = null;
			}
			ParamsIssuerImporter comparatorFilter = _ComparatorFilter;
			if (uint.MaxValue != 0)
			{
				comparatorFilter._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FillDic(byte[] config, int num_cust, byte[] role, int var12_amount)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = default(int);
			if (0 == 0)
			{
				num = 15;
			}
			while (true)
			{
				int num2 = num;
				if (false)
				{
					goto IL_00e2;
				}
				byte[] array;
				IntPtr intPtr;
				if (num2 >= 12)
				{
					byte[] array2 = array = broadcasterList;
					int num3 = num;
					intPtr = (IntPtr)num3;
					byte b;
					array2[num3] = (b = (byte)(array[(long)intPtr] + 1));
					if (b == 0)
					{
						int num4 = num - 1;
						if (uint.MaxValue != 0)
						{
							num = num4;
						}
						continue;
					}
				}
				byte[] array3 = new byte[16];
				byte[] array4;
				if (8u != 0)
				{
					array4 = array3;
				}
				byte[] cust;
				int num5;
				if (0 == 0)
				{
					_ComparatorFilter._0001(broadcasterList, 0, array4, 0);
					if (recordList)
					{
						byte[] consumerFilter = _ConsumerFilter;
						int length = 16 - num_cust;
						if (0 == 0)
						{
							Array.Copy(consumerFilter, num_cust, array4, num_cust, length);
						}
						if (5 == 0)
						{
							continue;
						}
						if (3u != 0)
						{
							cust = array4;
						}
					}
					else
					{
						if (8 == 0)
						{
							continue;
						}
						if (8u != 0)
						{
							cust = config;
						}
					}
					num5 = num_cust - 1;
				}
				goto IL_00e5;
				IL_00e5:
				if (num5 < 0)
				{
					MappingIteratorMapping.ValidateDic(m_ClientList, cust);
					break;
				}
				byte[] array5 = array = array4;
				int num6 = num5;
				intPtr = (IntPtr)num6;
				array5[num6] = (byte)(array[(long)intPtr] ^ config[num5]);
				role[var12_amount + num5] = array4[num5];
				if (5 == 0)
				{
					break;
				}
				num2 = num5;
				goto IL_00e2;
				IL_00e2:
				num5 = num2 - 1;
				goto IL_00e5;
			}
			procFilter._0002(m_ClientList);
			requestList += (ulong)num_cust;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] RunDic(byte[] value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] array2;
			if (0 == 0)
			{
				byte[] array = new byte[16];
				if (3u != 0)
				{
					array2 = array;
				}
			}
			int num = default(int);
			if (0 == 0)
			{
				num = 0;
			}
			if (0 == 0)
			{
			}
			int num5 = default(int);
			while (num < value.Length)
			{
				byte[] array3 = new byte[16];
				byte[] array4;
				if (8u != 0)
				{
					array4 = array3;
				}
				int num2 = value.Length - num;
				int num3 = 16;
				if (num3 != 0)
				{
					int num4 = Math.Min(num2, num3);
					if (0 == 0)
					{
						num5 = num4;
					}
					int sourceIndex = num;
					int length = num5;
					if (0 == 0)
					{
						Array.Copy(value, sourceIndex, array4, 0, length);
					}
					if (uint.MaxValue != 0)
					{
						MappingIteratorMapping.ValidateDic(array2, array4);
					}
					procFilter._0002(array2);
					num2 = num;
					goto IL_0079;
				}
				goto IL_007b;
				IL_007b:
				num2 += num3;
				if (5u != 0)
				{
					num = num2;
					continue;
				}
				goto IL_0079;
				IL_0079:
				num3 = 16;
				goto IL_007b;
			}
			return array2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CompareDic(ulong var1_X, byte[] vis, int versionc)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ulong num = var1_X;
			while (true)
			{
				int positionlast = (int)(num >> 32);
				if (0 == 0)
				{
					QueueList.MapDic((uint)positionlast, vis, versionc);
				}
				while (true)
				{
					num = var1_X;
					if (false)
					{
						break;
					}
					int positionlast2 = (int)num;
					int role = versionc + 4;
					if (3u != 0)
					{
						QueueList.MapDic((uint)positionlast2, vis, role);
					}
					if (8u != 0)
					{
						return;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FilterInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ConsumerFilter = new byte[16];
		}
	}
}
