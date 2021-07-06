using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Examples
{
	class Ex001
	{
		public void Run()
		{
			sbyte shortByteNumber = 127;
			byte byteNumber = 0;

			short shortNumber = 32754;

			int intNumber = 45555;
			long longNumber = 500000;

			float floatNumber = 3.14f;
			double doubleNumber = 232.121;

			decimal decimalNumber = 5.5m;

			Console.WriteLine("integer: {0}, {1}, {2}, {3}, {4}",
				shortByteNumber,
				byteNumber,
				shortNumber,
				intNumber,
				longNumber
			);
			
			Console.WriteLine("float: {0}, {1}, {2}", floatNumber, doubleNumber, decimalNumber);

		}
	}
}
