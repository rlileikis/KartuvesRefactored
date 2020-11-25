using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactoredDomainL.Models
{
	public class HiddenWord
	{
		public HiddenWord(int wordSize)
		{
			CorrectGueses = new string[wordSize];
			IncorrectGueses = new List<string>();

		}

		public List<string> IncorrectGueses { get; set; }
		public string[] CorrectGueses { get; set; }

		public int HiddenLetterCount => CorrectGueses.Count(z => z == null);

	}
}
