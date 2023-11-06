using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.Presenters.User;
using Stock.BusinessRules.Interfaces.Presenters;

namespace Stock.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            /*services.AddScoped<GetAllActorPresenter>();

            services.AddScoped<IGetAllActorsOutputPort, GetAllActorPresenter>();

            services.AddScoped<IGetAllActorsPresenter, GetAllActorPresenter>();
            */


            services.AddScoped<ICreateActorPresenter, CreateActorPresenter>();

            services.AddScoped<IDeleteActorPresenter, DeleteActorPresenter>();

            services.AddScoped<IGetActorByIdPresenter, GetActorByIdPresenter>();

            services.AddScoped<IUpdateActorPresenter, UpdateActorPresenter>();

            return services;
        }
    }
}
