namespace OrderManagement.Core.Configuration
{
    public class DatabaseConfig
    {
        public string ConnectionString = $"";

        public string Host { get; set; } = string.Empty;

        public string Database { get; set; } = string.Empty;

        public string User { get; set; } = string.Empty;

        public string Pass { get; set; } = string.Empty;
    }
}
