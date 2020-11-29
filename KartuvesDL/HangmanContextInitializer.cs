using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KartuvesDL.Models;

namespace KartuvesDL
{
	class HangmanContextInitializer : CreateDatabaseIfNotExists<HangmanContext>
	{

		protected override void Seed(HangmanContext context)
		{
			const string temaVardai = "VARDAI";
			const string temaMiestai = "LIETUVOS MIESTAI";
			const string temaValstybes = "VALSTYBES";
			const string temaKita = "KITA";

			List<Subject> temos = new List<Subject>
			{
				new Subject 
				{ 
					Name = temaVardai,
					Words = new List<Word>
					{
						new Word {Text = "VILMANTAS"},
						new Word {Text = "VALENTINAS"},
						new Word {Text = "AUDRONE"},
						new Word {Text = "GIEDRE"},
						new Word {Text = "GEDIMINAS"},
					}
				},
				new Subject 
				{
					Name = temaMiestai,
					Words = new List<Word>
					{
						new Word {Text = "VILNIUS"},
						new Word {Text = "KAUNAS"},
						new Word {Text = "KLAIPEDA"},
						new Word {Text = "SIAULIAI"},
						new Word {Text = "PANEVEZYS"},


					}
				},
				new Subject 
				{
					Name = temaValstybes,
					Words = new List<Word>
					{
						new Word {Text = "ANGOLA"},
						new Word {Text = "BEININAS"},
						new Word {Text = "BURUNDIS"},
						new Word {Text = "TOKELAU"},
						new Word {Text = "DZIBUTIS"},
					}
				
				},
				new Subject 
				{ 
					Name = temaKita,
					Words = new List<Word>
					{
						new Word {Text = "ZODIS"},
						new Word {Text = "RAIDE"},
						new Word {Text = "SAKINYS"},
						new Word {Text = "TEKSTAS"},
						new Word {Text = "PASTRAIPA"},
					}
				},
			};

			context.Subjects.AddRange(temos);
		}


	}
}
