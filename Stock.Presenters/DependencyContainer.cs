using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.Presenters.User;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
           
            services.AddScoped<ICreateUserPresenter, CreateUserPresenter>();

            services.AddScoped<IDeleteUserPresenter, DeleteUserPresenter>();

            services.AddScoped<IUpdateUserPresenter, UpdateUserPresenter>();

            return services;
        }
    }
}