using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Examples
{
	class FileInfo
	{
		private static readonly string cwd = Environment.CurrentDirectory;

		public static void Run()
		{
			System.IO.FileInfo fileinfo = new System.IO.FileInfo(
				cwd + @"\data\asd.txt"
			);

			Console.WriteLine($"save path: {fileinfo.DirectoryName}");
			Console.WriteLine($"name: {fileinfo.Name}");

			Console.WriteLine("=== file content ===\n");

			using (StreamReader sr = new StreamReader(fileinfo.FullName))
			{
				string line = string.Empty;

				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}
		}
	}
}
