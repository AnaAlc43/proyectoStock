using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Sales
    {
        public int IdSales { get; set; }

        public int? User { get; set; }

        public int? Customer { get; set; }

        public string DetalleProducto { get; set; }

        public DateTime? Fecha { get; set; }

        public string EstadoVenta { get; set; }

        public virtual Customer CustomerNavigation { get; set; }

        public virtual ICollection<Salesdetail> Salesdetails { get; set; } = new List<Salesdetail>();

        public virtual Users UserNavigation { get; set; }
    }
}