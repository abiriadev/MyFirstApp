using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class MagicBox
	{
		public static void Run()
		{

			#region 3 free types
			object obj = 1;
			var v = "var";
			dynamic d = true;

			Console.WriteLine(obj);
			Console.WriteLine(v);
			Console.WriteLine(d);

			#endregion

			object hello_obj = "Hello world!";
			var hello_v = "Hello_wordl!";	 
			dynamic hello_d = "Hello world!";

			bool isContain1 = hello_obj.ToString().Contains("ello");
			bool isContain2 = hello_v.Contains("ello");
			bool isContain3 = hello_d.Contains("ello");

			Console.WriteLine("1: {0}, 2: {1}, 3: {2}", isContain1, isContain2, isContain3);

			dynamic var1 = "string";

			Console.WriteLine("first: {0}", var1);

			var1 = 222;

			Console.WriteLine("secend: {0}", var1);

		}
	}
}
