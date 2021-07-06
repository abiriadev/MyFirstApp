using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class GetType
	{
		public static void Run()
		{
			int number1 = 10;

			double number2 = number1;

			int number3 = (int)number2;

			Console.WriteLine("The type of number1: {0}", number1.GetType());
			Console.WriteLine("The type of number2: {0}", number2.GetType());
			Console.WriteLine("The type of number3: {0}", number3.GetType());
		}
	}
}
