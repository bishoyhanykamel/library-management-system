using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class LibrarianApproveRequest
	{
		public string ApproveDate { get; set; }
		public string LibrarianId { get; set; }
		public LibrarianUser Librarian { get; set; }
		public int BorrowId { get; set; }
		public BorrowRequest Borrow { get; set; }
	}
}
