using KartuvesDL.Models;
using KartuvesRefactoredDomainL.Interfaces;
using KartuvesRefactoredDomainL.Models;
using System;
using System.Collections.Generic;
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

		public HiddenWord GetHiddenWord()
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

		public void CHeckLetter(string spejimas)
		{
			var zodisArr = _word.Text.ToCharArray();
			var raidesIndeksas = new List<int>();
			for (int i = 0; i < _word.Text.Length; i++)
			{
				if (zodisArr[i].ToString() == spejimas.ToUpper()) raidesIndeksas.Add(i);
			}

			if (raidesIndeksas.Count == 0)
			{
				HiddenWord.IncorrectGueses.Add(spejimas);
			}
			else
			{
				PridetiRaideITeisingaVietaZodyje(spejimas, raidesIndeksas);
			}
		}

		private void PridetiRaideITeisingaVietaZodyje(string spejimas, List<int> raidesIndeksai )
		{
			foreach (int i in raidesIndeksai)
			{
				HiddenWord.CorrectGueses[i] = spejimas;
			}
		}



	}
}
