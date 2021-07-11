using System;
using System.Collections.Generic;
using System.Collections;

namespace Array.Examples
{
	class ArrayList
	{
		public static void Run()
		{

			System.Collections.ArrayList arrlist = new System.Collections.ArrayList();

			for (int i = 0; i < 10; i++)
			{
				arrlist.Add(i);
			}

			for (int i = 0; i < 15; i++)
			{
				arrlist.Add(i.ToString());
			}

			arrlist.Insert(5, "Abiria");

			arrlist.RemoveAt(13);

			for (int i = 0; i < arrlist.Count; i++)
			{
				Console.WriteLine($"[{arrlist[i].GetType()}] {arrlist[i]}");
			}
		}
	}
}
