using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.BusinessRules.DTOs.ProviderDTOs
{
    /// DTO que representa la información de un actor que se envía como respuesta 
    /// desde la capa de negocio -> al controlador o presentación.
    public class ProviderResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}