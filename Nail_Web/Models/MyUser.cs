using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class MyUser
    {
        [Key]
        public int Usr_Id { get; set; }
        public string? Usr_FirstName { get; set; }
        public string? Usr_LastName { get; set; }
        public bool? Usr_IsAdmin { get; set; }
        [MaxLength(20)]
        public string? Usr_UserName { get; set; }
        [MaxLength(10)]
        public string? Usr_Password { get; set; }
        public string? Usr_PhoneNum { get; set; }
        [EmailAddress]
        public string? Usr_Email { get; set; }
        public string? Usr_Gender { get; set; }
    }
}
