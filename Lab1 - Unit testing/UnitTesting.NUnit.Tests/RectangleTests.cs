using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace UnitTesting.NUnit.Tests
{
	
	public class RectangleTests
	{
		[TestCase(new double[4] {0, 0, 5, 5}, new double[4] {3, 7, 7, 3})]
		[TestCase(new double[4] {6, 0, 0, 6}, new double[4] {7, 7, 3, 3})]
		public void TestRectangleVerticies(double[] x, double[] y)
		{
			Assert.DoesNotThrow(() =>
			{
				TestContext.Out.WriteLine(new Rectangle(x, y));
			});
		}


		public static IEnumerable<TestCaseData> CreateTestRectanglesWithRotate
		{
			get
			{
				var rectangle = new Rectangle(new Point(0, 0), new Point(0, 10), new Point(10, 10), new Point(10, 0));
				var diagonal = 14.142135623730951;

				for (float angle = 0; angle < 360; angle += 0.5f)
				{
					var rotatedRectangle = rectangle.Rotate(MathHelper.DegToRad(angle));
					yield return new TestCaseData(rotatedRectangle, diagonal);
				}
			}
		}

		public static IEnumerable<TestCaseData> CreateTestRectangles
		{
			get
			{
				yield return new TestCaseData(
					new Rectangle(
						new Point(13.623, 98.1086),
						new Point(13.623, 1208.2),
						new Point(11.33, 98.1086),
						new Point(11.33, 1208.2)),
					1110.0937682029207);

				yield return new TestCaseData(
					new Rectangle(
						new Point(-328, 332.01),
						new Point(-328, -15.1),
						new Point(-100, -15.1),
						new Point(-100, 332.01)),
					415.2942957710833);
			}
		}

		[TestCaseSource(nameof(CreateTestRectanglesWithRotate))]
		[TestCaseSource(nameof(CreateTestRectangles))]
		public void TestRectangleDiagonalRotated(Rectangle rectangle, double diagonal)
		{
			Assert.AreEqual(rectangle.Diagonal(), diagonal, 1d / Math.Pow(10, 7));
		}
	}
}
