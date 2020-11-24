namespace KartuvesRefactored.Interfaces
{
	public interface IUiMessageFactory
	{
		void HangmanPictureMessage(int incorrectGuessCount);
		void LostGameMessage(string zodis);
		int WelcomeMessage();
		void WinGameMessage(string zodis);
	}
}