using GDBD.Specifications;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	internal static class IndexerInstance
	{
		[FieldClassSpec("AAC")]
		public static readonly Guid _DecoratorInstance;

		[FieldClassSpec("ADTS")]
		public static readonly Guid m_FieldInstance;

		[FieldClassSpec("Dolby AC3 SPDIF")]
		public static readonly Guid _ItemInstance;

		[FieldClassSpec("DRM")]
		public static readonly Guid regInstance;

		[FieldClassSpec("DTS")]
		public static readonly Guid processInstance;

		[FieldClassSpec("IEEE floating-point")]
		public static readonly Guid baseInstance;

		[FieldClassSpec("MP3")]
		public static readonly Guid containerInstance;

		[FieldClassSpec("MPEG")]
		public static readonly Guid _ProccesorInstance;

		[FieldClassSpec("WMA 9 Voice codec")]
		public static readonly Guid adapterInstance;

		[FieldClassSpec("PCM")]
		public static readonly Guid _TokenInstance;

		[FieldClassSpec("WMA SPDIF")]
		public static readonly Guid dispatcherInstance;

		[FieldClassSpec("WMAudio Lossless")]
		public static readonly Guid accountInstance;

		[FieldClassSpec("Windows Media Audio")]
		public static readonly Guid _SingletonInstance;

		[FieldClassSpec("Windows Media Audio Professional")]
		public static readonly Guid m_ModelInstance;

		[FieldClassSpec("Dolby AC3")]
		public static readonly Guid m_MessageInstance;

		[FieldClassSpec("MPEG-4 and AAC Audio Types")]
		public static readonly Guid _ProductInstance;

		[FieldClassSpec("Dolby Audio Types")]
		public static readonly Guid interceptorInstance;

		[FieldClassSpec("Dolby Audio Types")]
		public static readonly Guid algoInstance;

		[FieldClassSpec("μ-law")]
		public static readonly Guid annotationInstance;

		[FieldClassSpec("ADPCM")]
		public static readonly Guid exporterInstance;

		[FieldClassSpec("Dolby Digital Plus for HDMI")]
		public static readonly Guid _VisitorInstance;

		[FieldClassSpec("MSAudio1")]
		public static readonly Guid globalInstance;

		[FieldClassSpec("IMA ADPCM")]
		public static readonly Guid wrapperInstance;

		[FieldClassSpec("WMSP2")]
		public static readonly Guid paramsInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IndexerInstance()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_DecoratorInstance = new Guid("00001610-0000-0010-8000-00aa00389b71");
			m_FieldInstance = new Guid("00001600-0000-0010-8000-00aa00389b71");
			_ItemInstance = new Guid("00000092-0000-0010-8000-00aa00389b71");
			regInstance = new Guid("00000009-0000-0010-8000-00aa00389b71");
			processInstance = new Guid("00000008-0000-0010-8000-00aa00389b71");
			baseInstance = new Guid("00000003-0000-0010-8000-00aa00389b71");
			containerInstance = new Guid("00000055-0000-0010-8000-00aa00389b71");
			_ProccesorInstance = new Guid("00000050-0000-0010-8000-00aa00389b71");
			adapterInstance = new Guid("0000000a-0000-0010-8000-00aa00389b71");
			_TokenInstance = new Guid("00000001-0000-0010-8000-00aa00389b71");
			dispatcherInstance = new Guid("00000164-0000-0010-8000-00aa00389b71");
			accountInstance = new Guid("00000163-0000-0010-8000-00aa00389b71");
			_SingletonInstance = new Guid("00000161-0000-0010-8000-00aa00389b71");
			m_ModelInstance = new Guid("00000162-0000-0010-8000-00aa00389b71");
			m_MessageInstance = new Guid("e06d802c-db46-11cf-b4d1-00805f6cbbea");
			_ProductInstance = new Guid("000000ff-0000-0010-8000-00aa00389b71");
			interceptorInstance = new Guid("00002000-0000-0010-8000-00aa00389b71");
			algoInstance = new Guid("a7fb87af-2d02-42fb-a4d4-05cd93843bdd");
			annotationInstance = new Guid("00000007-0000-0010-8000-00aa00389b71");
			exporterInstance = new Guid("00000002-0000-0010-8000-00aa00389b71");
			_VisitorInstance = new Guid("0000000a-0cea-0010-8000-00aa00389b71");
			globalInstance = new Guid("00000160-0000-0010-8000-00aa00389b71");
			wrapperInstance = new Guid("00000011-0000-0010-8000-00aa00389b71");
			paramsInstance = new Guid("0000000b-0000-0010-8000-00aa00389b71");
		}
	}
}
