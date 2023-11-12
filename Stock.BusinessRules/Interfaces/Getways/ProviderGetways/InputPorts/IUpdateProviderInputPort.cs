using Stock.BusinessRules.DTOs.ProviderDTOs;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.InputPorts
{
    // Este Input Port se utiliza para manejar la actualización de la información de un proveedor
    // existente. 
    public interface IUpdateProviderInputPort
    {
        Task Handle(UpdateProviderRequest updateProviderRequest);
    }

}
