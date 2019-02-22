using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.MS.Tests
{
	[TestClass]
	public class StringFormatterTests
	{
		private StringFormatter _formatter;

		[TestInitialize]
		public void Initialize()
		{
			_formatter = new StringFormatter();
		}

		[TestMethod]
		[DataRow("F:/root/file.bat", "FILE.TMP")]
		[DataRow("E:/g-08ks.ini", "G-08KS.TMP")]
		[DataRow("config", "CONFIG.TMP")]
		[DataRow("", "")]
		public void TestShortFileString(string @in, string @out)
		{
			string result = _formatter.ShortFileString(@in);

			Assert.AreEqual(result, @out, true);
		}

		[TestMethod]
		public void TestNullShortFileString()
		{
			Assert.ThrowsException<NullReferenceException>(() => _formatter.ShortFileString(null));
		}
	}
}
