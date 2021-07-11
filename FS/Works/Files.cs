using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Works
{
	class Files
	{
		public static void Run()
		{
			string cwd = Environment.CurrentDirectory;

			DirectoryInfo dir = new DirectoryInfo(cwd);

			FileInfo[] files = dir.GetFiles();

			foreach (FileInfo file in files)
			{
				if (file.Exists)
				{
					Console.WriteLine($"{file.Name}");
				}
			}
		}
	}
}
