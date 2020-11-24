using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartuvesDL.Models
{
	[Table("Players")]
	public class Player
	{
		[Key]
		public int PlayerId { get; set; }
		[Required]
		public string Name { get; set; }

		public virtual List<ScoreBoard> ScoreBoards { get; set; }

	}



}
