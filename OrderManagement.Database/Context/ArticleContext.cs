using System.Data.Entity;
using OrderManagement.Database.Model;

namespace OrderManagement.Database.Context
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
            : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().Map(m =>
            {
                m.Properties(p => new { p.Id, p.Name, p.Price, p.ArticleGroupId });
                m.ToTable("Article");
            });
        }

        public virtual DbSet<ArticleContext> Article { get; set; }

    }
}
