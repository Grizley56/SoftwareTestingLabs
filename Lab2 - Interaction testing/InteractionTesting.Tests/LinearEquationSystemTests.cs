using System;
using System.Collections.Generic;
using System.Text;
using InteractionTesting.Tests.Stubs;
using NUnit.Framework;

namespace InteractionTesting.Tests
{
	[TestFixture]
	class LinearEquationSystemTests
	{
		[Test]
		public void TestDeterminantSolverGetCalled()
		{
			var mock = new FakeDeterminantSolver();

			LinearEquationsSystem system = new LinearEquationsSystem()
			{
				DeterminantSolver = mock
			};

			system.SetCoefficients(new double[,] {{1, 2}, {3, 4}});
			system.Solve();

			Assert.That(mock.CallsCount, Is.AtLeast(1));
		}

		[Test]
		public void TestEquationSystemSolveZeroDeterminantThrowException()
		{
			var stub = new FakeDeterminantSolverZero();
			LinearEquationsSystem system = new LinearEquationsSystem()
			{
				DeterminantSolver = stub
			};

			system.SetCoefficients(new double[,] { { 0, 0 }, { 0, 0 } });
			Assert.Throws<Exception>(() => system.Solve());
		}

		[Test]
		public void TestEquationSystemSetCoefficientsInvalidArrayThrowException()
		{
			LinearEquationsSystem system = new LinearEquationsSystem();

			Assert.Multiple(() =>
			{
				Assert.Throws<Exception>(() => system.SetCoefficients(new double[1, 1]));
				Assert.Throws<Exception>(() => system.SetCoefficients(new double[1, 2]));
				Assert.Throws<Exception>(() => system.SetCoefficients(new double[2, 1]));
				Assert.Throws<Exception>(() => system.SetCoefficients(new double[3, 3]));
			});
		}



	}
}
