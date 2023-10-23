using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Entities
{
    public class Sales
    {
        public int Id { get; set; }

        public int Usuario { get; set; }

        public int Cliente { get; set; }

        public string DetallePedido { get; set; }

        public int Fecha { get; set; }

        public string EstadoVenta { get; set; }
    }
}
