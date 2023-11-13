using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.Controllers;
using Stock.Presenters;
using Stock.Repositories;
using Stock.UseCases;

namespace Stock.DependencyInversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControlStockServices(this IServiceCollection services, IConfiguration configuration, string connectionString)

        {
            services

            .AddServicesRepositories(configuration, connectionString)
            .AddServicesUseCases()
            .AddServicesPresenter()
            .AddServicesControllers();

            return services;
        }
    }
}