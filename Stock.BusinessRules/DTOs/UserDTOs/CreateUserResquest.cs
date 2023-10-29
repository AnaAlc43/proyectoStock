﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.UserDTOs

{
    //Un constructor predeterminado, que es un método especial llamado "CreateUserResquest" que se ejecuta
    //cuando se crea una nueva instancia de la clase. Este constructor no tiene parámetros y no realiza ninguna
    //operación.

    public class CreateUserResquest
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }       

        public string LastName { get; set; }
       
        public string UserName { get; set; }

        public string Password { get; set; }

        //Almacenar contraseñas en texto sin formato.
        //Solo el hash de la contraseña, usar la clase "PasswordHasher" de .NET para
        //generar y validar hashes de contraseñas.

        //para garantizar la seguridad, implementar el control de acceso y de autenticación adecuado para la aplicación.
        //Se puede usar la autenticación basada en tokens de JSON Web Token (JWT) para proteger la API.

        public string Email { get; set; }
    }

}