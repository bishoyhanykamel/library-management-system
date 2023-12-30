using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class ApplicationUser : IdentityUser
	{
        public string Name { get; set; }
        public ICollection<BorrowRequest> Request { get; set; }
		public ICollection<BorrowHistory> History { get; set; }
	}
}
