using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.UserDTOs
{
    public class UserResponse
    {
        /* DTO que representa la información de un actor que se envía como respuesta 
        desde la capa de "negocio" -> al "controlador o presentación." */

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
           
    }
}
