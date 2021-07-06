using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class BoolTest
	{
		public static void Rune()
		{
			bool bCalculate01 = (1 + 2 == 3);

			bool bCalculate02 = ((12 > 8) && (8 < 20));
			bool isContainsWord = "Help me plz".Contains("me");

			Console.WriteLine("1 + 2 = 3 ? {0}", bCalculate01);
			Console.WriteLine(bCalculate02);
			Console.WriteLine("does the string contains the word 'me' ? {0}", isContainsWord);
		}
	}
}
