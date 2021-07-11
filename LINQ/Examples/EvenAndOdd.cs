using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples
{
	class EvenAndOdd
	{

		public static void Run()
		{

			int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

			List<int> tmpNumbers = new List<int>();

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] % 2 == 0)
				{	
					tmpNumbers.Add(numbers[i]);
				}
			}

			for (int i = 0; i < tmpNumbers.Count; i++)
			{
				Console.WriteLine(tmpNumbers[i]);
			}

			tmpNumbers.Clear();

			tmpNumbers = numbers.Where(n => n % 2 == 1).ToList();

			for (int i = 0; i < tmpNumbers.Count; i++)
			{
				Console.WriteLine(tmpNumbers[i]);
			}
		}
	}
}
