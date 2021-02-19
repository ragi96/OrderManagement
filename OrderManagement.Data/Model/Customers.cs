namespace OrderManagement.Data.Model
{
    public class Customers
    {
        public string Name { get; set; } = string.Empty;

        public Addresses Address { get; set; } = new Addresses();
    }
}
