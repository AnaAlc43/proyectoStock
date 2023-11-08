using Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stock.BusinessRules.Interfaces.Presenters.Provider
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de realizar un borrado
    /// lógico de un actor desde el contexto.
    /// </summary>
    public interface IDeleteProviderPresenter : IDeleteProviderOutputPort
    {
        /// <summary>
        /// Propiedad Actor que contiene detalles sobre la operación
        /// de eliminación.
        /// </summary>
        WDeleteUser Provider { get; }
    }
}
