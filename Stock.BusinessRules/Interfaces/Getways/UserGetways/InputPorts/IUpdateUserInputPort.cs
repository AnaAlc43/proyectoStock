using Stock.BusinessRules.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts
{
    // Este Input Port se utiliza para manejar la actualización de la información de un User
    // existente. 
    public interface IUpdateUserInputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto UpdateUserRequest con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="updateUserRequest">Contiene los detalles actualizados del User,
        /// incluido el Id del User que se debe actualizar.</param>
        Task Handle(UpdateUserRequest updateUserRequest);
    }

}
