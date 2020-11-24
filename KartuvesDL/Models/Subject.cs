using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KartuvesDL.Models
{
	[Table("Subjects")]
	public class Subject
	{
		[Key]
		public int SubjectId { get; set; }
		[Required]
		public string Name { get; set; }

		public virtual List<Word> Words { get; set; }

		public virtual List<ScoreBoard> ScoreBoard { get; set; }



	}
}
