using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
	public class ArrayProcessor
	{
		public int[] SortAndFilter(int[] array)
		{
			if (array == null)
				throw new ArgumentNullException(nameof(array));

			return array.Where(i => i > 999 && i < 10000).OrderBy(i => i).ToArray();
		}
	}
}
