using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Works
{
	class MovieReview
	{
		public static void Run()
		{
			string title = Console.ReadLine();

			int star = (int)Convert.ToDouble(Console.ReadLine());

			string resp = "";

			switch (star)
			{
				case 1:
					resp = "too boring, isn't it?";
					break;
				case 2:
					resp = "it's just mediocre";
					break;
				case 3:
					resp = "so coool!! I would see it again!";
					break;
				default:
					resp = "I don't handle the review";
					break;
			}

			Console.WriteLine("rate of {0}: {1}\n{2}", title, star, resp);
		}
	}
}
