using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Database.Model
{
    public class ArticleGroup
    {
        [Key]
        public string Name { get; set; } = string.Empty;

        public string ParentGroup { get; set; } = string.Empty;
    }
}
