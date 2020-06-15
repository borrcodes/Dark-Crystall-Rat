using GDBD.Workers;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	internal class AccountClassSpec
	{
		internal delegate void StrategyClientBridge(object o);

		internal static Module m_PageReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ManageGlobal(int typemdt)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = m_PageReader.ResolveType(33554432 + typemdt);
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)m_PageReader.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_PageReader = typeof(AccountClassSpec).Assembly.ManifestModule;
		}
	}
}
