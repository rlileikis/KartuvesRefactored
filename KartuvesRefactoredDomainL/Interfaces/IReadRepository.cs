using KartuvesDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactoredDomainL.Interfaces
{
	public interface IReadRepository
	{
		List<Subject> GetAllSubjects();
	}
}
