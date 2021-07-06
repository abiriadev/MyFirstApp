using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Works
{
	class UpDown
	{
		public static void Run()
		{
			int secretNumber = GetRandom();

			Console.WriteLine("guess my number!");

			int count = 1;
			int ques = Int32.Parse(Console.ReadLine());

			while (ques != secretNumber) {
				if (ques > secretNumber)
				{
					Console.WriteLine("too high!");
				}
				else
				{
					Console.WriteLine("too low!");
				}

				ques = Int32.Parse(Console.ReadLine());
				++count;
			}

			Console.WriteLine("That's right!");
			Console.WriteLine("you took {0} times to guess the number!", count);
		}

		static int GetRandom()
		{
			Random rand = new Random();
			return rand.Next(1, 100);
		}
	}
}
