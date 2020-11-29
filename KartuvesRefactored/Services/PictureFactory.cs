using KartuvesRefactored.Interfaces;
using System;

namespace KartuvesRefactored.Services
{
	public class PictureFactory : IPictureFactory
	{
		public void DisplayPictureAndSubject(int incorrectGuessCount, string subject)
		{
			Console.Clear();
			Console.WriteLine($"Pasirinkta tema: {subject}");
			switch (incorrectGuessCount)
			{
				case 0:
					IsvestiPradini();
					break;
				case 1:
					GalvosIsvedimas();
					break;
				case 2:
					KakloIsvedimas();
					break;
				case 3:
					KairesRankosIsvedimas();
					break;
				case 4:
					DesinesRankosIsvedimas();
					break;
				case 5:
					PilvoIsvedimas();
					break;
				case 6:
					KairesKojosIsvedimas();
					break;
				case 7:
					DesinesKojosIsvedimas();
					break;


			}
		}
		private void IsvestiPradini()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}

		private void GalvosIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}
		private void KakloIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|             |  ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}

		private void KairesRankosIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            \|  ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}

		private void DesinesRankosIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            \|/ ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}

		private void PilvoIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            \|/ ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}

		private void KairesKojosIsvedimas()
		{
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            \|/ ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            /   ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}
		private void DesinesKojosIsvedimas()
		{
			Console.Clear();
			Console.WriteLine(@"  - - - - - - |  ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            \|/ ");
			Console.WriteLine(@"|             0  ");
			Console.WriteLine(@"|            / \ ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"|                ");
			Console.WriteLine(@"_ _ _ _");
		}



	}
}
