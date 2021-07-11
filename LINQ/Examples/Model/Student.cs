using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Examples.Model
{
	class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Grade { get; set; }
		public string Major { get; set; }

		public Student(int id, string name, int grade, string major)
		{
			Id = id;
			Name = name;
			Grade = grade;
			Major = major;
		}
	}
}
