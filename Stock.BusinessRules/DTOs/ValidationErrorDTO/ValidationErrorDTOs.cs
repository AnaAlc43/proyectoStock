using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.ValidationErrorDTO
{
    public class ValidationErrorDTOs         
    {
        public string PropertyName { get; set; }
        //Es una cadena de texto que representa el nombre de la propiedad que
        //causó el error de validación.

        //Por ejemplo, si se verifica que el valor de un campo
        //llamado "Usuario" es menor a 18, el valor de "PropertyName" sería "Usuario".

        public string ErrorMessage { get; set; }
        //cadena de texto que representa el nombre del error de validación que ocurrió.
        //Por ejemplo, si se verifica que el valor de un campo
        //llamado "Password" es menor a 10, el valor de "ErrorMessage" sería "PasswordTooShort".
    }
}
