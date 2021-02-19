using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Model;

namespace OrderManagement.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Addresses> Addresses { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<ArticleGroups> ArticleGroups { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<OrderPositions> OrderPositions { get; set; }
    
        public DbSet<Orders> Orders { get; set; }
    }
}
