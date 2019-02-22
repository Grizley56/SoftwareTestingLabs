using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
	public static class MathHelper
	{
		public static float DegToRad(float angle)
		{
			return (float)(Math.PI * angle) / 180f;
		}
	}
}
