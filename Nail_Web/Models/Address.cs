using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class Address
    {
        [Key]
        public int Ads_Id { get; set; }
        public string? Ads_Name { get; set; }
        public string? Ads_Detail { get; set; }
        public Nullable<int> Ads_UsrId { get; set; }

    }
}
