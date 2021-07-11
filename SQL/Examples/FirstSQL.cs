using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
//using dotenv.net;


namespace SQL.Examples
{
	class FirstSQL
	{
		private static readonly string cwd = Environment.CurrentDirectory;

		private static readonly string ip = "127.0.0.1";
		private static readonly int port = 1433;
		private static readonly string DBname = "testdb";
		private static readonly string user = "sa";
		private static readonly string password = "1234";

		private static readonly string connectionStr = $"Data Source={ip},{port};Initial Catalog={DBname};User ID={user};Password={password}";

		public static void Run()
		{
			CheckDirectory();
			TryConnectToDB();
		}

		private static void CheckDirectory()
		{
			DirectoryInfo dirinfo = new DirectoryInfo(cwd + @"\data");

			if (!(dirinfo.Exists))
			{
				dirinfo.Create();
			}
		}

		public static void TryConnectToDB()
		{
			//DotEnv.Load();


			//DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { "./../.env" }));
			//var envVars = DotEnv.Read();

			Console.WriteLine(envVars);

			foreach (var envVar in envVars)
			{
				Console.WriteLine(envVar.Key.Length);


			}

			//Console.WriteLine(envVars["KEY"]); // would print out whatever value was associated with the 'KEY'

			SqlConnection connection = new SqlConnection(connectionStr);

			string fileName = $@"\data\db_{DateTime.Now.ToString("yyyyMMddHHmmss")}.log";

			using (StreamWriter sw = new StreamWriter(cwd + fileName, true))
			{
				sw.WriteLine($"[{DateTime.Now}] try connect to database...");

				connection.Open();

				Console.WriteLine(connection.State);

				if (connection.State == System.Data.ConnectionState.Closed)
				{
					Console.WriteLine("CLOSED!!!\n\n");

					connection.ConnectionString = connectionStr;
					connection.Open();
				}

				sw.WriteLine($"[{DateTime.Now}] successfully database connected...OK");

				Model.User user = SetUser();

				#region insert

				string insertSQL = $"INSERT INTO {"TB_USER"} (ID, NAME, AGE, JOB) VALUES ('{user.ID}', '{user.Name}', '{user.Age}', '{user.Job}')";

				using (SqlCommand sqlcmd = new SqlCommand(insertSQL, connection))
				{
					int activeNumber = sqlcmd.ExecuteNonQuery();

					sw.WriteLine($"response data: {activeNumber}");
				}

				#endregion

				#region update

				string update = $"UPDATE {"TB_USER"} SET {"NAME"} = '{"new_name"}' WHERE ID = '{"4"}'";

				using (SqlCommand updateCmd = new SqlCommand(update, connection))
				{
					int activeNumber = updateCmd.ExecuteNonQuery();

					sw.WriteLine($"response data-update: {activeNumber}");
				}

				#endregion

				#region delete

				string deleteSQL = $"DELETE FROM {"TB_USER"} WHERE ID = '{"2"}'";

				using (SqlCommand deleCommand = new SqlCommand(deleteSQL, connection))
				{
					int activeNumber = deleCommand.ExecuteNonQuery();

					sw.WriteLine($"response data-delete: {activeNumber}");
				}

				#endregion

				#region select

				string sql2 = $"SELECT * FROM TB_USER";

				using (SqlCommand select = new SqlCommand(sql2, connection))
				{
					SqlDataReader reader = select.ExecuteReader();

					Console.WriteLine("\n");

					while (reader.Read())
					{
						Console.WriteLine("\n==========");
						Console.WriteLine($"UserID: {reader["ID"]}");
						Console.WriteLine($"Name: {reader["NAME"]}");
						Console.WriteLine($"Age: {reader["AGE"]}");
						Console.WriteLine($"Job: {reader["JOB"]}");
					}
				}

				#endregion

				sw.WriteLine($"[{DateTime.Now}] try close connection...");

				connection.Close();

				sw.WriteLine($"[{DateTime.Now}] success to close connection...OK");
				
			}
		}

		private static Model.User SetUser()
		{
			Model.User user = new Model.User();

			bool validate = false;

			do
			{
				Console.Write("input new user ID: ");
				user.ID = Console.ReadLine();

				Console.Write("input new user name: ");
				user.Name = Console.ReadLine();

				Console.Write("input age of new user: ");
				user.Age = Convert.ToInt32(Console.ReadLine());

				Console.Write("input new user's job: ");
				user.Job = Console.ReadLine();

				Console.WriteLine();

				Console.WriteLine($"{user.Name}: ID {user.ID} / Age {user.Age} / Job {user.Job}");
				Console.Write("Are you sure about the above? (y/n) ");

				validate = Console
					.ReadLine()
					.ToLower() != "y";

			} while (validate);

			return user;
		}
	}
}
