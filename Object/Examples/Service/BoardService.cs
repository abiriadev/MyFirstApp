using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples.Service
{
	class BoardService
	{
		Model.Board board;

		public BoardService()
		{
			this.board = new Model.Board();
		}

		public BoardService(Model.Board board)
		{
			this.board = board;
		}

		public void Save(
			int number,
			string title,
			string content,
			string writer
		)
		{
			board.Number = number;
			board.Title = title;
			board.Contents = content;
			board.Writer = writer;
			board.CreateDate = DateTime.Now;
			board.UpdateDate = DateTime.Now;

			Console.WriteLine("the post are saved");
		}

		public void Update(
			string title,
			string content,
			string writer
		)
		{
			board.Title = title;
			board.Contents = content;
			board.Writer = writer;
			board.UpdateDate = DateTime.Now;

			Console.WriteLine("the post updated");
		}

		public void Delete()
		{
			board = null;

			Console.WriteLine("the post deleted");
		}

		public void Read()
		{
			if (board != null)
			{
				Console.WriteLine($"{board.Number}th post");
				Console.WriteLine($"title: {board.Title}");
				Console.WriteLine($"writed at: {board.CreateDate}");
				Console.WriteLine($"last updated at: {board.UpdateDate}");
				Console.WriteLine($"author: ${board.Writer}");
				Console.WriteLine($"content:\n\n{board.Contents}");
			}
			else
			{
				Console.WriteLine("post not exist");
			}
		}
	}
}
