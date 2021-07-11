using System;
using System.Collections.Generic;

namespace Array.Examples
{
	class Sort
	{
		public static void Run()
		{
			List<int> list = new List<int>();

			for (;;)
			{
				Console.Write($"(type q to stop) input the number: ");

				string input = Console.ReadLine();

				if (input == "q")
				{
					Console.WriteLine();
					break;
				}

				int number = 0;

				bool result = int.TryParse(input, out number);

				if (result)
				{
					list.Add(number);
				}
				else
				{
					Console.WriteLine("please input decimal number!");	
				}
			}

			string res = "";

			list.Sort();

			for (int i = 0; i < list.Count; ++i)
			{
				if (i != 0)
				{
					res += ", ";
				}
				res += list[i].ToString();
			}

			Console.WriteLine($"sorted result: {res}");
		}
	}
}
