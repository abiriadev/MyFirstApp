using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Weather
	{
		public static void Run()
		{
			string[] weathers = new string[7];

			weathers[0] = "sunny";
			weathers[1] = "sunny";
			weathers[2] = "rainy";
			weathers[3] = "cloudy";
			weathers[4] = "rainy";
			weathers[5] = "snow";
			weathers[6] = "sunny";

			int dayCnt = weathers.Length;

			int[] cnts = new int[4];

			for (int i = 0; i < cnts.Length; i++)
			{
				cnts[i] = 0;
			}

			for (int i = 0; i < weathers.Length; i++)
			{
				string weather = weathers[i];

				switch (weather)
				{
					case "sunny":
						++cnts[0];
						break;
					case "cloudy":
						++cnts[1];
						break;
					case "rainy":
						++cnts[2];
						break;
					case "snow":
						++cnts[3];
						break;
				}

			}

			Console.WriteLine($"sunny: {cnts[0]} / cloudy: {cnts[1]} / rainy: {cnts[2]} / snow: {cnts[3]}");

			int[] s = {1, 2, 3, 4};
		}
	}
}
