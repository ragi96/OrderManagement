using System.Threading.Tasks;

namespace OrderManagement.Core.Operations
{
    public interface IDataOperations
    {
        Task<object> Create(object entity);

        Task<object> Update(object entity, object newValues);

        Task Delete(object entity);

        Task<object> Get(object entity);
    }
}
