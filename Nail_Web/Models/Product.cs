using Microsoft.EntityFrameworkCore;

namespace Nail_Web.Models
{
    public class Product
    {
        public int Prd_Id { get; set; }
        public string? Prd_Name { get; set; }
        public string? Prd_AvaUrl { get; set; }
        public DateTime? Prd_ImportedDate { get; set; }
        public int? Prd_Quantity { get; set; }
        public int? Prd_Size { get; set; }
        public int? Prd_TypeId { get; set; }

        public DbSet<Feedback>? Feedback { get; set; }
        public int GetRating(int? id)
        {
            int? rate = 0;
            int count = 0;
#pragma warning disable CS8604 // Possible null reference argument.
            List<Feedback> feedbacks = Feedback.ToList();
            foreach (Feedback feedback in feedbacks)
            {
                if (feedback.Fdb_PrdId == id)
                {
                    count++;
                    rate += feedback.Fdb_Rating;
                }
            }

            if (count == 0)
            {
                return 1;
            }

            else return (int)rate / count;
        }

        public DbSet<ProductColor>? ProductColor { get; set; }

        public int getMinUnitPrice(int? id)
        {
            List<int> priceList = new List<int>();
            List<ProductColor> productColors = ProductColor.ToList();
            foreach (ProductColor productColor in productColors)
            {
                if (productColor.Clr_PrdId == id)
                {
#pragma warning disable CS8629 // Nullable value type may be null.
                    priceList.Add(item: (int)productColor.Clr_UnitPrice);
                }
            }
            return priceList.AsQueryable().Min();
        }

        public double getPercentUp(int? id)
        {
            List<double> percentUpList = new List<double>();
            List<ProductColor> productColors = ProductColor.ToList();
            foreach (ProductColor productColor in productColors)
            {
                if (productColor.Clr_PrdId == id)
                {
                    if (productColor.Clr_UnitPrice == getMinUnitPrice(id))
                    {
#pragma warning disable CS8629 // Nullable value type may be null.
                        percentUpList.Add((double)productColor.Clr_PercentUp);
                    }
                }
            }
            return percentUpList.AsQueryable().Min();
        }

        public int getRealPrice(int? id)
        {
            return (int)(getMinUnitPrice(id) * (1 - getPercentUp(id)));
        }
}
}
