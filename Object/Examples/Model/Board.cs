using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object.Examples.Model
{
	/// <summary>
	///  post board
	/// </summary>
	/// 
	class Board
	{
		/// <summary>
		/// post id
		/// </summary>
		public int Number { get; set;}

		/// <summary>
		/// title of post
		/// </summary>
		public string Title{ get; set; }

		/// <summary>
		/// content of post
		/// </summary>
		public string Contents { get; set; }

		/// <summary>
		/// author of post
		/// </summary>
		public string Writer { get; set; }

		/// <summary>
		/// time when the post created
		/// </summary>
		public DateTime CreateDate { get; set; }

		/// <summary>
		/// when edited
		/// </summary>
		public DateTime UpdateDate { get; set; }
	}
}
