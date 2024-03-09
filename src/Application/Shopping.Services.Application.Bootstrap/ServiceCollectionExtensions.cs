using Atlas.Framework.Core.Exception.Types;
using Atlas.Framework.Localization;
using Atlas.Framework.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shopping.Services.Library.Localization;
using Shopping.Services.Data.Repositories.Extensions;
using Atlas.Framework.CleanArchitecture;

namespace Shopping.Services.Application.Bootstrap
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add Application Layer
            services.AddCleanArchitecture(cac =>
            {
                cac.ConfigureHandling(chc => chc
                    .AddQueryApplication(typeof(Query.UseCases.v1.GetCustomerById).Assembly)
                );
            });

            // Add Localization
            services.AddLocalization(lc => lc
                .AddResource<CommonResource>("Common")
                .AddResource<BusinessResource>("Business")
                .AddResource<ValidationResource>("Validation")
            );

            services.AddWebApplication(wac => wac
                .AddExceptionHandler(ehc => ehc
                    .AddHandlerFor<BusinessException>("Business", System.Net.HttpStatusCode.BadRequest)
                    .AddHandlerFor<ValidationException>("Validation", System.Net.HttpStatusCode.BadRequest)
                    .AddHandlerFor<NotFoundException>("Common", System.Net.HttpStatusCode.BadRequest)
                    .AddHandlerFor<SecurityException>("Common", System.Net.HttpStatusCode.Forbidden)
                    .AddHandlerFor<System.SystemException>("Common", System.Net.HttpStatusCode.InternalServerError)
                )
            );

            services.AddDataRepositories();

            return services;
        }

        public static IApplicationBuilder UseApplication(this IApplicationBuilder builder)
        {
            builder.UseLocalization("en", "en", "en-EN", "en-US");
            builder.UseWebApplication();

            return builder;
        }
    }
}