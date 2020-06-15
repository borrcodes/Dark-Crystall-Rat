namespace Newtonsoft.Candidates
{
	public enum WatcherComposer
	{
		None,
		StartObject,
		StartArray,
		StartConstructor,
		PropertyName,
		Comment,
		Raw,
		Integer,
		Float,
		String,
		Boolean,
		Null,
		Undefined,
		EndObject,
		EndArray,
		EndConstructor,
		Date,
		Bytes
	}
}
