using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.DataAccess.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasSequence<int>("OrderNumbers", "shared")
                              .StartsAt(2020).IncrementsBy(1);
            modelBuilder.Entity<Order>()
               .Property(o => o.OrderNumber)
               .HasDefaultValueSql("NEXT VALUE FOR shared.OrderNumbers");
        }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<BillingAdress> BillingAdresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ShippingAdress> ShippingAdresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}