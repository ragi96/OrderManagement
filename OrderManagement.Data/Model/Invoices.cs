using System;

namespace OrderManagement.Data.Model
{
    public class Invoices
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public Orders Order { get; set; }
    }
}
