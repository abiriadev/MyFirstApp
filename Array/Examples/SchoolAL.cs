using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Examples
{
	class SchoolAL
	{
		public static void Run()
		{
			System
				.Collections
				.ArrayList students = new System
					.Collections
					.ArrayList();

			CollegeStudent student = new CollegeStudent();

			student.Id = "5402";
			student.Name = "Abiria";
			student.Department = "english";
			student.Age = 25;

			students.Add(student);

			for (int i = 0; i < students.Count; i++)
			{
				Console.WriteLine(((CollegeStudent)students[i]).Id);
				Console.WriteLine(((CollegeStudent)students[i]).Name);
				Console.WriteLine(((CollegeStudent)students[i]).Department);
				Console.WriteLine(((CollegeStudent)students[i]).Age);
			}
		}
	}
}
