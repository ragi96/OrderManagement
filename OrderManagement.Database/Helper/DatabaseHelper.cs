using OrderManagement.Database.Context;
using OrderManagement.Database.Model;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Database.Helper
{
    public class DatabaseHelper
    {
        private readonly CustomerContext _customerContext;

        public DatabaseHelper(
        CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public async Task<IQueryable<Customer>> SelectEntry(IDatabaseModels table)
        {
            switch (table)
            {
                case Customer customer:
                    return await Task.FromResult(_customerContext.Customer.Where(entity => entity.Equals(customer)));
            }

            return null;
        }
    }
}
