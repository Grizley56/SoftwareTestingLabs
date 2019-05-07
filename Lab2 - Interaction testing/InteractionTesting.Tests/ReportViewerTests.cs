using System;
using System.Collections.Generic;
using System.Text;
using InteractionTesting.Tests.Stubs;
using NUnit.Framework;

namespace InteractionTesting.Tests
{
	[TestFixture]
	public class ReportViewerTests
	{
		private ReportViewer _reportViewer = new ReportViewer(new FakeFileService());



		[Test]
		public void TestInvalidCleanPathThrow()
		{
			Assert.That(() => _reportViewer.Clean(":/-'`"), Throws.ArgumentException);
		}

		[Test]
		public void TestClean()
		{
			_reportViewer.Clean("E:");
		}

		[Test]
		public void TestRemoveTemporaryFilesGetCalled()
		{
			var stub = new FakeFileService();
			var reportViewer = new ReportViewer(stub);

			reportViewer.Clean("E:");

			Assert.That(stub.IsCalled, Is.EqualTo(true));
		}
	}
}
