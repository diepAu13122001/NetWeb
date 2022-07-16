using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class ProductType
    {
        [Key]
        public int Tpe_Id { get; set; }
        public string? Tpe_Name { get; set; }
        public int? Tpe_ParrentTpeId { get; set; }
    }
}
