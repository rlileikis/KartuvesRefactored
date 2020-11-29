using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuvesRefactoredDomainL.Interfaces
{
	public interface ICRUDRepository<TEntity>
	{
		List<TEntity> GetAll();
		TEntity Get(int Key);
		void Update(TEntity entity);
		int Add(TEntity entity);
		void Delete(int key);

	}
}
