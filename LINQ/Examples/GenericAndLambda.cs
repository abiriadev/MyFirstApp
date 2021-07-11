using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using LINQ.Examples.Model;

namespace LINQ.Examples
{
	class GenericAndLambda
	{
		private static List<Model.Student> Students = new List<Student>()
		{
			new Student(1, "Dexter", 3, "Software"),
			new Student(2, "Jeffrey", 4, "Software"),
			new Student(3, "pil", 4, "Software"),
			new Student(4, "Khan", 2, "Software"),
			new Student(5, "Sven", 2, "Software"),
			new Student(6, "Ellin", 3, "Design"),
			new Student(7, "Sienna", 4, "Design"),
			new Student(8, "Clint", 3, "Software"),
			new Student(9, "Mike", 2, "Advertisement"),
			new Student(10, "Peter", 1, "Theater")
		};


		public static void Run()
		{
			List<Student> res = new List<Student>();

			for (int i = 0; i < Students.Count; i++)
			{
				if (Students[i].Grade == 1 || Students[i].Grade == 3)
				{
					res.Add(Students[i]);
				}
			}

			for (int i = 0; i < res.Count; i++)
			{
				Console.WriteLine(res[i]);
			}

			Console.WriteLine("===========");

			Students.Where(s => s.Grade == 1 || s.Grade == 3).ToList().ForEach(s => Console.WriteLine(s.Name));

			Console.WriteLine("===========");

			int count1 = 0;

			for (int i = 0; i < Students.Count; i++)
			{
				if (Students[i].Grade >= 3)
				{
					++count1;
				}
			}

			Console.WriteLine(count1);

			Console.WriteLine("===========");

			Console.WriteLine(Students.Where(s => s.Grade >= 3).Count());

			Console.WriteLine("===========");

			Students.GroupBy(s => s.Major, (key, g) => new
			{
				Major = key, Count = g.Count()
			}).ToList().ForEach(s => Console.WriteLine($"{s.Major}: {s.Count}"));

			Console.WriteLine("===========");

			Console.WriteLine($"SUM: {Students.Select(s => s.Grade).Sum()}");
			Console.WriteLine($"SUM: {Students.Select(s => s.Grade).Max()}");
			Console.WriteLine($"SUM: {Students.Select(s => s.Grade).Min()}");
			Console.WriteLine($"SUM: {Students.Select(s => s.Grade).Average()}");

			Console.WriteLine("===========");

			var result = from s in Students where s.Grade is 1 or 3 select s;

			foreach (var r in result)
			{
				Console.WriteLine($"{r.Name}: {r.Major}");
			}
			
			Console.WriteLine("===========");

			var result2 = from s in Students where s.Grade >= 3 select s;

			Console.WriteLine(result2.Count());

			Console.WriteLine("===========");

			var result3 = from s in Students orderby s.Grade select s;

			foreach (var r in result3)
			{
				Console.WriteLine($"{r.Name}: {r.Major}");
			}
			
			Console.WriteLine("===========");

			var result4 = from s in Students
				group s by s.Major
				into grp
				select new
				{
					Major = grp.Key,
					Count = grp.Count()
				};

			foreach (var r in result4)
			{
				Console.WriteLine($"{r.Major}: {r.Count}");
			}

			Console.WriteLine("===========");

			var lis = Students.Where(s => s.Major == "Software").Select(s => s.Name);

			foreach (var li in lis)
			{
				Console.WriteLine(li);
			}

			Console.WriteLine("===========");

			var lis2 = Students.Where(s => s.Name.Contains("e")).Select(s => s.Name);

			foreach (var li in lis2)
			{
				Console.WriteLine(li);
			}

		}
	}
}
