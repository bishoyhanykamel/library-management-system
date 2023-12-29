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
	public class BorrowHistoryConfigurations : IEntityTypeConfiguration<BorrowHistory>
	{
		public void Configure(EntityTypeBuilder<BorrowHistory> builder)
		{
			builder.Property(h => h.BookId).IsRequired();
			builder.Property(h => h.UserId).IsRequired();
			//builder.HasOne(h => h.Book).WithMany().HasForeignKey(h => h.BookId);
			//builder.HasOne(h => h.User).WithMany().HasForeignKey(h => h.UserId);
		}
	}
}
