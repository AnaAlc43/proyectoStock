/*using Microsoft.Extensions.DependencyInjection;
using Stock.Controllers.UserControllers;

namespace Stock.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateActorController, CreateActorController>();

            services.AddScoped<IDeleteActorController, DeleteActorController>();

            services.AddScoped<IUpdateActorController, UpdateActorController>();

            services.AddScoped<IGetActorByIdController, GetActorByIdController>();

            services.AddScoped<IGetAllActorController, GetAllActorController>();

            return services;

        }
    }
}
*/