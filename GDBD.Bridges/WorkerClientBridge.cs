using _0008;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace GDBD.Bridges
{
	[global::_0008._0012(0)]
	internal sealed class WorkerClientBridge<[global::_0008._0012(2)] T> : DynamicMetaObject
	{
		private delegate DynamicMetaObject MessageComposer(DynamicMetaObject);

		[global::_0008._0012(0)]
		private sealed class ResolverPropertyStruct : GetMemberBinder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResolverPropertyStruct(InvokeMemberBinder spec)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector(spec.Name, spec.IgnoreCase);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DynamicMetaObject _0001(DynamicMetaObject value, DynamicMetaObject map)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				throw new NotSupportedException();
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			[global::_0008._0012(0)]
			public GetMemberBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0003()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackGetMember(_0002, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			[global::_0008._0012(0)]
			public SetMemberBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(0)]
			public DynamicMetaObject _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0004()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackSetMember(_0002, _0003, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0005
		{
			[global::_0008._0012(0)]
			public DeleteMemberBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0005()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackDeleteMember(_0002, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0006
		{
			[global::_0008._0012(0)]
			public ConvertBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0006()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackConvert(_0002, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0007
		{
			[global::_0008._0012(0)]
			public InvokeMemberBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0007()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackInvokeMember(this._0002, _0003, P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0002(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackInvoke(P_0, _0003, null);
			}
		}

		[CompilerGenerated]
		private sealed class _0008
		{
			[global::_0008._0012(0)]
			public CreateInstanceBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0008()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackCreateInstance(_0002, _0003, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _000E
		{
			[global::_0008._0012(0)]
			public InvokeBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _000E()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackInvoke(_0002, _0003, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _000F
		{
			[global::_0008._0012(0)]
			public BinaryOperationBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(0)]
			public DynamicMetaObject _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _000F()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackBinaryOperation(_0002, _0003, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0010
		{
			[global::_0008._0012(0)]
			public UnaryOperationBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0010()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackUnaryOperation(_0002, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0011
		{
			[global::_0008._0012(0)]
			public GetIndexBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0011()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackGetIndex(_0002, _0003, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0012
		{
			[global::_0008._0012(0)]
			public SetIndexBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[global::_0008._0012(0)]
			public DynamicMetaObject _0004;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0012()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackSetIndex(_0002, _0003, _0004, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0013
		{
			[global::_0008._0012(0)]
			public DeleteIndexBinder _0001;

			[global::_0008._0012(0)]
			public WorkerClientBridge<T> _0002;

			[global::_0008._0012(new byte[]
			{
				0,
				1
			})]
			public DynamicMetaObject[] _0003;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0013()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DynamicMetaObject _0001(DynamicMetaObject P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.FallbackDeleteIndex(_0002, _0003, P_0);
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class ProductComposer
		{
			[global::_0008._0012(0)]
			public static readonly ProductComposer _InterceptorComposer;

			[global::_0008._0012(0)]
			public static Func<DynamicMetaObject, Expression> m_AlgoComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ProductComposer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_InterceptorComposer = new ProductComposer();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ProductComposer()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Expression WriteProperty(DynamicMetaObject res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Expression expression = res.Expression;
				if (!expression.Type.FindClient())
				{
					return expression;
				}
				return Expression.Convert(expression, typeof(object));
			}
		}

		private readonly GDBD.Bridges.SetterClientBridge<T> modelComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WorkerClientBridge(Expression last, T cont, GDBD.Bridges.SetterClientBridge<T> pool)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(last, BindingRestrictions.Empty, cont);
			modelComposer = pool;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CancelProperty(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolverErrorFilter.InstantiateReader(modelComposer.GetType(), typeof(GDBD.Bridges.SetterClientBridge<T>), spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(GetMemberBinder reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryGetMember"))
			{
				return base.BindGetMember(reference);
			}
			return DefineProperty("TryGetMember", reference, WorkerClientBridge<T>._0001(), (DynamicMetaObject P_0) => reference.FallbackGetMember(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(SetMemberBinder config, DynamicMetaObject ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TrySetMember"))
			{
				return base.BindSetMember(config, ivk);
			}
			return SortProperty("TrySetMember", config, ExcludeProperty(new DynamicMetaObject[1]
			{
				ivk
			}), (DynamicMetaObject P_0) => config.FallbackSetMember(this, ivk, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(DeleteMemberBinder item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryDeleteMember"))
			{
				return base.BindDeleteMember(item);
			}
			return CallProperty("TryDeleteMember", item, WorkerClientBridge<T>._0001(), (DynamicMetaObject P_0) => item.FallbackDeleteMember(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(ConvertBinder i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryConvert"))
			{
				return base.BindConvert(i);
			}
			return DefineProperty("TryConvert", i, WorkerClientBridge<T>._0001(), (DynamicMetaObject P_0) => i.FallbackConvert(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(InvokeMemberBinder instance, DynamicMetaObject[] pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryInvokeMember"))
			{
				return base.BindInvokeMember(instance, pol);
			}
			MessageComposer messageComposer = (DynamicMetaObject P_0) => instance.FallbackInvokeMember(this, pol, P_0);
			return CollectProperty("TryInvokeMember", instance, WorkerClientBridge<T>._0001(pol), CollectProperty("TryGetMember", new ResolverPropertyStruct(instance), WorkerClientBridge<T>._0001(), messageComposer(null), (DynamicMetaObject P_0) => instance.FallbackInvoke(P_0, pol, null)), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(CreateInstanceBinder config, DynamicMetaObject[] pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryCreateInstance"))
			{
				return base.BindCreateInstance(config, pol);
			}
			return DefineProperty("TryCreateInstance", config, WorkerClientBridge<T>._0001(pol), (DynamicMetaObject P_0) => config.FallbackCreateInstance(this, pol, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(InvokeBinder v, DynamicMetaObject[] second)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryInvoke"))
			{
				return base.BindInvoke(v, second);
			}
			return DefineProperty("TryInvoke", v, WorkerClientBridge<T>._0001(second), (DynamicMetaObject P_0) => v.FallbackInvoke(this, second, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(BinaryOperationBinder i, DynamicMetaObject counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryBinaryOperation"))
			{
				return base.BindBinaryOperation(i, counter);
			}
			return DefineProperty("TryBinaryOperation", i, ExcludeProperty(new DynamicMetaObject[1]
			{
				counter
			}), (DynamicMetaObject P_0) => i.FallbackBinaryOperation(this, counter, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(UnaryOperationBinder key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryUnaryOperation"))
			{
				return base.BindUnaryOperation(key);
			}
			return DefineProperty("TryUnaryOperation", key, WorkerClientBridge<T>._0001(), (DynamicMetaObject P_0) => key.FallbackUnaryOperation(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(GetIndexBinder var1, DynamicMetaObject[] vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryGetIndex"))
			{
				return base.BindGetIndex(var1, vis);
			}
			return DefineProperty("TryGetIndex", var1, WorkerClientBridge<T>._0001(vis), (DynamicMetaObject P_0) => var1.FallbackGetIndex(this, vis, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(SetIndexBinder i, DynamicMetaObject[] cfg, DynamicMetaObject state)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TrySetIndex"))
			{
				return base.BindSetIndex(i, cfg, state);
			}
			return SortProperty("TrySetIndex", i, ManageProperty(cfg, state), (DynamicMetaObject P_0) => i.FallbackSetIndex(this, cfg, state, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(DeleteIndexBinder key, DynamicMetaObject[] counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!CancelProperty("TryDeleteIndex"))
			{
				return base.BindDeleteIndex(key, counter);
			}
			return CallProperty("TryDeleteIndex", key, WorkerClientBridge<T>._0001(counter), (DynamicMetaObject P_0) => key.FallbackDeleteIndex(this, counter, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Expression[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ObserverIteratorMapping.CheckProperty<Expression>();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerable<Expression> ExcludeProperty(DynamicMetaObject[] init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return init.Select(delegate(DynamicMetaObject res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Expression expression = res.Expression;
				return (!expression.Type.FindClient()) ? expression : Expression.Convert(expression, typeof(object));
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Expression[] SetupProperty(DynamicMetaObject[] init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new NewArrayExpression[1]
			{
				Expression.NewArrayInit(typeof(object), ExcludeProperty(init))
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Expression[] ManageProperty(DynamicMetaObject[] param, DynamicMetaObject vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Expression expression = vis.Expression;
			return new Expression[2]
			{
				Expression.NewArrayInit(typeof(object), ExcludeProperty(param)),
				expression.Type.FindClient() ? Expression.Convert(expression, typeof(object)) : expression
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ConstantExpression InitProperty(DynamicMetaObjectBinder task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type type = task.GetType();
			while (!type.PatchClient())
			{
				type = type.WriteReader();
			}
			return Expression.Constant(task, type);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicMetaObject DefineProperty(string info, DynamicMetaObjectBinder selection, IEnumerable<Expression> filter, [global::_0008._0012(new byte[]
		{
			1,
			0
		})] MessageComposer _0005, [global::_0008._0012(new byte[]
		{
			2,
			0
		})] MessageComposer _0006 = null)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMetaObject visitor = _0005(null);
			return CollectProperty(info, selection, filter, visitor, _0006);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicMetaObject CollectProperty(string def, DynamicMetaObjectBinder ivk, IEnumerable<Expression> role, DynamicMetaObject visitor2, MessageComposer last3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(InitProperty(ivk));
			list.ExcludeTest(role);
			list.Add(parameterExpression);
			DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
			if (ivk.ReturnType != typeof(object))
			{
				dynamicMetaObject = new DynamicMetaObject(Expression.Convert(dynamicMetaObject.Expression, ivk.ReturnType), dynamicMetaObject.Restrictions);
			}
			if (last3 != null)
			{
				dynamicMetaObject = last3(dynamicMetaObject);
			}
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[1]
			{
				parameterExpression
			}, Expression.Condition(Expression.Call(Expression.Constant(modelComposer), typeof(GDBD.Bridges.SetterClientBridge<T>).GetMethod(def), list), dynamicMetaObject.Expression, visitor2.Expression, ivk.ReturnType)), this._0001().Merge(dynamicMetaObject.Restrictions).Merge(visitor2.Restrictions));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicMetaObject SortProperty(string spec, DynamicMetaObjectBinder ivk, IEnumerable<Expression> control, MessageComposer ord2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMetaObject dynamicMetaObject = ord2(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(InitProperty(ivk));
			list.ExcludeTest(control);
			list[list.Count - 1] = Expression.Assign(parameterExpression, list[list.Count - 1]);
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[1]
			{
				parameterExpression
			}, Expression.Condition(Expression.Call(Expression.Constant(modelComposer), typeof(GDBD.Bridges.SetterClientBridge<T>).GetMethod(spec), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))), this._0001().Merge(dynamicMetaObject.Restrictions));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DynamicMetaObject CallProperty(string init, DynamicMetaObjectBinder ord, Expression[] dic, MessageComposer key2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMetaObject dynamicMetaObject = key2(null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(InitProperty(ord));
			list.ExcludeTest(dic);
			return new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(modelComposer), typeof(GDBD.Bridges.SetterClientBridge<T>).GetMethod(init), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this._0001().Merge(dynamicMetaObject.Restrictions));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BindingRestrictions PublishProperty()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base.Value != null || !base.HasValue)
			{
				return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
			}
			return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerable<string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return modelComposer._0001((T)base.Value);
		}
	}
}
