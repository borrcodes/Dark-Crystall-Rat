using System;

namespace Newtonsoft.Filters
{
	internal enum FileFormatVersions : byte
	{
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		m_ProductIssuer = 2,
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		interceptorIssuer
	}
}
