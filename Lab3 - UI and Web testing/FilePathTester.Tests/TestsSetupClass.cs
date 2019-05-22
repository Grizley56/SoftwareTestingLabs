using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FilePathTester.Tests
{
	[SetUpFixture]
	public class TestsSetupClass
	{
		[OneTimeSetUp]
		public void GlobalSetup()
		{
			// Do login here.
		}

		[OneTimeTearDown]
		public void GlobalTeardown()
		{
			PathTesterWindow.Instance.Dispose();
		}
	}
}
