using Stock.BusinessRules.DTOs.UserDTOs;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{
    // Este Input Port se utiliza para manejar la actualización de la información de un User
    // existente. 
    public interface IUpdateUserInputPort
    {
        Task Handle(UpdateUserRequest updateUserRequest);
    }

}
