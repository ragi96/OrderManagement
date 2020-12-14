using System;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Database.Model;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OrderManagement.Database.Context;
using OrderManagement.Database.Helper;

namespace OrderManagement.Handler.Database
{
    public class CustomerHandler : IDatabaseHandler
    {
        private readonly CustomerContext _context;
        private readonly ILogger<CustomerHandler> _logger;
        private readonly DatabaseHelper _databaseHelper;

        public CustomerHandler(
        CustomerContext context,
        ILoggerFactory loggerFactory,
        DatabaseHelper databaseHelper)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger<CustomerHandler>();
            _databaseHelper = databaseHelper;
        }

        public async Task<Customer> Search(Customer customer)
        {
            var selectedCustomer = await _databaseHelper.SelectEntry(customer);

            if (!selectedCustomer.Any())
                _logger.LogError($"Customer '{customer.Name}' not found.");

            return await Task.FromResult(selectedCustomer.First());
        }

        public async Task<Customer> Create(Customer customer)
        {
            try
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Customer '{customer.Name}' with ID {customer.Id} successful created.");
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError($"Failed to create '{customer.Name}': {dbEx}");
                throw;
            }

            return await await Task.FromResult(_context.Customer.FindAsync(_context.Customer.Max(entity => entity.Id)));
        }

        public async Task<Customer> Update(Customer customer)
        {
            var selectedCustomer = _context.Customer.Where(entity => entity.Id == customer.Id);

            if (!selectedCustomer.Any())
                _logger.LogError($"Customer '{customer.Name}' not found.");

            try
            {
                _context.Customer.Update(selectedCustomer.First());
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Customer '{customer.Name}' with ID {customer.Id} successful updated.");
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError($"Failed to update '{customer.Name}': {dbEx}");
                throw;
            }

            return await Task.FromResult(_context.Customer.First(entity => entity.Id == customer.Id));
        }

        public async Task Delete(Customer customer)
        {
            var selectedCustomer = _context.Customer.Where(entity => entity.Equals(customer));

            if (!selectedCustomer.Any())
                _logger.LogError($"Customer '{customer.Name}' not found.");

            try
            {
                _context.Customer.Remove(selectedCustomer.First());
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Customer '{customer.Name}' with ID {customer.Id} successful deleted.");
            }
            catch (DbUpdateException dbEx)
            {
                _logger.LogError($"Failed to delete '{customer.Name}': {dbEx}");
                throw;
            }
        }
    }
}
