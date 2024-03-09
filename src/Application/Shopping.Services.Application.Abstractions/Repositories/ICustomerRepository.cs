using Shopping.Services.Data.Entities.MySql;

namespace Shopping.Services.Application.Abstractions.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product> GetByIdAsync(int id);
        Task<IList<Product>> GetAllAsync();

        Task<bool> CommitAsync();
    }
}
