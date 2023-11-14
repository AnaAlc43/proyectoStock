using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.UseCases.Specification.UserSpecifications;
using Stock.UseCases.UsesCases.UserUseCase;
using Stock.UseCases.UsesCases.UserUsesCase;

namespace Stock.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateUserInputPort, CreateUserIteractor>();

            services.AddScoped<IDeleteUserInputPort, DeleteUserInteractor>();

            services.AddScoped<IUpdateUserInputPort, UpdateUserInteractor>();

            services.AddScoped<IGetUserByIdInputPort, GetUserByIdInteractor>();

            services.AddScoped<IGetAllUsersInputPort, GetAllUsersIterator>();

            return services;

        }
    }
}
