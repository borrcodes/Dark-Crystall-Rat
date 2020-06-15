using GDBD.Strategies;
using Newtonsoft.Common;

namespace GDBD.Filter
{
	internal interface AttrBroadcasterFilter : CreatorIssuer
	{
		CreatorIssuer _0001(string last);

		CreatorIssuer _0002(string value);

		CreatorIssuer _0003(string item);

		CreatorIssuer _0004(string key);

		CreatorIssuer _0005(string last);

		CreatorIssuer _0001(string instance, string caller, string tag);

		CreatorIssuer _0001(string spec, string caller, string state, string config2);

		CreatorIssuer _0001(string res, string visitor);

		InfoRequestStrategy _0001(string init);

		InfoRequestStrategy _0001(string instance, string attr);

		CreatorIssuer _0002(string v, string cfg);

		CreatorIssuer _0002(string init, string visitor, string template);

		new InfoRequestStrategy _0001();
	}
}
