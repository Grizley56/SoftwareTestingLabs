using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InteractionTesting.Tests.Stubs
{
	public class FakeFileService: IFileService
	{
		public bool IsCalled { get; private set; }
		public int RemoveTemporaryFiles(string dir)
		{
			IsCalled = true;
			return 0;
		}
	}
}
