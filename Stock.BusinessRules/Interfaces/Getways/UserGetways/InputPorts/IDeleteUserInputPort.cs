using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{
    // Este Input Port se encarga de manejar la eliminación de un User.

    public interface IDeleteUserInputPort
    {
        // El método Handle elimina un User del contexto en base a su Id.
        // <param name="idUser">Id del User que se debe eliminar.</param>

        Task Handle(int idUser);
    }

}
