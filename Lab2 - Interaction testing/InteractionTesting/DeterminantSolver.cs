using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionTesting
{
	public class DeterminantSolver: IDeterminantSolver
	{
		public double Determinant(Matrix m)
		{
			return m.M11 * m.M22 - m.M21 * m.M12;
		}
	}
}
