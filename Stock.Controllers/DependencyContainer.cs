using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.Controllers.UserControllers;

namespace Stock.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateUserController, CreateUserController>();

            services.AddScoped<IDeleteUserController, DeleteUserController>();

            services.AddScoped<IUpdateUserController, UpdateUserController>();

            //services.AddScoped<IGetActorByIdController, GetActorByIdController>();

            //services.AddScoped<IGetAllActorController, GetAllActorController>();

            return services;

        }
    }
}
