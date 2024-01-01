using LibraryMS.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace LibraryMS.Application.ViewModels
{
	public class BookViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Book name is required")]
		[MaxLength(50, ErrorMessage = "Book name can't be more than 50 characters")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Author name is required")]
		[MaxLength(50, ErrorMessage = "Author name can't be more than 50 characters")]
		public string Author { get; set; }
		[Required(ErrorMessage = "Book description is required")]
		[MaxLength(100, ErrorMessage = "Book description can't be more than 100 characters")]
		public string Description { get; set; }
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Book must have a category")]
		public string Category { get; set; }
		//public ICollection<BorrowRequest> BorrowRequest { get; set; }
		//public ICollection<BorrowHistory> BorrowHistory { get; set; }
		//public ICollection<ApplicationUser> ReaderUser { get; set; }
	}
}
