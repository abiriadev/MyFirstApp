using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class SchoolLT
	{
		public static void Run()
		{
			System
				.Collections
				.Generic
				.List<
					CollegeStudent
				> students = new System
					.Collections
					.Generic
					.List<
						CollegeStudent
					>();

			CollegeStudent student = new CollegeStudent();

			student.Id = "5402";
			student.Name = "Abiria";
			student.Department = "english";
			student.Age = 25;

			students.Add(student);

			for (int i = 0; i < students.Count; i++)
			{
				Console.WriteLine(students[i].Id);
				Console.WriteLine(students[i].Name);
				Console.WriteLine(students[i].Department);
				Console.WriteLine(students[i].Age);
			}
		}
	}
}