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
	public class UserFinesConfiguration : IEntityTypeConfiguration<UserFine>
	{
		public void Configure(EntityTypeBuilder<UserFine> builder)
		{
			builder.Property(f => f.Value).IsRequired();
			builder.Property(f => f.Resolved).HasDefaultValue(false);
			builder.Property(f => f.ReaderId).IsRequired();
		}
	}
}
