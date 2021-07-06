using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class Avg
	{
		public static void Run()
		{

			List<double> gl = new List<double> { 100, 100, 98, 97 };

			Console.WriteLine("grades: {0}", string.Join(", ", gl));

			Console.WriteLine("AVG: {0}", AVG(gl));
		}

		static double Sum(List<double> gradeList)
		{
			dynamic count = 0;

			foreach(dynamic grade in gradeList)
			{
				count += grade;
			}

			return count;
		}

		static double AVG(List<double> gradeList)
		{
			double sum = Sum(gradeList);

			return sum / gradeList.Count;
		}
	}
}
