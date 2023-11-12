using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Controllers.UserControllers
{
    public class UpdateUserController : IUpdateUserController
    {

        public Task<WCreateDeleteUser> UpdateUser(UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}