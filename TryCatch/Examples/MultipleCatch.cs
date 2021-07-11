using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch.Examples
{
	class MultipleCatch
	{
		public static void Run()
		{
			int number = 0;
			bool isException = false;

			try
			{
				number = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Format Exception!");
				isException = true;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Overflow!");
				isException = true;
			}
			catch (Exception e)
			{
				Console.WriteLine($"Exception code: {e.HResult}");
				Console.WriteLine($"Exception message: {e.Message}");

				isException = true;
			}
			finally
			{
				if (isException)
				{
					number = 0;
				}

				Console.WriteLine($"inputed number: {number}");
			}
		}
	}
}