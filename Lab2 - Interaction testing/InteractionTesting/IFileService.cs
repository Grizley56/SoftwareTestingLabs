using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public interface IFileService
	{
		int RemoveTemporaryFiles(string dir);
	}
}
