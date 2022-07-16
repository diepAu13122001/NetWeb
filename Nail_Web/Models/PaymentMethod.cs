using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class PaymentMethod
    {
        [Key]
        public int Mtd_Id { get; set; }
        public string? Mtd_Name { get; set; }
        public string? Mtd_IconUrl { get; set; }
        public string? Mtd_PaymentLink { get; set; }
    }
}
