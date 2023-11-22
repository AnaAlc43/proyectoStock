using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.User
{
    /// <summary>
    /// Este presenter se encarga de manejar la presentación después de realizar un borrado
    /// lógico de un usuario desde el contexto.
    /// </summary>
    public interface IDeleteUserPresenter : IDeleteUserOutputPort
    {
        /// <summary>
        /// Propiedad User que contiene detalles sobre la operación
        /// de eliminación.
        /// </summary>
        WDeleteUser User { get; }
    }
}