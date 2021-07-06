using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Works
{
	class WhatNumber
	{
		public static void Run()
		{
			string input = Console.ReadLine();

			int number = (int)Convert.ToDouble(input);

			if (number > 0)
			{
				Console.WriteLine("{0} is positive number", number);
			}
			else if (number == 0)
			{
				Console.WriteLine("{0} is zero", number);
			}
			else
			{
				Console.WriteLine("{0} is nagative number", number);
			}


			Console.WriteLine($"and it is {(number % 2 == 0 ? "even" : "odd")} number");
			
		}
	}
}
