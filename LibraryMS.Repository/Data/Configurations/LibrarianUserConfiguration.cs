﻿using LibraryMS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Repository.Data.Configurations
{
	public class LibrarianUserConfiguration : IEntityTypeConfiguration<LibrarianUser>
	{
		public void Configure(EntityTypeBuilder<LibrarianUser> builder)
		{

		}
	}
}
