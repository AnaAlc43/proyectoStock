using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
