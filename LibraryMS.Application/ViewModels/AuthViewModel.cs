using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LibraryMS.Application.ViewModels
{
	public class AuthViewModel
	{
		public string Id { get; set; }
        [Required(ErrorMessage = "Name can't be empty")]
        [MaxLength(128, ErrorMessage = "Use only first & last name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Username can't be empty")]
        [MaxLength(128, ErrorMessage = "Username too long")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email can't be empty")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
		[Required(ErrorMessage = "Password can't be empty")]
		[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
