using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Examples
{
	class If
	{
		public static void Run()
		{
			const int zero = 0;

			if (zero == 0)
				Console.WriteLine("is 0");
			else
				Console.WriteLine("not zero");
		}
	}
}
