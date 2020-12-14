using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Database.Model
{
    public class Article
    {
        [Key]
        public int Id { get; set; } = default;

        public string Name { get; set; } = string.Empty;

        public float Price { get; set; } = default;

        public int ArticleGroupId { get; set; } = default;
    }
}
