using KartuvesDL.Models;
using System.Collections.Generic;

namespace KartuvesRefactored.Interfaces
{
	public interface IUiMessageFactory
	{
		void GeneralStatisticsMessage(List<Player> player);
		void HangmanPictureMessage(int incorrectGuessCount, string subject);
		void CheatMessage(string zodis);
		void IncorrectLetterListMessage(List<string> neteisingiSpejimai);
		string LoginMessage();
		void LostGameMessage(string zodis);
		void PlayerStatisticsMessage(Player player);
		bool RepeatGameMessage();
		int WelcomeMessage();
		void WinGameMessage(string zodis);
		string WordInputMessage();
	}
}