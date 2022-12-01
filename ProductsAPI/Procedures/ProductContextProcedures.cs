using System;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Procedures
{
    public partial class ProductContextProcedures : DbContext
    {
        public virtual DbSet<CustOrderHistory> CustOrderHistories { get; set; } = null!;

        public ProductContextProcedures() { }

        public ProductContextProcedures(DbContextOptions<ProductContextProcedures> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustOrderHistory>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.ProductName);
                entity.Property(e => e.Total);
            });
        }
    }
}

