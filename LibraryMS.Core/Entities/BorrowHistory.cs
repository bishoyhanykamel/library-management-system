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
        public string ReaderId { get; set; }
        public ReaderUser Reader { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int FineId { get; set; }
        public UserFine UserFine { get; set; }
    }
}
