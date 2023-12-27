using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		public Task<int> AddAsync(T item)
		{
			throw new NotImplementedException();
		}

		public Task<int> DeleteAsync(T item)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<T>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public Task<T> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateAsync(T item)
		{
			throw new NotImplementedException();
		}
	}
}
