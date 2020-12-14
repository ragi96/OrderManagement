using System.Data.Entity;
using OrderManagement.Database.Model;

namespace OrderManagement.Database.Context
{
    public class ArticleGroupContext : DbContext
    {
        public ArticleGroupContext()
            : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleGroup>().Map(m =>
            {
                m.Properties(p => new { p.Name, p.ParentGroup });
                m.ToTable("ArticleGroup");
            });
        }

        public virtual DbSet<ArticleGroupContext> ArticleGroup { get; set; }
    }
}
