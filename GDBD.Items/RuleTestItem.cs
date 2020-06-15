using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Consumers;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[_0008._0012(0)]
	internal abstract class RuleTestItem
	{
		[_0008._0012(0)]
		private sealed class InterpreterListAnnotation : IEqualityComparer<object>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool _0001(object instance, object pred)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return instance == pred;
			}

			bool IEqualityComparer<object>.Equals(object instance, object pred)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001(instance, pred);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private int _0001(object item)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return RuntimeHelpers.GetHashCode(item);
			}

			int IEqualityComparer<object>.GetHashCode(object item)
			{
				//ILSpy generated this explicit interface implementation from .override directive in 
				return this._0001(item);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public InterpreterListAnnotation()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		[_0008._0012(2)]
		private ValErrorFilter regProperty;

		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private Newtonsoft.Consumers.EventEventConsumer<string, object> _ProcessProperty;

		internal readonly PrototypeError baseProperty;

		[_0008._0012(2)]
		internal readonly ModelTest containerProperty;

		[_0008._0012(2)]
		protected AlgoInstanceExpression m_ProccesorProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected RuleTestItem(PrototypeError item)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(item, "serializer");
			baseProperty = item;
			containerProperty = item._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Newtonsoft.Consumers.EventEventConsumer<string, object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ProcessProperty == null)
			{
				_ProcessProperty = new Newtonsoft.Consumers.EventEventConsumer<string, object>(EqualityComparer<string>.Default, new InterpreterListAnnotation(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
			}
			return _ProcessProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ApplicationState WriteClient(PrototypeFilterResolver config, ProductInstanceExpression ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ivk._0001() ?? config?._0001() ?? baseProperty.m_DatabaseError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ValErrorFilter RevertClient(object ident, object attr, string filter, Exception reg2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (regProperty == null)
			{
				regProperty = new ValErrorFilter(ident, attr, filter, reg2);
			}
			if (regProperty._0001() != reg2)
			{
				throw new InvalidOperationException("Current error context error is different to requested error.");
			}
			return regProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void LoginBroadcaster()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (regProperty == null)
			{
				throw new InvalidOperationException("Could not clear error context. Error context is already null.");
			}
			regProperty = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CheckBroadcaster(object i, ProcTest attr, object helper, IdentifierClientBridge value2, string reference3, Exception ident4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValErrorFilter valErrorFilter = RevertClient(i, helper, reference3, ident4);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Error && !valErrorFilter._0001())
			{
				valErrorFilter._0001(containssetup: true);
				string str = (GetType() == typeof(InterceptorInstanceExpression)) ? "Error serializing" : "Error deserializing";
				if (attr != null)
				{
					str = str + " " + attr._0002();
				}
				str = str + ". " + ident4.Message;
				if (!(ident4 is ListenerTestItem))
				{
					str = QueueError.ComputeError(value2, reference3, str);
				}
				containerProperty._0001(TraceLevel.Error, str, ident4);
			}
			if (attr != null && i != null)
			{
				attr.ConcatClient(i, baseProperty._0001(), valErrorFilter);
			}
			if (!valErrorFilter._0002())
			{
				baseProperty.VisitComposer(new FilterClassDispatcher(i, valErrorFilter));
			}
			return valErrorFilter._0002();
		}
	}
}
