using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort;
using Stock.BusinessRules.Wrappers.Provider;

namespace Stock.BusinessRules.Interfaces.Presenters.UseProviderr
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de insertar 
    /// un nuevo registro de un Provider en el contexto.
    /// </summary>
    public interface ICreateProviderPresenter : ICreateProviderOutputPort
    {
        /// <summary>
        /// Expone una propiedad Provider que contiene detalles sobre la operación
        /// de inserción.
        /// </summary>
        WCreateDeleteProvider Provider { get; }
    }
}
