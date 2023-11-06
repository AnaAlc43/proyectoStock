using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.BusinessRules.DTOs.ValidationErrorDTO;

namespace Stock.BusinessRules.Wrappers.Provider
{
    public class WUpdateProvider : WBase
    {
        public int IdProvider { get; set; }
        public string Nombre { get; set; }
        public List<ValidationErrorDTOs> ValidationErrors { get; set; }
        
        //Esta propiedad es del tipo "LIST"  <ValidationErrorDTOs>
        //La lista se encarga de almacenar varios objetos de tipo "ValidationErrorDTOs".
    }
}