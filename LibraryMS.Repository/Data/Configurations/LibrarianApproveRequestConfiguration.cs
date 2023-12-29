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
	public class LibrarianApproveRequestConfiguration : IEntityTypeConfiguration<LibrarianApproveRequest>
	{
		public void Configure(EntityTypeBuilder<LibrarianApproveRequest> builder)
		{
			#region Rules
			builder.Property(appr => appr.ApproveDate).IsRequired();
			builder.Property(appr => appr.LibrarianId).IsRequired();
			builder.Property(appr => appr.BorrowId).IsRequired();
			builder.HasKey(appr => new { appr.LibrarianId, appr.BorrowId });
			#endregion

			#region Relations
			builder.HasOne(appr => appr.Librarian).WithMany(lib => lib.ApproveRequests).HasForeignKey(appr => appr.LibrarianId);
			builder.HasOne(appr => appr.Borrow).WithMany(lib => lib.RequestsApprove).HasForeignKey(appr => appr.BorrowId);
			#endregion
		}
	}
}
