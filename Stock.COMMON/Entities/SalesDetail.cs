using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Salesdetail
    {
        public int IdDetail { get; set; }

        public int? Sales { get; set; }

        public int? Product { get; set; }

        public decimal? PrecioVenta { get; set; }

        public int? Cantidad { get; set; }

        public DateTime? Fecha { get; set; }

        public string EstadoDetalleVentas { get; set; }

        public virtual Product ProductNavigation { get; set; }

        public virtual Sales SalesNavigation { get; set; }
    }
}