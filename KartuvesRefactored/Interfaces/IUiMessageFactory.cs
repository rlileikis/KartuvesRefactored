namespace KartuvesRefactored.Interfaces
{
	public interface IUiMessageFactory
	{
		void HangmanPictureMessage(int incorrectGuessCount);
		string LoginMessage();
		void LostGameMessage(string zodis);
		bool RepeatGameMessasge();
		int WelcomeMessage();
		void WinGameMessage(string zodis);
		string WordInputMessage();
	}
}