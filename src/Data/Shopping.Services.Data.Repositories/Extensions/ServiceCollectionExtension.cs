using Microsoft.Extensions.DependencyInjection;
using Shopping.Services.Application.Abstractions.Repositories;

namespace Shopping.Services.Data.Repositories.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddDataRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.BuildServiceProvider();
        }
    }
}
