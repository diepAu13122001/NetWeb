namespace Nail_Web.Models
{
    public class Cart
    {
        public int Crt_UsrId { get; set; }
        public int Crt_PrdId { get; set; }
        public int? Crt_Quantity { get; set; }
        public int? Crt_UnitPrice { get; set; }
        public double? Crt_PercentUp { get; set; }
        public int? Crt_Total { get; set; }
    }
}
