using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.UseCases.Specification.UserSpecifications;
using Stock.UseCases.UseCases.UserUseCase;

namespace Stock.UsesCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateUserInputPort, CreateUserIteractor>();

            services.AddScoped<IDeleteUserInputPort, DeleteUserInteractor>();

            services.AddScoped<IUpdateUserInputPort, UpdateUserInteractor>();

            //services.AddScoped<IGetUserByIdInputPort, GetUserByIdInteractor>();

            //services.AddScoped<IGetAllUserInputPort, GetAllUserIterator>();

            return services;

        }
    }
}
