using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Database.Model
{
    public class Customer : IDatabaseModels
    {
        [Key]
        public int Id { get; set; } = default;

        public string Name { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public int PostalCode { get; set; } = default;

        public string City { get; set; } = string.Empty;
    }
}
