using GDBD.Importers;
using Newtonsoft.Expressions;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Items
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CallbackTestItem : IDisposable
	{
		[MarshalAs(UnmanagedType.Interface)]
		private ResolverList _InfoList;

		private ParserList valueList;

		private long _ParameterList;

		private long prototypeList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_InfoList != null)
			{
				((ServerList)_InfoList)._0001();
				_InfoList = null;
				GC.SuppressFinalize(this);
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0001();
		}
	}
}
