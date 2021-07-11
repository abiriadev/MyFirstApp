using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Hash
	{
		public static void Run()
		{
			Hashtable hash = new Hashtable();

			hash.Add("korea", "KR");
			hash.Add("japan", "JP");
			hash.Add("america", "US");
			hash.Add("england", "UK");

			Console.Write("input word: ");
			string word = Console.ReadLine().ToLower();

			if (hash.Contains(word))
			{
				Console.WriteLine($"{word} : {hash[word]}");
			}
			else
			{
				Console.WriteLine($"No result were found for '{word}'");
			}
		}
	}
}
