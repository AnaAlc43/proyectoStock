using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.UserDTOs;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{

    // Este Input Port se encarga de manejar la creación de un nuevo User en el sistema. 

    public interface ICreateUserInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CreateUserRequest con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="creatUserRequest">Contiene los detalles del nuevo User a crear.</param>
        Task Handle(CreateUserRequest creatUserRequest);
    }
}
