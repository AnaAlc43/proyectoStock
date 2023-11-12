using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.ProviderDTOs;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.InputPorts
{

    // Este Input Port se encarga de manejar la creación de un nuevo proveedor en el sistema. 

    public interface ICreateProviderInputPort
    {
        Task Handle(CreateProviderRequest creatProviderRequest);
    }
}
