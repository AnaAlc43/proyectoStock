using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.UserDTOs


    // DTO que se utiliza para transferir datos de entrada cuando se está creando un nuevo
    // actor en la capa de controlador o presentación y se necesita enviar esos datos a la
    // capa de negocio.

{
    /*Un constructor predeterminado, que es un método especial llamado "CreateUserResquest" que se ejecuta
    cuando se crea una nueva instancia de la clase. Este constructor no tiene parámetros y no realiza ninguna
    operación.*/

    public class CreateUserRequest
    {     
        public string Nombre { get; set; }       

        public string Apellido { get; set; }

        public string Email { get; set; }

        //public string Contraseña { get; set; }

        //Almacenar contraseñas en texto sin formato.
        //Solo el hash de la contraseña, usar la clase "PasswordHasher" de .NET para
        //generar y validar hashes de contraseñas.

        //para garantizar la seguridad, implementar el control de acceso y de autenticación adecuado para la aplicación.
        //Se puede usar la autenticación basada en tokens de JSON Web Token (JWT) para proteger la API.

    }

}