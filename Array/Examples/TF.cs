using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class TF
	{
		public static Dictionary<string, bool> tf()
		{
			Dictionary<string, bool> tf = new Dictionary<string, bool>();

			tf.Add("y", true);
			tf.Add("n", false);
			
			tf.Add("t", true);
			tf.Add("f", false);

			return tf;
		}
	}
}
