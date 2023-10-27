using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Proveedor
{
    public int Idproveedor { get; set; }

    public int? Localidad { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Contacto { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? Fechaderegistro { get; set; }

    public virtual Departamento? LocalidadNavigation { get; set; }

    public virtual ICollection<Producto> IdProductos { get; set; } = new List<Producto>();
}
