using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace InteractionTesting.Tests
{
	[TestFixture]
	class ReportViewerMoqTests
	{

		[Test]
		public void TestReportViewerUsedSize()
		{
			Mock<IFileService> mock = new Mock<IFileService>();
			mock.Setup(i => i.RemoveTemporaryFiles(It.IsAny<string>())).Returns(256);

			var reportViewer = new ReportViewer(mock.Object);

			reportViewer.Clean("E:");

			Assert.That(reportViewer.UsedSize, Is.EqualTo(256));
		}

		[Test]
		public void TestRemoveTemporaryFilesGetCalledOnce()
		{
			Mock<IFileService> mock = new Mock<IFileService>();

			var reportViewer = new ReportViewer(mock.Object);

			reportViewer.Clean(string.Empty);

			mock.Verify(i => i.RemoveTemporaryFiles(It.IsAny<string>()), Times.Once);
		}


	}
}
