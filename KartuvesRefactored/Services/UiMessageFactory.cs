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
			bool validChoice = false;
			int choiceNumber = 0;
			while (!validChoice)
			{
				var choice = Console.ReadKey().KeyChar;
				int.TryParse(choice.ToString(), out choiceNumber);
				if (choiceNumber == 0) Console.WriteLine("\nGalima vesti tik skaiciu, bandyk per nauja");
			}
			return choiceNumber;


		}

		public void LostGameMessage(string zodis)
		{

			Console.WriteLine($"Pralaimejai. Zodis buvo: {zodis}");

		}

		public void WinGameMessage(string zodis)
		{

			Console.WriteLine($"Laimejai. Zodis: {zodis}");

		}

		public void HangmanPictureMessage(int incorrectGuessCount)
		{

			_pictureFactory.DisplayPicture(incorrectGuessCount);
		}
	}





}
