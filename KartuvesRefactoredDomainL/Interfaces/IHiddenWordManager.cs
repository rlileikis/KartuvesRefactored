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
		HiddenWordManager GetHiddenWord();
		string GetHiddenWordStructure();
	}
}
