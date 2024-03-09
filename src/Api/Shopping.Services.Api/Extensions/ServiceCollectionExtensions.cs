using Atlas.Framework.Data.Mysql;
using Shopping.Services.Data.Context;

namespace Atlas.Services.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddShoppingDependencies(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddMySQLDbContext<ShoppingContext>(Configuration.GetSection("ShoppingConfiguration")["MysqlConnectionString"]);
        }

        public static IServiceCollection AddDependencyServiceUtilities(this IServiceCollection services)
        {
            return Framework.Utilities.ServiceUtilities.Create(services);
        }
    }
}
