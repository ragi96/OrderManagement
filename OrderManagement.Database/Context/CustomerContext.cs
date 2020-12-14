using Microsoft.EntityFrameworkCore;
using OrderManagement.Database.Model;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace OrderManagement.Database.Context
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base()
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().Property(p => p.Id);
            builder.Entity<Customer>().Property(p => p.Name);
            builder.Entity<Customer>().Property(p => p.Street);
            builder.Entity<Customer>().Property(p => p.PostalCode);
            builder.Entity<Customer>().Property(p => p.City);
        }

        public virtual DbSet<Customer> Customer { get; set; }
    }
}
