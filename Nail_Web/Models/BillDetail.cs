using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class BillDetail
    {
        public int Dtl_BllId { get; set; }
        public int? Dtl_PrdId { get; set; }
        public int? Dtl_Quantity { get; set; }
        public int? Dtl_UnitPrice { get; set; }
        public double? Dtl_PercentUP { get; set; }
        public int? Dtl_Total { get; set; }
    }
}
