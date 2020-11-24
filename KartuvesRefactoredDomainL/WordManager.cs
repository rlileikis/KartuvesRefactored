using KartuvesDL;
using KartuvesDL.Models;
using KartuvesRefactoredDomainL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KartuvesRefactoredDomainL
{
    public class WordManager : IReadRepository
    {

        public List<Subject> GetAllSubjects()
		{
            List<Subject> list;
            using (var context = new HangmanContext())
			{
                list = context.Subjects.Include(e=>e.Words).ToList();
			}
            return list;

		}
    }
}
