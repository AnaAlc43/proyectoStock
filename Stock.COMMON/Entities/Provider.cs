using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Provider
    {
        public int IdProvider { get; set; }

        public string Nombre { get; set; }

        public int? Telefono { get; set; }

        public string Contacto { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}