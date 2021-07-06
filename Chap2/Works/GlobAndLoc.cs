using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2.Works
{
	public class GlobAndLoc
	{
		int globVal = 10;
		const float PI = 3.14f;

		public void Run()
		{
			int locVal = 20;

			Sum();
			Multiple();

			Console.WriteLine("local: {0} / global: {1}", locVal, globVal);

		}

		private void Sum()
		{
			globVal = globVal + 10;
		}

		private void Multiple()
		{
			globVal = globVal * 2;
		}
	}
}
