using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class Product
    {
        [Key]
        public int Prd_Id { get; set; }
        public string? Prd_Name { get; set; }
        public string? Prd_AvaUrl { get; set; }
        public DateTime? Prd_ImportedDate { get; set; }
        public int? Prd_Quantity { get; set; }
        public decimal? Prd_Size { get; set; }
        public int? Prd_TypeId { get; set; }

    }
    

}
