using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KartuvesDL.Models;

namespace KartuvesDL
{
    public class HangmanContext : DbContext
    {
        public HangmanContext(): base("Hangman")
		{
			Database.SetInitializer(new HangmanContextInitializer());

		}
		public DbSet<Player> Players { get; set; }

		public DbSet<ScoreBoard> ScoreBoards { get; set; }

		public DbSet<Subject> Subjects { get; set; }

		public DbSet<Word> Words { get; set; }
	}
}
