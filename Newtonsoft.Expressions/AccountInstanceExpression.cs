using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Newtonsoft.Expressions
{
	internal sealed class AccountInstanceExpression : CollectionBase
	{
		public ExceptionEvent this[int insert_LASTAt]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (ExceptionEvent)base.InnerList[insert_LASTAt];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountInstanceExpression(Guid var1)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			FindInstance(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindInstance(Guid task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object obj = null;
			InterceptorComposerWorker interceptorComposerWorker = null;
			IEnumMoniker counter = null;
			IMoniker[] array = new IMoniker[1];
			try
			{
				Type typeFromCLSID = Type.GetTypeFromCLSID(AlgoComposerWorker.pageFilter);
				if (typeFromCLSID == null)
				{
					throw new ApplicationException("Failed creating device enumerator");
				}
				obj = Activator.CreateInstance(typeFromCLSID);
				interceptorComposerWorker = (InterceptorComposerWorker)obj;
				if (interceptorComposerWorker._0001(ref task, out counter, 0) != 0)
				{
					throw new ApplicationException("No devices of the category");
				}
				IntPtr zero = IntPtr.Zero;
				while (counter.Next(1, array, zero) == 0 && array[0] != null)
				{
					ExceptionEvent value = new ExceptionEvent(array[0]);
					base.InnerList.Add(value);
					Marshal.ReleaseComObject(array[0]);
					array[0] = null;
				}
				base.InnerList.Sort();
			}
			catch
			{
			}
			finally
			{
				interceptorComposerWorker = null;
				if (obj != null)
				{
					Marshal.ReleaseComObject(obj);
					obj = null;
				}
				if (counter != null)
				{
					Marshal.ReleaseComObject(counter);
					counter = null;
				}
				if (array[0] != null)
				{
					Marshal.ReleaseComObject(array[0]);
					array[0] = null;
				}
			}
		}
	}
}
