using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.ProviderDTOs
{
    /// <summary>
    /// DTO que representa la información de un actor que se envía como respuesta 
    /// desde la capa de negocio -> al controlador o presentación.
    /// </summary>

    public class ProviderDTO
    {
        public int Id { get; set; }

        //public int Localidad { get; set; }

        public string Nombre { get; set; }
           
        //public string Email { get; set; }
          
        //public string Telefono { get; set; }
          
        //public string Direccion { get; set; }   
    }
}
