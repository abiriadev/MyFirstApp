using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples
{
	class Posts
	{
		public static void Run()
		{
			int number = 1;

			string title = "first post";
			string content = "Illo qui ullam laudantium eos hic labore minus. Nobis atque dolores explicabo. Et dignissimos est possimus eos quis enim est repellendus. Sunt et totam qui tempore totam et qui eaque consectetur.\nOccaecati quos eaque ratione quos maxime. Nobis magnam earum provident non hic maiores dolor autem.Quia tempore et sapiente reprehenderit et et quidem placeat.Ipsum est ipsum rem rerum quo. Non nulla et deserunt fugiat id expedita dicta sapiente.\nMaiores quia amet.Non aliquam repellendus quae. Non laboriosam voluptatem quos recusandae a harum quos laudantium.";
			string writer = "Admin";

			Service.BoardService boardService = new Service.BoardService();
			boardService.Save(number, title, content, writer);
			boardService.Read();

			Console.WriteLine("============");

			boardService.Update(
				"edited first post!",
				content,
				writer
			);
			boardService.Read();

			Console.WriteLine("============");

			boardService.Delete();
			boardService.Read();

			Console.WriteLine("============");

			Model.Board board = new Model.Board();

			board.Number = 2;
			board.Title = "secend post";
			board.Contents = "Quis id dolores aut. Et non blanditiis. Excepturi omnis dolor voluptatem. In doloremque atque qui exercitationem non. Ut molestiae quis consequuntur. Iusto nostrum dolorem.\nBeatae veritatis consequatur eos velit non voluptas tempore aliquam ut. Qui eaque non dignissimos distinctio enim. Necessitatibus deleniti architecto illum et unde sunt aliquam omnis.\nQuasi doloribus illo sed distinctio. Illum quae quos molestiae est tenetur qui aliquid itaque. Eius explicabo atque quos. Delectus animi ipsa in possimus. Quaerat ipsa quod nesciunt quae voluptas autem.";
			board.Writer = "abiria";
			board.CreateDate = DateTime.Now;
			board.UpdateDate = DateTime.Now;

			Service.BoardService anotherBoardService = new Service.BoardService();
			anotherBoardService.Read();
		}
	}
}
