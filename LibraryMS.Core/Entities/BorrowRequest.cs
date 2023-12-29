using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class BorrowRequest : BaseEntity
	{
		public DateTime Date { get; set; }
		public int AmountOfDays { get; set; }
		public bool Status { get; set; }
		public int BookId { get; set; }
		public Book Book { get; set; }
		public ICollection<ApplicationUser> Reader { get; set; }
		public ICollection<LibrarianApproveRequest> RequestsApprove { get; set; }
	}
}
