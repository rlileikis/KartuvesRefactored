using KartuvesDL.Models;
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
	public class GameService : IGameService, IRandomize
	{
		private readonly IUiMessageFactory _messageFactory;
		private readonly List<Subject> _subjects;
		private readonly IRandomUtils _randomUtils;


		public GameService()
		{
			_messageFactory = new UiMessageFactory();
			_randomUtils = new RandomUtils();
			IReadRepository wordManager = new WordManager();

			_subjects = wordManager.GetAllSubjects();
		}
		public void Begin()
		{

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
					IHiddenWordManager hiddenWordManager = new HiddenWordManager(zodis);
					//var neteisingiSpejimai = new List<string>();
					//var teisingiSpejimai = new string[zodis.Length];
					bool leidziamaSpeti = true;
					PildytiAtrinktuZodziuMasyva(tema, zodis);

				}


				kartoti = Console.ReadKey().KeyChar.ToString().ToUpper()=="T";
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

		private static void PildytiAtrinktuZodziuMasyva(string tema, string zodis)
		{
			if (panaudotiZodziai.ContainsKey(tema)) panaudotiZodziai[tema].Add(zodis);
			else panaudotiZodziai.Add(tema, new List<string> { zodis });
		}


	}
}
