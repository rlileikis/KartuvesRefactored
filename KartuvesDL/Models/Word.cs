using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesDL.Models
{
	[Table("Words")]
	public class Word
	{
		[Key]
		public int WordId { get; set; }

		public int SubjectId { get; set; }

		public string Text { get; set; }

		public virtual Subject Subject { get; set; }
		public List<ScoreBoard> ScoreBoards { get; set; }
	}



}
