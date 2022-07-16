using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nail_Web.Models;

namespace Nail_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Nail_Web.Models.Address>? Addresses { get; set; }
        public DbSet<Nail_Web.Models.Bill>? Bills { get; set; }
        public DbSet<Nail_Web.Models.BillDetail>? BillDetails { get; set; }
        public DbSet<Nail_Web.Models.Discount>? Discount { get; set; }
        public DbSet<Nail_Web.Models.Feedback>? Feedback { get; set; }
        public DbSet<Nail_Web.Models.MyUser>? MyUser { get; set; }
        public DbSet<Nail_Web.Models.PaymentMethod>? PaymentMethod { get; set; }
        public DbSet<Nail_Web.Models.Product>? Product { get; set; }
        public DbSet<Nail_Web.Models.ProductColor>? ProductColor { get; set; }
        public DbSet<Nail_Web.Models.ProductType>? ProductType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BillDetail>().HasNoKey();
            builder.Entity<Cart>().HasNoKey();
            builder.Entity<ProductColor>().HasNoKey();
            base.OnModelCreating(builder);
        }
    }
}