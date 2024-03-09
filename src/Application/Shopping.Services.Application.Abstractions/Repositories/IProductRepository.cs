using Shopping.Services.Data.Entities.MySql;

namespace Shopping.Services.Application.Abstractions.Repositories
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task<Customer> GetByIdAsync(int id);
        Task<IList<Customer>> GetAllAsync();
        Task<bool> CommitAsync();
    }
}
