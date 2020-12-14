using System;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Database.Model
{
    internal class Order
    {
        [Key]
        public int Id { get; set; } = default;

        public DateTime Date { get; set; } = default;

        public int CustomerId { get; set; } = default;

        public int PositionId { get; set; } = default;
    }
}
