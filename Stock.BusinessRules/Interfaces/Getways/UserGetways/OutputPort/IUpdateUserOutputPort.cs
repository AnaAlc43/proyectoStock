using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{

    // Este Output Port se utiliza para manejar la respuesta o salida después
    // de actualizar la información de un user.

    public interface IUpdateUserOutputPort
    {
        Task Handle(WUpdateUser user);
    }

}
