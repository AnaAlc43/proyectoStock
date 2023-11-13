using Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Presenters.User
{

    // Este presenter se encarga de manejar la presentación después de insertar 
    // un nuevo registro de un User en el contexto.
    // Expone una propiedad User que contiene detalles sobre la operación
    // de inserción.

    public interface ICreateUserPresenter : ICreateUserOutputPort
    {
        

        WCreateDeleteUser User { get; }
    }
}
