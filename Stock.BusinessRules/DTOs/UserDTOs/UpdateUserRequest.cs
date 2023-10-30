using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.UserDTOs
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        /*public string Apellido { get; set; }

        public string Email { get; set; }

        public string Contraseña { get; set; } = string.Empty;

        propiedad tiene un valor predeterminado asignado a string.Empty, que es una cadena vacía.*/

    }
}
