using _0008;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Filters;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal abstract class VisitorComposer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Func<T, object> ValidateIssuer<[_0008._0012(2)] T>(MemberInfo last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyInfo propertyInfo = last as PropertyInfo;
			if ((object)propertyInfo != null)
			{
				if (propertyInfo.PropertyType.IsByRef)
				{
					throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".ListReader(CultureInfo.InvariantCulture, propertyInfo));
				}
				return this._0001<T>(propertyInfo);
			}
			FieldInfo fieldInfo = last as FieldInfo;
			if ((object)fieldInfo != null)
			{
				return this._0001<T>(fieldInfo);
			}
			throw new Exception("Could not create getter for {0}.".ListReader(CultureInfo.InvariantCulture, last));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action<T, object> OrderIssuer<[_0008._0012(2)] T>(MemberInfo info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PropertyInfo propertyInfo = info as PropertyInfo;
			if ((object)propertyInfo != null)
			{
				return this._0001<T>(propertyInfo);
			}
			FieldInfo fieldInfo = info as FieldInfo;
			if ((object)fieldInfo != null)
			{
				return this._0001<T>(fieldInfo);
			}
			throw new Exception("Could not create setter for {0}.".ListReader(CultureInfo.InvariantCulture, info));
		}

		public abstract Newtonsoft.Rules.ClientInstanceRule<T, object> _0001<[_0008._0012(2)] T>(MethodBase v);

		public abstract GDBD.Specifications.AdapterClassSpec<object> _0001(MethodBase v);

		public abstract Func<T> _0001<[_0008._0012(2)] T>(Type task);

		public abstract Func<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo spec);

		public abstract Func<T, object> _0001<[_0008._0012(2)] T>(FieldInfo v);

		public abstract Action<T, object> _0001<[_0008._0012(2)] T>(FieldInfo spec);

		public abstract Action<T, object> _0001<[_0008._0012(2)] T>(PropertyInfo res);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected VisitorComposer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
