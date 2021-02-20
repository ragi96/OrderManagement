namespace OrderManagement.Data.Model
{
    public interface IModelBase
    {
        Articles Articles { get; set; }
        Articles GetArticles();
        void SetArticles(Articles value);
    }
}
