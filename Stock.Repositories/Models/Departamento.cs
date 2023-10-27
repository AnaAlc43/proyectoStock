using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public int? Provincia { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual Provincia? ProvinciaNavigation { get; set; }
}
