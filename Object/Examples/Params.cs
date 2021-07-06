using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples
{
	class Params
	{
		public static void Run()
		{
			Console.WriteLine(Sum(1, 2, 3, 4, 5, 6));
		}

		static int Sum(params int[] numbers)
		{
			int res = 0;

			for (int i = 0; i < numbers.Length; ++i)
			{
				res += numbers[i];
			}

			return res;
		}
	}
}
