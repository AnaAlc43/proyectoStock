using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Interfaces.Getways.ProviderGetways.OutputPort;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.User
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de actualizar la
    /// información de un User.
    /// </summary>
    public interface IUpdateProviderPresenter : IUpdateProviderOutputPort
    {
        /// <summary>
        /// Expone una propiedad User que contiene detalles sobre la operación
        /// de actualización.
        /// </summary>
        WUpdateUser Provider { get; }
    }

}
