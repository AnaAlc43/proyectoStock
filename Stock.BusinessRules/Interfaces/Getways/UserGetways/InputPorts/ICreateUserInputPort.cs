using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{

    // Este Input Port se encarga de manejar la creación de un nuevo User en el sistema. 

    public interface ICreateUserInputPort
    {
        Task Handle(CreateUserRequest creatUserRequest);
    }
}
