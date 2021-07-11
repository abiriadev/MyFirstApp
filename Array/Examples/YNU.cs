using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class YNU
	{
		public static bool ynu(
			string word,
			ANS ans
		)
		{
			Dictionary<string, bool> tf = TF.tf();

			if (tf.ContainsKey(word))
			{
				if (tf[word])
				{
					// delete the word
					Console.WriteLine(ans.positive);

					return true;
				}
				else
				{
					Console.WriteLine(ans.nagative);
				}
			}
			else
			{
				Console.WriteLine($"{word} is not recognizable.\nplease type only 'y' or 'n'");
			}

			return false;
		}
	}
}
