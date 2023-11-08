using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Presenters;

namespace Stock.DependencyInversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControlstock1ContextServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
           /* services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;*/
        }
    }
}
