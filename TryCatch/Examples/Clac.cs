using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch.Examples
{
	class Clac
	{
		public static void Run()
		{
			try
			{
				int a = Convert.ToInt32(Console.ReadLine());
				int b = Convert.ToInt32(Console.ReadLine());

				double res = Divide(a, b);

				Console.WriteLine($"res: {res}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		private static double Divide(int number1, int number2)
		{
			if (number2 == 0)
			{
				throw new MyException("can't divide with 0");
			}

			return (double)number1 / number2;
		}
	}
}
