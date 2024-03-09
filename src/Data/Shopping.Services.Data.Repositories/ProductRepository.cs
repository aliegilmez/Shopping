using Microsoft.EntityFrameworkCore;
using Shopping.Services.Application.Abstractions.Repositories;
using Shopping.Services.Data.Context;
using Shopping.Services.Data.Entities.MySql;

namespace Shopping.Services.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingContext _shoppingContext;
        private readonly DbSet<Product> _productRepository;

        public ProductRepository(ShoppingContext shoppingContext, DbSet<Product> productRepository)
        {
            _shoppingContext = shoppingContext;
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.FirstOrDefaultAsync(f => f.Id == id);

        }
        public async Task<IList<Product>> GetAllAsync()
        {
            return await _productRepository.ToListAsync();
        }

        public async Task<bool> CommitAsync()
        {
            return await _shoppingContext.SaveChangesAsync() > 0;
        }
    }
}
