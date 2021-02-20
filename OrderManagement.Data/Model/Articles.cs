namespace OrderManagement.Data.Model
{
    public class Articles
    {
        public int Number { get; set; }

        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public double Mwst { get; set; }
    }
}
