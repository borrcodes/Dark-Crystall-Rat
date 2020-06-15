using _0008;
using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Consumers;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[global::_0008._0012(0)]
	internal sealed class StatusDicCandidate : RecordClassDispatcher
	{
		[global::_0008._0012(1)]
		private readonly TextWriter m_MethodComposer;

		private ManagerComposer mapperComposer;

		private char _PredicateComposer;

		private int m_PolicyComposer;

		private char _ServiceComposer;

		private bool _QueueComposer;

		private bool[] _ProxyComposer;

		private char[] m_RegistryComposer;

		private GDBD.Workers.WrapperComposerWorker<char> _AttrComposer;

		private char[] configurationComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new ManagerComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (mapperComposer == null)
			{
				mapperComposer = new ManagerComposer(m_MethodComposer);
			}
			return mapperComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new char _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ServiceComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatusDicCandidate(TextWriter ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			if (ident == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			m_MethodComposer = ident;
			_ServiceComposer = '"';
			_QueueComposer = true;
			_PredicateComposer = ' ';
			m_PolicyComposer = 2;
			RunTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001();
			FillTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FillTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RegistryComposer != null)
			{
				ValueFilterResolver.RestartIssuer(_AttrComposer, m_RegistryComposer);
				m_RegistryComposer = null;
			}
			if (base._0001())
			{
				m_MethodComposer?.Close();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartObject, tagURLTEMPLATE.Object);
			m_MethodComposer.Write('{');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartArray, tagURLTEMPLATE.Array);
			m_MethodComposer.Write('[');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CalculateTest(WatcherComposer.StartConstructor, tagURLTEMPLATE.Constructor);
			m_MethodComposer.Write("new ");
			m_MethodComposer.Write(item);
			m_MethodComposer.Write('(');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(WatcherComposer instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (instance)
			{
			case WatcherComposer.EndObject:
				m_MethodComposer.Write('}');
				break;
			case WatcherComposer.EndArray:
				m_MethodComposer.Write(']');
				break;
			case WatcherComposer.EndConstructor:
				m_MethodComposer.Write(')');
				break;
			default:
				throw CollectionComposer.ListTest(this, "Invalid JsonToken: " + instance, null);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PostTest(spec);
			EnableTest(spec, _QueueComposer);
			m_MethodComposer.Write(':');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string asset, bool visitorneeded)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PostTest(asset);
			if (visitorneeded)
			{
				EnableTest(asset, _QueueComposer);
			}
			else
			{
				if (_QueueComposer)
				{
					m_MethodComposer.Write(_ServiceComposer);
				}
				m_MethodComposer.Write(asset);
				if (_QueueComposer)
				{
					m_MethodComposer.Write(_ServiceComposer);
				}
			}
			m_MethodComposer.Write(':');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RunTest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RunTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ProxyComposer = RegistryBroadcasterFilter.ComputeIssuer(base._0001(), _ServiceComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = base._0002() * m_PolicyComposer;
			int num2 = CompareTest();
			m_MethodComposer.Write(configurationComposer, 0, num2 + Math.Min(num, 12));
			while ((num -= 12) > 0)
			{
				m_MethodComposer.Write(configurationComposer, num2, Math.Min(num, 12));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CompareTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string newLine = m_MethodComposer.NewLine;
			int length = newLine.Length;
			bool flag = configurationComposer != null && configurationComposer.Length == 12 + length;
			if (flag)
			{
				for (int i = 0; i != length; i++)
				{
					if (newLine[i] != configurationComposer[i])
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				configurationComposer = (newLine + new string(_PredicateComposer, 12)).ToCharArray();
			}
			return length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MethodComposer.Write(',');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MethodComposer.Write(' ');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddTest(string param, WatcherComposer map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_MethodComposer.Write(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)ident;
				GetTest(WatcherComposer.Integer);
				AddTest(bigInteger.ToString(CultureInfo.InvariantCulture), WatcherComposer.String);
			}
			else
			{
				base._0001(ident);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Null);
			AddTest(ProcConsumer.testError, WatcherComposer.Null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Undefined);
			AddTest(ProcConsumer._PropertyError, WatcherComposer.Undefined);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ChangeTest();
			m_MethodComposer.Write(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0004(string def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
			if (def == null)
			{
				AddTest(ProcConsumer.testError, WatcherComposer.Null);
			}
			else
			{
				EnableTest(def, verifyreg: true);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnableTest(string item, bool verifyreg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FlushTest();
			RegistryBroadcasterFilter.SetIssuer(m_MethodComposer, item, _ServiceComposer, verifyreg, _ProxyComposer, base._0001(), _AttrComposer, ref m_RegistryComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(int configLow)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			LogoutTest(configLow);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(uint i_length)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			CreateTest(i_length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			CreateTest(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ulong var1_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			StopTest(var1_start, ispol: false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
			AddTest(ProcConsumer.PushError(i, base._0001(), this._0001(), isivk2: false), WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float? var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!var1.HasValue)
			{
				_0008();
				return;
			}
			GetTest(WatcherComposer.Float);
			AddTest(ProcConsumer.PushError(var1.GetValueOrDefault(), base._0001(), this._0001(), isivk2: true), WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
			AddTest(ProcConsumer.AwakeError(reference, base._0001(), this._0001(), allowtoken2: false), WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double? reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!reference.HasValue)
			{
				_0008();
				return;
			}
			GetTest(WatcherComposer.Float);
			AddTest(ProcConsumer.AwakeError(reference.GetValueOrDefault(), base._0001(), this._0001(), allowtoken2: true), WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(bool isconfig)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Boolean);
			AddTest(ProcConsumer.ForgotError(isconfig), WatcherComposer.Boolean);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(short first_Low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			LogoutTest(first_Low);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ushort positionres)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			LogoutTest(positionres);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(char task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
			AddTest(ProcConsumer.IncludeError(task), WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte specX)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			LogoutTest(specX);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(sbyte v_High)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Integer);
			LogoutTest(v_High);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(decimal res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Float);
			AddTest(ProcConsumer.InterruptError(res), WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTime last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Date);
			last = DescriptorIteratorMapping.ReadProperty(last, base._0001());
			if (SetterTest.StartReader(base._0003()))
			{
				int count = MapTest(last);
				m_MethodComposer.Write(m_RegistryComposer, 0, count);
			}
			else
			{
				m_MethodComposer.Write(_ServiceComposer);
				m_MethodComposer.Write(last.ToString(base._0003(), base._0001()));
				m_MethodComposer.Write(_ServiceComposer);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int MapTest(DateTime init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FlushTest();
			int start_cust = 0;
			m_RegistryComposer[start_cust++] = _ServiceComposer;
			start_cust = DescriptorIteratorMapping.ConcatProperty(m_RegistryComposer, start_cust, init, null, init.Kind, base._0001());
			m_RegistryComposer[start_cust++] = _ServiceComposer;
			return start_cust;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (param == null)
			{
				_0008();
				return;
			}
			GetTest(WatcherComposer.Bytes);
			m_MethodComposer.Write(_ServiceComposer);
			this._0001().TestTest(param, 0, param.Length);
			this._0001().PrintTest();
			m_MethodComposer.Write(_ServiceComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTimeOffset res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.Date);
			if (SetterTest.StartReader(base._0003()))
			{
				int count = InsertTest(res);
				m_MethodComposer.Write(m_RegistryComposer, 0, count);
			}
			else
			{
				m_MethodComposer.Write(_ServiceComposer);
				m_MethodComposer.Write(res.ToString(base._0003(), base._0001()));
				m_MethodComposer.Write(_ServiceComposer);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int InsertTest(DateTimeOffset reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FlushTest();
			int start_cust = 0;
			m_RegistryComposer[start_cust++] = _ServiceComposer;
			start_cust = DescriptorIteratorMapping.ConcatProperty(m_RegistryComposer, start_cust, (base._0001() == (FindDirection)0) ? reference.DateTime : reference.UtcDateTime, reference.Offset, DateTimeKind.Local, base._0001());
			m_RegistryComposer[start_cust++] = _ServiceComposer;
			return start_cust;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Guid var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
			string value = var1.ToString("D", CultureInfo.InvariantCulture);
			m_MethodComposer.Write(_ServiceComposer);
			m_MethodComposer.Write(value);
			m_MethodComposer.Write(_ServiceComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(TimeSpan item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			GetTest(WatcherComposer.String);
			string value = item.ToString(null, CultureInfo.InvariantCulture);
			m_MethodComposer.Write(_ServiceComposer);
			m_MethodComposer.Write(value);
			m_MethodComposer.Write(_ServiceComposer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Uri info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info == null)
			{
				_0008();
				return;
			}
			GetTest(WatcherComposer.String);
			EnableTest(info.OriginalString, verifyreg: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0005(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StartTest();
			m_MethodComposer.Write("/*");
			m_MethodComposer.Write(var1);
			m_MethodComposer.Write("*/");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FlushTest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_RegistryComposer == null)
			{
				m_RegistryComposer = ValueFilterResolver.RegisterIssuer(_AttrComposer, 35);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateTest(long sum_reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (sum_reference >= 0 && sum_reference <= 9)
			{
				m_MethodComposer.Write((char)(48 + sum_reference));
				return;
			}
			bool flag = sum_reference < 0;
			StopTest((ulong)(flag ? (-sum_reference) : sum_reference), flag);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopTest(ulong IDvalue, bool ispol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ispol && IDvalue <= 9)
			{
				m_MethodComposer.Write((char)(48 + IDvalue));
				return;
			}
			int count = CloneTest(IDvalue, ispol);
			m_MethodComposer.Write(m_RegistryComposer, 0, count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CloneTest(ulong idxinstance, bool verifycounter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (idxinstance <= uint.MaxValue)
			{
				return ViewTest((uint)idxinstance, verifycounter);
			}
			FlushTest();
			int num = IteratorComposerPool.ListIssuer(idxinstance);
			if (verifycounter)
			{
				num++;
				m_RegistryComposer[0] = '-';
			}
			int num2 = num;
			do
			{
				ulong num3 = idxinstance / 10uL;
				ulong num4 = idxinstance - num3 * 10;
				m_RegistryComposer[--num2] = (char)(48 + num4);
				idxinstance = num3;
			}
			while (idxinstance != 0L);
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LogoutTest(int init_counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init_counter >= 0 && init_counter <= 9)
			{
				m_MethodComposer.Write((char)(48 + init_counter));
				return;
			}
			bool flag = init_counter < 0;
			VisitTest((uint)(flag ? (-init_counter) : init_counter), flag);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VisitTest(uint sizeinit, bool rejectcont)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!rejectcont && sizeinit <= 9)
			{
				m_MethodComposer.Write((char)(48 + sizeinit));
				return;
			}
			int count = ViewTest(sizeinit, rejectcont);
			m_MethodComposer.Write(m_RegistryComposer, 0, count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int ViewTest(uint position_task, bool noresult)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			FlushTest();
			int num = IteratorComposerPool.ListIssuer(position_task);
			if (noresult)
			{
				num++;
				m_RegistryComposer[0] = '-';
			}
			int num2 = num;
			do
			{
				uint num3 = position_task / 10u;
				uint num4 = position_task - num3 * 10;
				m_RegistryComposer[--num2] = (char)(48 + num4);
				position_task = num3;
			}
			while (position_task != 0);
			return num;
		}
	}
}
