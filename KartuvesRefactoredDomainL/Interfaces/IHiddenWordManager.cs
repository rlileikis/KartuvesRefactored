using KartuvesRefactored.BL;
using KartuvesRefactoredDomainL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactoredDomainL.Interfaces
{
	public interface IHiddenWordManager
	{
		HiddenWord HiddenWord { get; set; }

		HiddenWord GetHiddenWord();
		string GetHiddenWordStructure();
		void CHeckLetter(string spejimas);
	}
}
