using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Workers;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	[_0008._0012(0)]
	internal struct PoolPropertyStruct<[_0008._0012(0)] T> : IEnumerable<T>, Newtonsoft.Rules.RegistryIssuer<T>, IEquatable<GDBD.Structs.PoolPropertyStruct<T>>, IEnumerable where T : ParserFilterResolver
	{
		[_0008._0012(new byte[]
		{
			0,
			1
		})]
		public static readonly GDBD.Structs.PoolPropertyStruct<T> producerIssuer;

		private readonly IEnumerable<T> _StructIssuer;

		public Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver> this[object config]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (_StructIssuer == null)
				{
					return GDBD.Structs.PoolPropertyStruct<ParserFilterResolver>.producerIssuer;
				}
				return new GDBD.Structs.PoolPropertyStruct<ParserFilterResolver>(_StructIssuer.RestartClass<T, ParserFilterResolver>(config));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PoolPropertyStruct(IEnumerable<T> item)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			ContextClientBridge.RunClient(item, "enumerable");
			_StructIssuer = item;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<T> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((IEnumerable<T>)(_StructIssuer ?? ((object)producerIssuer))).GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator _0001()
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
		public bool _0001(GDBD.Structs.PoolPropertyStruct<T> instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return object.Equals(_StructIssuer, instance._StructIssuer);
		}

		bool IEquatable<GDBD.Structs.PoolPropertyStruct<T>>.Equals(GDBD.Structs.PoolPropertyStruct<T> instance)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (value is GDBD.Structs.PoolPropertyStruct<T>)
			{
				GDBD.Structs.PoolPropertyStruct<T> instance = (GDBD.Structs.PoolPropertyStruct<T>)value;
				return _0001(instance);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_StructIssuer == null)
			{
				return 0;
			}
			return _StructIssuer.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static PoolPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			producerIssuer = new GDBD.Structs.PoolPropertyStruct<T>(Enumerable.Empty<T>());
		}
	}
}
