namespace OrderManagement.Data.Model
{
    public class ArticleGroups
    {
        public string Name { get; set; } = string.Empty;

        public ArticleGroups SuperiorArticleGroup { get; set; } = new ArticleGroups();
    }
}
