using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples
{
	class LinqTest
	{
		private delegate int RunCalc(int a, int b);

		public static void Run()
		{
			RunCalc calc = (a, b) => a + b;

			Console.WriteLine(calc(10, 20));

			calc = (a, b) => a * b;

			Console.WriteLine(calc(10, 20));

			calc = (a, b) =>
			{
				if (a > b)
				{
					return a + b;
				}
				else
				{
					return a * b;
				}
			};

			Console.WriteLine(calc(10, 20));
			Console.WriteLine(calc(20, 10));
		}
	}
}
