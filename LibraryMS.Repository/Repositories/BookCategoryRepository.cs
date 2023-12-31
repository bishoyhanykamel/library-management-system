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
	public class BookCategoryRepository : GenericRepository<BookCategory>, IBookCategoryRepository
	{
		private readonly LibraryDbContext dbContext;

		public BookCategoryRepository(LibraryDbContext _dbContext) : base(_dbContext)
        {
			dbContext = _dbContext;
		}
        public async Task<BookCategory> getCategoryByName(string name)
			=> await dbContext.Set<BookCategory>().Where(cat => cat.Name == name).FirstOrDefaultAsync();

		
	}
}
