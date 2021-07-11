using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class ListT
	{
		public static void Run()
		{
			List<int> aList = new List<int>();

			for (int i = 0; i < 15; i++)
			{
				aList.Add(i);
			}

			aList.Insert(5, 100);

			for (int i = 0; i < aList.Count; i++)
			{
				Console.WriteLine($"value: {aList[i]} / Type: {aList[i].GetType()}");
			}

			aList.RemoveAt(9);

			for (int i = 0; i < aList.Count(); i++)
			{
				Console.WriteLine($"{i}: {aList[i]}");
			}
		}
	}
}
