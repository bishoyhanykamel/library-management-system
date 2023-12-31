using System.ComponentModel.DataAnnotations;

namespace LibraryMS.Application.ViewModels
{
    public class BookCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name can't be empty")]
        [MaxLength(50, ErrorMessage = "Name can't be more than 50 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Description can't be more than 100 characters")]
        public string Description { get; set; }
    }
}
