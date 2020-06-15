using GDBD.Mappers;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Resolver;
using System.IO;
using System.Runtime.CompilerServices;

namespace GDBD.Dispatcher
{
	internal sealed class ConnectionBroadcasterDispatcher
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string FindRecord(string item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DirectoryInfo directoryInfo = new DirectoryInfo(item);
			FileInfo[] files = directoryInfo.GetFiles();
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
			for (int i = 0; i < directories.Length; i++)
			{
				DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper();
				decoratorReaderMapper["T"] = ParserFilterResolver._0001("Folder");
				decoratorReaderMapper["N"] = ParserFilterResolver._0001(directories[i].Name);
				decoratorReaderMapper["S"] = ParserFilterResolver._0001("");
				decoratorReaderMapper["M"] = ParserFilterResolver._0001(directories[i].LastWriteTimeUtc.ToString("dd.MM.yyyy HH:mm"));
				instanceClassDispatcher.Add(decoratorReaderMapper);
			}
			for (int j = 0; j < files.Length; j++)
			{
				DecoratorReaderMapper decoratorReaderMapper2 = new DecoratorReaderMapper();
				decoratorReaderMapper2["T"] = ParserFilterResolver._0001("File");
				decoratorReaderMapper2["N"] = ParserFilterResolver._0001(files[j].Name);
				decoratorReaderMapper2["S"] = ParserFilterResolver._0001(ReponseClassSpec.DisableList(files[j].Length));
				decoratorReaderMapper2["M"] = ParserFilterResolver._0001(files[j].LastWriteTimeUtc.ToString("dd.MM.yyyy HH:mm"));
				instanceClassDispatcher.Add(decoratorReaderMapper2);
			}
			return instanceClassDispatcher.SetClass((TimeState)0, new BroadcasterError[0]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ValidateRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DriveInfo[] drives = DriveInfo.GetDrives();
			InstanceClassDispatcher instanceClassDispatcher = new InstanceClassDispatcher();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady)
				{
					DecoratorReaderMapper decoratorReaderMapper = new DecoratorReaderMapper();
					decoratorReaderMapper["T"] = ParserFilterResolver._0001("Drive");
					decoratorReaderMapper["N"] = ParserFilterResolver._0001(driveInfo.Name.Remove(2, 1));
					decoratorReaderMapper["S"] = ParserFilterResolver._0001(ReponseClassSpec.DisableList(driveInfo.TotalSize));
					decoratorReaderMapper["M"] = ParserFilterResolver._0001("");
					instanceClassDispatcher.Add(decoratorReaderMapper);
				}
				else
				{
					DecoratorReaderMapper decoratorReaderMapper2 = new DecoratorReaderMapper();
					decoratorReaderMapper2["T"] = ParserFilterResolver._0001("Drive");
					decoratorReaderMapper2["N"] = ParserFilterResolver._0001(driveInfo.Name.Remove(2, 1));
					decoratorReaderMapper2["S"] = ParserFilterResolver._0001("");
					decoratorReaderMapper2["M"] = ParserFilterResolver._0001("");
					instanceClassDispatcher.Add(decoratorReaderMapper2);
				}
			}
			return instanceClassDispatcher.SetClass((TimeState)0, new BroadcasterError[0]);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConnectionBroadcasterDispatcher()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
