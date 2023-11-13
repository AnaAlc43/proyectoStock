using Stock.BusinessRules.Wrappers.User;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{
    // Este Output Port se utilizaría para manejar la respuesta o salida después
    // de recuperar la información de un actor específico.
    public interface IGetUserByIdOutputPort
    {
 
        // Maneja la respuesta que se le envía al Presenter con los detalles de un Actor
        // específico según su Id.
        Task Handle(WSelectUser user);
    }

}
