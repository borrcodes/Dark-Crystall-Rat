using _0008;
using GDBD.Workers;
using Newtonsoft.Candidates;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Mocks
{
	[_0008._0012(0)]
	internal struct InfoComposer
	{
		public int valueComposer;

		public int m_ParameterComposer;

		public int prototypeComposer;

		public int m_ParserComposer;

		public int m_StatusComposer;

		public int _PageComposer;

		public int _HelperComposer;

		public int _ExceptionComposer;

		public int attributeComposer;

		public ExceptionDicCandidate m_DatabaseComposer;

		private char[] m_FactoryComposer;

		private int serializerComposer;

		private static readonly int[] callbackComposer;

		private static readonly int merchantComposer;

		private static readonly int listenerComposer;

		private static readonly int m_TagComposer;

		private static readonly int specificationComposer;

		private static readonly int m_WriterComposer;

		private static readonly int roleComposer;

		private static readonly int creatorComposer;

		private static readonly int ruleComposer;

		private static readonly int bridgeComposer;

		private static readonly int _ImporterComposer;

		private static readonly int reponseComposer;

		private static readonly int _IndexerComposer;

		private static readonly int decoratorComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			callbackComposer = new int[7]
			{
				-1,
				10,
				100,
				1000,
				10000,
				100000,
				1000000
			};
			merchantComposer = "yyyy".Length;
			listenerComposer = "yyyy-".Length;
			m_TagComposer = "yyyy-MM".Length;
			specificationComposer = "yyyy-MM-".Length;
			m_WriterComposer = "yyyy-MM-dd".Length;
			roleComposer = "yyyy-MM-ddT".Length;
			creatorComposer = "HH".Length;
			ruleComposer = "HH:".Length;
			bridgeComposer = "HH:mm".Length;
			_ImporterComposer = "HH:mm:".Length;
			reponseComposer = "HH:mm:ss".Length;
			_IndexerComposer = "-".Length;
			decoratorComposer = "-zz".Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ConnectProperty(char[] config, int attr_low, int index_comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_FactoryComposer = config;
			serializerComposer = attr_low + index_comp;
			if (MoveProperty(attr_low) && PrepareProperty(m_WriterComposer + attr_low, 'T') && PopProperty(roleComposer + attr_low))
			{
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveProperty(int column_spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (IncludeProperty(column_spec, out valueComposer) && 1 <= valueComposer && PrepareProperty(column_spec + merchantComposer, '-') && PushProperty(column_spec + listenerComposer, out m_ParameterComposer) && 1 <= m_ParameterComposer && m_ParameterComposer <= 12 && PrepareProperty(column_spec + m_TagComposer, '-') && PushProperty(column_spec + specificationComposer, out prototypeComposer) && 1 <= prototypeComposer)
			{
				return prototypeComposer <= DateTime.DaysInMonth(valueComposer, m_ParameterComposer);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PopProperty(int lengthparam)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (NewProperty(ref lengthparam))
			{
				return ForgotProperty(lengthparam);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool NewProperty(ref int i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!PushProperty(i, out m_ParserComposer) || m_ParserComposer > 24 || !PrepareProperty(i + creatorComposer, ':') || !PushProperty(i + ruleComposer, out m_StatusComposer) || m_StatusComposer >= 60 || !PrepareProperty(i + bridgeComposer, ':') || !PushProperty(i + _ImporterComposer, out _PageComposer) || _PageComposer >= 60 || (m_ParserComposer == 24 && (m_StatusComposer != 0 || _PageComposer != 0)))
			{
				return false;
			}
			i += reponseComposer;
			if (PrepareProperty(i, '.'))
			{
				_HelperComposer = 0;
				int num = 0;
				while (++i < serializerComposer && num < 7)
				{
					int num2 = m_FactoryComposer[i] - 48;
					if (num2 < 0 || num2 > 9)
					{
						break;
					}
					_HelperComposer = _HelperComposer * 10 + num2;
					num++;
				}
				if (num < 7)
				{
					if (num == 0)
					{
						return false;
					}
					_HelperComposer *= callbackComposer[7 - num];
				}
				if (m_ParserComposer == 24 && _HelperComposer != 0)
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ForgotProperty(int offseti)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (offseti < serializerComposer)
			{
				char c = m_FactoryComposer[offseti];
				if (c == 'Z' || c == 'z')
				{
					m_DatabaseComposer = (ExceptionDicCandidate)1;
					offseti++;
				}
				else
				{
					if (offseti + 2 < serializerComposer && PushProperty(offseti + _IndexerComposer, out _ExceptionComposer) && _ExceptionComposer <= 99)
					{
						switch (c)
						{
						case '-':
							m_DatabaseComposer = (ExceptionDicCandidate)2;
							offseti += decoratorComposer;
							break;
						case '+':
							m_DatabaseComposer = (ExceptionDicCandidate)3;
							offseti += decoratorComposer;
							break;
						}
					}
					if (offseti < serializerComposer)
					{
						if (PrepareProperty(offseti, ':'))
						{
							offseti++;
							if (offseti + 1 < serializerComposer && PushProperty(offseti, out attributeComposer) && attributeComposer <= 99)
							{
								offseti += 2;
							}
						}
						else if (offseti + 1 < serializerComposer && PushProperty(offseti, out attributeComposer) && attributeComposer <= 99)
						{
							offseti += 2;
						}
					}
				}
			}
			return offseti == serializerComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IncludeProperty(int indexOfi, out int b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (indexOfi + 3 < serializerComposer)
			{
				int num = m_FactoryComposer[indexOfi] - 48;
				int num2 = m_FactoryComposer[indexOfi + 1] - 48;
				int num3 = m_FactoryComposer[indexOfi + 2] - 48;
				int num4 = m_FactoryComposer[indexOfi + 3] - 48;
				if (0 <= num && num < 10 && 0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10)
				{
					b = ((num * 10 + num2) * 10 + num3) * 10 + num4;
					return true;
				}
			}
			b = 0;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PushProperty(int min_v, out int counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (min_v + 1 < serializerComposer)
			{
				int num = m_FactoryComposer[min_v] - 48;
				int num2 = m_FactoryComposer[min_v + 1] - 48;
				if (0 <= num && num < 10 && 0 <= num2 && num2 < 10)
				{
					counter = num * 10 + num2;
					return true;
				}
			}
			counter = 0;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PrepareProperty(int position_instance, char vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (position_instance < serializerComposer)
			{
				return m_FactoryComposer[position_instance] == vis;
			}
			return false;
		}
	}
}
