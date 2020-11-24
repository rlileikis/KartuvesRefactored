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
			CorrectGuess = new string[wordSize];

		}

		public string[] CorrectGuess { get; set; }
		public List<string> IncorrectGueses { get; set; }
	}
}
