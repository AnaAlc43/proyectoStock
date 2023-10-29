using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entities.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public int DNI_CUIL { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

    }
}