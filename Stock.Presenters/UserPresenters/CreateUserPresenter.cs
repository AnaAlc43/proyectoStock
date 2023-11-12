using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Presenters.User
{
    public class CreateUserPresenter : ICreateUserPresenter
    {

        //El objeto WCreateDeleteUser que se pasa como argumento al método Handl
        //puede contener información de error, mensajes de validación y errores,
        //y datos del usuario, como el ID del usuario.
        public WCreateDeleteUser User { get; private set; } = new WCreateDeleteUser();


        //Este código permite que la vista interactúe con el modelo de datos
        //(por ejemplo, almacenar, actualizar o eliminar información de usuario) de una manera que está
        //desacoplada de la vista y que facilita la realización de pruebas unitarias y la depuración.
        public Task Handle(WCreateDeleteUser user)
        {
            User.ErrorNumber = user.ErrorNumber;
            User.ValidationErrors = user.ValidationErrors;
            User.Message = user.Message;
            User.IdUser = user.IdUser;
            return Task.CompletedTask;
        }
    }
}
