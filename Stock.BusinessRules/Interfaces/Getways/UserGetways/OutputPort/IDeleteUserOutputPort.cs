using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{
    // Este Output Port se encarga de manejar la respuesta o salida después de eliminar un usuario.

    public interface IDeleteUserOutputPort
    {
        /// <summary>
        /// Maneja la respuesta que se le envía al Presenter con los detalles de la operación
        /// de Eliminación de un User en el contexto.
        /// </summary>
        /// <param name="idUser">Recibir el Id del User que se eliminó</param>
        Task Handle(WDeleteUser user);
    }

}
