﻿using Stock.BusinessRules.DTOs.ValidationErrorDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.Wrappers.User
{
    public class WUpdateUser : WBase
    {
        public int IdUser { get; set; }
        public string NombreUsuario { get; set; }
        public List<ValidationErrorDTOs> ValidationErrors { get; set; }
        
        //Esta propiedad es del tipo "LIST"  <ValidationErrorDTOs>
        //La lista se encarga de almacenar varios objetos de tipo "ValidationErrorDTOs".
    }
}