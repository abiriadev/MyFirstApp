using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class MultiDimention
	{
		public static void Run()
		{
			int[][] gradeOfStudent =
			{
				new int[] {100, 98, 95},
				new int[] {90, 100, 100},
				new int[] {95, 96, 95},
				new int[] {88, 92, 98},
			};

			for (int i = 0; i < gradeOfStudent.Length; i++)
			{
				for (int j = 0; j < gradeOfStudent[i].Length; j++)
				{
					Console.WriteLine($"{i + 1}th student's {j + 1}th grade score: {gradeOfStudent[i][j]}");
				}
			}
		}
	}
}
