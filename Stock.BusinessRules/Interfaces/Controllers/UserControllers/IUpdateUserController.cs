using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Wrappers.User;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.UserControllers
{
    public interface IUpdateUserController
    {
        // Este método se utiliza para actualizar la información de un
        // usuario existente en el sistema.
        Task<WCreateDeleteUser> UpdateUser(UpdateUserRequest request);
    }
}
