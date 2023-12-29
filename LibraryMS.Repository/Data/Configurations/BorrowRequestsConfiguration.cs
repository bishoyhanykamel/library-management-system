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
			#region Rules
			builder.Property(req => req.Status).IsRequired().HasDefaultValue(false);
			builder.Property(req => req.AmountOfDays).IsRequired().HasDefaultValue(3);
			#endregion

			#region Relations
			//builder.HasOne(req => req.Reader).WithMany().HasForeignKey(req => req.ReaderId);
			#endregion
		}
	}
}
