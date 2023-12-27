using LibraryMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Interfaces.Repositories
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		public Task<IEnumerable<T>> GetAllAsync();
		public Task<T> GetByIdAsync(int id);
		public Task<int> AddAsync(T item);
		public Task<int> UpdateAsync(T item);
		public Task<int> DeleteAsync(T item);
	}
}
