using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Examples
{
	class Loop
	{
		public static void Run()
		{
			int cache = 1;

			for (int i = 1; i <= 5; ++i)
			{
				cache *= i;
			}

			Console.WriteLine(cache);
		}
	}
}
