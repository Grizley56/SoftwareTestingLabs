using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;

namespace InteractionTesting.Tests
{
	[TestFixture]
	class LinearEquationSystemMoqTests
	{
		[Test]
		public void TestDeterminantSolverCalls()
		{
			var mock = new Mock<IDeterminantSolver>();
			mock.Setup(i => i.Determinant(It.IsAny<Matrix>())).Returns(1);


			LinearEquationsSystem system = new LinearEquationsSystem()
			{
				DeterminantSolver = mock.Object
			};

			Matrix m = new Matrix(1, 2, 3, 4);

			var arg = new[,] {{m.M11, m.M12}, {m.M21, m.M22}};

			system.SetCoefficients(arg);
			system.Solve();

			mock.Verify(i => i.Determinant(m), Times.Once);
		}

		[Test]
		public void TestEquationSystemSolveZeroDeterminantThrowException()
		{
			var mock = new Mock<IDeterminantSolver>();
			mock.Setup(i => i.Determinant(It.IsAny<Matrix>())).Returns(0);

			LinearEquationsSystem system = new LinearEquationsSystem()
			{
				DeterminantSolver = mock.Object
			};
			system.SetCoefficients(new double[,] {{1, 2}, {3, 4}});

			Assert.Throws<Exception>(() => system.Solve());
		}


	}
}
