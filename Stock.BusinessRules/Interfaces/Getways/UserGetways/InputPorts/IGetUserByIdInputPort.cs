using System.Threading.Tasks;


namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{
    // Este Input Port se utiliza para recuperar información sobre un User 
    // específico en función de su Id.
    public interface IGetUserByIdInputPort
    {
        Task Handle(int idUser);
        // El método Handle recibiría el Id del User y devolvería un objeto que 
        // contiene los detalles del User.
    }

}
