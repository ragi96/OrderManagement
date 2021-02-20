using System;

namespace OrderManagement.Data.Model
{
    public class Orders
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public Customers Customer { get; set; }
    }
}
