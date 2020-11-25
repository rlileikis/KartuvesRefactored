using KartuvesDL.Models;
using KartuvesRefactoredDomainL.Interfaces;
using KartuvesRefactoredDomainL.Models;
using System;
using System.Text;

namespace KartuvesRefactored.BL
{
	public class HiddenWordManager : IHiddenWordManager
	{
		private readonly Word _word;

		public HiddenWord HiddenWord { get; set; }

		public HiddenWordManager(Word word)
		{
			_word = word;
			HiddenWord = new HiddenWord(_word.Text.Length);
		}

		public HiddenWordManager GetHiddenWord()
		{

			return HiddenWord;
		}

		public string GetHiddenWordStructure()
		{
			Console.WriteLine();
			var sb = new StringBuilder("Zodis: ");
			foreach (var r in HiddenWord.CorrectGueses)
			{
				if (string.IsNullOrWhiteSpace(r))
					sb.Append("_ ");
				else sb.Append($"{r} ");
			}
			return sb.ToString();
			
		}



	}
}
