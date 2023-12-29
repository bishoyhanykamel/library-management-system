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
        public string UserId { get; set; }
        public ReaderUser Reader { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int RequestId { get; set; }
        public BorrowRequest BorrowRequest { get; set; }
    }
}
