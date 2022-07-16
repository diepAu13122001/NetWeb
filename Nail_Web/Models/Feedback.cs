using System.ComponentModel.DataAnnotations;

namespace Nail_Web.Models
{
    public class Feedback
    {
        [Key]
        public int Fdb_Id { get; set; }
        public int? Fdb_UsrId { get; set; }
        public int? Fdb_PrdId { get; set; }
        public Nullable<int> Fdb_Rating { get; set; }
    }
}
