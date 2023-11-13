#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Stock.COMMON.Interfaces.Repositories;
using Stock.Repositories.Context;
using Stock.Repository.Repositories;

namespace Stock.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
           IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<Controlstock1Context>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}