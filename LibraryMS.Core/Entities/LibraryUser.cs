using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class LibraryUser : IdentityUser
	{
		public ICollection<BorrowRequest> BorrowRequest { get; set; }
	}
}
