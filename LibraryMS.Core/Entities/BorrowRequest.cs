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
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public bool Status { get; set; }
        //public int AdminId { get; set; }
        //public ApplicationUser Librarian { get; set; }
    }
}
