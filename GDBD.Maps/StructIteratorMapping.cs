using _0008;
using GDBD.Bridges;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	[_0008._0012(0)]
	internal sealed class StructIteratorMapping : RoleTestItem
	{
		private readonly MemberInfo _ItemTest;

		[_0008._0012(new byte[]
		{
			2,
			1,
			2
		})]
		private Func<object, object> regTest;

		[_0008._0012(new byte[]
		{
			2,
			1,
			2
		})]
		private Action<object, object> _ProcessTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructIteratorMapping(MemberInfo spec)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(spec, "memberInfo");
			_ItemTest = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(object key, object vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (_ProcessTest == null)
				{
					_ProcessTest = AnnotationComposer._0001().OrderIssuer<object>(_ItemTest);
				}
				_ProcessTest(key, vis);
			}
			catch (Exception second)
			{
				throw new StrategyError("Error setting value to '{0}' on '{1}'.".SelectReader(CultureInfo.InvariantCulture, _ItemTest.Name, key.GetType()), second);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001(object task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (regTest == null)
				{
					regTest = AnnotationComposer._0001().ValidateIssuer<object>(_ItemTest);
				}
				return regTest(task);
			}
			catch (Exception second)
			{
				throw new StrategyError("Error getting value from '{0}' on '{1}'.".SelectReader(CultureInfo.InvariantCulture, _ItemTest.Name, task.GetType()), second);
			}
		}
	}
}
