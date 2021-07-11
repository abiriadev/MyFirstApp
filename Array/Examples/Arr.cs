using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Arr
	{
		public static void Run()
		{
			string weather = "sunny,sunny,cloudy,rainy,snow,sunny";

			var weathers = weather.Split(',');

			Console.WriteLine(weather.GetType());
			Console.WriteLine(weathers.GetType());

			//Console.ReadLine();

			string[] strArr = new string[4];

			strArr[0] = "a";
			strArr[1] = "b";
			strArr[2] = "c";
			strArr[3] = "d";

			for (int i = 0; i < strArr.Length; i++)
			{
				Console.WriteLine($"strArr[{i}] : {strArr[i]}");
			}
		}
	}
}
