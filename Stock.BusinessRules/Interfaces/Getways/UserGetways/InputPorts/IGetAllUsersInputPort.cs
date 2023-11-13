using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{
    // Este Input Port se encarga de recuperar una lista de todos los actores disponibles en el contexto.
    public interface IGetAllUsersInputPort
    {
        //  El método Handle ejecuta una query en el contexto para obtener el contenido de
        //  la tabla actores.

        // <returns>Colección de objetos ActorResponse que representan a todos los actores.</returns>
        ValueTask Handle();
    }

}
