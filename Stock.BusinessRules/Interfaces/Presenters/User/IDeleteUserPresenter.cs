using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.User
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de realizar un borrado
    /// lógico de un actor desde el contexto.
    /// </summary>
    public interface IDeleteUserPresenter : IDeleteUserOutputPort
    {
        /// <summary>
        /// Propiedad Actor que contiene detalles sobre la operación
        /// de eliminación.
        /// </summary>
        WDeleteUser User { get; }
    }
}