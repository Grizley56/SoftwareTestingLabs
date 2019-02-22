using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
	public class StringFormatter
	{
		public string ShortFileString(string path)
		{
			if (path == string.Empty)
				return string.Empty;

			if (path == null)
				throw new NullReferenceException(nameof(path));

			return Path.ChangeExtension(Path.GetFileName(path), "tmp").ToUpper();
		}
	}
}
