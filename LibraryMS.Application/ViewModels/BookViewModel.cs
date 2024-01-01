using LibraryMS.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

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
		[Required(ErrorMessage = "Book must be assigned to a category")]
		public int CategoryId { get; set; }
		public string? Category { get; set; }
	}
}
