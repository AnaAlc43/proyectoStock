using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{
    // Este Output Port se encarga de manejar la respuesta o salida después de eliminar un usuario.

    public interface IDeleteUserOutputPort
    {
        Task Handle(WDeleteUser user);
    }

}
