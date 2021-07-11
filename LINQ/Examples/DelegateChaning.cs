using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples
{
	class DelegateChaning
	{
		private delegate void RunCalc(int a, int b);


		private static void Sum(int a, int b)
		{
			Console.WriteLine($"a + b = {a + b}");
		}

		private static void Multiply(int a, int b)
		{
			Console.WriteLine($"a * b = {a * b}");
		}

		private static void Divide(int a, int b)
		{
			Console.WriteLine($"a / b = {a / b}");
		}

		public static void Run()
		{
			RunCalc clac =
				(RunCalc) System.Delegate.Combine(new RunCalc(Sum), new RunCalc(Multiply), new RunCalc(Divide));

			clac(20, 4);
		}
	}
}
