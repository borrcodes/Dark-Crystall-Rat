using _0008;
using System;

namespace GDBD.Strategies
{
	internal interface UtilsRequestStrategy
	{
		Type BindToType(string var1, string b);

		void BindToName([_0008._0012(1)] Type serializedType, out string cont, out string tag);
	}
}
