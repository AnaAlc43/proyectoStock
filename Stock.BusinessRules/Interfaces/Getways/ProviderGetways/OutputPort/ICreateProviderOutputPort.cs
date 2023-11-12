using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort
{
    // Este Output Port se utiliza para manejar la respuesta o salida después
    // de insertar la información de un Provider.
    public interface ICreateProviderOutputPort
    {
        // Manejala respuesta que se le envia al Presenter con los detalles de la operación
        // de inserción de un Provider en el contexto.
        // <param name="Provider">Recibe un objeto WrapperCreateDeleteProvider que contiene detalles sobre la operación.</param>
        Task Handle(WCreateDeleteProvider provider);
    }   
}
