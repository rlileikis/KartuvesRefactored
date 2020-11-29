using KartuvesDL.Models;
using KartuvesRefactoredDomainL;
using KartuvesRefactoredDomainL.Interfaces;
using KartuvesDL;
using KartuvesRefactored;
using KartuvesRefactored.Interfaces;

namespace KartuvesRefactored.Services
{
	public class StatisticsService : IStatisticsService
	{
		private readonly IPlayerManager _playerManager;
		private readonly IUiMessageFactory _messageFactory;


		public StatisticsService()
		{
			_playerManager = new PlayerManager();
			_messageFactory = new UiMessageFactory();
		}

		public void Begin()
		{
			_messageFactory.GeneralStatisticsMessage(_playerManager.GetAll());

		}

	}
}
