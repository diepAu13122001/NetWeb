namespace Nail_Web.Models
{
    public class PaymentMethod
    {
        public int Mtd_Id { get; set; }
        public string? Mtd_Name { get; set; }
        public string? Mtd_IconUrl { get; set; }
        public string? Mtd_PaymentLink { get; set; }
    }
}
