using KartuvesDL.Models;
using KartuvesRefactored.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactored.Services
{
	public class UiMessageFactory : IUiMessageFactory
	{
		private readonly IPictureFactory _pictureFactory;

		public UiMessageFactory()
		{
			_pictureFactory = new PictureFactory();

		}

		public int WelcomeMessage()
		{
			Console.Clear();
			Console.WriteLine($"ka veikti?");
			Console.WriteLine($"1.Statistika, 2.Zaidimas");
			int choiceNumber = 0;
			while (choiceNumber == 0)
			{
				var choice = Console.ReadKey().KeyChar;
				int.TryParse(choice.ToString(), out choiceNumber);
				if (choiceNumber == 0) Console.WriteLine("\nGalima vesti tik skaiciu, bandyk per nauja");
			}
			Console.Clear();
			Console.WriteLine("Palaukite kraunasi");
			return choiceNumber;


		}

		public string LoginMessage()
		{
			Console.Clear();

			Console.WriteLine("Iveskit savo varda");
			Console.WriteLine();
			return Console.ReadLine();


		}

		public string WordInputMessage()
		{
			Console.WriteLine("\nSpek ar zodi ar raide: ");
			return Console.ReadLine();

		}



		public void LostGameMessage(string zodis)
		{

			Console.WriteLine($"Pralaimejai. Zodis buvo: {zodis}");

		}

		public void WinGameMessage(string zodis)
		{

			Console.WriteLine($"Laimejai. Zodis: {zodis}");

		}

		public void HangmanPictureMessage(int incorrectGuessCount, string subject)
		{

			_pictureFactory.DisplayPictureAndSubject(incorrectGuessCount, subject);
		}

		public bool RepeatGameMessage()
		{
			Console.WriteLine("Pakartojam? T/N");
			return Console.ReadKey().KeyChar.ToString().ToUpper() == "T";
		}

		public void CheatMessage(string zodis)
		{
			Console.WriteLine($"Cheat. Zodis = {zodis}");
		}

		public void IncorrectLetterListMessage(List<string> neteisingiSpejimai )
		{
			Console.WriteLine("\nNeteisingai spetos raides: ");
			foreach (var neteisingasSpejimas in neteisingiSpejimai)
			{
				Console.Write($"{neteisingasSpejimas} ");
			}
			Console.WriteLine();
		}
		public void PlayerStatisticsMessage(Player player)
		{
			Console.WriteLine($"Zaidejas {player.Name} zaide {player.ScoreBoards.Count} kartus");
			Console.WriteLine($"is ju laimejo {player.ScoreBoards.Count(z => z.IsCorrect)}");
			Console.WriteLine();
			Console.WriteLine("Press any key");
			Console.ReadKey();
		}

		public void GeneralStatisticsMessage(List<Player> players)
		{
			Console.Clear();
			foreach (var player in players)
			{
				Console.WriteLine($"Zaidejas {player.Name} zaide {player.ScoreBoards.Count} kartus");
				Console.WriteLine($"is ju laimejo {player.ScoreBoards.Count(z => z.IsCorrect)}");
				Console.WriteLine();
			}
			Console.WriteLine("Press any key");
			Console.ReadKey();

		}


	}





}
