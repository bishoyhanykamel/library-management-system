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
	public class BorrowRequestsConfiguration : IEntityTypeConfiguration<BorrowRequest>
	{
		public void Configure(EntityTypeBuilder<BorrowRequest> builder)
		{
			builder.Property(r => r.Status).IsRequired().HasDefaultValue(false);
		}
	}
}
