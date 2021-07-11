using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Examples
{
	class Dirinfo
	{
		private static readonly string currentDirectory = System.Environment.CurrentDirectory;

		public static void Run()
		{
			DirectoryInfo dirInfo = new DirectoryInfo(currentDirectory + @"\data");

			if (!dirInfo.Exists)
			{
				dirInfo.Create();
				Console.WriteLine($"create directory");
			}

			Console.WriteLine($"dir path: {dirInfo.FullName}");

			using (StreamWriter strm = new StreamWriter(dirInfo.FullName + @"\asd.txt", true))
			{
				strm.WriteLine($"on time: {DateTime.Now}");
			}
		}
	}
}
