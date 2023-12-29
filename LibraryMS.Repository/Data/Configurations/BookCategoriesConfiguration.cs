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
	public class BookCategoriesConfiguration : IEntityTypeConfiguration<BookCategory>
	{
		public void Configure(EntityTypeBuilder<BookCategory> builder)
		{
			#region Rules
			builder.Property(cat => cat.Name).IsRequired().HasMaxLength(50);
			builder.Property(cat => cat.Description).IsRequired().HasMaxLength(120);
			#endregion
		}
	}
}
