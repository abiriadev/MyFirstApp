using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Array.Examples
{
	class QueueT
	{
		public static void Run()
		{
			// FIFO
			System
				.Collections
				.Generic
				.Queue<
					string
				> que = new System
					.Collections
					.Generic
					.Queue<
						string
					>();

			for (int i = 0; i < 11; i++)
			{
				que.Enqueue(String.Format($"{i}th passenger"));
			}

			Console.WriteLine("* the current state of station");

			foreach (object obj in que)
			{
				Console.WriteLine(obj.ToString());
			}

			Console.WriteLine("==========================");
			Console.WriteLine("the bus comes");

			for (int i = 0; i < 6; i++)
			{
				object obj2 = que.Dequeue();

				Console.WriteLine($"{obj2.ToString()} gets on the bus");
			}

			Console.WriteLine("the bus leaves the station");
			Console.WriteLine("==========================");

			Console.WriteLine("new passengers queue up the station");

			que.Enqueue("new passenger1");
			que.Enqueue("new passenger2");

			Console.WriteLine("the current state of passenger queue");

			foreach (object obj in que)
			{
				Console.WriteLine(obj.ToString());
			}

			Console.WriteLine("==========================");
		}
	}
}
