using NUnit.Framework;

namespace UnitTesting.NUnit.Tests
{
	public class ArrayProcessorTests
	{
		private ArrayProcessor _processor;

		[SetUp]
		public void Setup()
		{
			_processor = new ArrayProcessor();
		}

		[TestCase(new [] {0, 10285, 2993, -6555, -1823, 88982, 1, 5938}, new [] {2993, 5938})]
		[TestCase(new [] {9999999, 9184, -0, -1828, 9588, 1111, -1872}, new [] { 1111, 9184, 9588  })]
		[TestCase(new int[0], new int[0])]
		public void TestSortAndFilter(int[] @in, int[] @out)
		{
			int[] result = _processor.SortAndFilter(@in);

			Assert.That(result, Is.Not.SameAs(@in));

			CollectionAssert.IsOrdered(result);
			
			CollectionAssert.AreEqual(result, @out);
		}

		[Test]
		public void TestNullSortAndFilter() => 
			Assert.That(() => _processor.SortAndFilter(null), Throws.ArgumentNullException);
	}
}