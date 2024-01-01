using LibraryMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Interfaces.Specifications
{
	public class BookWithCategorySpecification : BaseSpecification<Book>
	{
        public BookWithCategorySpecification()
        {
            Includes.Add(b => b.Category);
        }

        public BookWithCategorySpecification(int id) : base(b => b.Id == id)
        {
            Includes.Add(b => b.Category);
        }
    }
}
