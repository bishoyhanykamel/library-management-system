using LibraryMS.Core.Entities;
using LibraryMS.Core.Interfaces.Repositories;
using LibraryMS.Repository.Data.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Repositories
{
	public class BookRepository : GenericRepository<Book>, IBookRepository
	{
		private readonly LibraryDbContext dbContext;

		public BookRepository(LibraryDbContext _dbContext) : base(_dbContext)
        {
			dbContext = _dbContext;
		}
    }
}
