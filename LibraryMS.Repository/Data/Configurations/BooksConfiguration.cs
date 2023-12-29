using LibraryMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Data.Configurations
{
	public class BooksConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			#region Rules
			builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
			builder.Property(b => b.Description).IsRequired().HasMaxLength(512);
			#endregion

			#region Relations
			builder.HasOne(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId); 
			#endregion

		}
	}
}
