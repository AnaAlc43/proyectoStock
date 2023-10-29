using System;
using System.Collections.Generic;

namespace Stock.Repositories.Context;

public partial class Usuario
{
    public int Idusuario { get; set; }

    public int? Rol { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? NumeroTelefono { get; set; }

    public string? Email { get; set; }

    public string? Cuil { get; set; }

    public string? Descripcion { get; set; }

    public virtual Roles? RolNavigation { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
