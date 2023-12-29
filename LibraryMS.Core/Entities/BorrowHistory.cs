using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class BorrowHistory : BaseEntity
	{
        public DateTime Date { get; set; }
        public bool Returned { get; set; }
        public byte DaysLeft { get; set; }

        public string ReaderId { get; set; }
        public ApplicationUser Reader { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public UserFine Fine { get; set; }
    }
}
