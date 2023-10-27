using System;
using System.Collections.Generic;

namespace Stock.Repositories.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int? Usuario { get; set; }

    public int? Cliente { get; set; }

    public string? DetalleProducto { get; set; }

    public DateTime? Fecha { get; set; }

    public string? EstadoVenta { get; set; }

    public virtual Cliente? ClienteNavigation { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; set; } = new List<DetalleVenta>();

    public virtual Usuario? UsuarioNavigation { get; set; }
}
