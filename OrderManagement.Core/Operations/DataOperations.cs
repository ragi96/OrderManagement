using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Context;
using OrderManagement.Data.Model;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Core.Operations
{
    public class DataOperations : IDataOperations
    {
        private readonly DbContextOptions<DataContext> _dbContextOptions;
        private readonly DataContext _context;

        public DataOperations(DbContextOptions<DataContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
            _context = new DataContext(dbContextOptions);
        }

        public async Task<Articles> Articles(Articles article, OperationActions.Actions action)
        {
            switch(action)
            {
                case OperationActions.Actions.Create:
                    _context.Add(article);
                    break;
                case OperationActions.Actions.Delete:
                    _context.Remove(article);
                    break;
                case OperationActions.Actions.Update:
                    _context.Update(article);
                    break;
                case OperationActions.Actions.Search:
                    article = await _context.Articles.SingleOrDefaultAsync(elem => elem.Name.Equals(article.Name));
                    break;
            }

            await _context.SaveChangesAsync();

            return article;
        }

        public Task<Customers> Customers(Customers customer, OperationActions.Actions action)
        {
            throw new System.NotImplementedException();
        }
    }
}
