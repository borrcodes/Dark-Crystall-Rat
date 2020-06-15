using _0008;
using GDBD.Dispatcher;
using GDBD.Specifications;
using GDBD.Workers;
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[global::_0008._0012(0)]
	internal sealed class DicIssuer : RecordClassDispatcher
	{
		private readonly RecordClassDispatcher errorIssuer;

		private readonly StatusDicCandidate m_ComposerIssuer;

		private readonly StringWriter m_PropertyIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DicIssuer(RecordClassDispatcher asset)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			errorIssuer = asset;
			m_PropertyIssuer = new StringWriter(CultureInfo.InvariantCulture);
			m_PropertyIssuer.Write("Serialized JSON: " + Environment.NewLine);
			m_ComposerIssuer = new StatusDicCandidate(m_PropertyIssuer);
			m_ComposerIssuer._0001((TimeState)1);
			m_ComposerIssuer._0001(asset._0001());
			m_ComposerIssuer._0001(asset._0001());
			m_ComposerIssuer._0007(asset._0003());
			m_ComposerIssuer._0001(asset._0001());
			m_ComposerIssuer._0001(asset._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ReflectClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PropertyIssuer.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(decimal res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(res);
			errorIssuer._0001(res);
			base._0001(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(decimal? reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(reference);
			errorIssuer._0001(reference);
			if (reference.HasValue)
			{
				base._0001(reference.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(bool outputtask)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(outputtask);
			errorIssuer._0001(outputtask);
			base._0001(outputtask);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(bool? value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(value);
			errorIssuer._0001(value);
			if (value.HasValue)
			{
				base._0001(value.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte index_v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(index_v);
			errorIssuer._0001(index_v);
			base._0001(index_v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte? res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(res);
			errorIssuer._0001(res);
			if (res.HasValue)
			{
				base._0001(res.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(char key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			base._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(char? var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(var1);
			errorIssuer._0001(var1);
			if (var1.HasValue)
			{
				base._0001(var1.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(asset);
			errorIssuer._0001(asset);
			if (asset == null)
			{
				base._000E();
			}
			else
			{
				base._0001(asset);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTime instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(instance);
			errorIssuer._0001(instance);
			base._0001(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTime? key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			if (key.HasValue)
			{
				base._0001(key.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTimeOffset i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(i);
			errorIssuer._0001(i);
			base._0001(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTimeOffset? init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(init);
			errorIssuer._0001(init);
			if (init.HasValue)
			{
				base._0001(init.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(info);
			errorIssuer._0001(info);
			base._0001(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double? i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(i);
			errorIssuer._0001(i);
			if (i.HasValue)
			{
				base._0001(i.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._000E();
			errorIssuer._000E();
			base._000E();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0008();
			errorIssuer._0008();
			base._000E();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(spec);
			errorIssuer._0001(spec);
			base._0001(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float? key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			if (key.HasValue)
			{
				base._0001(key.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Guid key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			base._0001(key);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Guid? def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(def);
			errorIssuer._0001(def);
			if (def.HasValue)
			{
				base._0001(def.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(int instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(instance);
			errorIssuer._0001(instance);
			base._0001(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(int? key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			if (key.HasValue)
			{
				base._0001(key.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long task_end)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(task_end);
			errorIssuer._0001(task_end);
			base._0001(task_end);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long? instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(instance);
			errorIssuer._0001(instance);
			if (instance.HasValue)
			{
				base._0001(instance.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference is BigInteger)
			{
				m_ComposerIssuer._0001(reference);
				errorIssuer._0001(reference);
				GetTest(WatcherComposer.Integer);
				return;
			}
			m_ComposerIssuer._0001(reference);
			errorIssuer._0001(reference);
			if (reference == null)
			{
				base._000E();
			}
			else
			{
				GetTest(WatcherComposer.String);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(sbyte start_param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(start_param);
			errorIssuer._0001(start_param);
			base._0001(start_param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(sbyte? init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(init);
			errorIssuer._0001(init);
			if (init.HasValue)
			{
				base._0001(init.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(short var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(var1);
			errorIssuer._0001(var1);
			base._0001(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(short? res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(res);
			errorIssuer._0001(res);
			if (res.HasValue)
			{
				base._0001(res.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0004(string config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0004(config);
			errorIssuer._0004(config);
			base._0004(config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(TimeSpan first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(first);
			errorIssuer._0001(first);
			base._0001(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(TimeSpan? task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(task);
			errorIssuer._0001(task);
			if (task.HasValue)
			{
				base._0001(task.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(uint v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(v);
			errorIssuer._0001(v);
			base._0001(v);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(uint? key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(key);
			errorIssuer._0001(key);
			if (key.HasValue)
			{
				base._0001(key.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(ulong flags_def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(flags_def);
			errorIssuer._0001(flags_def);
			base._0001(flags_def);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(ulong? item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(item);
			errorIssuer._0001(item);
			if (item.HasValue)
			{
				base._0001(item.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Uri spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(spec);
			errorIssuer._0001(spec);
			if (spec == null)
			{
				base._000E();
			}
			else
			{
				base._0001(spec);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(ushort infoX)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(infoX);
			errorIssuer._0001(infoX);
			base._0001(infoX);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(ushort? instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(instance);
			errorIssuer._0001(instance);
			if (instance.HasValue)
			{
				base._0001(instance.GetValueOrDefault());
			}
			else
			{
				base._000E();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0005(string param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0005(param);
			errorIssuer._0005(param);
			base._0005(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((RecordClassDispatcher)m_ComposerIssuer)._0003();
			errorIssuer._0003();
			base._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _000F()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._000F();
			errorIssuer._000F();
			base._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(item);
			errorIssuer._0001(item);
			base._0001(item);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0010()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0010();
			errorIssuer._0010();
			base._0010();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(string last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0002(last);
			errorIssuer._0002(last);
			base._0002(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string instance, bool istoken)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0001(instance, istoken);
			errorIssuer._0001(instance, istoken);
			base._0002(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((RecordClassDispatcher)m_ComposerIssuer)._0002();
			errorIssuer._0002();
			base._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0011()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0011();
			errorIssuer._0011();
			base._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0006(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0006(spec);
			errorIssuer._0006(spec);
			GetTest(WatcherComposer.Undefined);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComposerIssuer._0003(var1);
			errorIssuer._0003(var1);
			base._0003(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((RecordClassDispatcher)m_ComposerIssuer)._0001();
			errorIssuer._0001();
			base._0001();
		}
	}
}
