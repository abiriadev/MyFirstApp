using System;

namespace Vars
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Examples.Hello hello = new Examples.Hello();

			hello.Run();
		}
	}
}
