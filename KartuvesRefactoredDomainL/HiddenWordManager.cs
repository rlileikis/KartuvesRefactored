using KartuvesDL.Models;
using KartuvesRefactoredDomainL.Interfaces;
using KartuvesRefactoredDomainL.Models;
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

		public void ZodzioStrukturosParodymas(string[] teisingiSpejimas)
		{
			Console.WriteLine();
			var sb = new StringBuilder("Zodis: ");
			foreach (var r in teisingiSpejimas)
			{
				if (string.IsNullOrWhiteSpace(r))
				{
					sb.Append("_ ");
				}
				else sb.Append($"{r} ");
			}
			var res = sb.ToString();
			Console.WriteLine(res);
		}



	}
}
