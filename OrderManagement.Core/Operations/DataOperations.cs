using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using System.Threading.Tasks;

namespace OrderManagement.Core.Operations
{
    public class DataOperations : IDataOperations
    {
        private readonly DataContext _context;

        public DataOperations(DbContextOptions<DataContext> dbContextOptions)
        {
            _context = new DataContext(dbContextOptions);
        }

        public async Task<object> Create(object entity)
        {
            var currentContext = await DetermineDbSet(entity);

            currentContext.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(object entity)
        {
            var currentContext = await DetermineDbSet(entity);

            currentContext.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<object> Get(object entity)
        {
            var currentContext = await DetermineDbSet(entity);
            var requestedEntity = await currentContext.SingleOrDefaultAsync(elem => elem == entity);

            if(requestedEntity != null)
            {
                return requestedEntity;
            }

            return null;
        }

        public async Task<object> Update(object entity, object newValues)
        {
            var currentContext = await DetermineDbSet(entity);
            var requestedEntity = await currentContext.SingleOrDefaultAsync(elem => elem == entity);

            requestedEntity = newValues;
            currentContext.Update(requestedEntity);

            return entity;
        }

        private Task<DbSet<object>> DetermineDbSet(object entity) 
        {
            var currentType = default(object);

            switch (entity)
            {
                case Articles _:
                    currentType = _context.Articles;
                    break;
                case ArticleGroups _:
                    currentType = _context.ArticleGroups;
                    break;
                case Customers _:
                    currentType = _context.Customers;
                    break;
                case Addresses _:
                    currentType = _context.Addresses;
                    break;
                case OrderPositions _:
                    currentType = _context.OrderPositions;
                    break;
                case Orders _:
                    currentType = _context.Orders;
                    break;
                case Invoices _:
                    currentType = _context.Invoices;
                    break;
            }

            return (Task<DbSet<object>>)currentType;
        }
    }
}
