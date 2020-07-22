using Core.Core.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderModule.Models.OrderItems;
using OrderModule.Models.Orders;
using OrderModule.Models.PaymentMethods;
using OrderModule.Models.Shipments;

namespace OrderModule.Core
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext()
        {
        }

        public OrderDbContext(DbContextOptions<OrderDbContext> options): base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Transport> Shipments { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .Build();
                optionsBuilder
                    .UseSqlServer(SalesConfiguration.GetConnectionString());
            }
        }
    }
}
