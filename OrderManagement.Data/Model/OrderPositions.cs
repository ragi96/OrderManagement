namespace OrderManagement.Data.Model
{
    public class OrderPositions
    {
        public int Number { get; set; }

        public Articles Article { get; set; } = new Articles();

        public int Amount { get; set; }
    }
}
