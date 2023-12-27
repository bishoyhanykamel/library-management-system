using LibraryMS.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Data.DbContexts
{
	public class LibraryDbContext : IdentityDbContext<ApplicationUser>
	{
        public LibraryDbContext(DbContextOptions options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
		public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BorrowHistory> BorrowHistories { get; set; }
        public DbSet<BorrowRequest> BorrowRequests { get; set; }
        public DbSet<UserFine> UserFines { get; set; }
    }
}
