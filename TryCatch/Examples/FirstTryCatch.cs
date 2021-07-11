using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch.Examples
{
	class FirstTryCatch
	{
		public static void Run()
		{
			try
			{
				int number = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine($"inputed number: {number}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception code: {e.HResult}");
				Console.WriteLine($"Exception message: {e.Message}");
			}
		}
	}
}
