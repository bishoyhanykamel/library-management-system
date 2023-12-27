using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using LibraryMS.Repository.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
	{
		private readonly LibraryDbContext dbContext;

		public GenericRepository(LibraryDbContext _dbContext)
        {
			dbContext = _dbContext;
		}
        public async Task<int> AddAsync(T item)
		{
			await dbContext.Set<T>().AddAsync(item);
			return await dbContext.SaveChangesAsync();
		}

		public async Task<int> DeleteAsync(T item)
		{
			dbContext.Set<T>().Remove(item);
			return await dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await dbContext.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await dbContext.Set<T>().FindAsync(id);
		}

		public async Task<int> UpdateAsync(T item)
		{
			dbContext.Set<T>().Update(item);
			return await dbContext.SaveChangesAsync();
		}
	}
}
