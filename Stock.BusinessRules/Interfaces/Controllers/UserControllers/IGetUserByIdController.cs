using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Controllers.UserControllers
{
    public interface IGetUserByIdController
    {
        Task<WSelectUser> GetUser(int IdUser);
    }
}
