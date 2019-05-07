using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public class LinearEquationsSystem
	{
		private double[,] _coefficients;

		public IDeterminantSolver DeterminantSolver { get; set; }

		public LinearEquationsSystem()
		{
			
		}

		public double[] Solve()
		{
			Matrix matrix = new Matrix(_coefficients[0, 0], _coefficients[0, 1], _coefficients[1, 0], _coefficients[1, 1]);
			var determinant = DeterminantSolver.Determinant(matrix);

			if (Math.Abs(determinant) < 0.00001f)
				throw new Exception();


			matrix.M11 = _coefficients[0, 3];
			matrix.M21 = _coefficients[1, 3];

			var determinant2 = DeterminantSolver.Determinant(matrix);

			matrix.M12 = _coefficients[0, 3];
			matrix.M22 = _coefficients[1, 3];

			var determinant3 = DeterminantSolver.Determinant(matrix);

			return new double[2]
			{
				determinant2 / determinant,
				determinant3 / determinant
			};
		}

		public void SetCoefficients(double[,] coefficients)
		{
			if (coefficients.GetLength(0) != 3 || coefficients.GetLength(1) != 3)
				throw new Exception();

			_coefficients = coefficients;
		}
	}
}
