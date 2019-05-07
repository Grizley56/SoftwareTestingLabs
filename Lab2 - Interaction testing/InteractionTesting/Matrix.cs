using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public struct Matrix
	{
		public double M11;
		public double M12;
		public double M21;
		public double M22;

		public Matrix(double m11, double m12, double m21, double m22)
		{
			M11 = m11;
			M12 = m12;
			M21 = m21;
			M22 = m22;
		}
	}
}
