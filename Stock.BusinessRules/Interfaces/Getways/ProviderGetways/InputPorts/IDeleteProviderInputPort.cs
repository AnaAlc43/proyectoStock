using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.InputPorts
{
    // Este Input Port se encarga de manejar la eliminación de un proveedor.

    public interface IDeleteProviderInputPort
    {
        // El método Handle elimina un Provider del contexto en base a su Id.
        // <param name="idProvider">Id del Provider que se debe eliminar.</param>

        Task Handle(int idProvider);
    }

}
