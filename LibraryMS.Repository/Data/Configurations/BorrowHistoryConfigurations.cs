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
			#region Rules
			builder.Property(hist => hist.Returned).IsRequired().HasDefaultValue(false);
			builder.Property(hist => hist.DaysLeft).IsRequired().HasDefaultValue(3);
			#endregion

			#region Relations
			builder.HasOne(hist => hist.Book).WithMany().HasForeignKey(hist => hist.BookId);
			builder.HasOne(hist => hist.Reader).WithMany().HasForeignKey(hist => hist.ReaderId);
			#endregion
		}
	}
}
