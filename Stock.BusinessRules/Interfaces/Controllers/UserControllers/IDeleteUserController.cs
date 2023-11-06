using Stock.BusinessRules.Wrappers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Controllers.UserControllers
{
    public interface IDeleteUserController
    {
        // Este método se utiliza para eliminar un usuario existente en el sistema.
        // Una tarea asíncrona(Task) que contiene un objeto WDeleteUser.
        Task<WDeleteUser> DeleteUser(int IdUser);
    }
}
