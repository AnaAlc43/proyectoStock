using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int? Telefono { get; set; }

        public int? Dni { get; set; }

        public string Email { get; set; }

        public string Direrccion { get; set; }

        public virtual ICollection<Sales> Sales { get; set; } = new List<Sales>();
    }
}