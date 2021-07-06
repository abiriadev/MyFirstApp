using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class IsBig
	{
		public static void Run()
		{
			Console.Write("input first number: ");
			string number1 = Console.ReadLine();
			Console.Write("input secend number: ");
			string number2 = Console.ReadLine();

			double num1 = Convert.ToDouble(number1);
			double num2 = Double.Parse(number2);

			Console.WriteLine("is {0} greater than {1} ? {2}", num1, num2, num1 > num2);
		}
	}
}
