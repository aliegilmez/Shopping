using Microsoft.EntityFrameworkCore;
using Shopping.Services.Application.Abstractions.Repositories;
using Shopping.Services.Data.Context;
using Shopping.Services.Data.Entities.MySql;

namespace Shopping.Services.Data.Repositories
{

    public class CustomerRepository : ICustomerRepository
    {
        private readonly ShoppingContext _shoppingContext;
        private readonly DbSet<Customer> _customerRepository;

        public CustomerRepository(ShoppingContext shoppingContext, DbSet<Customer> customerRepository)
        {
            _shoppingContext = shoppingContext;
            _customerRepository = customerRepository;
        }

        public async Task AddAsync(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
        }

        public async Task<IList<Customer>> GetAllAsync()
        {
            return await _customerRepository.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<bool> CommitAsync()
        {
            return await _shoppingContext.SaveChangesAsync() > 0;
        }
    }
}
