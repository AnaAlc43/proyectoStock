using System;
using System.Collections.Generic;

namespace Stock.COMMON.Entities
{
    public partial class Roles
    {
        public int IdRoles { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Users> Users { get; set; } = new List<Users>();
    }
}