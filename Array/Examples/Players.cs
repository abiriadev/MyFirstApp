using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Players
	{
		public static void Run()
		{
			Stack stk = new Stack();

			Console.WriteLine("* start point");

			for (int i = 0; i < 11; i++)
			{
				stk.Push($"{i}th player");
				Console.WriteLine($"{i}th player reach the finish line");
			}

			Console.WriteLine("==========");
			Console.WriteLine("the 5th through 10th players are eliminated");

			for (int i = 0; i < 6; i++)
			{
				object ply = stk.Pop();
				Console.WriteLine($"the {ply} eliminated");
			}

			Console.WriteLine("==========");

			Console.WriteLine("the national athletes:");
			foreach (object o in stk)
			{
				Console.WriteLine(o.ToString());
			}
		}
	}
}
