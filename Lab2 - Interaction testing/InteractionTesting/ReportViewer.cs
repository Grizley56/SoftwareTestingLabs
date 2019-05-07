using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public class ReportViewer
	{
		public IFileService FileService { get; set; }
		public int UsedSize { get; private set; }
		public ReportViewer(IFileService service)
		{
			FileService = service;
		}

		public ReportViewer()
		{
			
		}

		public void Clean(string dir)
		{
			if (dir.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
				throw new ArgumentException(nameof(dir));

			try
			{
				UsedSize = FileService.RemoveTemporaryFiles(dir);
			}
			catch
			{
				UsedSize = 0;
			}
		}
	}
}
