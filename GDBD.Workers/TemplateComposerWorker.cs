using _0008;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Workers
{
	[_0008._0012(0)]
	internal struct TemplateComposerWorker<[_0008._0012(2)] T, [_0008._0012(2)] TT> : IEquatable<GDBD.Workers.TemplateComposerWorker<T, TT>>
	{
		public readonly T workerTest;

		public readonly TT _AdvisorTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TemplateComposerWorker(T i, TT col)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			workerTest = i;
			_AdvisorTest = col;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			T val = workerTest;
			ref T reference = ref val;
			T val2 = default(T);
			int num;
			if (val2 == null)
			{
				val2 = reference;
				reference = ref val2;
				if (val2 == null)
				{
					num = 0;
					goto IL_0045;
				}
			}
			num = reference.GetHashCode();
			goto IL_0045;
			IL_0045:
			TT advisorTest = _AdvisorTest;
			ref TT reference2 = ref advisorTest;
			TT val3 = default(TT);
			int num2;
			if (val3 == null)
			{
				val3 = reference2;
				reference2 = ref val3;
				if (val3 == null)
				{
					num2 = 0;
					goto IL_0086;
				}
			}
			num2 = reference2.GetHashCode();
			goto IL_0086;
			IL_0086:
			return num ^ num2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(object last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last is GDBD.Workers.TemplateComposerWorker<T, TT>)
			{
				GDBD.Workers.TemplateComposerWorker<T, TT> var = (GDBD.Workers.TemplateComposerWorker<T, TT>)last;
				return _0001(var);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool _0001(GDBD.Workers.TemplateComposerWorker<T, TT> var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (object.Equals(workerTest, var1.workerTest))
			{
				return object.Equals(_AdvisorTest, var1._AdvisorTest);
			}
			return false;
		}

		bool IEquatable<GDBD.Workers.TemplateComposerWorker<T, TT>>.Equals(GDBD.Workers.TemplateComposerWorker<T, TT> var1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(var1);
		}
	}
}
