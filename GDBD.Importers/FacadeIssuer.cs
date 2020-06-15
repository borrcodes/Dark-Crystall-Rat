using _0008;
using GDBD.Mappers;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Resolver;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal sealed class FacadeIssuer : PropertyDescriptor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FacadeIssuer(string init)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(init, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(object var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(object ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ident as DecoratorReaderMapper)?[Name];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object reference)
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object reference, object ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DecoratorReaderMapper decoratorReaderMapper = reference as DecoratorReaderMapper;
			if (decoratorReaderMapper != null)
			{
				ParserFilterResolver map = (ivk as ParserFilterResolver) ?? new PoolIssuer(ivk);
				decoratorReaderMapper[Name] = map;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0002(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(DecoratorReaderMapper);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Type _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return typeof(object);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return base.NameHashCode;
		}
	}
}
