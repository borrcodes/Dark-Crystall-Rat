using _0008;
using GDBD.Bridges;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal sealed class ReaderInstanceRule : VisitorComposer
	{
		[CompilerGenerated]
		private new sealed class _0001
		{
			[_0008._0012(0)]
			public ConstructorInfo _0001;

			[_0008._0012(0)]
			public MethodBase _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object _0001(object[] P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.Invoke(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object _0002(object[] P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0002.Invoke(null, P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0002<_0001>
		{
			[_0008._0012(0)]
			public ConstructorInfo _0001;

			[_0008._0012(0)]
			public MethodBase _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object _0001(_0001 P_0, object[] P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.Invoke(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object _0002(_0001 P_0, object[] P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0002.Invoke(P_0, P_1);
			}
		}

		[CompilerGenerated]
		private sealed class _0003<_0001>
		{
			[_0008._0012(0)]
			public Type _0001;

			[_0008._0012(0)]
			public ConstructorInfo _0002;

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
			internal _0001 _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (_0001)Activator.CreateInstance(this._0001);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal _0001 _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (_0001)this._0002.Invoke(null);
			}
		}

		[CompilerGenerated]
		private sealed class _0004<_0001>
		{
			[_0008._0012(0)]
			public PropertyInfo _0001;

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
			internal object _0001(_0001 P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.GetValue(P_0, null);
			}
		}

		[CompilerGenerated]
		private sealed class _0005<_0001>
		{
			[_0008._0012(0)]
			public FieldInfo _0001;

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
			internal object _0001(_0001 P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return this._0001.GetValue(P_0);
			}
		}

		[CompilerGenerated]
		private sealed class _0006<_0001>
		{
			[_0008._0012(0)]
			public FieldInfo _0001;

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
			internal void _0001(_0001 P_0, object P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.SetValue(P_0, P_1);
			}
		}

		[CompilerGenerated]
		private sealed class _0007<_0001>
		{
			[_0008._0012(0)]
			public PropertyInfo _0001;

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
			internal void _0001(_0001 P_0, object P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				this._0001.SetValue(P_0, P_1, null);
			}
		}

		private static readonly ReaderInstanceRule _StructTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static VisitorComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StructTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GDBD.Specifications.AdapterClassSpec<object> _0001(MethodBase ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(ident, "method");
			ConstructorInfo constructorInfo = ident as ConstructorInfo;
			if ((object)constructorInfo != null)
			{
				return (object[] P_0) => constructorInfo.Invoke(P_0);
			}
			return (object[] P_0) => ident.Invoke(null, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Newtonsoft.Rules.ClientInstanceRule<T, object> _0001<[_0008._0012(2)] T>(MethodBase info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(info, "method");
			ConstructorInfo constructorInfo = info as ConstructorInfo;
			if ((object)constructorInfo != null)
			{
				return (T P_0, object[] P_1) => constructorInfo.Invoke(P_1);
			}
			return (T P_0, object[] P_1) => info.Invoke(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T> _0001<[_0008._0012(2)] T>(Type key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(key, "type");
			if (key.FindClient())
			{
				return () => (T)Activator.CreateInstance(key);
			}
			ConstructorInfo constructorInfo = ResolverErrorFilter.DisableReader(key, ismap: true);
			return () => (T)constructorInfo.Invoke(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(ident, "propertyInfo");
			return (T P_0) => ident.GetValue(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Func<T, object> _0001<[_0008._0012(2)] T>(FieldInfo asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(asset, "fieldInfo");
			return (T P_0) => asset.GetValue(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action<T, object> _0001<[_0008._0012(2)] T>(FieldInfo var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(var1, "fieldInfo");
			return delegate(T P_0, object P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				var1.SetValue(P_0, P_1);
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(i, "propertyInfo");
			return delegate(T P_0, object P_1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				i.SetValue(P_0, P_1, null);
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReaderInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ReaderInstanceRule()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_StructTest = new ReaderInstanceRule();
		}
	}
}
