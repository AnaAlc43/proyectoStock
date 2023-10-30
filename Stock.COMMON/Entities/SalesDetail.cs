using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entities.Entities
{
    public class SalesDetail
    {
        public int Producto { get; }
        public int Ventas { get; }
        public int PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
        public string EstadoDetalleVenta { get; set; }
    }
} 