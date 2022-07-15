namespace Nail_Web.Models
{
    public class Discount
    {
        public int Dsc_Id { get; set; }
        public string? Dsc_Name { get; set; }
        public int? Dsc_MaxDiscount { get; set; }
        public double? Dsc_PercentDiscount { get; set; }
        public DateTime? Dsc_AppliedDate { get; set; }
        public DateTime? Dsc_EndedDate { get; set; }
    }
}
