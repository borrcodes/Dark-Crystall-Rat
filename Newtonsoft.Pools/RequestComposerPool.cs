using _0008;
using GDBD.Bridges;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	[_0008._0012(0)]
	internal sealed class RequestComposerPool : TagTestItem, IdentifierClientBridge
	{
		private readonly TextReader m_ErrorComposer;

		[_0008._0012(2)]
		private char[] m_ComposerComposer;

		private int propertyComposer;

		private int _IssuerComposer;

		private int m_ReaderComposer;

		private int _ClientComposer;

		private bool broadcasterComposer;

		private PoolErrorFilter classComposer;

		private InvocationTest m_RequestComposer;

		[_0008._0012(2)]
		private GDBD.Workers.WrapperComposerWorker<char> _IteratorComposer;

		[CompilerGenerated]
		[_0008._0012(2)]
		private ObjectDic m_TestsComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestComposerPool(TextReader ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			if (ident == null)
			{
				throw new ArgumentNullException("reader");
			}
			m_ErrorComposer = ident;
			_ClientComposer = 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new ObjectDic _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TestsComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(ObjectDic v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_TestsComposer = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (classComposer._0001())
			{
				classComposer = new PoolErrorFilter(_IteratorComposer, 1024);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectComposer(bool isv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (isv && m_ComposerComposer[_IssuerComposer] == '\n')
			{
				_IssuerComposer++;
			}
			MoveComposer(_IssuerComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveComposer(int ID_value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ClientComposer++;
			m_ReaderComposer = ID_value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopComposer(char key, Docking ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerComposer++;
			IncludeComposer();
			SetComposer(key);
			NewComposer(key, ivk);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NewComposer(char init, Docking vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ExcludeError(countitem: true);
			switch (vis)
			{
			case (Docking)1:
			case (Docking)5:
			case (Docking)9:
				return;
			case (Docking)3:
			{
				Guid connection;
				byte[] reg2 = (m_RequestComposer._0002() == 0) ? ObserverIteratorMapping.CheckProperty<byte>() : ((m_RequestComposer._0002() != 36 || !HelperDicCandidate.VisitProperty(m_RequestComposer.ToString(), out connection)) ? Convert.FromBase64CharArray(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002()) : connection.ToByteArray());
				CancelError(WatcherComposer.Bytes, reg2, isstate: false);
				return;
			}
			case (Docking)4:
			{
				string reg = m_RequestComposer.ToString();
				CancelError(WatcherComposer.String, reg, isstate: false);
				m_StateError = init;
				return;
			}
			}
			if (_IdentifierError != 0)
			{
				StubListAnnotation stubListAnnotation;
				switch (vis)
				{
				case (Docking)6:
					stubListAnnotation = (StubListAnnotation)1;
					break;
				case (Docking)7:
					stubListAnnotation = (StubListAnnotation)2;
					break;
				default:
					stubListAnnotation = _IdentifierError;
					break;
				}
				DateTimeOffset res;
				if (stubListAnnotation == (StubListAnnotation)1)
				{
					if (DescriptorIteratorMapping.RateProperty(m_RequestComposer, base._0001(), base._0003(), base._0001(), out DateTime attr))
					{
						CancelError(WatcherComposer.Date, attr, isstate: false);
						return;
					}
				}
				else if (DescriptorIteratorMapping.PostProperty(m_RequestComposer, base._0003(), base._0001(), out res))
				{
					CancelError(WatcherComposer.Date, res, isstate: false);
					return;
				}
			}
			CancelError(WatcherComposer.String, m_RequestComposer.ToString(), isstate: false);
			m_StateError = init;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ForgotComposer(char[] item, int indexOfcaller, char[] third, int pol2_Low, int nextcaller3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Buffer.BlockCopy(item, indexOfcaller * 2, third, pol2_Low * 2, nextcaller3 * 2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IncludeComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = m_ComposerComposer.Length;
			if ((double)(num - _IssuerComposer) <= (double)num * 0.1 || num >= 1073741823)
			{
				int num2 = propertyComposer - _IssuerComposer;
				if (num2 > 0)
				{
					ForgotComposer(m_ComposerComposer, _IssuerComposer, m_ComposerComposer, 0, num2);
				}
				m_ReaderComposer -= _IssuerComposer;
				_IssuerComposer = 0;
				propertyComposer = num2;
				m_ComposerComposer[propertyComposer] = '\0';
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int PushComposer(bool isconfig)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return AwakeComposer(isconfig, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PrepareComposer(bool countinit, int indexOfcol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (propertyComposer + indexOfcol < m_ComposerComposer.Length - 1)
			{
				return;
			}
			if (countinit)
			{
				int num = m_ComposerComposer.Length * 2;
				int iD_vis = Math.Max((num < 0) ? int.MaxValue : num, propertyComposer + indexOfcol + 1);
				char[] array = ValueFilterResolver.RegisterIssuer(_IteratorComposer, iD_vis);
				ForgotComposer(m_ComposerComposer, 0, array, 0, m_ComposerComposer.Length);
				ValueFilterResolver.RestartIssuer(_IteratorComposer, m_ComposerComposer);
				m_ComposerComposer = array;
				return;
			}
			int num2 = propertyComposer - _IssuerComposer;
			if (num2 + indexOfcol + 1 >= m_ComposerComposer.Length)
			{
				char[] array2 = ValueFilterResolver.RegisterIssuer(_IteratorComposer, num2 + indexOfcol + 1);
				if (num2 > 0)
				{
					ForgotComposer(m_ComposerComposer, _IssuerComposer, array2, 0, num2);
				}
				ValueFilterResolver.RestartIssuer(_IteratorComposer, m_ComposerComposer);
				m_ComposerComposer = array2;
			}
			else if (num2 > 0)
			{
				ForgotComposer(m_ComposerComposer, _IssuerComposer, m_ComposerComposer, 0, num2);
			}
			m_ReaderComposer -= _IssuerComposer;
			_IssuerComposer = 0;
			propertyComposer = num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int AwakeComposer(bool issetup, int connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (broadcasterComposer)
			{
				return 0;
			}
			PrepareComposer(issetup, connection);
			int count = m_ComposerComposer.Length - propertyComposer - 1;
			int num = m_ErrorComposer.Read(m_ComposerComposer, propertyComposer, count);
			propertyComposer += num;
			if (num == 0)
			{
				broadcasterComposer = true;
			}
			m_ComposerComposer[propertyComposer] = '\0';
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool UpdateComposer(int asset, bool issecond)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_IssuerComposer + asset >= propertyComposer)
			{
				return ReadComposer(asset, issecond);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ReadComposer(int last, bool allowselection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (broadcasterComposer)
			{
				return false;
			}
			int num = _IssuerComposer + last - propertyComposer + 1;
			int num2 = 0;
			do
			{
				int num3 = AwakeComposer(allowselection, num - num2);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
			}
			while (num2 < num);
			if (num2 < num)
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DestroyComposer();
			do
			{
				switch (resolverError)
				{
				case (MethodAttributes)0:
				case (MethodAttributes)2:
				case (MethodAttributes)5:
				case (MethodAttributes)6:
				case (MethodAttributes)9:
				case (MethodAttributes)10:
					return CountComposer();
				case (MethodAttributes)3:
				case (MethodAttributes)4:
					return DeleteComposer();
				case (MethodAttributes)8:
					break;
				case (MethodAttributes)12:
					if (UpdateComposer(0, issecond: false))
					{
						QueryComposer();
						if (broadcasterComposer)
						{
							CustomizeError(WatcherComposer.None);
							return false;
						}
						if (m_ComposerComposer[_IssuerComposer] == '/')
						{
							DefineComposer(isi: true);
							return true;
						}
						throw ContextError.CheckComposer(this, "Additional text encountered after finished reading JSON content: {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
					}
					CustomizeError(WatcherComposer.None);
					return false;
				default:
					throw ContextError.CheckComposer(this, "Unexpected state: {0}.".ListReader(CultureInfo.InvariantCulture, base._0001()));
				}
			}
			while (!SelectComposer(striplast: false));
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (int?)ResetComposer((Docking)1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTime? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (DateTime?)InterruptComposer((Docking)6);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (string)InterruptComposer((Docking)4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DestroyComposer();
			bool flag = false;
			switch (resolverError)
			{
			case (MethodAttributes)8:
				if (SelectComposer(striplast: true))
				{
					return null;
				}
				goto case (MethodAttributes)0;
			case (MethodAttributes)0:
			case (MethodAttributes)2:
			case (MethodAttributes)5:
			case (MethodAttributes)6:
			case (MethodAttributes)9:
			case (MethodAttributes)10:
				while (true)
				{
					char c = m_ComposerComposer[_IssuerComposer];
					switch (c)
					{
					case '\0':
						if (ComputeComposer())
						{
							CancelError(WatcherComposer.None, null, isstate: false);
							return null;
						}
						break;
					case '"':
					case '\'':
					{
						PopComposer(c, (Docking)3);
						byte[] array = (byte[])((TagTestItem)this)._0001();
						if (flag)
						{
							InvokeError();
							if (((TagTestItem)this)._0001() != WatcherComposer.EndObject)
							{
								throw ContextError.CheckComposer(this, "Error reading bytes. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, ((TagTestItem)this)._0001()));
							}
							CancelError(WatcherComposer.Bytes, array, isstate: false);
						}
						return array;
					}
					case '{':
						_IssuerComposer++;
						CustomizeError(WatcherComposer.StartObject);
						CountError();
						flag = true;
						break;
					case '[':
						_IssuerComposer++;
						CustomizeError(WatcherComposer.StartArray);
						return ChangeError();
					case 'n':
						RestartComposer();
						return null;
					case '/':
						DefineComposer(isi: false);
						break;
					case ',':
						ReflectComposer();
						break;
					case ']':
						_IssuerComposer++;
						if (resolverError == (MethodAttributes)6 || resolverError == (MethodAttributes)5 || resolverError == (MethodAttributes)8)
						{
							CustomizeError(WatcherComposer.EndArray);
							return null;
						}
						throw InstantiateComposer(c);
					case '\r':
						CustomizeComposer(isvar1: false);
						break;
					case '\n':
						AssetComposer();
						break;
					case '\t':
					case ' ':
						_IssuerComposer++;
						break;
					default:
						_IssuerComposer++;
						if (!char.IsWhiteSpace(c))
						{
							throw InstantiateComposer(c);
						}
						break;
					}
				}
			case (MethodAttributes)12:
				SearchComposer();
				return null;
			default:
				throw ContextError.CheckComposer(this, "Unexpected state: {0}.".ListReader(CultureInfo.InvariantCulture, base._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object InterruptComposer(Docking reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DestroyComposer();
			switch (resolverError)
			{
			case (MethodAttributes)8:
				if (SelectComposer(striplast: true))
				{
					return null;
				}
				goto case (MethodAttributes)0;
			case (MethodAttributes)0:
			case (MethodAttributes)2:
			case (MethodAttributes)5:
			case (MethodAttributes)6:
			case (MethodAttributes)9:
			case (MethodAttributes)10:
				while (true)
				{
					char c = m_ComposerComposer[_IssuerComposer];
					switch (c)
					{
					case '\0':
						if (ComputeComposer())
						{
							CancelError(WatcherComposer.None, null, isstate: false);
							return null;
						}
						break;
					case '"':
					case '\'':
						PopComposer(c, reference);
						return CalcComposer(reference);
					case '-':
						if (UpdateComposer(1, issecond: true) && m_ComposerComposer[_IssuerComposer + 1] == 'I')
						{
							return VerifyTest(reference);
						}
						ExcludeComposer(reference);
						return ((TagTestItem)this)._0001();
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						if (reference != (Docking)4)
						{
							_IssuerComposer++;
							throw InstantiateComposer(c);
						}
						ExcludeComposer((Docking)4);
						return ((TagTestItem)this)._0001();
					case 'f':
					case 't':
					{
						if (reference != (Docking)4)
						{
							_IssuerComposer++;
							throw InstantiateComposer(c);
						}
						string text = (c == 't') ? ProcConsumer._ErrorError : ProcConsumer.composerError;
						if (!PublishComposer(text))
						{
							throw InstantiateComposer(m_ComposerComposer[_IssuerComposer]);
						}
						QueryError(WatcherComposer.String, text);
						return text;
					}
					case 'I':
						return FindTest(reference);
					case 'N':
						return OrderTest(reference);
					case 'n':
						RestartComposer();
						return null;
					case '/':
						DefineComposer(isi: false);
						break;
					case ',':
						ReflectComposer();
						break;
					case ']':
						_IssuerComposer++;
						if (resolverError == (MethodAttributes)6 || resolverError == (MethodAttributes)5 || resolverError == (MethodAttributes)8)
						{
							CustomizeError(WatcherComposer.EndArray);
							return null;
						}
						throw InstantiateComposer(c);
					case '\r':
						CustomizeComposer(isvar1: false);
						break;
					case '\n':
						AssetComposer();
						break;
					case '\t':
					case ' ':
						_IssuerComposer++;
						break;
					default:
						_IssuerComposer++;
						if (!char.IsWhiteSpace(c))
						{
							throw InstantiateComposer(c);
						}
						break;
					}
				}
			case (MethodAttributes)12:
				SearchComposer();
				return null;
			default:
				throw ContextError.CheckComposer(this, "Unexpected state: {0}.".ListReader(CultureInfo.InvariantCulture, base._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object CalcComposer(Docking info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (info)
			{
			case (Docking)3:
			case (Docking)4:
				return ((TagTestItem)this)._0001();
			case (Docking)6:
			{
				object obj = ((TagTestItem)this)._0001();
				if (obj is DateTime)
				{
					DateTime dateTime = (DateTime)obj;
					return dateTime;
				}
				return DeleteError((string)((TagTestItem)this)._0001());
			}
			case (Docking)7:
			{
				object obj = ((TagTestItem)this)._0001();
				if (obj is DateTimeOffset)
				{
					DateTimeOffset dateTimeOffset = (DateTimeOffset)obj;
					return dateTimeOffset;
				}
				return ConcatError((string)((TagTestItem)this)._0001());
			}
			default:
				throw new ArgumentOutOfRangeException("readType");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ContextError InstantiateComposer(char key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ContextError.CheckComposer(this, "Unexpected character encountered while parsing value: {0}.".ListReader(CultureInfo.InvariantCulture, key));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DestroyComposer();
			switch (resolverError)
			{
			case (MethodAttributes)8:
				if (SelectComposer(striplast: true))
				{
					return null;
				}
				goto case (MethodAttributes)0;
			case (MethodAttributes)0:
			case (MethodAttributes)2:
			case (MethodAttributes)5:
			case (MethodAttributes)6:
			case (MethodAttributes)9:
			case (MethodAttributes)10:
				while (true)
				{
					char c = m_ComposerComposer[_IssuerComposer];
					switch (c)
					{
					case '\0':
						if (ComputeComposer())
						{
							CancelError(WatcherComposer.None, null, isstate: false);
							return null;
						}
						break;
					case '"':
					case '\'':
						PopComposer(c, (Docking)0);
						return StartError(m_RequestComposer.ToString());
					case 'n':
						RestartComposer();
						return null;
					case '-':
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					{
						ExcludeComposer((Docking)0);
						object obj = ((TagTestItem)this)._0001();
						bool flag2;
						if (obj is BigInteger)
						{
							BigInteger left = (BigInteger)obj;
							flag2 = (left != 0L);
						}
						else
						{
							flag2 = Convert.ToBoolean(((TagTestItem)this)._0001(), CultureInfo.InvariantCulture);
						}
						CancelError(WatcherComposer.Boolean, flag2, isstate: false);
						return flag2;
					}
					case 'f':
					case 't':
					{
						bool flag = c == 't';
						string asset = flag ? ProcConsumer._ErrorError : ProcConsumer.composerError;
						if (!PublishComposer(asset))
						{
							throw InstantiateComposer(m_ComposerComposer[_IssuerComposer]);
						}
						QueryError(WatcherComposer.Boolean, flag);
						return flag;
					}
					case '/':
						DefineComposer(isi: false);
						break;
					case ',':
						ReflectComposer();
						break;
					case ']':
						_IssuerComposer++;
						if (resolverError == (MethodAttributes)6 || resolverError == (MethodAttributes)5 || resolverError == (MethodAttributes)8)
						{
							CustomizeError(WatcherComposer.EndArray);
							return null;
						}
						throw InstantiateComposer(c);
					case '\r':
						CustomizeComposer(isvar1: false);
						break;
					case '\n':
						AssetComposer();
						break;
					case '\t':
					case ' ':
						_IssuerComposer++;
						break;
					default:
						_IssuerComposer++;
						if (!char.IsWhiteSpace(c))
						{
							throw InstantiateComposer(c);
						}
						break;
					}
				}
			case (MethodAttributes)12:
				SearchComposer();
				return null;
			default:
				throw ContextError.CheckComposer(this, "Unexpected state: {0}.".ListReader(CultureInfo.InvariantCulture, base._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReflectComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerComposer++;
			if (resolverError != (MethodAttributes)8)
			{
				CustomizeError(WatcherComposer.Undefined);
				ContextError contextError = InstantiateComposer(',');
				_IssuerComposer--;
				throw contextError;
			}
			InitError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ResetComposer(Docking last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DestroyComposer();
			switch (resolverError)
			{
			case (MethodAttributes)8:
				if (SelectComposer(striplast: true))
				{
					return null;
				}
				goto case (MethodAttributes)0;
			case (MethodAttributes)0:
			case (MethodAttributes)2:
			case (MethodAttributes)5:
			case (MethodAttributes)6:
			case (MethodAttributes)9:
			case (MethodAttributes)10:
				while (true)
				{
					char c = m_ComposerComposer[_IssuerComposer];
					switch (c)
					{
					case '\0':
						if (ComputeComposer())
						{
							CancelError(WatcherComposer.None, null, isstate: false);
							return null;
						}
						break;
					case '"':
					case '\'':
						PopComposer(c, last);
						return RegisterComposer(last);
					case 'n':
						RestartComposer();
						return null;
					case 'N':
						return OrderTest(last);
					case 'I':
						return FindTest(last);
					case '-':
						if (UpdateComposer(1, issecond: true) && m_ComposerComposer[_IssuerComposer + 1] == 'I')
						{
							return VerifyTest(last);
						}
						ExcludeComposer(last);
						return ((TagTestItem)this)._0001();
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						ExcludeComposer(last);
						return ((TagTestItem)this)._0001();
					case '/':
						DefineComposer(isi: false);
						break;
					case ',':
						ReflectComposer();
						break;
					case ']':
						_IssuerComposer++;
						if (resolverError == (MethodAttributes)6 || resolverError == (MethodAttributes)5 || resolverError == (MethodAttributes)8)
						{
							CustomizeError(WatcherComposer.EndArray);
							return null;
						}
						throw InstantiateComposer(c);
					case '\r':
						CustomizeComposer(isvar1: false);
						break;
					case '\n':
						AssetComposer();
						break;
					case '\t':
					case ' ':
						_IssuerComposer++;
						break;
					default:
						_IssuerComposer++;
						if (!char.IsWhiteSpace(c))
						{
							throw InstantiateComposer(c);
						}
						break;
					}
				}
			case (MethodAttributes)12:
				SearchComposer();
				return null;
			default:
				throw ContextError.CheckComposer(this, "Unexpected state: {0}.".ListReader(CultureInfo.InvariantCulture, base._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object RegisterComposer(Docking res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (res)
			{
			case (Docking)1:
				return PostError(m_RequestComposer.ToString());
			case (Docking)5:
				return SelectError(m_RequestComposer.ToString());
			case (Docking)8:
				return GetError(m_RequestComposer.ToString());
			default:
				throw new ArgumentOutOfRangeException("readType");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTimeOffset? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (DateTimeOffset?)InterruptComposer((Docking)7);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override decimal? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (decimal?)ResetComposer((Docking)5);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (double?)ResetComposer((Docking)8);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RestartComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (UpdateComposer(1, issecond: true))
			{
				if (m_ComposerComposer[_IssuerComposer + 1] == 'u')
				{
					LoginTest();
					return;
				}
				_IssuerComposer += 2;
				throw InstantiateComposer(m_ComposerComposer[_IssuerComposer - 1]);
			}
			_IssuerComposer = propertyComposer;
			throw PrintError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SearchComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (UpdateComposer(0, issecond: false))
			{
				QueryComposer();
				if (broadcasterComposer)
				{
					return;
				}
				if (m_ComposerComposer[_IssuerComposer] != '/')
				{
					throw ContextError.CheckComposer(this, "Additional text encountered after finished reading JSON content: {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
				}
				DefineComposer(isi: false);
			}
			CustomizeError(WatcherComposer.None);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ComputeComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (propertyComposer == _IssuerComposer)
			{
				if (PushComposer(isconfig: false) == 0)
				{
					broadcasterComposer = true;
					return true;
				}
			}
			else
			{
				_IssuerComposer++;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DestroyComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ComposerComposer == null)
			{
				m_ComposerComposer = ValueFilterResolver.RegisterIssuer(_IteratorComposer, 1024);
				m_ComposerComposer[0] = '\0';
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetComposer(char task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = _IssuerComposer;
			int issuerComposer = _IssuerComposer;
			int num2 = _IssuerComposer;
			classComposer._0001(0);
			while (true)
			{
				switch (m_ComposerComposer[num++])
				{
				case '\0':
					if (propertyComposer == num - 1)
					{
						num--;
						if (PushComposer(isconfig: true) == 0)
						{
							_IssuerComposer = num;
							throw ContextError.CheckComposer(this, "Unterminated string. Expected delimiter: {0}.".ListReader(CultureInfo.InvariantCulture, task));
						}
					}
					break;
				case '\\':
				{
					_IssuerComposer = num;
					if (!UpdateComposer(0, issecond: true))
					{
						throw ContextError.CheckComposer(this, "Unterminated string. Expected delimiter: {0}.".ListReader(CultureInfo.InvariantCulture, task));
					}
					int fieldstart = num - 1;
					char c = m_ComposerComposer[num];
					num++;
					char c2;
					switch (c)
					{
					case 'b':
						c2 = '\b';
						break;
					case 't':
						c2 = '\t';
						break;
					case 'n':
						c2 = '\n';
						break;
					case 'f':
						c2 = '\f';
						break;
					case 'r':
						c2 = '\r';
						break;
					case '\\':
						c2 = '\\';
						break;
					case '"':
					case '\'':
					case '/':
						c2 = c;
						break;
					case 'u':
						_IssuerComposer = num;
						c2 = ChangeComposer();
						if (SetterTest.CancelReader(c2))
						{
							c2 = '\ufffd';
						}
						else if (SetterTest.QueryReader(c2))
						{
							bool flag;
							do
							{
								flag = false;
								if (UpdateComposer(2, issecond: true) && m_ComposerComposer[_IssuerComposer] == '\\' && m_ComposerComposer[_IssuerComposer + 1] == 'u')
								{
									char init = c2;
									_IssuerComposer += 2;
									c2 = ChangeComposer();
									if (!SetterTest.CancelReader(c2))
									{
										if (SetterTest.QueryReader(c2))
										{
											init = '\ufffd';
											flag = true;
										}
										else
										{
											init = '\ufffd';
										}
									}
									ViewComposer();
									RemoveComposer(init, num2, fieldstart);
									num2 = _IssuerComposer;
								}
								else
								{
									c2 = '\ufffd';
								}
							}
							while (flag);
						}
						num = _IssuerComposer;
						break;
					default:
						_IssuerComposer = num;
						throw ContextError.CheckComposer(this, "Bad JSON escape sequence: {0}.".ListReader(CultureInfo.InvariantCulture, "\\" + c));
					}
					ViewComposer();
					RemoveComposer(c2, num2, fieldstart);
					num2 = num;
					break;
				}
				case '\r':
					_IssuerComposer = num - 1;
					CustomizeComposer(isvar1: true);
					num = _IssuerComposer;
					break;
				case '\n':
					_IssuerComposer = num - 1;
					AssetComposer();
					num = _IssuerComposer;
					break;
				case '"':
				case '\'':
					if (m_ComposerComposer[num - 1] == task)
					{
						RateComposer(num - 1, issuerComposer, num2);
						return;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RateComposer(int column_reference, int attr_low, int idx_c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr_low == idx_c)
			{
				m_RequestComposer = new InvocationTest(m_ComposerComposer, attr_low, column_reference - attr_low);
			}
			else
			{
				ViewComposer();
				if (column_reference > idx_c)
				{
					classComposer.DestroyReader(_IteratorComposer, m_ComposerComposer, idx_c, column_reference - idx_c);
				}
				m_RequestComposer = new InvocationTest(classComposer._0001(), 0, classComposer._0001());
			}
			_IssuerComposer = column_reference + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveComposer(char init, int b_Ptr, int fieldstart)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (fieldstart > b_Ptr)
			{
				classComposer.DestroyReader(_IteratorComposer, m_ComposerComposer, b_Ptr, fieldstart - b_Ptr);
			}
			classComposer.ComputeReader(_IteratorComposer, init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char PostComposer(bool injectfirst)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (injectfirst)
			{
				if (HelperDicCandidate.ViewProperty(m_ComposerComposer, _IssuerComposer, _IssuerComposer + 4, out int selection))
				{
					char result = Convert.ToChar(selection);
					_IssuerComposer += 4;
					return result;
				}
				throw ContextError.CheckComposer(this, "Invalid Unicode escape sequence: \\u{0}.".ListReader(CultureInfo.InvariantCulture, new string(m_ComposerComposer, _IssuerComposer, 4)));
			}
			throw ContextError.CheckComposer(this, "Unexpected end while parsing Unicode escape sequence.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char ChangeComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PostComposer(UpdateComposer(4, issecond: true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CalculateComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = _IssuerComposer;
			while (true)
			{
				char c = m_ComposerComposer[num];
				if (c == '\0')
				{
					_IssuerComposer = num;
					if (propertyComposer != num || PushComposer(isconfig: true) == 0)
					{
						break;
					}
				}
				else
				{
					if (GetComposer(c, num))
					{
						break;
					}
					num++;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool GetComposer(char spec, int rowreg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (spec)
			{
			case '+':
			case '-':
			case '.':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'X':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'x':
				return false;
			default:
				_IssuerComposer = rowreg;
				if (char.IsWhiteSpace(spec) || spec == ',' || spec == '}' || spec == ']' || spec == ')' || spec == '/')
				{
					return true;
				}
				throw ContextError.CheckComposer(this, "Unexpected character encountered while parsing number: {0}.".ListReader(CultureInfo.InvariantCulture, spec));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			classComposer._0001(0);
			m_RequestComposer = default(InvocationTest);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SelectComposer(bool striplast)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (true)
			{
				char c = m_ComposerComposer[_IssuerComposer];
				switch (c)
				{
				case '\0':
					if (propertyComposer == _IssuerComposer)
					{
						if (PushComposer(isconfig: false) == 0)
						{
							resolverError = (MethodAttributes)12;
							return false;
						}
					}
					else
					{
						_IssuerComposer++;
					}
					continue;
				case '}':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.EndObject);
					return true;
				case ']':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.EndArray);
					return true;
				case ')':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.EndConstructor);
					return true;
				case '/':
					DefineComposer(!striplast);
					if (!striplast)
					{
						return true;
					}
					continue;
				case ',':
					_IssuerComposer++;
					InitError();
					return false;
				case '\t':
				case ' ':
					_IssuerComposer++;
					continue;
				case '\r':
					CustomizeComposer(isvar1: false);
					continue;
				case '\n':
					AssetComposer();
					continue;
				}
				if (char.IsWhiteSpace(c))
				{
					_IssuerComposer++;
					continue;
				}
				if (_0004() && ((TagTestItem)this)._0003() == 0)
				{
					InitError();
					return false;
				}
				throw ContextError.CheckComposer(this, "After parsing a value an unexpected character was encountered: {0}.".ListReader(CultureInfo.InvariantCulture, c));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeleteComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (true)
			{
				char c = m_ComposerComposer[_IssuerComposer];
				switch (c)
				{
				case '\0':
					if (propertyComposer == _IssuerComposer)
					{
						if (PushComposer(isconfig: false) == 0)
						{
							return false;
						}
					}
					else
					{
						_IssuerComposer++;
					}
					break;
				case '}':
					CustomizeError(WatcherComposer.EndObject);
					_IssuerComposer++;
					return true;
				case '/':
					DefineComposer(isi: true);
					return true;
				case '\r':
					CustomizeComposer(isvar1: false);
					break;
				case '\n':
					AssetComposer();
					break;
				case '\t':
				case ' ':
					_IssuerComposer++;
					break;
				default:
					if (char.IsWhiteSpace(c))
					{
						_IssuerComposer++;
						break;
					}
					return TestComposer();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TestComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			char c = m_ComposerComposer[_IssuerComposer];
			char c2;
			if (c == '"' || c == '\'')
			{
				_IssuerComposer++;
				c2 = c;
				IncludeComposer();
				SetComposer(c2);
			}
			else
			{
				if (!ConcatComposer(c))
				{
					throw ContextError.CheckComposer(this, "Invalid property identifier character: {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
				}
				c2 = '\0';
				IncludeComposer();
				InvokeComposer();
			}
			string text;
			if (this._0001() != null)
			{
				text = this._0001()._0001(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002());
				if (text == null)
				{
					text = m_RequestComposer.ToString();
				}
			}
			else
			{
				text = m_RequestComposer.ToString();
			}
			QueryComposer();
			if (m_ComposerComposer[_IssuerComposer] != ':')
			{
				throw ContextError.CheckComposer(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
			}
			_IssuerComposer++;
			QueryError(WatcherComposer.PropertyName, text);
			m_StateError = c2;
			StartComposer();
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConcatComposer(char i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!char.IsLetterOrDigit(i) && i != '_')
			{
				return i == '$';
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InvokeComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int issuerComposer = _IssuerComposer;
			while (true)
			{
				char c = m_ComposerComposer[_IssuerComposer];
				if (c == '\0')
				{
					if (propertyComposer != _IssuerComposer)
					{
						break;
					}
					if (PushComposer(isconfig: true) == 0)
					{
						throw ContextError.CheckComposer(this, "Unexpected end while parsing unquoted property name.");
					}
				}
				else if (PrintComposer(c, issuerComposer))
				{
					return;
				}
			}
			m_RequestComposer = new InvocationTest(m_ComposerComposer, issuerComposer, _IssuerComposer - issuerComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PrintComposer(char res, int nextsecond)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ConcatComposer(res))
			{
				_IssuerComposer++;
				return false;
			}
			if (char.IsWhiteSpace(res) || res == ':')
			{
				m_RequestComposer = new InvocationTest(m_ComposerComposer, nextsecond, _IssuerComposer - nextsecond);
				return true;
			}
			throw ContextError.CheckComposer(this, "Invalid JavaScript property identifier character: {0}.".ListReader(CultureInfo.InvariantCulture, res));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CountComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (true)
			{
				char c = m_ComposerComposer[_IssuerComposer];
				switch (c)
				{
				case '\0':
					if (propertyComposer == _IssuerComposer)
					{
						if (PushComposer(isconfig: false) == 0)
						{
							return false;
						}
					}
					else
					{
						_IssuerComposer++;
					}
					break;
				case '"':
				case '\'':
					PopComposer(c, (Docking)0);
					return true;
				case 't':
					RevertComposer();
					return true;
				case 'f':
					DisableTest();
					return true;
				case 'n':
					if (UpdateComposer(1, issecond: true))
					{
						switch (m_ComposerComposer[_IssuerComposer + 1])
						{
						case 'u':
							LoginTest();
							break;
						case 'e':
							CancelComposer();
							break;
						default:
							throw InstantiateComposer(m_ComposerComposer[_IssuerComposer]);
						}
						return true;
					}
					_IssuerComposer++;
					throw PrintError();
				case 'N':
					OrderTest((Docking)0);
					return true;
				case 'I':
					FindTest((Docking)0);
					return true;
				case '-':
					if (UpdateComposer(1, issecond: true) && m_ComposerComposer[_IssuerComposer + 1] == 'I')
					{
						VerifyTest((Docking)0);
					}
					else
					{
						ExcludeComposer((Docking)0);
					}
					return true;
				case '/':
					DefineComposer(isi: true);
					return true;
				case 'u':
					CheckTest();
					return true;
				case '{':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.StartObject);
					return true;
				case '[':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.StartArray);
					return true;
				case ']':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.EndArray);
					return true;
				case ',':
					CustomizeError(WatcherComposer.Undefined);
					return true;
				case ')':
					_IssuerComposer++;
					CustomizeError(WatcherComposer.EndConstructor);
					return true;
				case '\r':
					CustomizeComposer(isvar1: false);
					break;
				case '\n':
					AssetComposer();
					break;
				case '\t':
				case ' ':
					_IssuerComposer++;
					break;
				default:
					if (char.IsWhiteSpace(c))
					{
						_IssuerComposer++;
						break;
					}
					if (char.IsNumber(c) || c == '-' || c == '.')
					{
						ExcludeComposer((Docking)0);
						return true;
					}
					throw InstantiateComposer(c);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AssetComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerComposer++;
			MoveComposer(_IssuerComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CustomizeComposer(bool isvar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerComposer++;
			ConnectComposer(UpdateComposer(1, isvar1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QueryComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			while (true)
			{
				char c = m_ComposerComposer[_IssuerComposer];
				switch (c)
				{
				case '\0':
					if (propertyComposer == _IssuerComposer)
					{
						if (PushComposer(isconfig: false) == 0)
						{
							return;
						}
					}
					else
					{
						_IssuerComposer++;
					}
					continue;
				case '\r':
					CustomizeComposer(isvar1: false);
					continue;
				case '\n':
					AssetComposer();
					continue;
				default:
					if (!char.IsWhiteSpace(c))
					{
						return;
					}
					break;
				case ' ':
					break;
				}
				_IssuerComposer++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PublishComposer("new"))
			{
				QueryComposer();
				int issuerComposer = _IssuerComposer;
				int issuerComposer2;
				while (true)
				{
					char c = m_ComposerComposer[_IssuerComposer];
					if (c == '\0')
					{
						if (propertyComposer == _IssuerComposer)
						{
							if (PushComposer(isconfig: true) == 0)
							{
								throw ContextError.CheckComposer(this, "Unexpected end while parsing constructor.");
							}
							continue;
						}
						issuerComposer2 = _IssuerComposer;
						_IssuerComposer++;
						break;
					}
					if (char.IsLetterOrDigit(c))
					{
						_IssuerComposer++;
						continue;
					}
					switch (c)
					{
					case '\r':
						issuerComposer2 = _IssuerComposer;
						CustomizeComposer(isvar1: true);
						break;
					case '\n':
						issuerComposer2 = _IssuerComposer;
						AssetComposer();
						break;
					default:
						if (char.IsWhiteSpace(c))
						{
							issuerComposer2 = _IssuerComposer;
							_IssuerComposer++;
							break;
						}
						if (c == '(')
						{
							issuerComposer2 = _IssuerComposer;
							break;
						}
						throw ContextError.CheckComposer(this, "Unexpected character while parsing constructor: {0}.".ListReader(CultureInfo.InvariantCulture, c));
					}
					break;
				}
				m_RequestComposer = new InvocationTest(m_ComposerComposer, issuerComposer, issuerComposer2 - issuerComposer);
				string cfg = m_RequestComposer.ToString();
				QueryComposer();
				if (m_ComposerComposer[_IssuerComposer] != '(')
				{
					throw ContextError.CheckComposer(this, "Unexpected character while parsing constructor: {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
				}
				_IssuerComposer++;
				StartComposer();
				QueryError(WatcherComposer.StartConstructor, cfg);
				return;
			}
			throw ContextError.CheckComposer(this, "Unexpected content while parsing JSON.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExcludeComposer(Docking asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IncludeComposer();
			char counter = m_ComposerComposer[_IssuerComposer];
			int issuerComposer = _IssuerComposer;
			CalculateComposer();
			SetupComposer(asset, counter, issuerComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupComposer(Docking item, char counter, int column_c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ExcludeError(countitem: true);
			m_RequestComposer = new InvocationTest(m_ComposerComposer, column_c, _IssuerComposer - column_c);
			bool flag = char.IsDigit(counter) && m_RequestComposer._0002() == 1;
			bool flag2 = counter == '0' && m_RequestComposer._0002() > 1 && m_RequestComposer._0001()[m_RequestComposer._0001() + 1] != '.' && m_RequestComposer._0001()[m_RequestComposer._0001() + 1] != 'e' && m_RequestComposer._0001()[m_RequestComposer._0001() + 1] != 'E';
			WatcherComposer instance;
			object reg;
			switch (item)
			{
			case (Docking)4:
			{
				string text5 = m_RequestComposer.ToString();
				double result3;
				if (flag2)
				{
					try
					{
						if (text5.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
						{
							Convert.ToInt64(text5, 16);
						}
						else
						{
							Convert.ToInt64(text5, 8);
						}
					}
					catch (Exception ex4)
					{
						throw ManageComposer("Input string '{0}' is not a valid number.".ListReader(CultureInfo.InvariantCulture, text5), ex4);
					}
				}
				else if (!double.TryParse(text5, NumberStyles.Float, CultureInfo.InvariantCulture, out result3))
				{
					throw ManageComposer("Input string '{0}' is not a valid number.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
				}
				instance = WatcherComposer.String;
				reg = text5;
				break;
			}
			case (Docking)1:
				if (flag)
				{
					reg = counter - 48;
				}
				else if (flag2)
				{
					string text6 = m_RequestComposer.ToString();
					try
					{
						reg = (text6.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(text6, 16) : Convert.ToInt32(text6, 8));
					}
					catch (Exception ex5)
					{
						throw ManageComposer("Input string '{0}' is not a valid integer.".ListReader(CultureInfo.InvariantCulture, text6), ex5);
					}
				}
				else
				{
					int result4;
					switch (HelperDicCandidate.StopProperty(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002(), out result4))
					{
					case (TYMED)1:
						break;
					case (TYMED)2:
						throw ManageComposer("JSON integer {0} is too large or small for an Int32.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
					default:
						throw ManageComposer("Input string '{0}' is not a valid integer.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
					}
					reg = result4;
				}
				instance = WatcherComposer.Integer;
				break;
			case (Docking)5:
				if (flag)
				{
					reg = (decimal)counter - 48m;
				}
				else if (flag2)
				{
					string text3 = m_RequestComposer.ToString();
					try
					{
						reg = Convert.ToDecimal(text3.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text3, 16) : Convert.ToInt64(text3, 8));
					}
					catch (Exception ex2)
					{
						throw ManageComposer("Input string '{0}' is not a valid decimal.".ListReader(CultureInfo.InvariantCulture, text3), ex2);
					}
				}
				else
				{
					if (HelperDicCandidate.LogoutProperty(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002(), out decimal reference2) != (TYMED)1)
					{
						throw ManageComposer("Input string '{0}' is not a valid decimal.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
					}
					reg = reference2;
				}
				instance = WatcherComposer.Float;
				break;
			case (Docking)8:
				if (flag)
				{
					reg = (double)(int)counter - 48.0;
				}
				else if (flag2)
				{
					string text4 = m_RequestComposer.ToString();
					try
					{
						reg = Convert.ToDouble(text4.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text4, 16) : Convert.ToInt64(text4, 8));
					}
					catch (Exception ex3)
					{
						throw ManageComposer("Input string '{0}' is not a valid double.".ListReader(CultureInfo.InvariantCulture, text4), ex3);
					}
				}
				else
				{
					if (!double.TryParse(m_RequestComposer.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double result2))
					{
						throw ManageComposer("Input string '{0}' is not a valid double.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
					}
					reg = result2;
				}
				instance = WatcherComposer.Float;
				break;
			case (Docking)0:
			case (Docking)2:
			{
				if (flag)
				{
					reg = (long)counter - 48L;
					instance = WatcherComposer.Integer;
					break;
				}
				if (flag2)
				{
					string text = m_RequestComposer.ToString();
					try
					{
						reg = (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text, 16) : Convert.ToInt64(text, 8));
					}
					catch (Exception ex)
					{
						throw ManageComposer("Input string '{0}' is not a valid number.".ListReader(CultureInfo.InvariantCulture, text), ex);
					}
					instance = WatcherComposer.Integer;
					break;
				}
				long caller;
				switch (HelperDicCandidate.CloneProperty(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002(), out caller))
				{
				case (TYMED)1:
					reg = caller;
					instance = WatcherComposer.Integer;
					break;
				case (TYMED)2:
				{
					string text2 = m_RequestComposer.ToString();
					if (text2.Length > 380)
					{
						throw ManageComposer("JSON integer {0} is too large to parse.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
					}
					reg = InitComposer(text2, CultureInfo.InvariantCulture);
					instance = WatcherComposer.Integer;
					break;
				}
				default:
					if (m_GetterError == (SudsUse)1)
					{
						decimal reference;
						TYMED tYMED = HelperDicCandidate.LogoutProperty(m_RequestComposer._0001(), m_RequestComposer._0001(), m_RequestComposer._0002(), out reference);
						if (tYMED != (TYMED)1)
						{
							throw ManageComposer("Input string '{0}' is not a valid decimal.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
						}
						reg = reference;
					}
					else
					{
						if (!double.TryParse(m_RequestComposer.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
						{
							throw ManageComposer("Input string '{0}' is not a valid number.".ListReader(CultureInfo.InvariantCulture, m_RequestComposer.ToString()));
						}
						reg = result;
					}
					instance = WatcherComposer.Float;
					break;
				}
				break;
			}
			default:
				throw ContextError.CheckComposer(this, "Cannot read number value as type.");
			}
			StartComposer();
			CancelError(instance, reg, isstate: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ContextError ManageComposer(string last, [_0008._0012(2)] Exception _0003 = null)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CancelError(WatcherComposer.Undefined, null, isstate: false);
			return ContextError.DisableComposer(this, last, _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object InitComposer(string param, CultureInfo counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return BigInteger.Parse(param, counter);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DefineComposer(bool isi)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerComposer++;
			if (!UpdateComposer(1, issecond: false))
			{
				throw ContextError.CheckComposer(this, "Unexpected end while parsing comment.");
			}
			bool flag;
			if (m_ComposerComposer[_IssuerComposer] == '*')
			{
				flag = false;
			}
			else
			{
				if (m_ComposerComposer[_IssuerComposer] != '/')
				{
					throw ContextError.CheckComposer(this, "Error parsing comment. Expected: *, got {0}.".ListReader(CultureInfo.InvariantCulture, m_ComposerComposer[_IssuerComposer]));
				}
				flag = true;
			}
			_IssuerComposer++;
			int issuerComposer = _IssuerComposer;
			while (true)
			{
				switch (m_ComposerComposer[_IssuerComposer])
				{
				case '\0':
					if (propertyComposer == _IssuerComposer)
					{
						if (PushComposer(isconfig: true) == 0)
						{
							if (!flag)
							{
								throw ContextError.CheckComposer(this, "Unexpected end while parsing comment.");
							}
							CollectComposer(isi, issuerComposer, _IssuerComposer);
							return;
						}
					}
					else
					{
						_IssuerComposer++;
					}
					break;
				case '*':
					_IssuerComposer++;
					if (!flag && UpdateComposer(0, issecond: true) && m_ComposerComposer[_IssuerComposer] == '/')
					{
						CollectComposer(isi, issuerComposer, _IssuerComposer - 1);
						_IssuerComposer++;
						return;
					}
					break;
				case '\r':
					if (flag)
					{
						CollectComposer(isi, issuerComposer, _IssuerComposer);
						return;
					}
					CustomizeComposer(isvar1: true);
					break;
				case '\n':
					if (flag)
					{
						CollectComposer(isi, issuerComposer, _IssuerComposer);
						return;
					}
					AssetComposer();
					break;
				default:
					_IssuerComposer++;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CollectComposer(bool keyneeded, int row_col, int max_helper)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (keyneeded)
			{
				QueryError(WatcherComposer.Comment, new string(m_ComposerComposer, row_col, max_helper - row_col));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SortComposer(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CallComposer(UpdateComposer(spec.Length - 1, issecond: true), spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CallComposer(bool isi, string connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!isi)
			{
				_IssuerComposer = propertyComposer;
				throw PrintError();
			}
			for (int i = 0; i < connection.Length; i++)
			{
				if (m_ComposerComposer[_IssuerComposer + i] != connection[i])
				{
					_IssuerComposer += i;
					return false;
				}
			}
			_IssuerComposer += connection.Length;
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PublishComposer(string asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!SortComposer(asset))
			{
				return false;
			}
			if (!UpdateComposer(0, issecond: false))
			{
				return true;
			}
			if (!WriteComposer(m_ComposerComposer[_IssuerComposer]))
			{
				return m_ComposerComposer[_IssuerComposer] == '\0';
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool WriteComposer(char ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (ident)
			{
			case ',':
			case ']':
			case '}':
				return true;
			case '/':
			{
				if (!UpdateComposer(1, issecond: false))
				{
					return false;
				}
				char c = m_ComposerComposer[_IssuerComposer + 1];
				if (c != '*')
				{
					return c == '/';
				}
				return true;
			}
			case ')':
				if (base._0001() == (MethodAttributes)10 || base._0001() == (MethodAttributes)9)
				{
					return true;
				}
				break;
			case '\t':
			case '\n':
			case '\r':
			case ' ':
				return true;
			default:
				if (char.IsWhiteSpace(ident))
				{
					return true;
				}
				break;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevertComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PublishComposer(ProcConsumer._ErrorError))
			{
				QueryError(WatcherComposer.Boolean, true);
				return;
			}
			throw ContextError.CheckComposer(this, "Error parsing boolean value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoginTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PublishComposer(ProcConsumer.testError))
			{
				CustomizeError(WatcherComposer.Null);
				return;
			}
			throw ContextError.CheckComposer(this, "Error parsing null value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PublishComposer(ProcConsumer._PropertyError))
			{
				CustomizeError(WatcherComposer.Undefined);
				return;
			}
			throw ContextError.CheckComposer(this, "Error parsing undefined value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisableTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (PublishComposer(ProcConsumer.composerError))
			{
				QueryError(WatcherComposer.Boolean, false);
				return;
			}
			throw ContextError.CheckComposer(this, "Error parsing boolean value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object VerifyTest(Docking info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PatchTest(info, PublishComposer(ProcConsumer.readerError));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object PatchTest(Docking i, bool appendcfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (appendcfg)
			{
				switch (i)
				{
				case (Docking)0:
				case (Docking)8:
					if (m_GetterError == (SudsUse)0)
					{
						QueryError(WatcherComposer.Float, double.NegativeInfinity);
						return double.NegativeInfinity;
					}
					break;
				case (Docking)4:
					QueryError(WatcherComposer.String, ProcConsumer.readerError);
					return ProcConsumer.readerError;
				}
				throw ContextError.CheckComposer(this, "Cannot read -Infinity value.");
			}
			throw ContextError.CheckComposer(this, "Error parsing -Infinity value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object FindTest(Docking instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ValidateTest(instance, PublishComposer(ProcConsumer.m_IssuerError));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ValidateTest(Docking i, bool hasmap)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (hasmap)
			{
				switch (i)
				{
				case (Docking)0:
				case (Docking)8:
					if (m_GetterError == (SudsUse)0)
					{
						QueryError(WatcherComposer.Float, double.PositiveInfinity);
						return double.PositiveInfinity;
					}
					break;
				case (Docking)4:
					QueryError(WatcherComposer.String, ProcConsumer.m_IssuerError);
					return ProcConsumer.m_IssuerError;
				}
				throw ContextError.CheckComposer(this, "Cannot read Infinity value.");
			}
			throw ContextError.CheckComposer(this, "Error parsing Infinity value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object OrderTest(Docking asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolveTest(asset, PublishComposer(ProcConsumer._ClientError));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ResolveTest(Docking param, bool checkvisitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (checkvisitor)
			{
				switch (param)
				{
				case (Docking)0:
				case (Docking)8:
					if (m_GetterError == (SudsUse)0)
					{
						QueryError(WatcherComposer.Float, double.NaN);
						return double.NaN;
					}
					break;
				case (Docking)4:
					QueryError(WatcherComposer.String, ProcConsumer._ClientError);
					return ProcConsumer._ClientError;
				}
				throw ContextError.CheckComposer(this, "Cannot read NaN value.");
			}
			throw ContextError.CheckComposer(this, "Error parsing NaN value.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001();
			if (m_ComposerComposer != null)
			{
				ValueFilterResolver.RestartIssuer(_IteratorComposer, m_ComposerComposer);
				m_ComposerComposer = null;
			}
			if (base._0003())
			{
				m_ErrorComposer?.Close();
			}
			classComposer.SetReader(_IteratorComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0001() == (MethodAttributes)0 && this._0002() == 0 && ((TagTestItem)this)._0001() != WatcherComposer.Comment)
			{
				return 0;
			}
			return _ClientComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IssuerComposer - m_ReaderComposer;
		}
	}
}
