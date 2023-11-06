using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.ProviderDTOs
{
    /// <summary>
    ///  DTO que se utiliza para transferir datos de entrada cuando se está creando un nuevo
    ///  actor en la capa de controlador o presentación y se necesita enviar esos datos a la
    ///  capa de negocio.
    /// </summary>

    public class CreateProviderRequest
    {
        public string Nombre { get; set; }

        //public string Email { get; set; }

        //public string Telefono { get; set; }

        //public string Direccion { get; set; }
    }
}
