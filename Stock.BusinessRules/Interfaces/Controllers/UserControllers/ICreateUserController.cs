using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Controllers.UserControllers
{
    public interface ICreateUserController
    {
        // Este método se utiliza para crear un nuevo usuario en el sistema. 
        //El propósito principal de esta interfaz es definir un contrato para que
        //las clases que la implementan tengan un método llamado CreateUser.

        //Este método acepta un objeto CreateUserRequest como parámetro de entrada y
        //devuelve una tarea asíncrona (Task) que contiene un objeto WCreateDeleteActor.
        Task<WCreateDeleteUser> CreateUser(CreateUserRequest request);
    }

}
           