using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
	public struct Rectangle: IEnumerable<Point>, IEquatable<Rectangle>
	{
		public Point PointA, PointB, PointC, PointD;

		public Rectangle(double[] x, double[] y)
		{
			PointA = Point.Zero;
			PointB = Point.Zero;
			PointC = Point.Zero;
			PointD = Point.Zero;

			SetVerticies(x, y);
		}

		public Rectangle(Point[] points)
			:this(points[0], points[1], points[2], points[3])
		{

		}

		public Rectangle(Point a, Point b, Point c, Point d)
		{
			var normalizedPoints = NormalizePoints(a, b, c, d).ToArray();

			PointA = normalizedPoints[0];
			PointB = normalizedPoints[1];
			PointC = normalizedPoints[2];
			PointD = normalizedPoints[3];
		}

		public double Diagonal()
		{
			var abVector = new
			{
				X = PointB.X - PointA.X,
				Y = PointB.Y - PointA.Y
			};

			var adVector = new
			{
				X = PointD.X - PointA.X,
				Y = PointD.Y - PointA.Y
			};

			double abLen = Math.Sqrt(abVector.X * abVector.X + abVector.Y * abVector.Y);
			double adLen = Math.Sqrt(adVector.X * adVector.X + adVector.Y * adVector.Y);

			return Math.Sqrt(abLen * abLen + adLen * adLen);
		}

		public Rectangle Rotate(float angle)
		{
			Point[] newPoints = new Point[4];
			int i = 0;

			foreach (var point in this)
			{
				Point newPoint = new Point();
				newPoint.X = point.X * Math.Cos(angle) - point.Y * Math.Sin(angle);
				newPoint.Y = point.X * Math.Sin(angle) + point.Y * Math.Cos(angle);
				newPoints[i] = newPoint;
			}

			return new Rectangle(newPoints);
		}

		public void SetVerticies(double[] x, double[] y)
		{
			if (x.Length != 4 || y.Length != 4)
				throw new ArgumentException();

			Point[] normalizedPoints = NormalizePoints(
				new Point(x[0], y[0]),
				new Point(x[1], y[1]),
				new Point(x[2], y[2]),
				new Point(x[3], y[3])).ToArray();

			PointA = normalizedPoints[0];
			PointB = normalizedPoints[1];
			PointC = normalizedPoints[2];
			PointD = normalizedPoints[3];
		}

		private static IEnumerable<Point> NormalizePoints(Point p1, Point p2, Point p3, Point p4)
		{
			Point[] points = new Point[4] {p1, p2, p3, p4};

			if (IsRectange(points[0], points[1], points[2], points[3]))
			{
				yield return points[0];
				yield return points[1];
				yield return points[2];
				yield return points[3];
			}
			else if (IsRectange(points[1], points[2], points[0], points[3]))
			{
				yield return points[1];
				yield return points[2];
				yield return points[0];
				yield return points[3];
			}
			else if (IsRectange(points[2], points[0], points[1], points[3]))
			{
				yield return points[2];
				yield return points[0];
				yield return points[1];
				yield return points[3];
			}
			else
			{
				throw new ArgumentException($"Verticies doesn't fit to {nameof(Rectangle)}");
			}
		}

		private static bool IsOrthogonal(Point a, Point b, Point c)
		{
			return Math.Abs((b.X - a.X) * (b.X - c.X) + (b.Y - a.Y) * (b.Y - c.Y)) < 0.0001f;
		}

		public static bool IsRectange(Point a, Point b, Point c, Point d)
		{
			return
				IsOrthogonal(a, b, c) &&
				IsOrthogonal(b, c, d) &&
				IsOrthogonal(c, d, a);
		}

		public IEnumerator<Point> GetEnumerator()
		{
			yield return PointA;
			yield return PointB;
			yield return PointC;
			yield return PointD;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool Equals(Rectangle other)
		{
			return PointA.Equals(other.PointA) && PointB.Equals(other.PointB) && PointC.Equals(other.PointC) && PointD.Equals(other.PointD);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is Rectangle && Equals((Rectangle) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = PointA.GetHashCode();
				hashCode = (hashCode * 397) ^ PointB.GetHashCode();
				hashCode = (hashCode * 397) ^ PointC.GetHashCode();
				hashCode = (hashCode * 397) ^ PointD.GetHashCode();
				return hashCode;
			}
		}

		public override string ToString()
		{
			return $"A: [{PointA}], B: [{PointB}], C: [{PointC}], D: [{PointD}]";
		}
	}
}
