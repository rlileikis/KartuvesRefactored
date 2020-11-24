using KartuvesDL;
using KartuvesRefactored.Interfaces;
using KartuvesRefactored.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactored
{
	class Program
	{
		const int choiseStatistika = 1;
		const int choiseZaidimas = 2;
		static void Main(string[] args)
		{
			IUiMessageFactory messageFactory = new UiMessageFactory();

			var welcomeChoice = messageFactory.WelcomeMessage();

			if(welcomeChoice == choiseZaidimas)
			{

				IGameService gameService = new GameService();
				gameService.Begin();

			}

		}
	}
}
