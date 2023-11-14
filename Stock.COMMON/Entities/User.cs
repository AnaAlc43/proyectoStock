using System.Collections.Generic;
using Stock.COMMON.Common;

namespace Stock.COMMON.Entities
{
    public partial class Users : EntityCommon
    {
        public int IdUser { get; set; }

        public int Rol { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cuil { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Descripcion { get; set; }

        public virtual Roles RolNavigation { get; set; }

        public virtual ICollection<Sales> Sales { get; set; } = new List<Sales>();

    }
}