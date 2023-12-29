using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class UserFine : BaseEntity
	{
        public decimal Value { get; set; }
        public bool Resolved { get; set; }
        public DateTime Date { get; set; }
		public string ReaderId { get; set; }
		public ReaderUser Reader { get; set; }
		public int BorrowHistoryId { get; set; }
        public BorrowHistory BorrowHistory { get; set; }
    }
}
