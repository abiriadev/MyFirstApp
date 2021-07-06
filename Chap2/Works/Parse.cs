using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	class Parse
	{
		public static void Run()
		{
			string strNumber = "340";

			int covNum = Convert.ToInt32(strNumber);
			int covNum2 = Int32.Parse(strNumber);

			Console.WriteLine("covNum: {0}, covNum2: {1}", covNum, covNum2);

			double con_d = Convert.ToDouble(null);
			// double par_d = Double.Parse(null);

			Console.WriteLine("con_d: {0}", con_d);
			// Console.WriteLine("par_d: {0}", par_d);
		}
	}
}
