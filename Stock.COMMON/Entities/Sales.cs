using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entities.Entities
{
    public class Sales
    {
        public int Id { get; set; }

        public int Usuario { get; set; }

        public int Cliente { get; set; }

        public int DetallePedido { get; set; }

        public DateTime Fecha { get; set; } = DateTime.UtcNow;

        public string EstadoVenta { get; set; }
    }
}
