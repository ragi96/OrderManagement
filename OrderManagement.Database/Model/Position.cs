using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Database.Model
{
    internal class Position
    {
        [Key]
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public int NumOfArticles { get; set; }
    }
}
