using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Dics
	{
		public static void Run()
		{
			Dictionary<string, bool> tf = TF.tf();

			Dictionary<string, Box> dict = new Dictionary<string, Box>();

			dict.Add("abiria", new Box(
				"jeju",
				"seoul",
				454412
			));

			dict.Add("bobo", new Box(
				"boboland",
				"hunee land",
				54
			));

			dict.Add("kuku", new Box(
				"kk town",
				"abiria town",
				45465
			));

			dict.Add("ppt", new Box(
				"microsoft",
				"apple",
				405465
			));

			dict.Add("mac", new Box(
				"apple",
				"google",
				45000500
			));

			dict.Add("google earth", new Box(
				"google",
				"abiria's home",
				2022
			));

			while (true)
			{
				Console.Write("(type Q to exit) please input word: ");
				string word = Console.ReadLine().ToLower();

				if (word == "q")
				{
					Console.WriteLine("Bye! see you again!");
					break;
				}

				if (dict.ContainsKey(word))
				{
					Console.WriteLine($"information of {word} box:");
					Console.WriteLine($"\tfrom: {dict[word].From}");
					Console.WriteLine($"\tto: {dict[word].To}");
					Console.WriteLine($"\tprice: {dict[word].Price}");

					Console.Write($"\nare you want to delete '{word}' from list? (y/n)");
					string ans = Console.ReadLine().ToLower();

					ANS myans = new ANS();

					myans.positive = $"delete the '{word}'";
					myans.nagative = $"good choice!";

					bool res = YNU.ynu(ans, myans);

					if (res)
					{
						// delete the word
						dict.Remove(word);
					}
				}
				else
				{
					Console.WriteLine($"I don't know the word '{word}'");
					//Console.Write("are you add it to dictionary? (y/n)");

					//string ans = Console.ReadLine();

					//ANS myAns = new ANS();

					//myAns.positive = $"add '{word}' to dictionary!";

					//YNU.ynu(ans, )
				}
			}
		}

		private string youWrong(string msg)
		{
			Console.WriteLine($"{msg} is not recognizable.\nplease type only 'y' or 'n'");

			return "s";
		}
	}
}
