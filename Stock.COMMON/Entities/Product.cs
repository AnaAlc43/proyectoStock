using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.COMMON.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int lote { get; set; }

        public string Vencimiento { get; set; }

        public int Codigo { get; set; }

        public string EstadoProd { get; set; }
    }
}
