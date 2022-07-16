using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class Login
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Email address is required")]
        public string? Lgn_UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Lgn_Password { get; set; }
    }
}
