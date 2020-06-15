using GDBD.Dispatcher;
using GDBD.Strategies;
using Newtonsoft.Database;

namespace GDBD.Mappers
{
	internal interface WriterReaderMapper
	{
		string Source
		{
			get;
		}

		int FramesReceived
		{
			get;
		}

		long BytesReceived
		{
			get;
		}

		bool IsRunning
		{
			get;
		}

		event ParserEvent NewFrame;

		event ObjectBroadcasterDispatcher VideoSourceError;

		event RegEventEntry PlayingFinished;

		void _0001();

		void _0002();

		void _0003();

		void _0004();
	}
}
