using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Category
    {
        public int IdCategory { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}