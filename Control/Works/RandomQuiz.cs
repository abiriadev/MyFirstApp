using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Works
{
	class RandomQuiz
	{
		public static void Run()
		{
			int num1 = GetRandom();
			int num2 = GetRandom();

			Console.Write($"{num1} + {num2} = ");

			int ans = (int)Convert.ToDouble(Console.ReadLine());

			if (ans == num1 + num2)
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				Console.WriteLine("That's wron... :(\nthe right answer is {0}", num1 + num2);
			}
		}

		static int GetRandom()
		{
			System.Random rand = new Random();
			return rand.Next(1, 100);
		}
	}
}
