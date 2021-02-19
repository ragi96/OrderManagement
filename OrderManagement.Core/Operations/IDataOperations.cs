using OrderManagement.Data.Model;
using System.Threading.Tasks;

namespace OrderManagement.Core.Operations
{
    public interface IDataOperations
    {
        Task<Customers> Customers(Customers customer, OperationActions.Actions action);

        Task<Articles> Articles(Articles article, OperationActions.Actions action);
    }
}
