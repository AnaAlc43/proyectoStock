using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.ProviderDTOs;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.InputPorts
{

    // Este Input Port se encarga de manejar la creación de un nuevo proveedor en el sistema. 

    public interface ICreateProviderInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateProviderRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="creatProviderRequest">Contiene los detalles del nuevo Provider a crear.</param>
        Task Handle(CreateProviderRequest creatProviderRequest);
    }
}
