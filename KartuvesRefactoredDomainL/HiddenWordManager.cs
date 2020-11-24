using KartuvesDL.Models;
using KartuvesRefactoredDomainL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactoredDomainL
{
	public class HiddenWordManager : IHiddenWordManager
	{
		private readonly Word _word;

		public HiddenWordManager(Word word)
		{
			_word = word;
		}

		public HiddenWordManager GetHiddenWord()
		{

			var hiddenWord = new HiddenWord(_word.Text.Length);
			return hiddenWord;
		}
	}
}
