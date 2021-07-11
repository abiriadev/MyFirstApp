using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class CollegeStudent : Student
	{
		public string Department { get; set; }

		private int age;
		public override int Age
		{
			get { return age; }
			set
			{
				if (value < 20)
				{
					return;
				}
				else
				{
					age = value;
				}
			}
		}
	}
}
