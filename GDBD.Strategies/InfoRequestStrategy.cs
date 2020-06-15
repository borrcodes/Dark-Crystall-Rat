using Newtonsoft.Common;

namespace GDBD.Strategies
{
	internal interface InfoRequestStrategy : CreatorIssuer
	{
		new void _0001(CreatorIssuer key);

		string _0001(string def);

		new bool _0001();
	}
}
