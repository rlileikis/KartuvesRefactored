namespace KartuvesRefactored.Interfaces
{
	public interface IUiMessageFactory
	{
		void LostGameMessage(string zodis);
		int WelcomeMessage();
		void WinGameMessage(string zodis);
	}
}