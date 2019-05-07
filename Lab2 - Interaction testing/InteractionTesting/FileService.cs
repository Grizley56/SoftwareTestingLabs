using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public class FileService: IFileService
	{
		private LogService _logService;

		public FileService()
		{
			_logService = new LogService("error.log");
		}

		public int RemoveTemporaryFiles(string dir)
		{
			var toRemove = Path.Combine(dir, "ToRemove.txt");

			if (!File.Exists(toRemove))
				throw new FileNotFoundException("File not found.", toRemove);

			int totalBytes = 0;
			
			using (StreamReader reader = new StreamReader(File.OpenRead(toRemove)))
			{
				while (!reader.EndOfStream)
				{
					var removeFile = reader.ReadLine();

					if (removeFile == null || !File.Exists(removeFile))
					{
						_logService.Log($"File {removeFile} doesn't exist");
						continue;
					}

					FileInfo file = new FileInfo(removeFile);
					file.Delete();

					totalBytes += (int)file.Length;
				}

				return totalBytes;
			}
		}
	}
}
