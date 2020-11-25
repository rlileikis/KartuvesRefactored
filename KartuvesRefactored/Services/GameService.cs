using KartuvesDL.Models;
using KartuvesRefactored.BL;
using KartuvesRefactored.Interfaces;
using KartuvesRefactoredDomainL;
using KartuvesRefactoredDomainL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactored.Services
{
	public class GameService : IGameService
	{
		private readonly IUiMessageFactory _messageFactory;
		private readonly List<Subject> _subjects;
		private readonly IRandomUtils _randomUtils;
		const int gyvybiuKiekis = 7;

		static List<Word> panaudotiZodziai = new List<Word>();

		public GameService()
		{
			_messageFactory = new UiMessageFactory();
			_randomUtils = new RandomUtils();
			IReadRepository wordManager = new WordManager();

			_subjects = wordManager.GetAllSubjects();
		}
		public void Begin()
		{
			var userName = _messageFactory.LoginMessage();
			bool kartoti = true;

			while(kartoti)
			{

				Console.Clear();
				var tema = SelectSubject();
				var zodis = AtsitiktinisZodzioPasirinkimas(tema);

				//dabartinisZodis = zodis;// cheat

				if (zodis == null)
				{
					Console.WriteLine("Temoje nebeliko zodziu.Ar rinktis kita? T/N");
				}
				else
				{
					IHiddenWordManager _hiddenWordManager = new HiddenWordManager(zodis);
					//var neteisingiSpejimai = new List<string>();
					//var teisingiSpejimai = new string[zodis.Length];
					bool leidziamaSpeti = true;
					panaudotiZodziai.Add(zodis);
					_messageFactory.HangmanPictureMessage(0);
					Console.WriteLine();
					Console.WriteLine(_hiddenWordManager.GetHiddenWordStructure());
					while (leidziamaSpeti)
					{
						string spejimas = _messageFactory.WordInputMessage();
						bool arSpetasZodis = spejimas.Length > 1;
						if (arSpetasZodis)
						{
							bool arTeisinga = zodis.Text == spejimas.ToUpper();

							if (arTeisinga) _messageFactory.WinGameMessage(zodis.Text);
							else
							{
								_messageFactory.HangmanPictureMessage(gyvybiuKiekis);
								_messageFactory.LostGameMessage(zodis.Text);
							}
							leidziamaSpeti = false;
						}
						else 
						{
							bool arBuvoSpeta = _hiddenWordManager.HiddenWord.IncorrectGueses.Contains(spejimas);
							if (!arBuvoSpeta)
							{
								_hiddenWordManager.CHeckLetter(spejimas);

							}
							if (_hiddenWordManager.HiddenWord.IncorrectGueses.Count == gyvybiuKiekis)
							{
								_messageFactory.HangmanPictureMessage(gyvybiuKiekis);
								_messageFactory.LostGameMessage(zodis.Text);
								leidziamaSpeti = false;
							}
							else
							{
								Console.Clear();
								_messageFactory.HangmanPictureMessage(_hiddenWordManager.HiddenWord.IncorrectGueses.Count);
								_messageFactory.IncorrectLetterListMessage(_hiddenWordManager.HiddenWord.IncorrectGueses);
								Console.WriteLine(_hiddenWordManager.GetHiddenWordStructure());
								if (_hiddenWordManager.HiddenWord.HiddenLetterCount == 0)
								{
									_messageFactory.WinGameMessage(zodis.Text);

									leidziamaSpeti = false;
								}
							}


						}

					}

				}

				kartoti = _messageFactory.RepeatGameMessage();
			}
		}
		private Word AtsitiktinisZodzioPasirinkimas(Subject tema)
		{
			var zodziai = tema.Words;
			if (zodziai.Count == 0) return null;

			var atsitiktinisSk = _randomUtils.Random(0, zodziai.Count);
			return zodziai[atsitiktinisSk];
		}

		private Subject SelectSubject()
		{
			Console.WriteLine("Pasirinkti temą:");
			int ivestasTemosNr = 0;
			IsveskTemuPavadinimus();
			while (ivestasTemosNr > _subjects.Count || ivestasTemosNr == 0)
			{
				var temosChar = Console.ReadKey().KeyChar;
				int.TryParse(temosChar.ToString(), out ivestasTemosNr);
				if (ivestasTemosNr > _subjects.Count || ivestasTemosNr == 0) Console.WriteLine("\n {0} temos nėr, bandyk per nauja", ivestasTemosNr);
			}
			Console.Clear();
			//dabartineTema = temos[ivestasTemosNr - 1];
			return _subjects[ivestasTemosNr - 1];
		}

		private void IsveskTemuPavadinimus()
		{
			for (int i = 0; i < _subjects.Count; i++)
			{

				Console.WriteLine($"{i + 1}. {_subjects[i].Name}");
			}
		}


	}
}
