using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Works
{
	class Factorial
	{
		public static void Run()
		{
			int num = Int32.Parse(Console.ReadLine());

			int res = 1;

			for (int i = 1; i <= num; ++i)
			{
				res *= i;
			}

			Console.WriteLine(res);
		}
	}
}
