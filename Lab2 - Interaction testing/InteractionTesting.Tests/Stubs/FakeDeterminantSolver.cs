using System;
using System.Collections.Generic;
using System.Text;

namespace InteractionTesting.Tests.Stubs
{
	class FakeDeterminantSolver: IDeterminantSolver
	{
		public int CallsCount { get; private set; }

		public double Determinant(Matrix m)
		{
			CallsCount++;
			return 1;
		}
	}
}
