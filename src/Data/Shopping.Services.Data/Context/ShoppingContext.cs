using Microsoft.EntityFrameworkCore;
using Shopping.Services.Data.Entities.MySql;

namespace Shopping.Services.Data.Context
{
    public class ShoppingContext: DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
    }

}
