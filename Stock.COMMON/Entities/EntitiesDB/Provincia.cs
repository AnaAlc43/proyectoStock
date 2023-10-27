using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Provincia
{
    public int Idprovincia { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
