using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.BusinessRules.Interfaces.Getways.UserGetways.OutputPort
{
    // Este Output Port se utiliza para manejar la respuesta o salida después
    // de insertar la información de un User.
    public interface ICreateUserOutputPort
    {
        // Manejala respuesta que se le envia al Presenter con los detalles de la operación
        // de inserción de un User en el contexto.
        // <param name="User">Recibe un objeto WrapperCreateDeleteUser que contiene detalles sobre la operación.</param>
        Task Handle(WCreateDeleteUser user);
    }   
}
