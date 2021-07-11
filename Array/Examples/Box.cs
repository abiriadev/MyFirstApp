using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class Box
	{
		public Box(
			string from,
			string to,
			int price
		)
		{
			From = from;
			To = to;
			Price = price;
		}

		public string From { get; set; }
		public string To { get; set; }
		public int Price { get; set; }
	}
}
