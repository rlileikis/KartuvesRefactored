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
				new Subject { 
					Name = temaVardai,
					Words = new List<Word>
					{
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
					}
				},
				new Subject {
					Name = temaMiestai,
					Words = new List<Word>
					{
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},

					}
				},
				new Subject {
					Name = temaValstybes,
					Words = new List<Word>
					{
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
					}
				
				},
				new Subject { 
					Name = temaKita,
					Words = new List<Word>
					{
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
						new Word {Text = "Vilmant"},
					}
				},
			};

			context.Subjects.AddRange(temos);


			//readonly static List<string> vardai = new List<string> { "VILMANTAS", "VALENTINAS", "AUDRONE", "GIEDRE", "GEDIMINAS", "KASTYTIS", "LAIMUTE", "MARIJA", "RADVILE", "ZYGIMANTAS" };
			//readonly static List<string> miestai = new List<string> { "VILNIUS", "KAUNAS", "KLAIPEDA", "SIAULIAI", "PANEVEZYS", "ALYTUS", "MAZEIKIAI", "JONAVA", "TAURAGE", "UKMERDE" };
			//readonly static List<string> valstybes = new List<string> { "ANGOLA", "BENINAS", "BURUNDIS", "TOKELAU", "DZIBUTIS", "ETIOPIJA", "GABONAS", "LAOSAS", "MALAVIS", "SUDANAS" };
			//readonly static List<string> kita = new List<string> { "ZODIS", "RAIDE", "SAKINYS", "TEKSTAS", "PASTRAIPA", "STULPELIS", "POSMAS", "KABLELIS", "DVITASKIS", "SKAICIUS" };



		}


	}
}
