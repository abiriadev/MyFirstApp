using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Works
{
	class Files2
	{
		public static void Run()
		{
			string cwd = @"C:\Users\oro36\Downloads\p_lerz server";

			DirectoryInfo dir = new DirectoryInfo(cwd);

			Search(dir, 0);
		}

		private static void Search(DirectoryInfo dir, int depth)
		{
			string tab = String.Concat(Enumerable.Repeat("    ", depth));

			Console.WriteLine($"{tab}{dir.Name}/");

			FileInfo[] files = dir.GetFiles();
			DirectoryInfo[] dirs = dir.GetDirectories();

			foreach (FileInfo file in files)
			{
				if (file.Exists)
				{
					Console.WriteLine($"{tab}{file.Name}");
				}
			}

			foreach (DirectoryInfo subdir in dirs)
			{
				Search(subdir, depth + 1);
			}
		}
	}
}
