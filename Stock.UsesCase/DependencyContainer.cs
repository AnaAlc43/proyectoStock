/*using Microsoft.Extensions.DependencyInjection;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.UseCases.UseCases;

namespace Stock.UsesCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateActorInputPort, CreateActorIteractor>();

            services.AddScoped<IDeleteActorInputPort, DeleteActorInteractor>();

            services.AddScoped<IUpdateActorInputPort, UpdateActorInteractor>();

            services.AddScoped<IGetActorByIdInputPort, GetActorByIdInteractor>();

            services.AddScoped<IGetAllActorsInputPort, GetAllActorsIterator>();

            return services;

        }
    }
}
*/