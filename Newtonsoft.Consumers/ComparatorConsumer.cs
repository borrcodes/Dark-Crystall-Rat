using GDBD.Specifications;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	internal static class ComparatorConsumer
	{
		public static readonly Guid _EventDic;

		public static readonly Guid filterDic;

		[FieldClassSpec("Transform Flags")]
		public static readonly Guid instanceDic;

		[FieldClassSpec("Transform Category")]
		public static readonly Guid dicDic;

		[FieldClassSpec("Class identifier")]
		public static readonly Guid m_ErrorDic;

		[FieldClassSpec("Input Types")]
		public static readonly Guid m_ComposerDic;

		[FieldClassSpec("Output Types")]
		public static readonly Guid m_PropertyDic;

		public static readonly Guid m_IssuerDic;

		[FieldClassSpec("Name")]
		public static readonly Guid _ReaderDic;

		public static readonly Guid _ClientDic;

		public static readonly Guid _BroadcasterDic;

		[FieldClassSpec("Preferred Output Format")]
		public static readonly Guid _ClassDic;

		public static readonly Guid requestDic;

		public static readonly Guid iteratorDic;

		public static readonly Guid m_TestsDic;

		public static readonly Guid methodDic;

		public static readonly Guid m_AuthenticationDic;

		public static readonly Guid _MapperDic;

		[FieldClassSpec("PMP Host Context")]
		public static readonly Guid m_PredicateDic;

		[FieldClassSpec("App Context")]
		public static readonly Guid policyDic;

		[FieldClassSpec("Duration")]
		public static readonly Guid serviceDic;

		[FieldClassSpec("Total File Size")]
		public static readonly Guid queueDic;

		[FieldClassSpec("Audio encoding bitrate")]
		public static readonly Guid m_ProxyDic;

		[FieldClassSpec("Video Encoding Bitrate")]
		public static readonly Guid m_RegistryDic;

		[FieldClassSpec("MIME Type")]
		public static readonly Guid m_AttrDic;

		[FieldClassSpec("Last Modified Time")]
		public static readonly Guid m_ConfigurationDic;

		[FieldClassSpec("Element ID")]
		public static readonly Guid _CandidateDic;

		[FieldClassSpec("Preferred Language")]
		public static readonly Guid m_TokenizerDic;

		[FieldClassSpec("Playback boundary time")]
		public static readonly Guid m_PrinterDic;

		[FieldClassSpec("Audio is variable bitrate")]
		public static readonly Guid m_MappingDic;

		[FieldClassSpec("Major Media Type")]
		public static readonly Guid mockDic;

		[FieldClassSpec("Media Subtype")]
		public static readonly Guid _ObserverDic;

		[FieldClassSpec("Audio block alignment")]
		public static readonly Guid m_DescriptorDic;

		[FieldClassSpec("Audio average bytes per second")]
		public static readonly Guid m_ProducerDic;

		[FieldClassSpec("Audio number of channels")]
		public static readonly Guid structDic;

		[FieldClassSpec("Audio samples per second")]
		public static readonly Guid _StubDic;

		[FieldClassSpec("Audio bits per sample")]
		public static readonly Guid m_CodeDic;

		[FieldClassSpec("Enable Hardware Transforms")]
		public static readonly Guid taskDic;

		[FieldClassSpec("User data")]
		public static readonly Guid _CustomerDic;

		[FieldClassSpec("All samples independent")]
		public static readonly Guid interpreterDic;

		[FieldClassSpec("Fixed size samples")]
		public static readonly Guid m_WatcherDic;

		[FieldClassSpec("DirectShow Format Guid")]
		public static readonly Guid _CollectionDic;

		[FieldClassSpec("Preferred legacy format structure")]
		public static readonly Guid m_RepositoryDic;

		[FieldClassSpec("Is Compressed")]
		public static readonly Guid m_ServerDic;

		[FieldClassSpec("Average bitrate")]
		public static readonly Guid facadeDic;

		[FieldClassSpec("AAC payload type")]
		public static readonly Guid m_ManagerDic;

		[FieldClassSpec("AAC Audio Profile Level Indication")]
		public static readonly Guid stateDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ComparatorConsumer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_EventDic = new Guid("f81a699a-649a-497d-8c73-29f8fed6ad7a");
			filterDic = new Guid("e5666d6b-3422-4eb6-a421-da7db1f8e207");
			instanceDic = new Guid("9359bb7e-6275-46c4-a025-1c01e45f1a86");
			dicDic = new Guid("ceabba49-506d-4757-a6ff-66c184987e4e");
			m_ErrorDic = new Guid("6821c42b-65a4-4e82-99bc-9a88205ecd0c");
			m_ComposerDic = new Guid("4276c9b1-759d-4bf3-9cd0-0d723d138f96");
			m_PropertyDic = new Guid("8eae8cf3-a44f-4306-ba5c-bf5dda242818");
			m_IssuerDic = new Guid("2fb866ac-b078-4942-ab6c-003d05cda674");
			_ReaderDic = new Guid("314ffbae-5b41-4c95-9c19-4e7d586face3");
			_ClientDic = new Guid("71eeb820-a59f-4de2-bcec-38db1dd611a4");
			_BroadcasterDic = new Guid("34e6e728-06d6-4491-a553-4795650db912");
			_ClassDic = new Guid("7e700499-396a-49ee-b1b4-f628021e8c9d");
			requestDic = new Guid("543186e4-4649-4e65-b588-4aa352aff379");
			iteratorDic = new Guid("53004909-1ef5-46d7-a18e-5a75f8b5905f");
			m_TestsDic = new Guid("8d030fb8-cc43-4258-a22e-9210bef89be4");
			methodDic = new Guid("8ec2e9fd-9148-410d-831e-702439461a8e");
			m_AuthenticationDic = new Guid("88a7cb15-7b07-4a34-9128-e64c6703c4d3");
			_MapperDic = new Guid("111ea8cd-b62a-4bdb-89f6-67ffcdc2458b");
			m_PredicateDic = new Guid("6c990d31-bb8e-477a-8598-0d5d96fcd88a");
			policyDic = new Guid("6c990d32-bb8e-477a-8598-0d5d96fcd88a");
			serviceDic = new Guid("6c990d33-bb8e-477a-8598-0d5d96fcd88a");
			queueDic = new Guid("6c990d34-bb8e-477a-8598-0d5d96fcd88a");
			m_ProxyDic = new Guid("6c990d35-bb8e-477a-8598-0d5d96fcd88a");
			m_RegistryDic = new Guid("6c990d36-bb8e-477a-8598-0d5d96fcd88a");
			m_AttrDic = new Guid("6c990d37-bb8e-477a-8598-0d5d96fcd88a");
			m_ConfigurationDic = new Guid("6c990d38-bb8e-477a-8598-0d5d96fcd88a");
			_CandidateDic = new Guid("6c990d39-bb8e-477a-8598-0d5d96fcd88a");
			m_TokenizerDic = new Guid("6c990d3a-bb8e-477a-8598-0d5d96fcd88a");
			m_PrinterDic = new Guid("6c990d3b-bb8e-477a-8598-0d5d96fcd88a");
			m_MappingDic = new Guid("33026ee0-e387-4582-ae0a-34a2ad3baa18");
			mockDic = new Guid("48eba18e-f8c9-4687-bf11-0a74c9f96a8f");
			_ObserverDic = new Guid("f7e34c9a-42e8-4714-b74b-cb29d72c35e5");
			m_DescriptorDic = new Guid("322de230-9eeb-43bd-ab7a-ff412251541d");
			m_ProducerDic = new Guid("1aab75c8-cfef-451c-ab95-ac034b8e1731");
			structDic = new Guid("37e48bf5-645e-4c5b-89de-ada9e29b696a");
			_StubDic = new Guid("5faeeae7-0290-4c31-9e8a-c534f68d9dba");
			m_CodeDic = new Guid("f2deb57f-40fa-4764-aa33-ed4f2d1ff669");
			taskDic = new Guid("a634a91c-822b-41b9-a494-4de4643612b0");
			_CustomerDic = new Guid("b6bc765f-4c3b-40a4-bd51-2535b66fe09d");
			interpreterDic = new Guid("c9173739-5e56-461c-b713-46fb995cb95f");
			m_WatcherDic = new Guid("b8ebefaf-b718-4e04-b0a9-116775e3321b");
			_CollectionDic = new Guid("73d1072d-1870-4174-a063-29ff4ff6c11e");
			m_RepositoryDic = new Guid("a901aaba-e037-458a-bdf6-545be2074042");
			m_ServerDic = new Guid("3afd0cee-18f2-4ba5-a110-8bea502e1f92");
			facadeDic = new Guid("20332624-fb0d-4d9e-bd0d-cbf6786c102e");
			m_ManagerDic = new Guid("bfbabe79-7434-4d1c-94f0-72a3b9e17188");
			stateDic = new Guid("7632f0e6-9538-4d61-acda-ea29c8c14456");
		}
	}
}
