using GDBD.Structs;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GDBD.Workers
{
	internal sealed class InitializerComposerWorker : SystemPropertyStruct, IEnumerable, IEnumerable<SystemPropertyStruct>
	{
		private readonly List<SystemPropertyStruct> m_InitializerIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogoutIterator(SystemPropertyStruct var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_InitializerIssuer.Add(var1);
			var1._0001(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ChildRunStatus _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ChildRunStatus)4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new IEnumerator<SystemPropertyStruct> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InitializerIssuer.GetEnumerator();
		}

		IEnumerator<SystemPropertyStruct> IEnumerable<SystemPropertyStruct>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new IEnumerator _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return this._0001();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InitializerComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_InitializerIssuer = new List<SystemPropertyStruct>();
			base._002Ector();
		}
	}
}
