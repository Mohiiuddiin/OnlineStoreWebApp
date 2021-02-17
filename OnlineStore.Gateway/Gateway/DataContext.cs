using OnlineStore.Core.Models;
using OnlineStore.Core.ViewModels;
using System.Data.Entity;

namespace OnlineStore.DAL.Gateway
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("OnlineStoreConnectionString") {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Busket> Buskets { get; set; }
        public DbSet<BusketItem> BusketiItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        
    }
}
