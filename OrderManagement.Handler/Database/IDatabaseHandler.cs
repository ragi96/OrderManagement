using System.Threading.Tasks;
using OrderManagement.Database.Model;

namespace OrderManagement.Handler.Database
{
    public interface IDatabaseHandler
    {
        public Task<Customer> Search(Customer customer);

        public Task<Customer> Update(Customer customer);

        public Task<Customer> Create (Customer customer);

        public Task Delete (Customer customer);
    }
}
