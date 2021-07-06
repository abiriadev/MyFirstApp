using System;

namespace Chap2
{
	class Program
	{
		static void Main(string[] args)
		{
			Chap2.Examples.Ex001 ex = new Chap2.Examples.Ex001();
			
			ex.Run();

			Works.ChAndString chs = new Works.ChAndString();

			chs.Run();

			Works.BoolTest.Rune();
			Works.MagicBox.Run();
			Works.Avg.Run();
			Works.GetType.Run();
			Works.Parse.Run();
			Works.GlobAndLoc cl = new Works.GlobAndLoc();
			cl.Run();

			Works.IsBig.Run();
		}
	}
}
