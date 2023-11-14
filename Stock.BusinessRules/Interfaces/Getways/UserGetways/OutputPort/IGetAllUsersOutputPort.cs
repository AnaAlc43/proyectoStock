using Stock.BusinessRules.Wrappers.User;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{ 
    // Este Output Port se encargaría de manejar la respuesta o salida después de recuperar
    // una lista de todos los Users disponibles en el contexto.

    public interface IGetAllUsersOutputPort
    {

    /// Manejala respuesta que se le envia al Presenter con los detalles de la operación
    /// de seleccion de todos los Users en el contexto. 

        ValueTask Handle(WSelectAllUsers Users);
    }

}
