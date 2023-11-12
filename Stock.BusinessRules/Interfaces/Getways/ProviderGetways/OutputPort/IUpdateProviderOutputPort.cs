using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort
{

    // Este Output Port se utiliza para manejar la respuesta o salida después
    // de actualizar la información de un Provider.

    public interface IUpdateProviderOutputPort
    {
        Task Handle(WUpdateProvider provider);
    }

}
