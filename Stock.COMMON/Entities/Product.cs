using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int IdStock { get; set; }
        public string Nombre { get; set; }
        public int Lote { get; set; }
        public string Vencimiento { get; set; }
        public decimal PrecioProducto { get; set; }
        public int Codigo { get; set; }
        public string EstadoProd { get; set; }
    }
}
