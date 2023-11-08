using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Product
    {
        public int IdProduct { get; set; }

        public int? Category { get; set; }

        public string Nombre { get; set; }

        public string Lote { get; set; }

        public DateTime? Vencimiento { get; set; }

        public float? PrecioProducto { get; set; }

        public int? Codigoproducto { get; set; }

        public string EstadoProducto { get; set; }

        public virtual Category CategoryNavigation { get; set; }

        public virtual ICollection<Salesdetail> Salesdetails { get; set; } = new List<Salesdetail>();

        public virtual ICollection<Provider> Providers { get; set; } = new List<Provider>();
    }
}