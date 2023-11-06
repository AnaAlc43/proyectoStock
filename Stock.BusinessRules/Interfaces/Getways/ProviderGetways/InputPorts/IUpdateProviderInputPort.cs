using Stock.BusinessRules.DTOs.ProviderDTOs;
using Stock.BusinessRules.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.InputPorts
{
    // Este Input Port se utiliza para manejar la actualización de la información de un proveedor
    // existente. 
    public interface IUpdateProviderInputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto UpdateProviderRequest con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="updateProviderRequest">Contiene los detalles actualizados del Provider,
        /// incluido el Id del Provider que se debe actualizar.</param>
        Task Handle(UpdateProviderRequest updateProviderRequest);
    }

}
