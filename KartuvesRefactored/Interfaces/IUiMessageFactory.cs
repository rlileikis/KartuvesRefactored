using System.Collections.Generic;

namespace KartuvesRefactored.Interfaces
{
	public interface IUiMessageFactory
	{
		void HangmanPictureMessage(int incorrectGuessCount);
		void IncorrectLetterListMessage(List<string> neteisingiSpejimai);
		string LoginMessage();
		void LostGameMessage(string zodis);
		bool RepeatGameMessage();
		int WelcomeMessage();
		void WinGameMessage(string zodis);
		string WordInputMessage();
	}
}