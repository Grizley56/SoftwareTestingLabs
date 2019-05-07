using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTesting.Tests.Stubs
{
	class FakeDeterminantSolverZero: IDeterminantSolver
	{
		public double Determinant(Matrix m)
		{
			return 0;
		}
	}
}
