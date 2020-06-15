using GDBD.Specifications;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	internal static class TemplateInstance
	{
		public static readonly Guid expressionInstance;

		[FieldClassSpec("Audio")]
		public static readonly Guid m_ConfigInstance;

		[FieldClassSpec("Video")]
		public static readonly Guid _ConnectionInstance;

		[FieldClassSpec("Protected Media")]
		public static readonly Guid _InitializerInstance;

		[FieldClassSpec("SAMI captions")]
		public static readonly Guid _ObjectInstance;

		[FieldClassSpec("Script stream")]
		public static readonly Guid schemaInstance;

		[FieldClassSpec("Still image stream")]
		public static readonly Guid m_RefInstance;

		[FieldClassSpec("HTML stream")]
		public static readonly Guid threadInstance;

		[FieldClassSpec("Binary stream")]
		public static readonly Guid consumerInstance;

		[FieldClassSpec("File transfer")]
		public static readonly Guid _ComparatorInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TemplateInstance()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			expressionInstance = new Guid("81A412E6-8103-4B06-857F-1862781024AC");
			m_ConfigInstance = new Guid("73647561-0000-0010-8000-00aa00389b71");
			_ConnectionInstance = new Guid("73646976-0000-0010-8000-00aa00389b71");
			_InitializerInstance = new Guid("7b4b6fe6-9d04-4494-be14-7e0bd076c8e4");
			_ObjectInstance = new Guid("e69669a0-3dcd-40cb-9e2e-3708387c0616");
			schemaInstance = new Guid("72178c22-e45b-11d5-bc2a-00b0d0f3f4ab");
			m_RefInstance = new Guid("72178c23-e45b-11d5-bc2a-00b0d0f3f4ab");
			threadInstance = new Guid("72178c24-e45b-11d5-bc2a-00b0d0f3f4ab");
			consumerInstance = new Guid("72178c25-e45b-11d5-bc2a-00b0d0f3f4ab");
			_ComparatorInstance = new Guid("72178c26-e45b-11d5-bc2a-00b0d0f3f4ab");
		}
	}
}
