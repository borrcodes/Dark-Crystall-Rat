using _0008;
using Newtonsoft.Resolver;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Rules
{
	internal interface RegistryIssuer<[_0008._0012(0)] out T> : IEnumerable<T>, IEnumerable where T : ParserFilterResolver
	{
		Newtonsoft.Rules.RegistryIssuer<ParserFilterResolver> this[object task]
		{
			get;
		}
	}
}
