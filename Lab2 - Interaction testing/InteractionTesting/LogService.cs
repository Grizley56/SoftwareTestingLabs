using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public class LogService
	{
		public string FilePath { get; }

		public LogService(string filePath)
		{
			FilePath = filePath;
		}

		public void Log(params string[] message)
		{
			File.AppendAllLines(FilePath, message);
		}
	}
}
