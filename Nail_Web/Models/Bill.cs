using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class Bill
    {
        [Key]
        public int Bll_Id { get; set; }
        public int? Bll_UsrId { get; set; }
        public int? Bll_AdsID { get; set; }
        public DateTime? Bll_CreatedDate { get; set; }
        public DateTime? DllReceivedDate { get; set; }
        public int? Bll_TempTotal { get; set; }
        public int? Bll_DscId { get; set; }
        public int? Bll_Discount { get; set; }
        public int? ShippingFee { get; set; }
        public int? Bll_FinalTotal { get; set; }
    }
}
