using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers;


namespace Stock.BusinessRules.Interfaces.Controllers.UserControllers
{
    public interface IDeleteUserController
    {
        Task<WDeleteUser> DeleteUser(int IdUser);
    }
}
