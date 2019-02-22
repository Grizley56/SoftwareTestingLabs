using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
	public struct Point: IEquatable<Point>
	{
		public double X;
		public double Y;

		public static Point Zero => new Point();

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public bool Equals(Point other)
		{
			return X.Equals(other.X) && Y.Equals(other.Y);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is Point && Equals((Point) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (X.GetHashCode() * 397) ^ Y.GetHashCode();
			}
		}

		public override string ToString()
		{
			return $"X: {X}, Y: {Y}";
		}
	}
}
