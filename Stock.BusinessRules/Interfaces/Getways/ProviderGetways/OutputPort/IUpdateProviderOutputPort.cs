using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort
{

    // Este Output Port se utiliza para manejar la respuesta o salida después
    // de actualizar la información de un Provider.

    public interface IUpdateProviderOutputPort
    {
        /// <summary>
        /// Manejala respuesta que se le envia al Presenter con los detalles de la operación
        /// de actualización de una Provider en el contexto.
        /// </summary>
        /// <param name="provider">Recibe un objeto WrapperCreateDeleteProvider que contiene detalles sobre la operación.</param>
        Task Handle(WUpdateProvider provider);
    }

}
