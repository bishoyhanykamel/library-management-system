using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class ReaderUser : IdentityUser
	{
		public int RequestId { get; set; }
		public BorrowRequest BorrowRequest { get; set; }
		public ICollection<UserFine> Fines { get; set; }
		public ICollection<BorrowHistory> BorrowHistory { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
