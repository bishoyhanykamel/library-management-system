﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Entities
{
	public class Book : BaseEntity
	{
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public int CategoryId { get; set; }
        public BookCategory Category { get; set; }
        public ICollection<BorrowRequest> BorrowRequest { get; set; }
        public ICollection<BorrowHistory> BorrowHistory { get; set; }
        public ICollection<ReaderUser> ReaderUser { get; set; }
    }
}
