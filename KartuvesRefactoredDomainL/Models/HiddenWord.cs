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

		}

		public List<string> IncorrectGueses { get; set; }
		public string[] CorrectGueses { get; set; }
		
	}
}
