using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples
{
	class Delegate
	{
		private delegate int RunCalc(int a, int b);

		private static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}

		private static int Multiply(int number1, int number2)
		{
			return number1 * number2;
		}

		public static void Run()
		{
			RunCalc calc = Sum;
			
			Console.WriteLine(calc(10, 20));
			
			calc = Multiply;

			Console.WriteLine(calc(10, 20));

			RunCalc newDelegate = delegate(int a, int b)
			{
				return a / b;
			};

			Console.WriteLine(newDelegate(20, 10));
		}
	}
}
